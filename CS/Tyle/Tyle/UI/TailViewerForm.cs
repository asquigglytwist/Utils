﻿using Tyle.Core;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Tyle.UI
{
    #region TailViewerForm
    public partial class TailViewerForm : Form
    {
        #region Fields
        MainForm MainForm;
        TailedStream tailedFile;
        #endregion

        public TailViewerForm(MainForm mdiParentForm, string fileToTail)
        {
            Hide();
            InitializeComponent();
            MdiParent = MainForm = mdiParentForm;
            lsvTailViewer.ShowGroups = false;
            tailedFile = new TailedStream(fileToTail);
            tailedFile.OnTailedFileChanged += TailedFile_OnTailedFileChanged;
            tailedFile.InitTailing();
            Text = Path.GetFileName(fileToTail);
            //InitDisplay();
            WindowState = FormWindowState.Maximized;
            //tailedFile.InitTailing();
            Show();
        }

        private void TailedFile_OnTailedFileChanged(object sender, TailedFileChangedArgs args)
        {
            switch (args.ChangeType)
            {
                case TailedFileChangeType.InitialReadComplete:
                case TailedFileChangeType.LastLineExtended:
                case TailedFileChangeType.LinesAdded:
                    // [BIB]:  https://stackoverflow.com/a/661662
                    Invoke((MethodInvoker)delegate { UpdateTailView(); });
                    break;
                case TailedFileChangeType.Shrunk:
                    break;
                case TailedFileChangeType.Renamed:
                    MessageBox.Show("File has been Renamed.");
                    break;
                case TailedFileChangeType.Deleted:
                    MessageBox.Show("File has been deleted.");
                    break;
                case TailedFileChangeType.NoContentChange:
                default:
                    break;
            }
        }

        protected void InitDisplay()
        {
        }

        protected void UpdateTailView()
        {
            int lineCount = tailedFile.LineCount;
            MainForm.NotifyFileUpdate(Text);
            lsvTailViewer.VirtualListSize = lineCount;
            lsvTailViewer.AutoFitColumnsToContent(tailedFile.LongestLine);
            lsvTailViewer.SelectVirtualItem(tailedFile.LineCount - 1);
            // [BIB]:  https://stackoverflow.com/a/30104935
            lsvTailViewer.Refresh();
        }

        protected bool FindNextItem()
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

        internal void ActivateAndMaximize()
        {
            WindowState = FormWindowState.Maximized;
            Activate();
        }

        #region EventHandlers
        private void lsvTailViewer_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            var lineToDisplay = tailedFile[e.ItemIndex];
            e.Item = new ListViewItem((e.ItemIndex + 1).ToString());
            e.Item.UseItemStyleForSubItems = false;
            e.Item.ToolTipText = lineToDisplay;
            if (e.ItemIndex % 8 != 0)
            {
                e.Item.SubItems.Add(lineToDisplay, Color.LightYellow, Color.Black, lsvTailViewer.Font);
            }
            else
            {
                e.Item.SubItems.Add(lineToDisplay, Color.Black, Color.White, lsvTailViewer.Font);
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
            if(!FindNextItem())
            {
                //TODO:  Visual cue (or auditory)
            }
        }

        private void mnuEFindPrev_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
    #endregion
}