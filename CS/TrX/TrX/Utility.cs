using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace TrX
{
    /// <summary>
    /// Utility class to perform all Behind the scene operations - Settings persistence, FileSystem handling for storage and retrieval of Expense data.
    /// </summary>
    static class Utility
    {
        static Utility()
        {
        }

        internal static bool Store(DataGridViewRowCollection dgvrc)
        {
            string ExpFilNam = DateTime.Today.ToString("MMyyyy");
            foreach (DataGridViewRow row in dgvrc)
            {
                foreach (DataGridViewCell cel in row.Cells)
                {
                }
            }
            return true;
        }

        internal static string GetTypeName()
        {
            return "utility";
        }
    }
}

