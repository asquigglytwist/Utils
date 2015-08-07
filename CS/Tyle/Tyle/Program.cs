using System;
using System.Windows.Forms;

namespace Tyle
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.frmMain());
        }
    }

    public static class AppMetaData
    {
        public const string ApplicationName = "Tyle";
        public const string Description = "Tail Your Logs Efficiently...";
        public const string CompanyName = "LS";
        public const string CopyRight = "Copyright © " + CompanyName + ", 2017; All rights reserved.";
        public const string TradeMark = ApplicationName + ", " + CompanyName;
    }
}
