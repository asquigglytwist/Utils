using System.Reflection;
using System.Windows.Forms;

namespace Tyle.UI
{
    partial class AboutBox : Form
    {
        public static AboutBox AppAbout;
        static AboutBox()
        {
            AppAbout = new AboutBox();
        }
        private AboutBox()
        {
            InitializeComponent();
            Text = string.Format("About {0}", AssemblyTitle);
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = string.Format("Version {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                return AppMetaData.ApplicationName;
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                return AppMetaData.Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                return AppMetaData.ApplicationName;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                return AppMetaData.CopyRight;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                return AppMetaData.CompanyName;
            }
        }
        #endregion
    }
}
