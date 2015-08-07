using Tyle.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Tyle.Core
{
    class TailedStream : IDisposable
    {
        #region Fields
        const int ItemNotFound = -1;
        readonly int CRLFLength = Environment.NewLine.Length;
        StreamReader fileStream;
        List<string> lsLinesInFile;
        FileSystemWatcher fileWatcher;
        frmTailViewer streamOwnerForm;
        #endregion

        #region Constructor
        public TailedStream(string filePath, frmTailViewer ownerForm)
        {
            TailedFilePath = filePath;
            streamOwnerForm = ownerForm;
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

        protected bool TailToEOF()
        {
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
                            }
                            else
                            {
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
            fileWatcher.Changed += new FileSystemEventHandler(OnChanged);
            //watcher.Created += new FileSystemEventHandler(OnChanged);
            fileWatcher.Deleted += new FileSystemEventHandler(OnChanged);
            fileWatcher.Renamed += new RenamedEventHandler(OnRenamed);
            fileWatcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            switch(e.ChangeType)
            {
                case WatcherChangeTypes.Changed:
                    int linesRead = lsLinesInFile.Count;
                    if(TailToEOF())
                    {
                        linesRead = lsLinesInFile.Count - linesRead;
                        if (linesRead > 0)
                        {
                            // [BIB]:  https://stackoverflow.com/a/661662
                            streamOwnerForm.Invoke((MethodInvoker)delegate { streamOwnerForm.UpdateTailView(); });
                        }
                    }
                    break;
            }
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
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
}
