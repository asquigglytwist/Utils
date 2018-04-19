namespace ASquigglyTwist
{
    partial class InputBox
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
            this.components = new System.ComponentModel.Container();
            this.spnSize = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.HOTF = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spnSize)).BeginInit();
            this.SuspendLayout();
            // 
            // spnSize
            // 
            this.spnSize.BackColor = System.Drawing.Color.Gainsboro;
            this.spnSize.DecimalPlaces = 2;
            this.spnSize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spnSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spnSize.Location = new System.Drawing.Point(0, 129);
            this.spnSize.Margin = new System.Windows.Forms.Padding(4);
            this.spnSize.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.spnSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnSize.Name = "spnSize";
            this.spnSize.Size = new System.Drawing.Size(422, 32);
            this.spnSize.TabIndex = 1;
            this.spnSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spnSize.ThousandsSeparator = true;
            this.spnSize.Value = new decimal(new int[] {
            10001,
            0,
            0,
            131072});
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(297, 25);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 36);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.HOTF.SetToolTip(this.btnOk, "Click to accept the current input\r\n\r\n[ HOTKEY: ENTER / RETURN ]");
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // HOTF
            // 
            this.HOTF.IsBalloon = true;
            this.HOTF.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.HOTF.ToolTipTitle = "IME-IFx";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(297, 69);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.HOTF.SetToolTip(this.btnCancel, "Click to cancel the current input\r\n\r\n[ HOTKEY: ESC (ESCAPE) ]");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the size Manually\r\nin the Spinner below";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(46, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Range is\r\n[ 1 to 3000 ]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputBox
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(422, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.spnSize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "IFx";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.spnSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown spnSize;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ToolTip HOTF;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}