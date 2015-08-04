using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            Application.Run(new frmMain());
        }
    }

    public static class AppMetaData
    {
        public const string ApplicationName = "Tyle";
        public const string Description = "A Windows Tail Utility...";
        public const string CompanyName = "L";
        public const string CopyRight = "Copyright © " + AppMetaData.CompanyName + ", 2017; All rights reserved.";
        public const string TradeMark = AppMetaData.ApplicationName + ", " + AppMetaData.CompanyName;
    }
}
