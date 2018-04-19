namespace ASquigglyTwist
{
    partial class ImgFx
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
            this.lblPath = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoResize = new System.Windows.Forms.RadioButton();
            this.rdoNegative = new System.Windows.Forms.RadioButton();
            this.rdoPencilSketch = new System.Windows.Forms.RadioButton();
            this.track = new System.Windows.Forms.TrackBar();
            this.rdoGrayScale = new System.Windows.Forms.RadioButton();
            this.rdoSepia = new System.Windows.Forms.RadioButton();
            this.rdoASCIIArt = new System.Windows.Forms.RadioButton();
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spnThreshold = new System.Windows.Forms.NumericUpDown();
            this.spnEnhance = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.rdoSolar = new System.Windows.Forms.RadioButton();
            this.lblVal = new System.Windows.Forms.Label();
            this.lblTVal = new System.Windows.Forms.Label();
            this.oDlg0 = new System.Windows.Forms.OpenFileDialog();
            this.sDlg0 = new System.Windows.Forms.SaveFileDialog();
            this.grpState = new System.Windows.Forms.GroupBox();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.sDlg1 = new System.Windows.Forms.SaveFileDialog();
            this.tlpTopHalf = new System.Windows.Forms.TableLayoutPanel();
            this.tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.track)).BeginInit();
            this.grpCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnEnhance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.grpState.SuspendLayout();
            this.tlpTopHalf.SuspendLayout();
            this.tlpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoEllipsis = true;
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(0, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(1258, 32);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Path of the picture selected";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblPath, "Path of the Image file \r\nselected for conversion\r\n\r\nDoubleClick to copy path \r\nto" +
        " ClipBoard\r\n(or Reduce MiniBrowser\'s \r\nsize.\r\n[Only for ASCII Art mode])");
            this.lblPath.Click += new System.EventHandler(this.lblPath_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 300;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "IME";
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(463, 103);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(68, 22);
            this.rdoBlue.TabIndex = 9;
            this.rdoBlue.Text = "&BLUE";
            this.toolTip1.SetToolTip(this.rdoBlue, "Select to enhance the BLUE\r\ncomponent in the Image");
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(233, 103);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(81, 22);
            this.rdoGreen.TabIndex = 8;
            this.rdoGreen.Text = "&GREEN";
            this.toolTip1.SetToolTip(this.rdoGreen, "Select to enhance the GREEN\r\ncomponent in the Image");
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(3, 103);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(60, 22);
            this.rdoRed.TabIndex = 7;
            this.rdoRed.Text = "&RED";
            this.toolTip1.SetToolTip(this.rdoRed, "Select to enhance the RED\r\ncomponent in the Image");
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // rdoResize
            // 
            this.rdoResize.AutoSize = true;
            this.rdoResize.Checked = true;
            this.rdoResize.Location = new System.Drawing.Point(3, 153);
            this.rdoResize.Name = "rdoResize";
            this.rdoResize.Size = new System.Drawing.Size(79, 22);
            this.rdoResize.TabIndex = 6;
            this.rdoResize.TabStop = true;
            this.rdoResize.Text = "Resi&ze";
            this.toolTip1.SetToolTip(this.rdoResize, "Select to create a Resized Image\r\nwithout any Special Effects");
            this.rdoResize.UseVisualStyleBackColor = true;
            this.rdoResize.CheckedChanged += new System.EventHandler(this.rdoResize_CheckedChanged);
            // 
            // rdoNegative
            // 
            this.rdoNegative.AutoSize = true;
            this.rdoNegative.Location = new System.Drawing.Point(233, 53);
            this.rdoNegative.Name = "rdoNegative";
            this.rdoNegative.Size = new System.Drawing.Size(97, 22);
            this.rdoNegative.TabIndex = 5;
            this.rdoNegative.Text = "&Negative";
            this.toolTip1.SetToolTip(this.rdoNegative, "Select to produce Negative \r\nColors on the Selected Image");
            this.rdoNegative.UseVisualStyleBackColor = true;
            this.rdoNegative.CheckedChanged += new System.EventHandler(this.rdoNegative_CheckedChanged);
            // 
            // rdoPencilSketch
            // 
            this.rdoPencilSketch.AutoSize = true;
            this.rdoPencilSketch.Location = new System.Drawing.Point(463, 3);
            this.rdoPencilSketch.Name = "rdoPencilSketch";
            this.rdoPencilSketch.Size = new System.Drawing.Size(126, 22);
            this.rdoPencilSketch.TabIndex = 4;
            this.rdoPencilSketch.Text = "&PencilSketch";
            this.toolTip1.SetToolTip(this.rdoPencilSketch, "Select to produce the Pencil Sketch\r\nof the Selected Image");
            this.rdoPencilSketch.UseVisualStyleBackColor = true;
            this.rdoPencilSketch.CheckedChanged += new System.EventHandler(this.rdoPencilSketch_CheckedChanged);
            // 
            // track
            // 
            this.tlpOptions.SetColumnSpan(this.track, 3);
            this.track.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track.LargeChange = 100;
            this.track.Location = new System.Drawing.Point(11, 211);
            this.track.Margin = new System.Windows.Forms.Padding(11);
            this.track.Maximum = 3000;
            this.track.Minimum = 1;
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(670, 30);
            this.track.SmallChange = 50;
            this.track.TabIndex = 3;
            this.track.TickFrequency = 100;
            this.toolTip1.SetToolTip(this.track, "ASCII Art Mode:\r\n     Indicate the Width to be used for ASCII Art\r\n[ i.e., Number" +
        " of characters per line ]\r\n\r\nResize Mode:\r\n     Indicate the Width to be used fo" +
        "r Image  Resizing");
            this.track.Value = 100;
            this.track.ValueChanged += new System.EventHandler(this.track_ValueChanged);
            // 
            // rdoGrayScale
            // 
            this.rdoGrayScale.AutoSize = true;
            this.rdoGrayScale.Location = new System.Drawing.Point(233, 3);
            this.rdoGrayScale.Name = "rdoGrayScale";
            this.rdoGrayScale.Size = new System.Drawing.Size(106, 22);
            this.rdoGrayScale.TabIndex = 2;
            this.rdoGrayScale.Text = "Gra&yScale";
            this.toolTip1.SetToolTip(this.rdoGrayScale, "Select to produce the GrayScale\r\nof the Selected Image");
            this.rdoGrayScale.UseVisualStyleBackColor = true;
            this.rdoGrayScale.CheckedChanged += new System.EventHandler(this.rdoGrayScale_CheckedChanged);
            // 
            // rdoSepia
            // 
            this.rdoSepia.AutoSize = true;
            this.rdoSepia.Location = new System.Drawing.Point(3, 53);
            this.rdoSepia.Name = "rdoSepia";
            this.rdoSepia.Size = new System.Drawing.Size(71, 22);
            this.rdoSepia.TabIndex = 1;
            this.rdoSepia.Text = "S&epia";
            this.toolTip1.SetToolTip(this.rdoSepia, "Select to produce Sepia effect\r\non the Selected Image");
            this.rdoSepia.UseVisualStyleBackColor = true;
            this.rdoSepia.CheckedChanged += new System.EventHandler(this.rdoSepia_CheckedChanged);
            // 
            // rdoASCIIArt
            // 
            this.rdoASCIIArt.AutoSize = true;
            this.rdoASCIIArt.Location = new System.Drawing.Point(3, 3);
            this.rdoASCIIArt.Name = "rdoASCIIArt";
            this.rdoASCIIArt.Size = new System.Drawing.Size(96, 22);
            this.rdoASCIIArt.TabIndex = 0;
            this.rdoASCIIArt.Text = "&ASCIIArt";
            this.toolTip1.SetToolTip(this.rdoASCIIArt, "Select to create an ASCIIArt\r\nof the Selected Image");
            this.rdoASCIIArt.UseVisualStyleBackColor = true;
            this.rdoASCIIArt.CheckedChanged += new System.EventHandler(this.rdoASCIIArt_CheckedChanged);
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.lblTimer);
            this.grpCommand.Controls.Add(this.label2);
            this.grpCommand.Controls.Add(this.label1);
            this.grpCommand.Controls.Add(this.spnThreshold);
            this.grpCommand.Controls.Add(this.spnEnhance);
            this.grpCommand.Controls.Add(this.btnSave);
            this.grpCommand.Controls.Add(this.btnConvert);
            this.grpCommand.Controls.Add(this.btnBrowse);
            this.grpCommand.Location = new System.Drawing.Point(744, 569);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(496, 174);
            this.grpCommand.TabIndex = 10;
            this.grpCommand.TabStop = false;
            this.grpCommand.Text = "Commands";
            this.toolTip1.SetToolTip(this.grpCommand, "The available Conversion Commands");
            // 
            // lblTimer
            // 
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Bisque;
            this.lblTimer.Location = new System.Drawing.Point(240, 29);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(127, 66);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "Time";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblTimer, "Total time taken for \r\nCurrent Conversion");
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Threshold";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enhancement";
            // 
            // spnThreshold
            // 
            this.spnThreshold.BackColor = System.Drawing.Color.Gainsboro;
            this.spnThreshold.Enabled = false;
            this.spnThreshold.Location = new System.Drawing.Point(148, 69);
            this.spnThreshold.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.spnThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnThreshold.Name = "spnThreshold";
            this.spnThreshold.Size = new System.Drawing.Size(69, 26);
            this.spnThreshold.TabIndex = 4;
            this.spnThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.spnThreshold, "Enter a value to be used as Threshold \r\nfor Selected mode enhancement\r\n\r\n[ RANGE:" +
        " 1 to 255 ]");
            this.spnThreshold.Value = new decimal(new int[] {
            63,
            0,
            0,
            0});
            // 
            // spnEnhance
            // 
            this.spnEnhance.BackColor = System.Drawing.Color.Gainsboro;
            this.spnEnhance.Enabled = false;
            this.spnEnhance.Location = new System.Drawing.Point(148, 29);
            this.spnEnhance.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.spnEnhance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnEnhance.Name = "spnEnhance";
            this.spnEnhance.Size = new System.Drawing.Size(69, 26);
            this.spnEnhance.TabIndex = 3;
            this.spnEnhance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.spnEnhance, "Enter a value to be used for\r\nSelected mode enhancement\r\n\r\n[ RANGE: 1 to 255 ]");
            this.spnEnhance.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.spnEnhance.EnabledChanged += new System.EventHandler(this.spnEnhance_EnabledChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(240, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.toolTip1.SetToolTip(this.btnSave, "Click to Save the \r\napplied Conversions");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(130, 114);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(87, 42);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "&Convert";
            this.toolTip1.SetToolTip(this.btnConvert, "Click to apply Conversion\r\non Selected Image");
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(10, 114);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(89, 42);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Br&owse";
            this.toolTip1.SetToolTip(this.btnBrowse, "Click to Browse for the\r\nImage File to be Converted");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSize
            // 
            this.lblSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(3, 22);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(500, 23);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblSize, "Mode and State");
            // 
            // lblMode
            // 
            this.lblMode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(3, 70);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(500, 28);
            this.lblMode.TabIndex = 1;
            this.lblMode.Text = "Resize";
            this.toolTip1.SetToolTip(this.lblMode, "Mode and State");
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(630, 36);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(238, 18);
            this.lblPreview.TabIndex = 7;
            this.lblPreview.Text = "Preview Current Changes";
            this.toolTip1.SetToolTip(this.lblPreview, "Preview Current Changes");
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblStatus.Location = new System.Drawing.Point(0, 755);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1258, 27);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblStatus, "Status of Task / SubTask \r\ncurrently being carried out \r\nas part of Conversion");
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::IFx.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(1218, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnClose, "Click to Close\r\n\r\n[HOTKEY: ESC (ESCAPE)]");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picOriginal
            // 
            this.picOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picOriginal.Location = new System.Drawing.Point(3, 3);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(609, 374);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 1;
            this.picOriginal.TabStop = false;
            this.toolTip1.SetToolTip(this.picOriginal, "Preview of the Original Image selected \r\nfor conversion.\r\n\r\nDoubleClick to enlarg" +
        "e or reduce View Area");
            this.picOriginal.DoubleClick += new System.EventHandler(this.Image_DoubleClick);
            // 
            // picPreview
            // 
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview.Location = new System.Drawing.Point(618, 3);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(610, 374);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 5;
            this.picPreview.TabStop = false;
            this.toolTip1.SetToolTip(this.picPreview, "Preview of the Image as of current changes\r\n\r\nDoubleClick to enlarge or reduce  V" +
        "iew Area");
            this.picPreview.DoubleClick += new System.EventHandler(this.Image_DoubleClick);
            // 
            // rdoSolar
            // 
            this.rdoSolar.AutoSize = true;
            this.rdoSolar.Location = new System.Drawing.Point(463, 53);
            this.rdoSolar.Name = "rdoSolar";
            this.rdoSolar.Size = new System.Drawing.Size(91, 22);
            this.rdoSolar.TabIndex = 12;
            this.rdoSolar.TabStop = true;
            this.rdoSolar.Text = "So&larize";
            this.rdoSolar.UseVisualStyleBackColor = true;
            this.rdoSolar.CheckedChanged += new System.EventHandler(this.rdoSolar_CheckedChanged);
            // 
            // lblVal
            // 
            this.lblVal.AutoEllipsis = true;
            this.lblVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblVal.Location = new System.Drawing.Point(471, 161);
            this.lblVal.Margin = new System.Windows.Forms.Padding(11);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(123, 25);
            this.lblVal.TabIndex = 11;
            this.lblVal.Text = "100";
            this.lblVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTVal
            // 
            this.lblTVal.AutoEllipsis = true;
            this.lblTVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTVal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTVal.Location = new System.Drawing.Point(241, 161);
            this.lblTVal.Margin = new System.Windows.Forms.Padding(11);
            this.lblTVal.Name = "lblTVal";
            this.lblTVal.Size = new System.Drawing.Size(117, 25);
            this.lblTVal.TabIndex = 10;
            this.lblTVal.Text = "Track Value";
            this.lblTVal.Click += new System.EventHandler(this.lblTVal_Click);
            // 
            // oDlg0
            // 
            this.oDlg0.Filter = "All genric Image Formats(Bitmap, JPEG, GIF, PNG)|*.bmp;*.jpg;*.jpeg;*.gif;*.png";
            this.oDlg0.Title = "Select an Image File";
            // 
            // sDlg0
            // 
            this.sDlg0.DefaultExt = "html";
            this.sDlg0.Filter = "HTML Files|*.html";
            this.sDlg0.Title = "Save ASCII Art as";
            // 
            // grpState
            // 
            this.grpState.Controls.Add(this.lblMode);
            this.grpState.Controls.Add(this.lblSize);
            this.grpState.Location = new System.Drawing.Point(737, 462);
            this.grpState.Name = "grpState";
            this.grpState.Size = new System.Drawing.Size(506, 101);
            this.grpState.TabIndex = 11;
            this.grpState.TabStop = false;
            this.grpState.Text = "PresentState";
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(15, 36);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(120, 18);
            this.lblOriginal.TabIndex = 6;
            this.lblOriginal.Text = "Original Image";
            // 
            // sDlg1
            // 
            this.sDlg1.DefaultExt = "bmp";
            this.sDlg1.Filter = "Bitmap File|*.bmp|Graphics Interchange Format(GIF)|*.gif|Joint Photographic Exper" +
    "ts Group(JPEG)|*.jpg|Portable Network Graphics (PNG)|*.png";
            this.sDlg1.Title = "Save Converted Image as";
            // 
            // tlpTopHalf
            // 
            this.tlpTopHalf.ColumnCount = 2;
            this.tlpTopHalf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTopHalf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTopHalf.Controls.Add(this.picOriginal, 0, 0);
            this.tlpTopHalf.Controls.Add(this.picPreview, 1, 0);
            this.tlpTopHalf.Location = new System.Drawing.Point(15, 57);
            this.tlpTopHalf.Name = "tlpTopHalf";
            this.tlpTopHalf.RowCount = 1;
            this.tlpTopHalf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTopHalf.Size = new System.Drawing.Size(1231, 380);
            this.tlpTopHalf.TabIndex = 13;
            // 
            // tlpOptions
            // 
            this.tlpOptions.ColumnCount = 3;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpOptions.Controls.Add(this.track, 0, 4);
            this.tlpOptions.Controls.Add(this.lblVal, 2, 3);
            this.tlpOptions.Controls.Add(this.rdoSolar, 2, 1);
            this.tlpOptions.Controls.Add(this.lblTVal, 1, 3);
            this.tlpOptions.Controls.Add(this.rdoASCIIArt, 0, 0);
            this.tlpOptions.Controls.Add(this.rdoResize, 0, 3);
            this.tlpOptions.Controls.Add(this.rdoBlue, 2, 2);
            this.tlpOptions.Controls.Add(this.rdoGrayScale, 1, 0);
            this.tlpOptions.Controls.Add(this.rdoGreen, 1, 2);
            this.tlpOptions.Controls.Add(this.rdoPencilSketch, 2, 0);
            this.tlpOptions.Controls.Add(this.rdoRed, 0, 2);
            this.tlpOptions.Controls.Add(this.rdoSepia, 0, 1);
            this.tlpOptions.Controls.Add(this.rdoNegative, 1, 1);
            this.tlpOptions.Location = new System.Drawing.Point(18, 459);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.RowCount = 5;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpOptions.Size = new System.Drawing.Size(692, 252);
            this.tlpOptions.TabIndex = 14;
            // 
            // ImgFx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1258, 782);
            this.Controls.Add(this.tlpOptions);
            this.Controls.Add(this.tlpTopHalf);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpState);
            this.Controls.Add(this.grpCommand);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPath);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImgFx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IFx";
            ((System.ComponentModel.ISupportInitialize)(this.track)).EndInit();
            this.grpCommand.ResumeLayout(false);
            this.grpCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnEnhance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.grpState.ResumeLayout(false);
            this.tlpTopHalf.ResumeLayout(false);
            this.tlpOptions.ResumeLayout(false);
            this.tlpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog oDlg0;
        private System.Windows.Forms.SaveFileDialog sDlg0;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdoASCIIArt;
        private System.Windows.Forms.RadioButton rdoSepia;
        private System.Windows.Forms.RadioButton rdoGrayScale;
        private System.Windows.Forms.TrackBar track;
        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton rdoPencilSketch;
        private System.Windows.Forms.RadioButton rdoNegative;
        private System.Windows.Forms.RadioButton rdoResize;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.GroupBox grpState;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblTVal;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.NumericUpDown spnEnhance;
        private System.Windows.Forms.NumericUpDown spnThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoSolar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.SaveFileDialog sDlg1;
        private System.Windows.Forms.TableLayoutPanel tlpTopHalf;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
    }
}