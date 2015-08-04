using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyle
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
            foreach(string file in fileNames)
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
                    tailForm.InitTailing();
                }
            }
        }

        public void NotifyStoppedTailing(string fileName)
        {
            mapOpenFiles.Remove(fileName.ToLower());
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
    }
}
