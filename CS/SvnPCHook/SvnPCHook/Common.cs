using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Lavnok.SvnPCHook
{
    class Common
    {
        static string sMarkers = null;
        static int iWaitTimeForProcessExit = 0;
        
        public static bool Init()
        {
            const string sMarkersDef = "NOT_FOR_REPO|NOT FOR REPO|DO_NOT_CHECKIN|DO_NOT_CHECK_IN|LOCAL_ONLY",
                csRulesFileName = @".\RulesN.xml";
            string sTagSrcMarkers = "SrcCodeMarkers",
                sTagWaitForPrcExit = "WaitForProcessExit",
                sTagAllRules = "AllRules";
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(csRulesFileName);
                sMarkers = xDoc.GetElementsByTagName(sTagSrcMarkers)[0].InnerText.Trim();
                if (sMarkers.Length < 2)
                    sMarkers = sMarkersDef;
                try
                {
                    iWaitTimeForProcessExit = int.Parse(xDoc.GetElementsByTagName(sTagWaitForPrcExit)[0].InnerText.Trim());
                }
                catch (Exception)
                {
                    iWaitTimeForProcessExit = 600000;
                }
                XmlNodeList xnlAllRuleGroups = xDoc.GetElementsByTagName(sTagAllRules)[0].ChildNodes;
                return true;
            }
            catch (FileNotFoundException exFNF)
            {
                Common.Alert(exFNF);
            }
            catch (IndexOutOfRangeException/* exIOOR*/)
            {
                Common.Alert("XML format invalid.");
            }
            return false;
        }

        public static void Alert(string sMessage)
        {
            MessageBox.Show(sMessage);
        }

        public static string Alert(Exception ex)
        {
            string sExMsg = null;
            if ((ex.InnerException != null) && !string.IsNullOrEmpty(ex.InnerException.Message))
                sExMsg = string.Format("An Exception occured.{0}Details - OuterException:{0}\"{1}\"{0}{0}StackTrace:{0}{2}{0}{0}Details - InnerException:{0}\"{3}\"{0}{0}StackTrace:{0}{4}", Environment.NewLine, ex.Message, ex.StackTrace, ex.InnerException.Message, ex.InnerException.StackTrace);
            else
                sExMsg = string.Format("An exception occured; Details:{0}\"{1}\"{0}{0}StackTrace:{0}{2}", Environment.NewLine, ex.Message, ex.StackTrace);
            Common.Alert(sExMsg);
            return sExMsg;
        }

        public static string SourceCodeMarkers
        {
            get
            {
                return sMarkers;
            }
        }

        public static int WaitTimeForProcessExit
        {
            get
            {
                return iWaitTimeForProcessExit;
            }
        }
    }
}
