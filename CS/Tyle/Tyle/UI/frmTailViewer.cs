using Tyle.Core;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static Tyle.UI.FindDialog;

namespace Tyle.UI
{
    #region TailViewer
    public partial class frmTailViewer : Form
    {
        #region Fields
        frmMain MainForm;
        TailedStream tailedFile;
        #endregion

        public frmTailViewer(frmMain mdiParentForm, string fileToTail)
        {
            Hide();
            InitializeComponent();
            MdiParent = MainForm = mdiParentForm;
            lsvTailViewer.ShowGroups = false;
            tailedFile = new TailedStream(fileToTail, this);
            Text = Path.GetFileName(fileToTail);
            InitDisplay();
        }

        protected void InitDisplay()
        {
            WindowState = FormWindowState.Maximized;
            if (tailedFile.InitTailing())
            {
                UpdateTailView();
            }
            Show();
        }

        public void UpdateTailView()
        {
            lsvTailViewer.BeginUpdate();
            int lineCount = tailedFile.LineCount;
            if(lsvTailViewer.VirtualListSize < lineCount)
            {
                MainForm.NotifyFileUpdate(Text);
                lsvTailViewer.VirtualListSize = lineCount;
                lsvTailViewer.AutoFitColumnsToContent(tailedFile.LongestLine);
                lsvTailViewer.SelectVirtualItem(tailedFile.LineCount - 1);
                lsvTailViewer.EndUpdate();
                lsvTailViewer.Invalidate();
            }
            else if (lsvTailViewer.VirtualListSize > lineCount)
            {
                // TODO:  Request for a resurrection.
            }
            else
            {
                // No change; Just leave things be.
            }
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
                var foundItemIndex = tailedFile.FindItem(FindDialog.findDialog.SearchText, lsvTailViewer.SearchBeginIndex, FindDialog.findDialog.WrapSearch);
                if (foundItemIndex != -1)
                {
                    lsvTailViewer.SelectVirtualItem(foundItemIndex);
                    return true;
                }
            }
            return false;
        }

        #region EventHandlers
        private void lsvTailViewer_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem((e.ItemIndex + 1).ToString());
            e.Item.UseItemStyleForSubItems = false;
            e.Item.ToolTipText = e.Item.Text;
            if (e.ItemIndex % 8 != 0)
            {
                e.Item.SubItems.Add(tailedFile[e.ItemIndex], Color.Black, Color.White, lsvTailViewer.Font);
            }
            else
            {
                e.Item.SubItems.Add(tailedFile[e.ItemIndex], Color.LightYellow, Color.Black, lsvTailViewer.Font);
            }
        }

        private void frmTailViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                MainForm.NotifyStoppedTailing(tailedFile.TailedFilePath, Text);
            }
            catch (Exception)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (MessageBox.Show(string.Format("Unable to close:{0}{1}{0}Would you like to cancel closure and continue tailing?", Environment.NewLine, tailedFile.TailedFilePath), "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
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
            if (FindDialog.findDialog.ShowDialog(this) == DialogResult.OK)
            {
                if(FindNextItem())
                {
                    if(!mnuEFindNext.Enabled)
                    {
                        mnuEFindNext.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show(FindDialog.findDialog.SearchText, "Unable to find string searched for", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
