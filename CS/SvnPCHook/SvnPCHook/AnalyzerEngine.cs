using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ASquigglyTwist.SvnPCHook
{
    class AnalyzerEngine
    {
        static AnalyzerEngine()
        {
            if (!Common.Init())
                throw new ApplicationException("Unable to genereate rules from XML.  Possible causes:\nThe XML file is - Not present / Not accessible (permission or path issues) / Not a valid XML file (corrpt or incomplete editing).");
        }

        public static int AnalyzeChangesInFile(string sSrcFilePath, ProcessStartInfo psiDiffGen)
        {
            const string csDiffCmd = "diff ";
            int iViolationCount = 0;
            string sDiffText = string.Empty;
            psiDiffGen.Arguments = csDiffCmd + sSrcFilePath;
            Process prcDiffGen = Process.Start(psiDiffGen);
            if (!prcDiffGen.HasExited)
                prcDiffGen.WaitForExit(Common.WaitTimeForProcessExit);
            while (!prcDiffGen.StandardOutput.EndOfStream)
            {
                sDiffText = prcDiffGen.StandardOutput.ReadLine().TrimStart();
                //Bounds checking.
                if (sDiffText.Length < 2)
                    continue;
#if DEBUG
                Console.WriteLine("DIFF Text: {0}.", sDiffText);
#endif
                if ((sDiffText[0] == '+') && (sDiffText[1] != '+'))
                {
                    iViolationCount += Regex.Matches(sDiffText, Common.SourceCodeMarkers, RegexOptions.IgnoreCase).Count;
                }
            }
            prcDiffGen.Close();
            return iViolationCount;
        }
    }
}
