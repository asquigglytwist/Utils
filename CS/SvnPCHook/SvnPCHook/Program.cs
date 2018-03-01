using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace ASquigglyTwist.SvnPCHook
{
    class Program
    {
        //static string sFileExtPat = ".cxx.cc.cpp.c.cs.js.css.html.config.txt";
        static ProcessStartInfo psiDiffGen;
        static void Main(string[] args)
        {
#if DEBUG
            Common.Alert("Attach");
#endif
            if (args.Length < 4)
            {
                if (args.Length == 1)
                {
                    // TODO:  Add a new form where rules can be added or edited; Display it.
                }
                else
                {
                    Console.Error.WriteLine("Too few args.");
                    Environment.Exit(1);
                }
            }
            if (!isTSvnInstalled())
            {
                Environment.Exit(1);
            }
            string[] sAffectedPaths = File.ReadAllLines(args[0]);
            int iTotalMarkersFound = 0;
            try
            {
#if DEBUG
                for (int i = 0; i < sAffectedPaths.Length; i++)
#else
                System.Threading.Tasks.Parallel.For(0, sAffectedPaths.Length, delegate(int i)
#endif
                {
                    iTotalMarkersFound += AnalyzerEngine.AnalyzeChangesInFile(sAffectedPaths[i], psiDiffGen);
                }
#if DEBUG
                Console.Error.WriteLine("[DEBUG]: To avoid accidental commit.");
                Environment.Exit(1);
#else
);
#endif
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Unable to analyze commit.  Details:{0}{1}", Environment.NewLine, Common.Alert(ex));
                Environment.Exit(1);
            }
            if (iTotalMarkersFound > 0)
            {
                Console.Error.WriteLine("A total of {0} marker(s) found; Please revisit the modified files.", iTotalMarkersFound);
                Environment.Exit(1);
            }
        }

        private static bool isTSvnInstalled()
        {
            string sTSVNPath = "";
            const string SVNLookName = "bin\\svn.exe";
            RegistryKey rkTSVN = Registry.LocalMachine.OpenSubKey("SOFTWARE\\TortoiseSVN");
            if (null == rkTSVN)
            {
                rkTSVN = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\TortoiseSVN");
            }
            if (null == rkTSVN)
            {
                Console.Error.WriteLine("Unable to find TortoiseSVN installation.");
                return false;
            }
            sTSVNPath = (string)rkTSVN.GetValue("Directory");
            if (rkTSVN != null)
            {
                rkTSVN.Close();
            }
            if (!sTSVNPath.EndsWith("\\") && !sTSVNPath.EndsWith("/"))
            {
                sTSVNPath += "\\";
            }
            sTSVNPath += SVNLookName;
            psiDiffGen = new ProcessStartInfo(sTSVNPath);
            psiDiffGen.CreateNoWindow = true;
            psiDiffGen.UseShellExecute = false;
            psiDiffGen.RedirectStandardOutput = true;
            return true;
        }
    }
}
