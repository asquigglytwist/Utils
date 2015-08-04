using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Tyle.Dialogs.dlgFind;

namespace Tyle
{
    #region TailViewer
    public partial class frmTailViewer : Form
    {
        #region Fields
        StreamReader fileStream;
        List<string> lsLinesInFile;
        frmMain MainForm;
        #endregion

        public frmTailViewer(frmMain mdiParentForm, string fileToTail)
        {
            Hide();
            InitializeComponent();
            MdiParent = MainForm = mdiParentForm;
            lsvTailViewer.ShowGroups = false;
            TailedFilePath = fileToTail;
            Text = Path.GetFileName(TailedFilePath);
        }

        public void InitTailing()
        {
            var longestLine = "";
            string temp;
            WindowState = FormWindowState.Maximized;
            lsLinesInFile = new List<string>();
            fileStream = new StreamReader(new FileStream(TailedFilePath, FileMode.Open, FileAccess.Read, FileShare.Read));
            while ((temp = fileStream.ReadLine()) != null)
            {
                if(string.IsNullOrWhiteSpace(temp))
                {
                    continue;
                }
                temp = temp.Replace("\t", "    ");
                longestLine = (longestLine.Length < temp.Length ? temp : longestLine);
                lsLinesInFile.Add(temp);
            }
            lsvTailViewer.VirtualListSize = lsLinesInFile.Count;
            lsvTailViewer.AutoFitColumnsToContent(longestLine);
            lsvTailViewer.SelectVirtualItem(lsLinesInFile.Count - 1);
            Show();
        }

        internal void ActivateAndMaximize()
        {
            WindowState = FormWindowState.Maximized;
            Activate();
        }

        internal bool FindNextItem()
        {
            if (lsvTailViewer.VirtualListSize > 0)
            {
                NextSearchStartIndex %= lsvTailViewer.VirtualListSize;
                var foundItemIndex = lsLinesInFile.FindIndex(NextSearchStartIndex, (line => (line.IndexOf(FindDialog.SearchText, StringComparison.OrdinalIgnoreCase) > -1)));
                if (foundItemIndex == -1 && NextSearchStartIndex != 0 && FindDialog.WrapSearch)
                {
                    foundItemIndex = lsLinesInFile.FindIndex(0, (line => (line.IndexOf(FindDialog.SearchText, StringComparison.OrdinalIgnoreCase) > -1)));
                }
                if (foundItemIndex != -1)
                {
                    NextSearchStartIndex = foundItemIndex + 1;
                    if (NextSearchStartIndex >= lsvTailViewer.VirtualListSize)
                    {
                        NextSearchStartIndex = 0;
                    }
                    lsvTailViewer.SelectVirtualItem(foundItemIndex);
                    return true;
                }
            }
            return false;
        }

        #region Properties
        public string TailedFilePath { get; protected set; }
        protected int NextSearchStartIndex { get; set; }
        #endregion

        #region MenuEventHandlers
        private void lsvTailViewer_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem(e.ItemIndex.ToString());
            e.Item.UseItemStyleForSubItems = false;
            e.Item.ToolTipText = e.Item.Text;
            if (e.ItemIndex % 8 != 0)
            {
                e.Item.SubItems.Add(lsLinesInFile[e.ItemIndex]);
            }
            else
            {
                e.Item.SubItems.Add(lsLinesInFile[e.ItemIndex], Color.Red, Color.Black, new Font("Verdana", 18, FontStyle.Bold));
            }
        }

        private void frmTailViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                MainForm.NotifyStoppedTailing(TailedFilePath);
            }
            catch (Exception)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (MessageBox.Show(string.Format("Unable to close:{0}{1}{0}Would you like to cancel closure and continue tailing?", Environment.NewLine, TailedFilePath), "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void mnuECopy_Click(object sender, EventArgs e)
        {
        }

        private void mnuEFind_Click(object sender, EventArgs e)
        {
            if (FindDialog.ShowDialog(this) == DialogResult.OK)
            {
                NextSearchStartIndex = (lsvTailViewer.FocusedItem != null ? lsvTailViewer.FocusedItem.Index + 1 : NextSearchStartIndex);
                if(FindNextItem())
                {
                    if(!mnuEFindNext.Enabled)
                    {
                        mnuEFindNext.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show(FindDialog.SearchText, "Unable to find string searched for", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void mnuEFindNext_Click(object sender, EventArgs e)
        {
            FindNextItem();
        }

        private void mnuEFindPrev_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
    #endregion
}
