using Tyle.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Tyle.Core
{
    class TailedStream : IDisposable
    {
        public delegate void TailedFileChangedHandler(object sender, TailedFileChangedArgs args);
        public event TailedFileChangedHandler OnTailedFileChanged;

        #region Fields
        const int ItemNotFound = -1;
        readonly int CRLFLength = Environment.NewLine.Length;
        StreamReader fileStream;
        List<string> lsLinesInFile;
        FileSystemWatcher fileWatcher;
        //frmTailViewer streamOwnerForm;
        #endregion

        #region Constructor
        public TailedStream(string filePath/*, frmTailViewer ownerForm*/)
        {
            TailedFilePath = filePath;
            //streamOwnerForm = ownerForm;
        }
        #endregion

        #region Functions
        public bool InitTailing()
        {
            lsLinesInFile = new List<string>();
            LongestLine = string.Empty;
            fileStream = new StreamReader(new FileStream(TailedFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
            if (ReadLinesToEOF())
            {
                WatchFileForChanges();
                return true;
            }
            return false;
        }

        protected bool ReadLinesToEOF()
        {
            string temp;
            try
            {
                while ((temp = fileStream.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(temp))
                    {
                        continue;
                    }
                    temp = temp.Replace("\t", "    ");
                    LongestLine = (LongestLine.Length < temp.Length ? temp : LongestLine);
                    lsLinesInFile.Add(temp);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        protected bool TailToEOF(out bool lastLineExtended)
        {
            lastLineExtended = false;
            try
            {
                if (lsLinesInFile.Count > 0)
                {
                    string temp;
                    var lastKnownPosition = fileStream.BaseStream.Position;
                    if ((temp = fileStream.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(temp))
                        {
                            var charsRead = temp.Length;
                            var shiftInPosition = ((fileStream.BaseStream.Position - charsRead) - lastKnownPosition);
                            temp = temp.Replace("\t", "    ");
                            if (shiftInPosition < CRLFLength)
                            {
                                // TODO:  We should theoretically not be running into an IndexOutOfRange issue here; Check again though...
                                lsLinesInFile[lsLinesInFile.Count - 1] = lsLinesInFile[lsLinesInFile.Count - 1] + temp;
                                lastLineExtended = true;
                            }
                            else
                            {
                                // We've read the line; So we have to add it to the list...
                                lsLinesInFile.Add(temp);
                            }
                            LongestLine = (LongestLine.Length < temp.Length ? temp : LongestLine);
                        }
                    }
                }
                return ReadLinesToEOF();
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal int FindItem(string searchText, int searchStartIndex, bool wrapSearch)
        {
            int foundItemIndex = ItemNotFound;
            if (lsLinesInFile.Count > 0)
            {
                searchStartIndex %= lsLinesInFile.Count;
                foundItemIndex = lsLinesInFile.FindIndex(searchStartIndex, (line => (line.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) > -1)));
                if (foundItemIndex == ItemNotFound && searchStartIndex != 0 && wrapSearch)
                {
                    foundItemIndex = lsLinesInFile.FindIndex(0, (line => (line.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) > ItemNotFound)));
                }
            }
            return foundItemIndex;
        }

        public void Dispose()
        {
            if (fileStream != null)
            {
                fileStream.Dispose();
            }
            if(fileWatcher != null)
            {
                fileWatcher.Dispose();
            }
        }

        protected void WatchFileForChanges()
        {
            // [BIB]:  https://stackoverflow.com/questions/721714/notification-when-a-file-changes
            fileWatcher = new FileSystemWatcher();
            fileWatcher.Path = Path.GetDirectoryName(TailedFilePath);
            fileWatcher.NotifyFilter = (NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName);
            fileWatcher.Filter = Path.GetFileName(TailedFilePath);
            fileWatcher.Changed += new FileSystemEventHandler(OnFileChanged);
            //watcher.Created += new FileSystemEventHandler(OnChanged);
            fileWatcher.Deleted += new FileSystemEventHandler(OnFileChanged);
            fileWatcher.Renamed += new RenamedEventHandler(OnRenamed);
            fileWatcher.EnableRaisingEvents = true;
        }

        private void OnFileChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Changed:
                    // [BIB]:  https://stackoverflow.com/a/3042963
                    var modTime = File.GetLastWriteTime(TailedFilePath);
                    if (modTime != LastModified)
                    {
                        TailedFileChangeType temp = TailedFileChangeType.NoChange;
                        int linesRead = lsLinesInFile.Count;
                        var currentSize = new FileInfo(TailedFilePath).Length;
                        if (currentSize > StreamSize)
                        {
                            bool lastLineExtended;
                            if (TailToEOF(out lastLineExtended))
                            {
                                linesRead = lsLinesInFile.Count - linesRead;
                                if (lastLineExtended)
                                {
                                    temp = TailedFileChangeType.LastLineExtended;
                                }
                                else if (linesRead > 0)
                                {
                                    temp = TailedFileChangeType.LinesAdded;
                                }
                                else
                                {
                                    temp = TailedFileChangeType.Shrunk;
                                }
                                // [BIB]:  https://stackoverflow.com/questions/33233161/how-to-ensure-that-streamreader-basestream-length-will-return-the-correct-value
                                // [BIB]:  https://stackoverflow.com/a/20863065
                                StreamSize = currentSize;
                                LastModified = modTime;
                            }
                        }
                        else
                        {
                            /**
                             * Treat both reduced file size and and unaltered file size as shrunk because we're not sure where
                             * the change has happened within the file; Hence a complete reset makes more sense.
                             */
                            temp = TailedFileChangeType.Shrunk;
                        }
                        OnTailedFileChanged(this, new TailedFileChangedArgs(temp, linesRead));
                    }
                    break;
                case WatcherChangeTypes.Deleted:
                    OnTailedFileChanged(this, new TailedFileChangedArgs(TailedFileChangeType.Deleted));
                    break;
            }
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
            OnTailedFileChanged(this, new TailedFileChangedArgs(TailedFileChangeType.Renamed, e.OldFullPath, e.FullPath));
        }
        #endregion

        #region Properties
        public string TailedFilePath { get; private set; }

        public int LineCount
        {
            get
            {
                return lsLinesInFile.Count;
            }
        }

        public long StreamSize { get; private set; }
        public DateTime LastModified { get; private set; }

        public string LongestLine { get; protected set; }
        #endregion

        #region Indexer
        public string this[int index]
        {
            get
            {
                return lsLinesInFile[index];
            }
        }
        #endregion
    }

    /// <summary>
    /// Enumeration of possible changes to the tailed file.
    /// </summary>
    public enum TailedFileChangeType
    {
        /// <summary>
        /// File's content has not changed; Most likely an attribute change.
        /// </summary>
        NoChange,
        /// <summary>
        /// New lines have been added.
        /// </summary>
        LinesAdded,
        /// <summary>
        /// The last line was edited; New lines may or may not have been added.
        /// </summary>
        LastLineExtended,
        /// <summary>
        /// File has shrunk; Requires a refresh / reset.
        /// </summary>
        Shrunk,
        /// <summary>
        /// File has been renamed.
        /// </summary>
        Renamed,
        /// <summary>
        /// File has been deleted.
        /// </summary>
        Deleted
    }

    /// <summary>
    /// Provides data for the OnTailedFileChanged event.
    /// </summary>
    public class TailedFileChangedArgs : EventArgs
    {
        // [BIB]:  https://www.codeproject.com/Articles/9355/Creating-advanced-C-custom-events
        public TailedFileChangedArgs(TailedFileChangeType changeType, int linesRead = 0)
        {
            ChangeType = changeType;
            LinesRead = linesRead;
        }

        public TailedFileChangedArgs(TailedFileChangeType changeType, string oldPath, string newPath)
            : this(changeType)
        {
            OldFilePath = oldPath;
            NewFilePath = newPath;
        }

        public TailedFileChangeType ChangeType { get; protected set; }
        public int LinesRead { get; protected set; }
        public string OldFilePath { get; protected set; }
        public string NewFilePath { get; protected set; }
    }
}
