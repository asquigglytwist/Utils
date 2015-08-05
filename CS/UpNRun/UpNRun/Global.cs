using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpNRun
{
    class Global
    {
        //static string m_sUAString;
        static Global()
        {
            StringBuilder sb = new StringBuilder("UpNRun / ");
            sb.Append(System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString());
            sb.Append("; ");
            sb.Append(Environment.OSVersion.Platform.ToString());
            sb.Append(" / ");
            sb.Append(Environment.OSVersion.Version.ToString());
            sb.Append("; HtmlAgilityPack / ");
            sb.Append(System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetAssembly(new HtmlAgilityPack.AttributeValueQuote().GetType()).Location).FileVersion);
            //m_sUAString = "0.1; HtmlAgilityPack - " + System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetAssembly(new HtmlAgilityPack.AttributeValueQuote().GetType()).Location).FileVersion;
            UserAgent = sb.ToString();
        }

        public static string UserAgent
        {
            get;
            protected set;
        }
    }
}
