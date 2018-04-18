using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Igrans
{
    namespace IFx
    {
        public partial class InputBox : Form
        {
            ImgFx hPg;

            public InputBox(ImgFx HPg)
            {
                InitializeComponent();
                hPg = HPg;
            }

            /// <summary>
            /// The Value specified by the user in the Numeric UpDown box
            /// </summary>
            internal double SizeValue
            {
                get
                {
                    return Convert.ToDouble(spnSize.Value);
                }
            }

            private void btnOk_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.OK;
            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}