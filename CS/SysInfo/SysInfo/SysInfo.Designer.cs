namespace ASquigglyTwist
{
    namespace SysInfo
    {
        partial class SysInfo
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
                this.tabby1 = new System.Windows.Forms.TabControl();
                this.tbpBasic = new System.Windows.Forms.TabPage();
                this.table2 = new System.Windows.Forms.TableLayoutPanel();
                this.label10 = new System.Windows.Forms.Label();
                this.label9 = new System.Windows.Forms.Label();
                this.label8 = new System.Windows.Forms.Label();
                this.label7 = new System.Windows.Forms.Label();
                this.label6 = new System.Windows.Forms.Label();
                this.lblUpTime = new System.Windows.Forms.Label();
                this.lblNetwork = new System.Windows.Forms.Label();
                this.lblBootMode = new System.Windows.Forms.Label();
                this.lblPowerStatus = new System.Windows.Forms.Label();
                this.lblMonitorSize = new System.Windows.Forms.Label();
                this.table1 = new System.Windows.Forms.TableLayoutPanel();
                this.label4 = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.label1 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.label5 = new System.Windows.Forms.Label();
                this.lblMName = new System.Windows.Forms.Label();
                this.lblOSVer = new System.Windows.Forms.Label();
                this.lblPCount = new System.Windows.Forms.Label();
                this.lblSysDir = new System.Windows.Forms.Label();
                this.lblUName = new System.Windows.Forms.Label();
                this.btnBExit = new System.Windows.Forms.Button();
                this.btnBSave = new System.Windows.Forms.Button();
                this.tbpAdvanced = new System.Windows.Forms.TabPage();
                this.label12 = new System.Windows.Forms.Label();
                this.btnExit = new System.Windows.Forms.Button();
                this.btnSave = new System.Windows.Forms.Button();
                this.lblInterface = new System.Windows.Forms.Label();
                this.lblTracksPerCyl = new System.Windows.Forms.Label();
                this.lblBytesPerSect = new System.Windows.Forms.Label();
                this.lblCapacity = new System.Windows.Forms.Label();
                this.lblSectorsPerTrack = new System.Windows.Forms.Label();
                this.lblHeads = new System.Windows.Forms.Label();
                this.lblType = new System.Windows.Forms.Label();
                this.lblSerial = new System.Windows.Forms.Label();
                this.lblTracks = new System.Windows.Forms.Label();
                this.lblSectors = new System.Windows.Forms.Label();
                this.lblCylinders = new System.Windows.Forms.Label();
                this.lblSignature = new System.Windows.Forms.Label();
                this.lblPartitions = new System.Windows.Forms.Label();
                this.lblModel = new System.Windows.Forms.Label();
                this.picDrvIco = new System.Windows.Forms.PictureBox();
                this.cmbDrive = new System.Windows.Forms.ComboBox();
                this.tbpPartitions = new System.Windows.Forms.TabPage();
                this.label11 = new System.Windows.Forms.Label();
                this.btnPExit = new System.Windows.Forms.Button();
                this.btnPSave = new System.Windows.Forms.Button();
                this.txtDriveInfo = new System.Windows.Forms.TextBox();
                this.HOTF = new System.Windows.Forms.ToolTip(this.components);
                this.tmrUpTime = new System.Windows.Forms.Timer(this.components);
                this.tabby1.SuspendLayout();
                this.tbpBasic.SuspendLayout();
                this.table2.SuspendLayout();
                this.table1.SuspendLayout();
                this.tbpAdvanced.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.picDrvIco)).BeginInit();
                this.tbpPartitions.SuspendLayout();
                this.SuspendLayout();
                // 
                // tabby1
                // 
                this.tabby1.Controls.Add(this.tbpBasic);
                this.tabby1.Controls.Add(this.tbpAdvanced);
                this.tabby1.Controls.Add(this.tbpPartitions);
                this.tabby1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tabby1.Location = new System.Drawing.Point(0, 0);
                this.tabby1.Margin = new System.Windows.Forms.Padding(4);
                this.tabby1.Name = "tabby1";
                this.tabby1.SelectedIndex = 0;
                this.tabby1.ShowToolTips = true;
                this.tabby1.Size = new System.Drawing.Size(608, 457);
                this.tabby1.TabIndex = 0;
                this.tabby1.SelectedIndexChanged += new System.EventHandler(this.tabby1_SelectedIndexChanged);
                // 
                // tbpBasic
                // 
                this.tbpBasic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
                this.tbpBasic.Controls.Add(this.table2);
                this.tbpBasic.Controls.Add(this.table1);
                this.tbpBasic.Controls.Add(this.btnBExit);
                this.tbpBasic.Controls.Add(this.btnBSave);
                this.tbpBasic.ForeColor = System.Drawing.Color.White;
                this.tbpBasic.Location = new System.Drawing.Point(4, 25);
                this.tbpBasic.Margin = new System.Windows.Forms.Padding(4);
                this.tbpBasic.Name = "tbpBasic";
                this.tbpBasic.Padding = new System.Windows.Forms.Padding(4);
                this.tbpBasic.Size = new System.Drawing.Size(600, 428);
                this.tbpBasic.TabIndex = 0;
                this.tbpBasic.Text = "Basic";
                this.tbpBasic.ToolTipText = "Displays basic information about system";
                // 
                // table2
                // 
                this.table2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
                this.table2.ColumnCount = 2;
                this.table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.90734F));
                this.table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.09266F));
                this.table2.Controls.Add(this.label10, 0, 4);
                this.table2.Controls.Add(this.label9, 0, 3);
                this.table2.Controls.Add(this.label8, 0, 2);
                this.table2.Controls.Add(this.label7, 0, 1);
                this.table2.Controls.Add(this.label6, 0, 0);
                this.table2.Controls.Add(this.lblUpTime, 1, 0);
                this.table2.Controls.Add(this.lblNetwork, 1, 1);
                this.table2.Controls.Add(this.lblBootMode, 1, 2);
                this.table2.Controls.Add(this.lblPowerStatus, 1, 3);
                this.table2.Controls.Add(this.lblMonitorSize, 1, 4);
                this.table2.Location = new System.Drawing.Point(8, 221);
                this.table2.Name = "table2";
                this.table2.RowCount = 5;
                this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                this.table2.Size = new System.Drawing.Size(518, 199);
                this.table2.TabIndex = 56;
                // 
                // label10
                // 
                this.label10.AutoSize = true;
                this.label10.ForeColor = System.Drawing.Color.Goldenrod;
                this.label10.Location = new System.Drawing.Point(9, 165);
                this.label10.Margin = new System.Windows.Forms.Padding(7);
                this.label10.Name = "label10";
                this.label10.Size = new System.Drawing.Size(150, 16);
                this.label10.TabIndex = 61;
                this.label10.Text = "Primary Monitor Size";
                this.HOTF.SetToolTip(this.label10, "The Size of the Primary Monitor [Resolution]");
                // 
                // label9
                // 
                this.label9.AutoSize = true;
                this.label9.ForeColor = System.Drawing.Color.Goldenrod;
                this.label9.Location = new System.Drawing.Point(9, 126);
                this.label9.Margin = new System.Windows.Forms.Padding(7);
                this.label9.Name = "label9";
                this.label9.Size = new System.Drawing.Size(131, 16);
                this.label9.TabIndex = 60;
                this.label9.Text = "Power Line Status";
                this.HOTF.SetToolTip(this.label9, "Current Power Status of the System");
                // 
                // label8
                // 
                this.label8.AutoSize = true;
                this.label8.ForeColor = System.Drawing.Color.Goldenrod;
                this.label8.Location = new System.Drawing.Point(9, 87);
                this.label8.Margin = new System.Windows.Forms.Padding(7);
                this.label8.Name = "label8";
                this.label8.Size = new System.Drawing.Size(83, 16);
                this.label8.TabIndex = 59;
                this.label8.Text = "Boot Mode";
                this.HOTF.SetToolTip(this.label8, "Current Boot Mode, the \r\nOS is running in.");
                // 
                // label7
                // 
                this.label7.AutoSize = true;
                this.label7.ForeColor = System.Drawing.Color.Goldenrod;
                this.label7.Location = new System.Drawing.Point(9, 48);
                this.label7.Margin = new System.Windows.Forms.Padding(7);
                this.label7.Name = "label7";
                this.label7.Size = new System.Drawing.Size(121, 16);
                this.label7.TabIndex = 58;
                this.label7.Text = "Network Present";
                this.HOTF.SetToolTip(this.label7, "Indicates the presence of \r\na Network Connection");
                // 
                // label6
                // 
                this.label6.AutoSize = true;
                this.label6.ForeColor = System.Drawing.Color.Goldenrod;
                this.label6.Location = new System.Drawing.Point(9, 9);
                this.label6.Margin = new System.Windows.Forms.Padding(7);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(63, 16);
                this.label6.TabIndex = 57;
                this.label6.Text = "UpTime";
                this.HOTF.SetToolTip(this.label6, "Time elapsed since System Boot");
                // 
                // lblUpTime
                // 
                this.lblUpTime.AutoEllipsis = true;
                this.lblUpTime.AutoSize = true;
                this.lblUpTime.ForeColor = System.Drawing.Color.White;
                this.lblUpTime.Location = new System.Drawing.Point(194, 9);
                this.lblUpTime.Margin = new System.Windows.Forms.Padding(7);
                this.lblUpTime.Name = "lblUpTime";
                this.lblUpTime.Size = new System.Drawing.Size(83, 16);
                this.lblUpTime.TabIndex = 62;
                this.lblUpTime.Tag = "V";
                this.lblUpTime.Text = "UpTime :   ";
                this.HOTF.SetToolTip(this.lblUpTime, "Time elapsed since System Boot");
                // 
                // lblNetwork
                // 
                this.lblNetwork.AutoEllipsis = true;
                this.lblNetwork.AutoSize = true;
                this.lblNetwork.ForeColor = System.Drawing.Color.White;
                this.lblNetwork.Location = new System.Drawing.Point(194, 48);
                this.lblNetwork.Margin = new System.Windows.Forms.Padding(7);
                this.lblNetwork.Name = "lblNetwork";
                this.lblNetwork.Size = new System.Drawing.Size(83, 16);
                this.lblNetwork.TabIndex = 63;
                this.lblNetwork.Tag = "V";
                this.lblNetwork.Text = "UpTime :   ";
                this.HOTF.SetToolTip(this.lblNetwork, "Indicates the presence of \r\na Network Connection");
                // 
                // lblBootMode
                // 
                this.lblBootMode.AutoEllipsis = true;
                this.lblBootMode.AutoSize = true;
                this.lblBootMode.ForeColor = System.Drawing.Color.White;
                this.lblBootMode.Location = new System.Drawing.Point(194, 87);
                this.lblBootMode.Margin = new System.Windows.Forms.Padding(7);
                this.lblBootMode.Name = "lblBootMode";
                this.lblBootMode.Size = new System.Drawing.Size(83, 16);
                this.lblBootMode.TabIndex = 64;
                this.lblBootMode.Tag = "V";
                this.lblBootMode.Text = "UpTime :   ";
                this.HOTF.SetToolTip(this.lblBootMode, "Current Boot Mode, the \r\nOS is running in.");
                // 
                // lblPowerStatus
                // 
                this.lblPowerStatus.AutoEllipsis = true;
                this.lblPowerStatus.AutoSize = true;
                this.lblPowerStatus.ForeColor = System.Drawing.Color.White;
                this.lblPowerStatus.Location = new System.Drawing.Point(194, 126);
                this.lblPowerStatus.Margin = new System.Windows.Forms.Padding(7);
                this.lblPowerStatus.Name = "lblPowerStatus";
                this.lblPowerStatus.Size = new System.Drawing.Size(83, 16);
                this.lblPowerStatus.TabIndex = 65;
                this.lblPowerStatus.Tag = "V";
                this.lblPowerStatus.Text = "UpTime :   ";
                this.HOTF.SetToolTip(this.lblPowerStatus, "Current Power Status of the System");
                // 
                // lblMonitorSize
                // 
                this.lblMonitorSize.AutoEllipsis = true;
                this.lblMonitorSize.AutoSize = true;
                this.lblMonitorSize.ForeColor = System.Drawing.Color.White;
                this.lblMonitorSize.Location = new System.Drawing.Point(194, 165);
                this.lblMonitorSize.Margin = new System.Windows.Forms.Padding(7);
                this.lblMonitorSize.Name = "lblMonitorSize";
                this.lblMonitorSize.Size = new System.Drawing.Size(83, 16);
                this.lblMonitorSize.TabIndex = 66;
                this.lblMonitorSize.Tag = "V";
                this.lblMonitorSize.Text = "UpTime :   ";
                this.HOTF.SetToolTip(this.lblMonitorSize, "The Size of the Primary Monitor [Resolution]");
                // 
                // table1
                // 
                this.table1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
                this.table1.ColumnCount = 2;
                this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.08018F));
                this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.91982F));
                this.table1.Controls.Add(this.label4, 0, 3);
                this.table1.Controls.Add(this.label3, 0, 2);
                this.table1.Controls.Add(this.label1, 0, 0);
                this.table1.Controls.Add(this.label2, 0, 1);
                this.table1.Controls.Add(this.label5, 0, 4);
                this.table1.Controls.Add(this.lblMName, 1, 0);
                this.table1.Controls.Add(this.lblOSVer, 1, 1);
                this.table1.Controls.Add(this.lblPCount, 1, 2);
                this.table1.Controls.Add(this.lblSysDir, 1, 3);
                this.table1.Controls.Add(this.lblUName, 1, 4);
                this.table1.Location = new System.Drawing.Point(7, 37);
                this.table1.Name = "table1";
                this.table1.RowCount = 5;
                this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
                this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                this.table1.Size = new System.Drawing.Size(519, 178);
                this.table1.TabIndex = 55;
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.ForeColor = System.Drawing.Color.Goldenrod;
                this.label4.Location = new System.Drawing.Point(9, 114);
                this.label4.Margin = new System.Windows.Forms.Padding(7);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(126, 16);
                this.label4.TabIndex = 48;
                this.label4.Text = "System Directory";
                this.HOTF.SetToolTip(this.label4, "The System Directory");
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.ForeColor = System.Drawing.Color.Goldenrod;
                this.label3.Location = new System.Drawing.Point(9, 79);
                this.label3.Margin = new System.Windows.Forms.Padding(7);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(122, 16);
                this.label3.TabIndex = 47;
                this.label3.Text = "Processor Count";
                this.HOTF.SetToolTip(this.label3, "Number of Processors in the System");
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.ForeColor = System.Drawing.Color.Goldenrod;
                this.label1.Location = new System.Drawing.Point(9, 9);
                this.label1.Margin = new System.Windows.Forms.Padding(7);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(111, 16);
                this.label1.TabIndex = 45;
                this.label1.Text = "Machine Name";
                this.HOTF.SetToolTip(this.label1, "Machine Name");
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.ForeColor = System.Drawing.Color.Goldenrod;
                this.label2.Location = new System.Drawing.Point(9, 44);
                this.label2.Margin = new System.Windows.Forms.Padding(7);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(86, 16);
                this.label2.TabIndex = 46;
                this.label2.Text = "OS Version";
                this.HOTF.SetToolTip(this.label2, "OS Version");
                // 
                // label5
                // 
                this.label5.AutoSize = true;
                this.label5.ForeColor = System.Drawing.Color.Goldenrod;
                this.label5.Location = new System.Drawing.Point(9, 149);
                this.label5.Margin = new System.Windows.Forms.Padding(7);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(86, 16);
                this.label5.TabIndex = 49;
                this.label5.Text = "User Name";
                this.HOTF.SetToolTip(this.label5, "Currently active System User");
                // 
                // lblMName
                // 
                this.lblMName.AutoEllipsis = true;
                this.lblMName.AutoSize = true;
                this.lblMName.ForeColor = System.Drawing.Color.White;
                this.lblMName.Location = new System.Drawing.Point(196, 9);
                this.lblMName.Margin = new System.Windows.Forms.Padding(7);
                this.lblMName.Name = "lblMName";
                this.lblMName.Size = new System.Drawing.Size(111, 16);
                this.lblMName.TabIndex = 50;
                this.lblMName.Tag = "V";
                this.lblMName.Text = "Machine Name";
                this.HOTF.SetToolTip(this.lblMName, "Machine Name");
                // 
                // lblOSVer
                // 
                this.lblOSVer.AutoEllipsis = true;
                this.lblOSVer.AutoSize = true;
                this.lblOSVer.ForeColor = System.Drawing.Color.White;
                this.lblOSVer.Location = new System.Drawing.Point(196, 44);
                this.lblOSVer.Margin = new System.Windows.Forms.Padding(7);
                this.lblOSVer.Name = "lblOSVer";
                this.lblOSVer.Size = new System.Drawing.Size(111, 16);
                this.lblOSVer.TabIndex = 51;
                this.lblOSVer.Tag = "V";
                this.lblOSVer.Text = "Machine Name";
                this.HOTF.SetToolTip(this.lblOSVer, "OS Version");
                // 
                // lblPCount
                // 
                this.lblPCount.AutoEllipsis = true;
                this.lblPCount.AutoSize = true;
                this.lblPCount.ForeColor = System.Drawing.Color.White;
                this.lblPCount.Location = new System.Drawing.Point(196, 79);
                this.lblPCount.Margin = new System.Windows.Forms.Padding(7);
                this.lblPCount.Name = "lblPCount";
                this.lblPCount.Size = new System.Drawing.Size(111, 16);
                this.lblPCount.TabIndex = 52;
                this.lblPCount.Tag = "V";
                this.lblPCount.Text = "Machine Name";
                this.HOTF.SetToolTip(this.lblPCount, "Number of Processors in the System");
                // 
                // lblSysDir
                // 
                this.lblSysDir.AutoEllipsis = true;
                this.lblSysDir.AutoSize = true;
                this.lblSysDir.ForeColor = System.Drawing.Color.White;
                this.lblSysDir.Location = new System.Drawing.Point(196, 114);
                this.lblSysDir.Margin = new System.Windows.Forms.Padding(7);
                this.lblSysDir.Name = "lblSysDir";
                this.lblSysDir.Size = new System.Drawing.Size(111, 16);
                this.lblSysDir.TabIndex = 53;
                this.lblSysDir.Tag = "V";
                this.lblSysDir.Text = "Machine Name";
                this.HOTF.SetToolTip(this.lblSysDir, "The System Directory");
                // 
                // lblUName
                // 
                this.lblUName.AutoEllipsis = true;
                this.lblUName.AutoSize = true;
                this.lblUName.ForeColor = System.Drawing.Color.White;
                this.lblUName.Location = new System.Drawing.Point(196, 149);
                this.lblUName.Margin = new System.Windows.Forms.Padding(7);
                this.lblUName.Name = "lblUName";
                this.lblUName.Size = new System.Drawing.Size(111, 16);
                this.lblUName.TabIndex = 54;
                this.lblUName.Tag = "V";
                this.lblUName.Text = "Machine Name";
                this.HOTF.SetToolTip(this.lblUName, "Currently active System User");
                // 
                // btnBExit
                // 
                this.btnBExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.btnBExit.Image = global::SysInfo.Properties.Resources.Close;
                this.btnBExit.Location = new System.Drawing.Point(566, 7);
                this.btnBExit.Name = "btnBExit";
                this.btnBExit.Size = new System.Drawing.Size(32, 32);
                this.btnBExit.TabIndex = 54;
                this.HOTF.SetToolTip(this.btnBExit, "Click to Quit the Application\r\n\r\n[HOTKEY: ESC (ESCAPE)]\r\n");
                this.btnBExit.UseVisualStyleBackColor = true;
                this.btnBExit.Click += new System.EventHandler(this.btnBExit_Click);
                // 
                // btnBSave
                // 
                this.btnBSave.Image = global::SysInfo.Properties.Resources.Save;
                this.btnBSave.Location = new System.Drawing.Point(528, 7);
                this.btnBSave.Name = "btnBSave";
                this.btnBSave.Size = new System.Drawing.Size(32, 32);
                this.btnBSave.TabIndex = 53;
                this.HOTF.SetToolTip(this.btnBSave, "Click to Save the Data on the Screen\r\n\r\n[HOTKEY: ENTER / RETURN]");
                this.btnBSave.UseVisualStyleBackColor = true;
                this.btnBSave.Click += new System.EventHandler(this.btnBSave_Click);
                // 
                // tbpAdvanced
                // 
                this.tbpAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
                this.tbpAdvanced.Controls.Add(this.label12);
                this.tbpAdvanced.Controls.Add(this.btnExit);
                this.tbpAdvanced.Controls.Add(this.btnSave);
                this.tbpAdvanced.Controls.Add(this.lblInterface);
                this.tbpAdvanced.Controls.Add(this.lblTracksPerCyl);
                this.tbpAdvanced.Controls.Add(this.lblBytesPerSect);
                this.tbpAdvanced.Controls.Add(this.lblCapacity);
                this.tbpAdvanced.Controls.Add(this.lblSectorsPerTrack);
                this.tbpAdvanced.Controls.Add(this.lblHeads);
                this.tbpAdvanced.Controls.Add(this.lblType);
                this.tbpAdvanced.Controls.Add(this.lblSerial);
                this.tbpAdvanced.Controls.Add(this.lblTracks);
                this.tbpAdvanced.Controls.Add(this.lblSectors);
                this.tbpAdvanced.Controls.Add(this.lblCylinders);
                this.tbpAdvanced.Controls.Add(this.lblSignature);
                this.tbpAdvanced.Controls.Add(this.lblPartitions);
                this.tbpAdvanced.Controls.Add(this.lblModel);
                this.tbpAdvanced.Controls.Add(this.picDrvIco);
                this.tbpAdvanced.Controls.Add(this.cmbDrive);
                this.tbpAdvanced.ForeColor = System.Drawing.Color.White;
                this.tbpAdvanced.Location = new System.Drawing.Point(4, 25);
                this.tbpAdvanced.Margin = new System.Windows.Forms.Padding(4);
                this.tbpAdvanced.Name = "tbpAdvanced";
                this.tbpAdvanced.Padding = new System.Windows.Forms.Padding(4);
                this.tbpAdvanced.Size = new System.Drawing.Size(600, 428);
                this.tbpAdvanced.TabIndex = 1;
                this.tbpAdvanced.Text = "Advanced";
                this.tbpAdvanced.ToolTipText = "Displays advanced information about system";
                // 
                // label12
                // 
                this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label12.Location = new System.Drawing.Point(89, 9);
                this.label12.Name = "label12";
                this.label12.Size = new System.Drawing.Size(409, 31);
                this.label12.TabIndex = 58;
                this.label12.Text = "Select a Drive from the list below";
                // 
                // btnExit
                // 
                this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.btnExit.Image = global::SysInfo.Properties.Resources.Close;
                this.btnExit.Location = new System.Drawing.Point(543, 40);
                this.btnExit.Name = "btnExit";
                this.btnExit.Size = new System.Drawing.Size(32, 32);
                this.btnExit.TabIndex = 52;
                this.HOTF.SetToolTip(this.btnExit, "Click to Quit the Application\r\n\r\n[HOTKEY: ESC (ESCAPE)]\r\n");
                this.btnExit.UseVisualStyleBackColor = true;
                this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
                // 
                // btnSave
                // 
                this.btnSave.Enabled = false;
                this.btnSave.Image = global::SysInfo.Properties.Resources.Save;
                this.btnSave.Location = new System.Drawing.Point(505, 40);
                this.btnSave.Name = "btnSave";
                this.btnSave.Size = new System.Drawing.Size(32, 32);
                this.btnSave.TabIndex = 51;
                this.HOTF.SetToolTip(this.btnSave, "Click to Save the Data on the Screen\r\n\r\n[HOTKEY: ENTER / RETURN]");
                this.btnSave.UseVisualStyleBackColor = true;
                this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
                // 
                // lblInterface
                // 
                this.lblInterface.AutoSize = true;
                this.lblInterface.Location = new System.Drawing.Point(336, 144);
                this.lblInterface.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblInterface.Name = "lblInterface";
                this.lblInterface.Size = new System.Drawing.Size(72, 16);
                this.lblInterface.TabIndex = 50;
                this.lblInterface.Text = "Interface:";
                this.HOTF.SetToolTip(this.lblInterface, "Interface Type");
                // 
                // lblTracksPerCyl
                // 
                this.lblTracksPerCyl.AutoSize = true;
                this.lblTracksPerCyl.Location = new System.Drawing.Point(30, 363);
                this.lblTracksPerCyl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblTracksPerCyl.Name = "lblTracksPerCyl";
                this.lblTracksPerCyl.Size = new System.Drawing.Size(148, 16);
                this.lblTracksPerCyl.TabIndex = 49;
                this.lblTracksPerCyl.Text = "Tracks per Cylinder:";
                this.HOTF.SetToolTip(this.lblTracksPerCyl, "Tracks per Cylinder");
                // 
                // lblBytesPerSect
                // 
                this.lblBytesPerSect.AutoSize = true;
                this.lblBytesPerSect.Location = new System.Drawing.Point(30, 300);
                this.lblBytesPerSect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblBytesPerSect.Name = "lblBytesPerSect";
                this.lblBytesPerSect.Size = new System.Drawing.Size(127, 16);
                this.lblBytesPerSect.TabIndex = 47;
                this.lblBytesPerSect.Text = "Bytes per Sector:";
                this.HOTF.SetToolTip(this.lblBytesPerSect, "Bytes per Sector");
                // 
                // lblCapacity
                // 
                this.lblCapacity.AutoSize = true;
                this.lblCapacity.Location = new System.Drawing.Point(55, 175);
                this.lblCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblCapacity.Name = "lblCapacity";
                this.lblCapacity.Size = new System.Drawing.Size(73, 16);
                this.lblCapacity.TabIndex = 46;
                this.lblCapacity.Text = "Capacity:";
                this.HOTF.SetToolTip(this.lblCapacity, "Capacity of the Selected Drive");
                // 
                // lblSectorsPerTrack
                // 
                this.lblSectorsPerTrack.AutoSize = true;
                this.lblSectorsPerTrack.Location = new System.Drawing.Point(30, 331);
                this.lblSectorsPerTrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblSectorsPerTrack.Name = "lblSectorsPerTrack";
                this.lblSectorsPerTrack.Size = new System.Drawing.Size(136, 16);
                this.lblSectorsPerTrack.TabIndex = 48;
                this.lblSectorsPerTrack.Text = "Sectors per Track:";
                this.HOTF.SetToolTip(this.lblSectorsPerTrack, "Sectors per Track");
                // 
                // lblHeads
                // 
                this.lblHeads.AutoSize = true;
                this.lblHeads.Location = new System.Drawing.Point(336, 235);
                this.lblHeads.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblHeads.Name = "lblHeads";
                this.lblHeads.Size = new System.Drawing.Size(58, 16);
                this.lblHeads.TabIndex = 45;
                this.lblHeads.Text = "Heads:";
                this.HOTF.SetToolTip(this.lblHeads, "Number of Heads in the Selected Drive");
                // 
                // lblType
                // 
                this.lblType.AutoSize = true;
                this.lblType.Location = new System.Drawing.Point(55, 86);
                this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblType.Name = "lblType";
                this.lblType.Size = new System.Drawing.Size(48, 16);
                this.lblType.TabIndex = 44;
                this.lblType.Text = "Type:";
                this.HOTF.SetToolTip(this.lblType, "MediaType");
                // 
                // lblSerial
                // 
                this.lblSerial.AutoSize = true;
                this.lblSerial.Location = new System.Drawing.Point(55, 144);
                this.lblSerial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblSerial.Name = "lblSerial";
                this.lblSerial.Size = new System.Drawing.Size(65, 16);
                this.lblSerial.TabIndex = 43;
                this.lblSerial.Text = "Serial #:";
                this.HOTF.SetToolTip(this.lblSerial, "Serial Number");
                // 
                // lblTracks
                // 
                this.lblTracks.AutoSize = true;
                this.lblTracks.Location = new System.Drawing.Point(336, 265);
                this.lblTracks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblTracks.Name = "lblTracks";
                this.lblTracks.Size = new System.Drawing.Size(60, 16);
                this.lblTracks.TabIndex = 42;
                this.lblTracks.Text = "Tracks:";
                this.HOTF.SetToolTip(this.lblTracks, "Number of Tracks in the Drive");
                // 
                // lblSectors
                // 
                this.lblSectors.AutoSize = true;
                this.lblSectors.Location = new System.Drawing.Point(56, 263);
                this.lblSectors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblSectors.Name = "lblSectors";
                this.lblSectors.Size = new System.Drawing.Size(65, 16);
                this.lblSectors.TabIndex = 41;
                this.lblSectors.Text = "Sectors:";
                this.HOTF.SetToolTip(this.lblSectors, "Number of Sectors in the disk");
                // 
                // lblCylinders
                // 
                this.lblCylinders.AutoSize = true;
                this.lblCylinders.Location = new System.Drawing.Point(55, 235);
                this.lblCylinders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblCylinders.Name = "lblCylinders";
                this.lblCylinders.Size = new System.Drawing.Size(77, 16);
                this.lblCylinders.TabIndex = 40;
                this.lblCylinders.Text = "Cylinders:";
                this.HOTF.SetToolTip(this.lblCylinders, "Number of Cylinders in the Drive");
                // 
                // lblSignature
                // 
                this.lblSignature.AutoSize = true;
                this.lblSignature.Location = new System.Drawing.Point(336, 205);
                this.lblSignature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblSignature.Name = "lblSignature";
                this.lblSignature.Size = new System.Drawing.Size(78, 16);
                this.lblSignature.TabIndex = 39;
                this.lblSignature.Text = "Signature:";
                this.HOTF.SetToolTip(this.lblSignature, "Signature of the Drive");
                // 
                // lblPartitions
                // 
                this.lblPartitions.AutoSize = true;
                this.lblPartitions.Location = new System.Drawing.Point(55, 205);
                this.lblPartitions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblPartitions.Name = "lblPartitions";
                this.lblPartitions.Size = new System.Drawing.Size(77, 16);
                this.lblPartitions.TabIndex = 38;
                this.lblPartitions.Text = "Partitions:";
                this.HOTF.SetToolTip(this.lblPartitions, "Number of partitions on the Drive");
                // 
                // lblModel
                // 
                this.lblModel.AutoSize = true;
                this.lblModel.Location = new System.Drawing.Point(55, 114);
                this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblModel.Name = "lblModel";
                this.lblModel.Size = new System.Drawing.Size(55, 16);
                this.lblModel.TabIndex = 37;
                this.lblModel.Text = "Model:";
                this.HOTF.SetToolTip(this.lblModel, "Model of the Selected Drive");
                // 
                // picDrvIco
                // 
                this.picDrvIco.Image = global::SysInfo.Properties.Resources.HDDIcon;
                this.picDrvIco.Location = new System.Drawing.Point(30, 33);
                this.picDrvIco.Margin = new System.Windows.Forms.Padding(4);
                this.picDrvIco.Name = "picDrvIco";
                this.picDrvIco.Size = new System.Drawing.Size(48, 39);
                this.picDrvIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.picDrvIco.TabIndex = 36;
                this.picDrvIco.TabStop = false;
                this.HOTF.SetToolTip(this.picDrvIco, "Display the list of Physical Drives\r\nattached to the system");
                // 
                // cmbDrive
                // 
                this.cmbDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.cmbDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.cmbDrive.FormattingEnabled = true;
                this.cmbDrive.Location = new System.Drawing.Point(86, 44);
                this.cmbDrive.Margin = new System.Windows.Forms.Padding(4);
                this.cmbDrive.Name = "cmbDrive";
                this.cmbDrive.Size = new System.Drawing.Size(412, 28);
                this.cmbDrive.TabIndex = 35;
                this.HOTF.SetToolTip(this.cmbDrive, "Display the list of Physical Drives\r\nattached to the system");
                this.cmbDrive.SelectedIndexChanged += new System.EventHandler(this.cmbDrive_SelectedIndexChanged);
                // 
                // tbpPartitions
                // 
                this.tbpPartitions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
                this.tbpPartitions.Controls.Add(this.label11);
                this.tbpPartitions.Controls.Add(this.btnPExit);
                this.tbpPartitions.Controls.Add(this.btnPSave);
                this.tbpPartitions.Controls.Add(this.txtDriveInfo);
                this.tbpPartitions.ForeColor = System.Drawing.Color.White;
                this.tbpPartitions.Location = new System.Drawing.Point(4, 25);
                this.tbpPartitions.Name = "tbpPartitions";
                this.tbpPartitions.Padding = new System.Windows.Forms.Padding(3);
                this.tbpPartitions.Size = new System.Drawing.Size(600, 428);
                this.tbpPartitions.TabIndex = 2;
                this.tbpPartitions.Text = "Partitions";
                this.tbpPartitions.ToolTipText = "Displays information about Partitions";
                // 
                // label11
                // 
                this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label11.Location = new System.Drawing.Point(33, 6);
                this.label11.Name = "label11";
                this.label11.Size = new System.Drawing.Size(409, 31);
                this.label11.TabIndex = 57;
                this.label11.Text = "Information on individual Partitions";
                // 
                // btnPExit
                // 
                this.btnPExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.btnPExit.Image = global::SysInfo.Properties.Resources.Close;
                this.btnPExit.Location = new System.Drawing.Point(564, 6);
                this.btnPExit.Name = "btnPExit";
                this.btnPExit.Size = new System.Drawing.Size(32, 32);
                this.btnPExit.TabIndex = 56;
                this.HOTF.SetToolTip(this.btnPExit, "Click to Quit the Application\r\n\r\n[HOTKEY: ESC (ESCAPE)]\r\n");
                this.btnPExit.UseVisualStyleBackColor = true;
                this.btnPExit.Click += new System.EventHandler(this.btnPExit_Click);
                // 
                // btnPSave
                // 
                this.btnPSave.Image = global::SysInfo.Properties.Resources.Save;
                this.btnPSave.Location = new System.Drawing.Point(526, 6);
                this.btnPSave.Name = "btnPSave";
                this.btnPSave.Size = new System.Drawing.Size(32, 32);
                this.btnPSave.TabIndex = 55;
                this.HOTF.SetToolTip(this.btnPSave, "Click to Save the Data on the Screen\r\n\r\n[HOTKEY: ENTER / RETURN]");
                this.btnPSave.UseVisualStyleBackColor = true;
                this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
                // 
                // txtDriveInfo
                // 
                this.txtDriveInfo.AcceptsReturn = true;
                this.txtDriveInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
                this.txtDriveInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.txtDriveInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtDriveInfo.Location = new System.Drawing.Point(3, 39);
                this.txtDriveInfo.Multiline = true;
                this.txtDriveInfo.Name = "txtDriveInfo";
                this.txtDriveInfo.ReadOnly = true;
                this.txtDriveInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
                this.txtDriveInfo.Size = new System.Drawing.Size(594, 386);
                this.txtDriveInfo.TabIndex = 0;
                // 
                // HOTF
                // 
                this.HOTF.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
                this.HOTF.ToolTipTitle = "DriveInfo";
                // 
                // tmrUpTime
                // 
                this.tmrUpTime.Enabled = true;
                this.tmrUpTime.Interval = 4321;
                this.tmrUpTime.Tick += new System.EventHandler(this.tmrUpTime_Tick);
                // 
                // SysInfo
                // 
                this.AcceptButton = this.btnBSave;
                this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.White;
                this.CancelButton = this.btnBExit;
                this.ClientSize = new System.Drawing.Size(608, 457);
                this.Controls.Add(this.tabby1);
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Margin = new System.Windows.Forms.Padding(4);
                this.Name = "SysInfo";
                this.Opacity = 0.88;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "SysInfo";
                this.HOTF.SetToolTip(this, "System Information Dialog");
                this.tabby1.ResumeLayout(false);
                this.tbpBasic.ResumeLayout(false);
                this.table2.ResumeLayout(false);
                this.table2.PerformLayout();
                this.table1.ResumeLayout(false);
                this.table1.PerformLayout();
                this.tbpAdvanced.ResumeLayout(false);
                this.tbpAdvanced.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.picDrvIco)).EndInit();
                this.tbpPartitions.ResumeLayout(false);
                this.tbpPartitions.PerformLayout();
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.TabControl tabby1;
            private System.Windows.Forms.TabPage tbpBasic;
            private System.Windows.Forms.TabPage tbpAdvanced;
            private System.Windows.Forms.Button btnExit;
            private System.Windows.Forms.ToolTip HOTF;
            private System.Windows.Forms.Button btnSave;
            private System.Windows.Forms.Label lblInterface;
            private System.Windows.Forms.Label lblTracksPerCyl;
            private System.Windows.Forms.Label lblBytesPerSect;
            private System.Windows.Forms.Label lblCapacity;
            private System.Windows.Forms.Label lblSectorsPerTrack;
            private System.Windows.Forms.Label lblHeads;
            private System.Windows.Forms.Label lblType;
            private System.Windows.Forms.Label lblSerial;
            private System.Windows.Forms.Label lblTracks;
            private System.Windows.Forms.Label lblSectors;
            private System.Windows.Forms.Label lblCylinders;
            private System.Windows.Forms.Label lblSignature;
            private System.Windows.Forms.Label lblPartitions;
            private System.Windows.Forms.Label lblModel;
            private System.Windows.Forms.PictureBox picDrvIco;
            private System.Windows.Forms.ComboBox cmbDrive;
            private System.Windows.Forms.Button btnBExit;
            private System.Windows.Forms.Button btnBSave;
            private System.Windows.Forms.TableLayoutPanel table1;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Label lblMName;
            private System.Windows.Forms.Label lblOSVer;
            private System.Windows.Forms.Label lblPCount;
            private System.Windows.Forms.Label lblSysDir;
            private System.Windows.Forms.Label lblUName;
            private System.Windows.Forms.TableLayoutPanel table2;
            private System.Windows.Forms.Label label9;
            private System.Windows.Forms.Label label8;
            private System.Windows.Forms.Label label7;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.Label label10;
            private System.Windows.Forms.Label lblUpTime;
            private System.Windows.Forms.Label lblNetwork;
            private System.Windows.Forms.Label lblBootMode;
            private System.Windows.Forms.Label lblPowerStatus;
            private System.Windows.Forms.Label lblMonitorSize;
            private System.Windows.Forms.Timer tmrUpTime;
            private System.Windows.Forms.TabPage tbpPartitions;
            private System.Windows.Forms.TextBox txtDriveInfo;
            private System.Windows.Forms.Button btnPExit;
            private System.Windows.Forms.Button btnPSave;
            private System.Windows.Forms.Label label11;
            private System.Windows.Forms.Label label12;
        }
    }
}