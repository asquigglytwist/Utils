using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tyle.UI
{
    public partial class frmMain : Form
    {
        private Dictionary<string, frmTailViewer> mapOpenFiles;

        public frmMain()
        {
            InitializeComponent();
            ResetAppState();
        }

        private void ResetAppState()
        {
            mapOpenFiles?.Clear();
            mapOpenFiles = new Dictionary<string, frmTailViewer>();
        }

        private void OpenFilesForTailing(string[] fileNames)
        {
#if DEBUG
            foreach(string file in fileNames)
#else
            System.Threading.Tasks.Parallel.ForEach(fileNames, file =>
#endif
            {
                var temp= file.ToLower();
                if(mapOpenFiles.ContainsKey(temp))
                {
                    mapOpenFiles[temp]?.ActivateAndMaximize();
                }
                else
                {
                    var tailForm = new frmTailViewer(this, file);
                    mapOpenFiles[temp] = tailForm;
                    var newPage = new TabPage(tailForm.Text);
                    newPage.ToolTipText = file;
                    tbcMDIChildren.TabPages.Add(newPage);
                    tbcMDIChildren.SelectedTab = newPage;
                    tbcMDIChildren.Show();
                }
#if DEBUG
            }
#else
            });
#endif
        }

        public void NotifyStoppedTailing(string fileName, string title)
        {
            mapOpenFiles.Remove(fileName.ToLower());
            foreach(TabPage page in tbcMDIChildren.TabPages)
            {
                if(page.Text.Equals(title))
                {
                    tbcMDIChildren.TabPages.Remove(page);
                    break;
                }
            }
            if(tbcMDIChildren.TabPages.Count < 1)
            {
                tbcMDIChildren.Hide();
            }
        }

        public void NotifyFileUpdate(string title)
        {
            foreach(TabPage page in tbcMDIChildren.TabPages)
            {
                if(page.Text.Equals(title))
                {
                    page.ImageKey = "NewLinesFound.png";
                    break;
                }
            }
        }

        #region MenuEventHandlers
        private void mnuFOpen_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == dlgOpenFile.ShowDialog())
            {
                OpenFilesForTailing(dlgOpenFile.FileNames);
            }
        }

        private void mnuFClose_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
        }

        private void mnuFExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuFCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
        }

        private void mnuWCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuWTileHorizontally_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuWTileVertically_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuWArrangeIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
#endregion

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            var temp = (ActiveMdiChild as frmTailViewer)?.Text;
            foreach (TabPage page in tbcMDIChildren.TabPages)
            {
                if (page.Text.Equals(temp))
                {
                    tbcMDIChildren.SelectedTab = page;
                    break;
                }
            }
        }

        private void tbcMDIChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmTailViewer childForm;
            if (tbcMDIChildren.SelectedTab != null && mapOpenFiles.TryGetValue(tbcMDIChildren.SelectedTab.ToolTipText.ToLower(), out childForm))
            {
                childForm.Activate();
            }
        }
    }
}
