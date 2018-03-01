using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrX
{
    static class Logger
    {
        static string _LogFile;
        static System.IO.TextWriter ActualConsole;
        private static long _MaxLogCount = 19;
        static ConsoleColor ConOrigCol;

        static Logger()
        {
            ConOrigCol = Console.ForegroundColor;
            if (!Sky.DirExists(Sky.LogPath))
                Sky.CreateDir(Sky.LogPath);
            if (Sky.GetDirCount(Sky.LogPath) > _MaxLogCount)
            {
                Sky.DelOldestFile(Sky.LogPath);
            }
            string sLogName = DateTime.Now.ToString("MMMddyyyhhmmss");
            _LogFile = sLogName + ".log";
            if (!Sky.FileExists(FileFormats.Timber))
            {
                ActualConsole = Console.Out;
                Console.SetOut(new System.IO.StreamWriter(Sky.LogPath + _LogFile));
                LogDebugInfo(sLogName);
                LogD("Console now points to : {0}", Console.Out.ToString());
            }
        }

        private static void LogDebugInfo(string sLogName)
        {
            Console.WriteLine("--DEBUG INFO--  Begin");
            
            Console.WriteLine("LogSession = {0}", sLogName);
            
            Console.WriteLine("MachineName = {0}", System.Environment.MachineName);
            Console.WriteLine("UserName = {0}", System.Environment.UserName);
            Console.WriteLine("OSVersion = {0}", System.Environment.OSVersion);
            Console.WriteLine("Is64BitOS = {0}", System.Environment.Is64BitOperatingSystem.ToString());
            Console.WriteLine("CLR Version = {0}", System.Environment.Version.ToString(4));

            Console.WriteLine("ProcessorCount = {0}", System.Environment.ProcessorCount);
            
            Console.WriteLine("SysDir = {0}", System.Environment.SystemDirectory);
            Console.WriteLine("CurrentDir = {0}", System.Environment.CurrentDirectory);
            Console.WriteLine("IsSessionUserInteractive = {0}", System.Environment.UserInteractive.ToString());

            LogE(Threats.DirNotCreated, "Test.");
            LogW("Test.");
            LogD("Test.");
            LogT("Test.");
            Console.WriteLine("--DEBUG INFO--  End");
        }

        static void CleanUp()
        {
            Console.ForegroundColor = ConOrigCol;
            if ((ActualConsole != null) && (Console.Out != ActualConsole))
            {
                Console.Out.Flush();
                Console.Out.Close();
                Console.SetOut(ActualConsole);
            }
        }

        internal static string LogFile
        {
            get
            {
                return _LogFile;
            }
        }

        internal static void LogT(string msg, params object[] fillers)
        {
#if TRACE
            Console.WriteLine("[{0}] TRCE:  {1}", DateTime.Now.ToString("MM/dd/yyyy, HH:mm:ss"), string.Format(msg, fillers));
            Console.Out.Flush();
#endif
        }

        internal static void LogD(string msg, params object[] fillers)
        {
#if DEBUG
            Console.WriteLine("[{0}] DBUG:  {1}", DateTime.Now.ToString("MM/dd/yyyy, HH:mm:ss"), string.Format(msg, fillers));
            Console.Out.Flush();
#endif
        }

        internal static void LogW(string msg, params object[] fillers)
        {
            Console.WriteLine("[{0}] WARN:  {1}", DateTime.Now.ToString("MM/dd/yyyy, HH:mm:ss"), string.Format(msg, fillers));
        }

        /*internal static void LogE(string msg, params object[] fillers)
        {
#if DEBUG
            ConsoleColor bk = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
#endif
            Console.WriteLine("[{0}] EROR:  {1}", DateTime.Now.ToString("MM/dd/yyyy, HH:mm:ss"), string.Format(msg, fillers));
#if DEBUG
            Console.ForegroundColor = bk;
#endif
        }*/

        internal static void LogE(Threats eCode, string msg, params object[] fillers)
        {
            Console.WriteLine("[{1}] EROR:  [CODE:{0}]  {2}", eCode, DateTime.Now.ToString("MM/dd/yyyy, HH:mm:ss"), string.Format(msg, fillers));
            Console.Out.Flush();
        }

        internal static void LogX(Threats eCode, Exception x, string msg, params object[] fillers)
        {
            LogE(eCode, msg, fillers);
            LogD("StackTrace:\n{0}", x.StackTrace);
            Console.Out.Flush();
        }
    }
}
