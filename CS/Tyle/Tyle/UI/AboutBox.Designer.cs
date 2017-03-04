namespace Tyle.UI
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBrandLogo = new System.Windows.Forms.PictureBox();
            this.lnkBrandName = new System.Windows.Forms.LinkLabel();
            this.pnlBrandDetails = new System.Windows.Forms.Panel();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.pnlAppDetails = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.picAppLogo = new System.Windows.Forms.PictureBox();
            this.lnkAppName = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBrandLogo)).BeginInit();
            this.pnlBrandDetails.SuspendLayout();
            this.pnlAppDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBrandLogo
            // 
            this.picBrandLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBrandLogo.Location = new System.Drawing.Point(57, 16);
            this.picBrandLogo.Name = "picBrandLogo";
            this.picBrandLogo.Size = new System.Drawing.Size(48, 48);
            this.picBrandLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBrandLogo.TabIndex = 0;
            this.picBrandLogo.TabStop = false;
            // 
            // lnkBrandName
            // 
            this.lnkBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBrandName.Location = new System.Drawing.Point(111, 16);
            this.lnkBrandName.Name = "lnkBrandName";
            this.lnkBrandName.Size = new System.Drawing.Size(399, 48);
            this.lnkBrandName.TabIndex = 1;
            this.lnkBrandName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBrandDetails
            // 
            this.pnlBrandDetails.Controls.Add(this.picBrandLogo);
            this.pnlBrandDetails.Controls.Add(this.lnkBrandName);
            this.pnlBrandDetails.Location = new System.Drawing.Point(12, 12);
            this.pnlBrandDetails.Name = "pnlBrandDetails";
            this.pnlBrandDetails.Size = new System.Drawing.Size(614, 82);
            this.pnlBrandDetails.TabIndex = 2;
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Enabled = false;
            this.lblSeparator.Location = new System.Drawing.Point(14, 110);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(614, 3);
            this.lblSeparator.TabIndex = 3;
            // 
            // pnlAppDetails
            // 
            this.pnlAppDetails.Controls.Add(this.lblDescription);
            this.pnlAppDetails.Controls.Add(this.lblVersion);
            this.pnlAppDetails.Controls.Add(this.lblCopyright);
            this.pnlAppDetails.Controls.Add(this.picAppLogo);
            this.pnlAppDetails.Controls.Add(this.lnkAppName);
            this.pnlAppDetails.Location = new System.Drawing.Point(12, 131);
            this.pnlAppDetails.Name = "pnlAppDetails";
            this.pnlAppDetails.Size = new System.Drawing.Size(614, 316);
            this.pnlAppDetails.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Location = new System.Drawing.Point(21, 176);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(569, 124);
            this.lblDescription.TabIndex = 4;
            // 
            // lblVersion
            // 
            this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVersion.Location = new System.Drawing.Point(21, 67);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(569, 40);
            this.lblVersion.TabIndex = 3;
            // 
            // lblCopyright
            // 
            this.lblCopyright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCopyright.Location = new System.Drawing.Point(21, 120);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(569, 40);
            this.lblCopyright.TabIndex = 2;
            // 
            // picAppLogo
            // 
            this.picAppLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAppLogo.Location = new System.Drawing.Point(57, 16);
            this.picAppLogo.Name = "picAppLogo";
            this.picAppLogo.Size = new System.Drawing.Size(48, 48);
            this.picAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAppLogo.TabIndex = 0;
            this.picAppLogo.TabStop = false;
            // 
            // lnkAppName
            // 
            this.lnkAppName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAppName.Location = new System.Drawing.Point(111, 16);
            this.lnkAppName.Name = "lnkAppName";
            this.lnkAppName.Size = new System.Drawing.Size(399, 48);
            this.lnkAppName.TabIndex = 1;
            this.lnkAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 459);
            this.Controls.Add(this.pnlAppDetails);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.pnlBrandDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AboutBox";
            ((System.ComponentModel.ISupportInitialize)(this.picBrandLogo)).EndInit();
            this.pnlBrandDetails.ResumeLayout(false);
            this.pnlAppDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAppLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBrandLogo;
        private System.Windows.Forms.LinkLabel lnkBrandName;
        private System.Windows.Forms.Panel pnlBrandDetails;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Panel pnlAppDetails;
        private System.Windows.Forms.PictureBox picAppLogo;
        private System.Windows.Forms.LinkLabel lnkAppName;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDescription;
    }
}