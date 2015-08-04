using System.Windows.Forms;

namespace Tyle.Dialogs
{
    public partial class dlgFind : Form
    {
        public static dlgFind FindDialog;

        static dlgFind()
        {
            FindDialog = new dlgFind();
        }

        protected dlgFind()
        {
            InitializeComponent();
        }

        #region Properties
        public string SearchText
        {
            get
            {
                return tbxSearchText.Text;
            }
        }

        public bool WrapSearch
        {
            get
            {
                return chkWrapSearch.Checked;
            }
        }
        #endregion

        #region EventHandlers
        private void tbxSearchText_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSearchText.Text))
            {
                btnFind.Enabled = false;
            }
            else
            {
                btnFind.Enabled = true;
            }
        }
        #endregion
    }
}
