using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TrX
{
    internal static class Sky
    {
        #region Skeleton
        readonly static string _InstalPath = ".\\";
        readonly static string _ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Lavnok\\TrX\\";
        readonly static string _LogPath = _ConfigPath + "Logs\\";
        readonly static string _SetFile = _ConfigPath + "Settings.q";
        readonly static string _DefaultSetFile = _InstalPath + "Defaults.q";
        static StreamReader reader;
        static StreamWriter writer;
        private static string _StoreList = _ConfigPath + "Stores.l";
        internal static string _ExpenseFile = _ConfigPath + DateTime.Now.Month + ".m";

        static Sky()
        {
            Logger.LogD("Directory for UserConfig: {0} doesn't exist; Attempting to create.", _ConfigPath);
            try
            {
                Directory.CreateDirectory(_ConfigPath);
            }
            catch (Exception ex)
            {
                Logger.LogX(Threats.DirNotCreated, ex, "Unable to create Directory for UserConfig: {0}.", _ConfigPath);
            }
            //Logger.LogD("Caller of this static constructor for Sky class is {0}.", _Caller);
        }
        #endregion

        #region Globals
        /// <summary>
        /// Root path for the location of all the Quirks.
        /// </summary>
        internal static string ConfigPath
        {
            get
            {
                return _ConfigPath;
            }
        }

        /// <summary>
        /// Root path for the location of all the Logs.
        /// </summary>
        internal static string LogPath
        {
            get
            {
                return _LogPath;
            }
        }
        #endregion

        #region Assistants
        //private static int _findCaller(string sFileName)
        //{
        //    if (sFileName.EndsWith(".log"))
        //        return 0;
        //    else if (sFileName.EndsWith(".quirks"))
        //        return 1;
        //    return -1;
        //}

        /// <summary>
        /// Alerts the user with a given piece of Information.
        /// </summary>
        /// <param name="Information">Information to be intimated to the user.</param>
        internal static void Inform(string Information)
        {
            System.Windows.Forms.MessageBox.Show(Information);
        }
        #endregion

        internal static string GetTypeName()
        {
            return "sky";
        }

        #region FileSystem Operations
        #region Simple
        /// <summary>
        /// Returns the number of files present under the Directory.
        /// </summary>
        /// <param name="sPath">Path to the Directory.</param>
        /// <param name="bRecursive">Determines the recursive listing of the Directory; Defaults to True.</param>
        /// <returns>The number of files present under the specified Directory as a Long</returns>
        internal static long GetDirCount(string sPath, bool bRecursive = true)
        {
            try
            {
                if (bRecursive)
                    return new DirectoryInfo(sPath).GetFileSystemInfos("*", SearchOption.AllDirectories).LongLength;
                else
                    return new DirectoryInfo(sPath).GetFileSystemInfos("*", SearchOption.TopDirectoryOnly).LongLength;
            }
            catch (DirectoryNotFoundException ex)
            {
                Logger.LogX(Threats.DirNotFound, ex, "Directory {0} not found.", sPath);
                return 0;
            }
        }

        /// <summary>
        /// Verifies if a file exists in the current FileSystem
        /// </summary>
        /// <param name="sFileName">Only the file's name and extension; Path is determined dynamically based on the caller.</param>
        /// <returns>True if the file exists; False otherwise.</returns>
        internal static bool FileExists(FileFormats Format)
        {
            switch (Format)
            {
                case FileFormats.Timber:
                    return File.Exists(Logger.LogFile);
                    //return File.Exists(_LogPath + sFileName);
                case FileFormats.Quirks:
                    return File.Exists(_SetFile);
                case FileFormats.Stores:
                    return File.Exists(_StoreList);
                case FileFormats.Purpose:
                    return File.Exists(_ExpenseFile);
                default:
                    Logger.LogE(Threats.UnknownType, "Not trying to locate file.");
                    return false;
            }
        }

        private static bool CopyToUserDir(FileFormats Format)
        {
            switch (Format)
            {
                case FileFormats.Quirks:
                    try
                    {
                        File.Copy(_DefaultSetFile, _SetFile);
                    }
                    catch (Exception ex)
                    {
                        Logger.LogX(Threats.FileNotCopied, ex, "Unable to copy {0} file to user folder.", Format);
                        return false;
                    }
                    return true;
                default:
                    Logger.LogE(Threats.UnknownType, "FileFormat: {0} - not recognized.", Format);
                    return false;
            }
        }

        internal static bool DirExists(string sDirPath)
        {
            return System.IO.Directory.Exists(sDirPath);
        }

        internal static bool CreateDir(string sDirPath)
        {
            try
            {
                Directory.CreateDirectory(sDirPath);
                return true;
            }
            catch (Exception ex)
            {
                Logger.LogX(Threats.DirNotCreated, ex, "Unable to create Directory: {0}.", sDirPath);
                return false;
            }
        }

        internal static void DelOldestFile(string sDirPath, bool bRecursive = true)
        {
            FileInfo[] fiInfo;
            if (bRecursive)
                fiInfo = new DirectoryInfo(sDirPath).GetFiles("*", SearchOption.AllDirectories);
            else
                fiInfo = new DirectoryInfo(sDirPath).GetFiles("*", SearchOption.TopDirectoryOnly);
            var oldestfile = from f in fiInfo orderby f.LastWriteTimeUtc select f;
            Logger.LogD("Attempting to delete oldest file: {0}", oldestfile.ElementAt(0).FullName);
            oldestfile.ElementAt(0).Delete();
        }
        #endregion

        #region Advanced
        internal static object Parse(FileFormats Format)
        {
            int linenum;
            switch (Format)
            {
                case FileFormats.Quirks:
                    #region Quirks
                    if (!Sky.FileExists(FileFormats.Quirks))
                    {
                        if (!Sky.CopyToUserDir(FileFormats.Quirks))
                            return null;
                    }
                    Dictionary<string, string> dPrefs = new Dictionary<string, string>();
                    int index;
                    linenum = -1;
                    string line, key, val;
                    try
                    {
                        reader = new StreamReader(_SetFile);
                        while ((line = reader.ReadLine()) != null)
                        {
                            linenum++;
                            line = line.Trim();
                            if (line.Length < 1)
                            {
                                Logger.LogE(Threats.PrefsCorrupted, "Prefs file: {0} corrupted @ line: {1} = {2}.", _SetFile, linenum, line);
                                continue;
                            }
                            if (line[0] != '#')
                            {
                                index = line.IndexOf('=');
                                if (index < 1)
                                    continue;
                                key = line.Substring(0, index).Trim();
                                val = line.Substring(index + 1).Trim();
                                if ((!string.IsNullOrEmpty(key)) && (!string.IsNullOrEmpty(val)))
                                {
                                    if (!dPrefs.Keys.Contains(key))
                                    {
                                        Logger.LogT("Adding {0} = {1} key value pair for Preferences.", key, val);
                                        dPrefs.Add(key, val);
                                    }
                                }
                                else if (string.IsNullOrEmpty(key))
                                {
                                    Logger.LogE(Threats.PrefsCorrupted, "Key \"{0}\" corrupted at line: \"{1}\" in settings file:  \"{2}\".", key, linenum, _SetFile);
                                    Logger.LogD("Actual line: {0}", line);
                                }
                                else if (string.IsNullOrEmpty(val))
                                {
                                    Logger.LogE(Threats.PrefsCorrupted, "Value for the Key \"{0}\" corrupted at line: \"{1}\" in settings file:  \"{2}\".", key, linenum, _SetFile);
                                    Logger.LogD("Actual line: {0}", line);
                                }
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Logger.LogX(Threats.PrefsLost, ex, "Error while reading Preferences at line {0}", linenum);
                        return null;
                    }
                    #endregion
                    return dPrefs;
                case FileFormats.Timber:
                    #region LogFiles
                    if (!Sky.FileExists(FileFormats.Timber))
                    {
                        Logger.LogE(Threats.FileNotFound, "File {0} does not exist; Cannot Parse.", FileFormats.Timber);
                        return null;
                    }
                    break;
                    #endregion
                case FileFormats.Stores:
                    #region Stores_AutoCompleteList
                    if (!Sky.FileExists(FileFormats.Stores))
                    {
                        Logger.LogE(Threats.FileNotFound, "File {0} does not exist; Cannot load the Stores list.", FileFormats.Stores);
                        return null;
                    }
                    linenum = -1;
                    System.Windows.Forms.AutoCompleteStringCollection acsc = new System.Windows.Forms.AutoCompleteStringCollection();
                    try
                    {
                        reader = new StreamReader(_StoreList);
                        while ((line = reader.ReadLine()) != null)
                        {
                            linenum++;
                            line = line.Trim();
                            if (line.Length < 1)
                            {
                                Logger.LogE(Threats.StoresCorrupted, "Stores List file : {0} corrupted @ line: {1} = {2}.", _StoreList, linenum, line);
                                continue;
                            }
                            if (line[0] != '#')
                            {
                                acsc.Add(line);
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Logger.LogX(Threats.StoresLost, ex, "Error while reading StoresList at line {0}.", linenum);
                        return null;
                    }
                    #endregion
                    return acsc;
                case FileFormats.Purpose:
                    return ParsedExpenses();
                default:
                    break;
            }
            return null;
        }

        private static Expense[] ParsedExpenses()
        {
            if (!Sky.FileExists(FileFormats.Purpose))
            {
                Logger.LogE(Threats.FileNotFound, "{0} File: {1} does not exist; Cannot load the Expenses for the requestd date: {2}.", FileFormats.Purpose, _ExpenseFile, Expense.DateSpentOn.ToShortDateString());
                return null;
            }
            bool notAskedFor = true;
            int linenum = 0, index, iFieldNum = 0, DayOfMonth = Expense.DateSpentOn.Day, iNumEntries = 0;
            string line = null, key, val, DayOfMonthString = DayOfMonth.ToString();
            Expense[] eExpenses = new Expense[frmMain._MaxFields];
            string[] values;
            char[] delims = { ',' };
            try
            {
                reader = new StreamReader(_ExpenseFile);
                Expense.Reset();
                line = reader.ReadLine().Trim();
                if (line.StartsWith(":Month="))
                {
                    Logger.LogD("Header line for file: {0} @ line: {1} is {2}.", _ExpenseFile, linenum, line);
                }
                else
                {
                    Logger.LogE(Threats.ExpenseCorrupted, "Not able to find a header line for file: {0} @ line: {1}; Line is {2}.", _ExpenseFile, linenum, line);
                    return null;
                }
                while ((line = reader.ReadLine()) != null)
                {
                    linenum++;
                    line = line.Trim();
                    if (line.Length < 1)
                    {
                        Logger.LogE(Threats.ExpenseCorrupted, "Expenses file: {0} corrupted @ line: {1} = {2}.", _ExpenseFile, linenum, line);
                        continue;
                    }
                    if (line[0] != '#')
                    {
                        index = line.IndexOf('=');
                        if (index < 1)
                        {
                            Logger.LogE(Threats.ExpenseCorrupted, "Expenses file corrupted at line: {0} = {1}.", linenum, line);
                            continue;
                        }
                        key = line.Substring(0, index).Trim();
                        val = line.Substring(index + 1).Trim();
                        if ((!string.IsNullOrEmpty(key)) && (!string.IsNullOrEmpty(val)))
                        {
                            if (key.StartsWith(":Day"))
                            {
                                if (val.Equals(DayOfMonthString))
                                    notAskedFor = false;
                                else
                                    notAskedFor = true;
                                continue;
                            }
                            iFieldNum = int.Parse(key.Substring(0, 2));
                            values = val.Split(delims);
                            if (values.Length < 3)
                            {
                                Logger.LogE(Threats.ExpenseCorrupted, "Expenses file corrupted at line : {0} - {1}.", linenum, line);
                                continue;
                            }
                            if (notAskedFor)
                            {
                                Expense.Others[iFieldNum] += decimal.Parse(values[0]);
                            }
                            else
                            {
                                iNumEntries++;
                                eExpenses[iFieldNum] = new Expense(iFieldNum);
                                eExpenses[iFieldNum].AllThree(decimal.Parse(values[0]), (PaymentMode)Enum.Parse(typeof(PaymentMode), values[1]), values[2]);
                            }
                        }
                        else if (string.IsNullOrEmpty(key))
                        {
                            Logger.LogE(Threats.ExpenseCorrupted, "UId \"{0}\" corrupted at line: \"{1}\" in file:  \"{2}\".", key, linenum, _ExpenseFile);
                            Logger.LogD("Actual line: {0}", line);
                        }
                        else if (string.IsNullOrEmpty(val))
                        {
                            Logger.LogE(Threats.ExpenseCorrupted, "Expense entry with UId \"{0}\" corrupted at line: \"{1}\" in file:  \"{2}\".", key, linenum, _ExpenseFile);
                            Logger.LogD("Actual line: {0}", line);
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Logger.LogX(Threats.ExpenseCorrupted, ex, "Expenses file corrupted at line : {0} - {1}.", linenum, line);
            }
            if (iNumEntries < 1)
            {
                Logger.LogE(Threats.NoExp4Date, "No Expense Entries for date: {0}.", DayOfMonthString);
                return null;
            }
            return eExpenses;
        }

#if No_Improvements
        private static Expense[] ParsedExpenses_1()
        {
            int DayOfMonth = Expense.DateSpentOn.Day;
            if (!Sky.FileExists(FileFormats.Purpose))
            {
                Logger.LogE(Threats.FileNotFound, "File {0} does not exist; Cannot load the Stores list.", FileFormats.Purpose);
                return null;
            }
            int linenum = 0, index, iFieldNum = 0;
            string line, key, val, DayOfMonthString = DayOfMonth.ToString();
            Expense[] eExpenses = new Expense[41];
            string[] values;
            char[] delims = { ',' };
            bool isFound = false;
            try
            {
                reader = new StreamReader(_ExpenseFile);
                while ((line = reader.ReadLine()) != null)
                {
                    linenum++;
                    line = line.TrimStart();
                    if (line.Length < 1)
                        continue;
                    if (line[0] != '#')
                    {
                        if (line.StartsWith(":Day="))
                        {
                            if (isFound)
                                break;
                            else if (line.Equals(":Day=" + DayOfMonthString))
                            {
                                isFound = true;
                                Expense.DateSpentOn = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DayOfMonth);
                                continue;
                            }
                        }
                        if (isFound) // Expected Date is found
                        {
                            index = line.IndexOf('=');
                            if (index < 1)
                                continue;
                            key = line.Substring(0, index).Trim();
                            val = line.Substring(index + 1).Trim();
                            if ((!string.IsNullOrEmpty(key)) && (!string.IsNullOrEmpty(val)))
                            {
                                iFieldNum = int.Parse(key.Substring(0, 2));
                                eExpenses[iFieldNum] = new Expense(iFieldNum);
                                values = val.Split(delims);
                                if (values.Length < 3)
                                    continue;
                                eExpenses[iFieldNum].AllThree(decimal.Parse(values[0]), (PaymentMode)Enum.Parse(typeof(PaymentMode), values[1]), values[2]);
                            }
                            else if (string.IsNullOrEmpty(key))
                            {
                                Logger.LogE(Threats.ExpenseCorrupted, "UId \"{0}\" corrupted at line: \"{1}\" in file:  \"{2}\".", key, linenum, _ExpenseFile);
                                Logger.LogD("Actual line: {0}", line);
                            }
                            else if (string.IsNullOrEmpty(val))
                            {
                                Logger.LogE(Threats.ExpenseCorrupted, "Expense entry with UId \"{0}\" corrupted at line: \"{1}\" in file:  \"{2}\".", key, linenum, _ExpenseFile);
                                Logger.LogD("Actual line: {0}", line);
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Logger.LogX(Threats.StoresLost, ex, "Error while reading StoresList at line {0}.", linenum);
                return null;
            }
            return eExpenses;
        }
        
#endif
        internal static bool Preserve(FileFormats Format, object oData)
        {
            int linenum;
            switch (Format)
            {
                case FileFormats.Quirks:
                    #region Quirks
                    linenum = 0;
                    Dictionary<string, string> dPrefs = (Dictionary<string, string>)oData;
                    KeyValuePair<string, string> kvpTemp = new KeyValuePair<string, string>("Error", "Error");
                    try
                    {
                        writer = new StreamWriter(_SetFile, false);
                        while (linenum < dPrefs.Count)
                        {
                            kvpTemp = dPrefs.ElementAt(linenum++);
                            writer.WriteLine("{0}={1}", kvpTemp.Key, kvpTemp.Value);
                        }
                        writer.Flush();
                        writer.Close();
                    }
                    catch (Exception ex)
                    {
                        Logger.LogX(Threats.PrefsLost, ex, "Error while saving Preference: {0} at line {1}.", kvpTemp.ToString(), linenum);
                        return false;
                    }
                    return true;
                    #endregion
                case FileFormats.Purpose:
                    #region Expenses
                    Expense[] eExpenses = (Expense[])oData;
                    string sExpenses = ":Day=" + Expense.DateSpentOn.Day + Environment.NewLine;
                    linenum = 0;
                    int i = -1, j;
                    while (i < eExpenses.Length - 1)
                    {
                        i++;
                        if (eExpenses[i] != null)
                        {
                            linenum++;
                            sExpenses += eExpenses[i].UID + "=" + eExpenses[i].Amount + "," + eExpenses[i].PayMode + "," + eExpenses[i].Store + Environment.NewLine;
                        }
                    }
                    if (linenum < 1)
                    {
                        Logger.LogW("No expenses to Save.");
                        return true;
                    }
                    bool _ExpenseExists = Sky.FileExists(FileFormats.Purpose);
                    string lines = null;
                    try
                    {
                        if (_ExpenseExists)
                        {
                            reader = new StreamReader(_ExpenseFile);
                            lines = reader.ReadToEnd();
                            i = lines.IndexOf(":Day=" + Expense.DateSpentOn.Day.ToString());
                            if (i > -1)
                            {
                                j = lines.IndexOf(":Day=", i + 1);
                                if (j < i)
                                    j = lines.Length - 1;
                                lines = lines.Substring(0, i - 1) + Environment.NewLine + sExpenses + lines.Substring(j - 1);
                            }
                            else
                                lines += Environment.NewLine + sExpenses;
                            reader.Close();
                            writer = new StreamWriter(_ExpenseFile, false);
                        }
                        else
                        {
                            writer = new StreamWriter(_ExpenseFile, false);
                            writer.WriteLine(":Month={0}", Expense.DateSpentOn.Month);
                            lines = sExpenses;
                        }
                        writer.WriteLine(lines);
                        writer.Flush();
                        writer.Close();
                    }
                    catch (Exception ex)
                    {
                        Logger.LogX(Threats.ExpensesLost, ex, "Error while saving Expenses for Date: {0}.", Expense.DateSpentOn.ToString());
                        return false;
                    }
                    return true;
                    #endregion
                case FileFormats.Stores:
                    #region StoresList
                    linenum = -1;
                    try
                    {
                        System.Windows.Forms.AutoCompleteStringCollection acsc = (System.Windows.Forms.AutoCompleteStringCollection)oData;
                        writer = new StreamWriter(_StoreList, false);
                        foreach (string s in acsc)
                        {
                            linenum++;
                            writer.WriteLine(s);
                        }
                        writer.Flush();
                        writer.Close();
                    }
                    catch (Exception ex)
                    {
                        Logger.LogX(Threats.StoresLost, ex, "Not able to preserve newly added store names to file: {0} @ line: {1}.", _StoreList, linenum);
                        return false;
                    }
                    return true; 
                    #endregion
            }
            return false;
        }
        #endregion
        #endregion

        internal static void UpdateExpenseFileName()
        {
            _ExpenseFile = _ConfigPath + Expense.DateSpentOn.Month + ".m";
        }
    }
}