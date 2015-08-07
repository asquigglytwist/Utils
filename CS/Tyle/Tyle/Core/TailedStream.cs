using System;
using System.Collections.Generic;
using System.IO;
using static Tyle.UI.dlgFind;

namespace Tyle.Core
{
    class TailedStream
    {
        StreamReader fileStream;
        List<string> lsLinesInFile;

        public TailedStream(string filePath)
        {
            TailedFilePath = filePath;
        }

        public bool InitTailing()
        {
            lsLinesInFile = new List<string>();
            LongestLine = string.Empty;
            fileStream = new StreamReader(new FileStream(TailedFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
            return ReadLinesToEOF();
        }

        internal void Close()
        {
            if (fileStream != null)
            {
                fileStream.Close();
            }
        }

        public bool ReadLinesToEOF()
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

        internal int FindNextItem()
        {
            if (lsLinesInFile.Count > 0)
            {
                NextSearchStartIndex %= lsLinesInFile.Count;
                var foundItemIndex = lsLinesInFile.FindIndex(NextSearchStartIndex, (line => (line.IndexOf(FindDialog.SearchText, StringComparison.OrdinalIgnoreCase) > -1)));
                if (foundItemIndex == -1 && NextSearchStartIndex != 0 && FindDialog.WrapSearch)
                {
                    foundItemIndex = lsLinesInFile.FindIndex(0, (line => (line.IndexOf(FindDialog.SearchText, StringComparison.OrdinalIgnoreCase) > -1)));
                }
                if (foundItemIndex != -1)
                {
                    NextSearchStartIndex = foundItemIndex + 1;
                    if (NextSearchStartIndex >= lsLinesInFile.Count)
                    {
                        NextSearchStartIndex = 0;
                    }
                    return foundItemIndex;
                }
            }
            return -1;
        }

        public string TailedFilePath { get; private set; }

        public int LineCount
        {
            get
            {
                return lsLinesInFile.Count;
            }
        }

        public int NextSearchStartIndex { get; set; }

        public string LongestLine { get; protected set; }

        public string this[int index]
        {
            get
            {
                return lsLinesInFile[index];
            }
        }
    }
}
