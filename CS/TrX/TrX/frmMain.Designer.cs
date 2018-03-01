namespace TrX
{
    partial class frmMain
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
            this.dtpExpensdOn = new System.Windows.Forms.DateTimePicker();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.stsBottom = new System.Windows.Forms.StatusStrip();
            this.tslToday = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslRecurrence = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslCategory = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tslLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrInvoluntary = new System.Windows.Forms.Timer(this.components);
            this.btnDebug = new System.Windows.Forms.Button();
            this.gbxExpense = new System.Windows.Forms.GroupBox();
            this.sltExpenses = new System.Windows.Forms.SplitContainer();
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoHarvest = new System.Windows.Forms.RadioButton();
            this.rdoEdibles = new System.Windows.Forms.RadioButton();
            this.rdoNeedles = new System.Windows.Forms.RadioButton();
            this.rdoDock = new System.Windows.Forms.RadioButton();
            this.rdoUpkeep = new System.Windows.Forms.RadioButton();
            this.rdoPeace = new System.Windows.Forms.RadioButton();
            this.rdoTrivia = new System.Windows.Forms.RadioButton();
            this.rdoBrainiac = new System.Windows.Forms.RadioButton();
            this.rdoSeeds = new System.Windows.Forms.RadioButton();
            this.flpControls = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHarvest = new System.Windows.Forms.Panel();
            this.cbxPayH2O = new System.Windows.Forms.ComboBox();
            this.cbxPayMilk = new System.Windows.Forms.ComboBox();
            this.cbxPayVeggies = new System.Windows.Forms.ComboBox();
            this.cbxPayGrocks = new System.Windows.Forms.ComboBox();
            this.tbxH2OStore = new System.Windows.Forms.TextBox();
            this.tbxMilkStore = new System.Windows.Forms.TextBox();
            this.tbxVegStore = new System.Windows.Forms.TextBox();
            this.tbxGrocStore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.spnH2O = new System.Windows.Forms.NumericUpDown();
            this.lblH2O = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.spnMilk = new System.Windows.Forms.NumericUpDown();
            this.lblMilk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spnVeggies = new System.Windows.Forms.NumericUpDown();
            this.lblVeggies = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spnGrocks = new System.Windows.Forms.NumericUpDown();
            this.lblGrocks = new System.Windows.Forms.Label();
            this.pnlEdible = new System.Windows.Forms.Panel();
            this.cbxPaySnacks = new System.Windows.Forms.ComboBox();
            this.cbxPayDinner = new System.Windows.Forms.ComboBox();
            this.cbxPayLunch = new System.Windows.Forms.ComboBox();
            this.cbxPayBreakFast = new System.Windows.Forms.ComboBox();
            this.lblBreakFast = new System.Windows.Forms.Label();
            this.lblSnacks = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.cbxSnacks = new System.Windows.Forms.ComboBox();
            this.cbxDinner = new System.Windows.Forms.ComboBox();
            this.cbxLunch = new System.Windows.Forms.ComboBox();
            this.cbxBreakFast = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.spnSnacks = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.spnDinner = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.spnLunch = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.spnBreakFast = new System.Windows.Forms.NumericUpDown();
            this.pnlDock = new System.Windows.Forms.Panel();
            this.cbxPayFuel = new System.Windows.Forms.ComboBox();
            this.cbxPayCabs = new System.Windows.Forms.ComboBox();
            this.cbxPayJourney = new System.Windows.Forms.ComboBox();
            this.cbxPayCommute = new System.Windows.Forms.ComboBox();
            this.tbxCabs = new System.Windows.Forms.TextBox();
            this.tbxJourney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.spnFuel = new System.Windows.Forms.NumericUpDown();
            this.lblFuel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.spnCabs = new System.Windows.Forms.NumericUpDown();
            this.lblCabs = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.spnJourney = new System.Windows.Forms.NumericUpDown();
            this.lblJourney = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.spnCommute = new System.Windows.Forms.NumericUpDown();
            this.lblCommute = new System.Windows.Forms.Label();
            this.pnlNeedles = new System.Windows.Forms.Panel();
            this.cbxPayHospital = new System.Windows.Forms.ComboBox();
            this.cbxPayMedicine = new System.Windows.Forms.ComboBox();
            this.tbxHospital = new System.Windows.Forms.TextBox();
            this.tbxMedicine = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.spnHospital = new System.Windows.Forms.NumericUpDown();
            this.lblHospital = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.spnMedicine = new System.Windows.Forms.NumericUpDown();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.pnlUpkeep = new System.Windows.Forms.Panel();
            this.cbxPayPhone = new System.Windows.Forms.ComboBox();
            this.lxtPhone = new System.Windows.Forms.Label();
            this.spnTelephony = new System.Windows.Forms.NumericUpDown();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cbxPayLoan = new System.Windows.Forms.ComboBox();
            this.cbxPayStrata = new System.Windows.Forms.ComboBox();
            this.cbxPayEB = new System.Windows.Forms.ComboBox();
            this.cbxDomH2O = new System.Windows.Forms.ComboBox();
            this.cbxPayRent = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.spnLoan = new System.Windows.Forms.NumericUpDown();
            this.lblLoan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.spnStrata = new System.Windows.Forms.NumericUpDown();
            this.lblStrata = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.spnEB = new System.Windows.Forms.NumericUpDown();
            this.lblEB = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.spnDomH2O = new System.Windows.Forms.NumericUpDown();
            this.lblDomH2O = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.spnRent = new System.Windows.Forms.NumericUpDown();
            this.lblRent = new System.Windows.Forms.Label();
            this.pnlPeace = new System.Windows.Forms.Panel();
            this.cbxPayTour = new System.Windows.Forms.ComboBox();
            this.cbxPayCinemas = new System.Windows.Forms.ComboBox();
            this.cbxPayMagazine = new System.Windows.Forms.ComboBox();
            this.cbxPayNewsPaper = new System.Windows.Forms.ComboBox();
            this.cbxPayInternet = new System.Windows.Forms.ComboBox();
            this.cbxPayDTH = new System.Windows.Forms.ComboBox();
            this.tbxTour = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.spnTour = new System.Windows.Forms.NumericUpDown();
            this.lblTour = new System.Windows.Forms.Label();
            this.tbxCinemas = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.spnCinemas = new System.Windows.Forms.NumericUpDown();
            this.lblCinemas = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.spnMagazine = new System.Windows.Forms.NumericUpDown();
            this.lblMagazine = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.spnNewsPaper = new System.Windows.Forms.NumericUpDown();
            this.lblNewspaper = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.spnInternet = new System.Windows.Forms.NumericUpDown();
            this.lblInternet = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.spnDTH = new System.Windows.Forms.NumericUpDown();
            this.lblDTH = new System.Windows.Forms.Label();
            this.pnlTrivials = new System.Windows.Forms.Panel();
            this.cbxPayFootWear = new System.Windows.Forms.ComboBox();
            this.cbxPayFurniture = new System.Windows.Forms.ComboBox();
            this.cbxPayUtensils = new System.Windows.Forms.ComboBox();
            this.cbxPayApparels = new System.Windows.Forms.ComboBox();
            this.cbxPayDress = new System.Windows.Forms.ComboBox();
            this.cbxPayElectronics = new System.Windows.Forms.ComboBox();
            this.cbxPayElectricals = new System.Windows.Forms.ComboBox();
            this.tbxFootwear = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.spnFootwear = new System.Windows.Forms.NumericUpDown();
            this.lblFootwear = new System.Windows.Forms.Label();
            this.tbxFurniture = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.spnFurniture = new System.Windows.Forms.NumericUpDown();
            this.lblFurniture = new System.Windows.Forms.Label();
            this.tbxUtensils = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.spnUtensils = new System.Windows.Forms.NumericUpDown();
            this.lblUtensils = new System.Windows.Forms.Label();
            this.tbxApparels = new System.Windows.Forms.TextBox();
            this.tbxDress = new System.Windows.Forms.TextBox();
            this.tbxElectronics = new System.Windows.Forms.TextBox();
            this.tbxElectricals = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.spnApparels = new System.Windows.Forms.NumericUpDown();
            this.lblApparels = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.spnDress = new System.Windows.Forms.NumericUpDown();
            this.lblDress = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.spnElectronics = new System.Windows.Forms.NumericUpDown();
            this.lblElectronics = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.spnElectricals = new System.Windows.Forms.NumericUpDown();
            this.lblElectricals = new System.Windows.Forms.Label();
            this.pnlBrainiac = new System.Windows.Forms.Panel();
            this.cbxPayFees = new System.Windows.Forms.ComboBox();
            this.cbxPayNoteBooks = new System.Windows.Forms.ComboBox();
            this.cbxPayBooks = new System.Windows.Forms.ComboBox();
            this.cbxPayStationery = new System.Windows.Forms.ComboBox();
            this.tbxFees = new System.Windows.Forms.TextBox();
            this.tbxNoteBooks = new System.Windows.Forms.TextBox();
            this.tbxBooks = new System.Windows.Forms.TextBox();
            this.tbxStationery = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.spnFees = new System.Windows.Forms.NumericUpDown();
            this.lblFees = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.spnNoteBooks = new System.Windows.Forms.NumericUpDown();
            this.lblNoteBooks = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.spnBooks = new System.Windows.Forms.NumericUpDown();
            this.lblBooks = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.spnStationery = new System.Windows.Forms.NumericUpDown();
            this.lblStationery = new System.Windows.Forms.Label();
            this.pnlSeeds = new System.Windows.Forms.Panel();
            this.cbxPayHouseEMI = new System.Windows.Forms.ComboBox();
            this.cbxPayMetals = new System.Windows.Forms.ComboBox();
            this.cbxPayDeposits = new System.Windows.Forms.ComboBox();
            this.cbxPayInsurance = new System.Windows.Forms.ComboBox();
            this.tbxMetals = new System.Windows.Forms.TextBox();
            this.tbxDeposits = new System.Windows.Forms.TextBox();
            this.tbxInsurance = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.spnHouseEMI = new System.Windows.Forms.NumericUpDown();
            this.lblHouseEMI = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.spnMetals = new System.Windows.Forms.NumericUpDown();
            this.lblMetals = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.spnDeposits = new System.Windows.Forms.NumericUpDown();
            this.lblDeposits = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.spnInsurance = new System.Windows.Forms.NumericUpDown();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.flpRecurrence = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoDaily = new System.Windows.Forms.RadioButton();
            this.rdoWeekly = new System.Windows.Forms.RadioButton();
            this.rdoMonthly = new System.Windows.Forms.RadioButton();
            this.rdoAnnual = new System.Windows.Forms.RadioButton();
            this.rdoOneTime = new System.Windows.Forms.RadioButton();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.stsBottom.SuspendLayout();
            this.gbxExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sltExpenses)).BeginInit();
            this.sltExpenses.Panel1.SuspendLayout();
            this.sltExpenses.Panel2.SuspendLayout();
            this.sltExpenses.SuspendLayout();
            this.flpCategories.SuspendLayout();
            this.flpControls.SuspendLayout();
            this.pnlHarvest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnH2O)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMilk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnVeggies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnGrocks)).BeginInit();
            this.pnlEdible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnSnacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnLunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnBreakFast)).BeginInit();
            this.pnlDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnJourney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCommute)).BeginInit();
            this.pnlNeedles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMedicine)).BeginInit();
            this.pnlUpkeep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnTelephony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnStrata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnEB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDomH2O)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnRent)).BeginInit();
            this.pnlPeace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCinemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMagazine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNewsPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnInternet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDTH)).BeginInit();
            this.pnlTrivials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnFootwear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFurniture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnUtensils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnApparels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnElectronics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnElectricals)).BeginInit();
            this.pnlBrainiac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNoteBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnStationery)).BeginInit();
            this.pnlSeeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnHouseEMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMetals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnInsurance)).BeginInit();
            this.flpRecurrence.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpExpensdOn
            // 
            this.dtpExpensdOn.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpExpensdOn.Location = new System.Drawing.Point(476, 67);
            this.dtpExpensdOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpExpensdOn.Name = "dtpExpensdOn";
            this.dtpExpensdOn.Size = new System.Drawing.Size(214, 25);
            this.dtpExpensdOn.TabIndex = 0;
            this.dtpExpensdOn.ValueChanged += new System.EventHandler(this.OnDateChanged);
            // 
            // mnuMain
            // 
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMain.Size = new System.Drawing.Size(842, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // stsBottom
            // 
            this.stsBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslToday,
            this.tslNow,
            this.tslRecurrence,
            this.tslCategory,
            this.tspProgress,
            this.tslLastAction});
            this.stsBottom.Location = new System.Drawing.Point(0, 435);
            this.stsBottom.Name = "stsBottom";
            this.stsBottom.Size = new System.Drawing.Size(842, 24);
            this.stsBottom.TabIndex = 3;
            this.stsBottom.Text = "StatusBar";
            // 
            // tslToday
            // 
            this.tslToday.AutoToolTip = true;
            this.tslToday.Name = "tslToday";
            this.tslToday.Size = new System.Drawing.Size(118, 19);
            this.tslToday.Text = "toolStripStatusLabel1";
            // 
            // tslNow
            // 
            this.tslNow.AutoToolTip = true;
            this.tslNow.Name = "tslNow";
            this.tslNow.Size = new System.Drawing.Size(118, 19);
            this.tslNow.Text = "toolStripStatusLabel1";
            // 
            // tslRecurrence
            // 
            this.tslRecurrence.AutoToolTip = true;
            this.tslRecurrence.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tslRecurrence.Name = "tslRecurrence";
            this.tslRecurrence.Size = new System.Drawing.Size(70, 19);
            this.tslRecurrence.Text = "Recurrence";
            this.tslRecurrence.ToolTipText = "Displays the recurrence currently selected.\r\n\r\nThe Display adapts to a combinatio" +
                "n of \r\nthe Recurrence and Category currently selected.";
            // 
            // tslCategory
            // 
            this.tslCategory.AutoToolTip = true;
            this.tslCategory.Name = "tslCategory";
            this.tslCategory.Size = new System.Drawing.Size(55, 19);
            this.tslCategory.Text = "Category";
            this.tslCategory.ToolTipText = "Displays the category currently selected.\r\n\r\nThe Display adapts to a combination " +
                "of \r\nthe Recurrence and Category currently selected.";
            // 
            // tspProgress
            // 
            this.tspProgress.Name = "tspProgress";
            this.tspProgress.Size = new System.Drawing.Size(100, 18);
            this.tspProgress.Value = 1;
            // 
            // tslLastAction
            // 
            this.tslLastAction.AutoToolTip = true;
            this.tslLastAction.Name = "tslLastAction";
            this.tslLastAction.Size = new System.Drawing.Size(394, 19);
            this.tslLastAction.Spring = true;
            this.tslLastAction.Text = "Any action performed by TrX will be displayed here for your information.";
            this.tslLastAction.ToolTipText = "Any action performed by TrX will be displayed here for your information.";
            // 
            // tmrInvoluntary
            // 
            this.tmrInvoluntary.Tick += new System.EventHandler(this.tmrInvoluntary_Tick);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(735, 53);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 23);
            this.btnDebug.TabIndex = 4;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // gbxExpense
            // 
            this.gbxExpense.Controls.Add(this.sltExpenses);
            this.gbxExpense.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxExpense.Location = new System.Drawing.Point(0, 110);
            this.gbxExpense.Name = "gbxExpense";
            this.gbxExpense.Size = new System.Drawing.Size(842, 325);
            this.gbxExpense.TabIndex = 6;
            this.gbxExpense.TabStop = false;
            this.gbxExpense.Text = "Expense";
            // 
            // sltExpenses
            // 
            this.sltExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sltExpenses.IsSplitterFixed = true;
            this.sltExpenses.Location = new System.Drawing.Point(3, 21);
            this.sltExpenses.Name = "sltExpenses";
            // 
            // sltExpenses.Panel1
            // 
            this.sltExpenses.Panel1.AutoScroll = true;
            this.sltExpenses.Panel1.Controls.Add(this.flpCategories);
            // 
            // sltExpenses.Panel2
            // 
            this.sltExpenses.Panel2.Controls.Add(this.flpControls);
            this.sltExpenses.Size = new System.Drawing.Size(836, 301);
            this.sltExpenses.SplitterDistance = 141;
            this.sltExpenses.TabIndex = 7;
            // 
            // flpCategories
            // 
            this.flpCategories.Controls.Add(this.rdoHarvest);
            this.flpCategories.Controls.Add(this.rdoEdibles);
            this.flpCategories.Controls.Add(this.rdoNeedles);
            this.flpCategories.Controls.Add(this.rdoDock);
            this.flpCategories.Controls.Add(this.rdoUpkeep);
            this.flpCategories.Controls.Add(this.rdoPeace);
            this.flpCategories.Controls.Add(this.rdoTrivia);
            this.flpCategories.Controls.Add(this.rdoBrainiac);
            this.flpCategories.Controls.Add(this.rdoSeeds);
            this.flpCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCategories.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCategories.Location = new System.Drawing.Point(0, 0);
            this.flpCategories.Name = "flpCategories";
            this.flpCategories.Size = new System.Drawing.Size(141, 301);
            this.flpCategories.TabIndex = 0;
            // 
            // rdoHarvest
            // 
            this.rdoHarvest.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoHarvest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoHarvest.FlatAppearance.BorderSize = 2;
            this.rdoHarvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoHarvest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdoHarvest.Location = new System.Drawing.Point(3, 3);
            this.rdoHarvest.Name = "rdoHarvest";
            this.rdoHarvest.Size = new System.Drawing.Size(128, 44);
            this.rdoHarvest.TabIndex = 4;
            this.rdoHarvest.Tag = "0";
            this.rdoHarvest.Text = "Harvest";
            this.rdoHarvest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoHarvest.UseVisualStyleBackColor = true;
            this.rdoHarvest.CheckedChanged += new System.EventHandler(this.OnCategoryChanged);
            this.rdoHarvest.MouseEnter += new System.EventHandler(this.RatUponCat);
            this.rdoHarvest.MouseLeave += new System.EventHandler(this.RatLeftCat);
            // 
            // rdoEdibles
            // 
            this.rdoEdibles.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoEdibles.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoEdibles.FlatAppearance.BorderSize = 2;
            this.rdoEdibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEdibles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdoEdibles.Location = new System.Drawing.Point(3, 53);
            this.rdoEdibles.Name = "rdoEdibles";
            this.rdoEdibles.Size = new System.Drawing.Size(128, 44);
            this.rdoEdibles.TabIndex = 5;
            this.rdoEdibles.Tag = "1";
            this.rdoEdibles.Text = "Edible";
            this.rdoEdibles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoEdibles.UseVisualStyleBackColor = true;
            this.rdoEdibles.CheckedChanged += new System.EventHandler(this.OnCategoryChanged);
            this.rdoEdibles.MouseEnter += new System.EventHandler(this.RatUponCat);
            this.rdoEdibles.MouseLeave += new System.EventHandler(this.RatLeftCat);
            // 
            // rdoNeedles
            // 
            this.rdoNeedles.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoNeedles.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoNeedles.FlatAppearance.BorderSize = 2;
            this.rdoNeedles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoNeedles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdoNeedles.Location = new System.Drawing.Point(3, 103);
            this.rdoNeedles.Name = "rdoNeedles";
            this.rdoNeedles.Size = new System.Drawing.Size(128, 44);
            this.rdoNeedles.TabIndex = 6;
            this.rdoNeedles.Tag = "2";
            this.rdoNeedles.Text = "Needles";
            this.rdoNeedles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoNeedles.UseVisualStyleBackColor = true;
            this.rdoNeedles.CheckedChanged += new System.EventHandler(this.OnCategoryChanged);
            this.rdoNeedles.MouseEnter += new System.EventHandler(this.RatUponCat);
            this.rdoNeedles.MouseLeave += new System.EventHandler(this.RatLeftCat);
            // 
            // rdoDock
            // 
            this.rdoDock.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoDock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoDock.FlatAppearance.BorderSize = 2;
            this.rdoDock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdoDock.Location = new System.Drawing.Point(3, 153);
            this.rdoDock.Name = "rdoDock";
            this.rdoDock.Size = new System.Drawing.Size(128, 44);
            this.rdoDock.TabIndex = 7;
            this.rdoDock.Tag = "3";
            this.rdoDock.Text = "Dock";
            this.rdoDock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoDock.UseVisualStyleBackColor = true;
            this.rdoDock.CheckedChanged += new System.EventHandler(this.OnCategoryChanged);
            this.rdoDock.MouseEnter += new System.EventHandler(this.RatUponCat);
            this.rdoDock.MouseLeave += new System.EventHandler(this.RatLeftCat);
            // 
            // rdoUpkeep
            // 
            this.rdoUpkeep.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoUpkeep.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoUpkeep.FlatAppearance.BorderSize = 2;
            this.rdoUpkeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoUpkeep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdoUpkeep.Location = new System.Drawing.Point(3, 203);
            this.rdoUpkeep.Name = "rdoUpkeep";
            this.rdoUpkeep.Size = new System.Drawing.Size(128, 44);
            this.rdoUpkeep.TabIndex = 8;
            this.rdoUpkeep.Tag = "4";
            this.rdoUpkeep.Text = "Upkeep";
            this.rdoUpkeep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoUpkeep.UseVisualStyleBackColor = true;
            this.rdoUpkeep.CheckedChanged += new System.EventHandler(this.OnCategoryChanged);
            this.rdoUpkeep.MouseEnter += new System.EventHandler(this.RatUponCat);
            this.rdoUpkeep.MouseLeave += new System.EventHandler(this.RatLeftCat);
            // 
            // rdoPeace
            // 
            this.rdoPeace.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPeace.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoPeace.FlatAppearance.BorderSize = 2;
            this.rdoPeace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPeace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdoPeace.Location = new System.Drawing.Point(3, 253);
            this.rdoPeace.Name = "rdoPeace";
            this.rdoPeace.Size = new System.Drawing.Size(128, 44);
            this.rdoPeace.TabIndex = 9;
            this.rdoPeace.Tag = "5";
            this.rdoPeace.Text = "Peace";
            this.rdoPeace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoPeace.UseVisualStyleBackColor = true;
            this.rdoPeace.CheckedChanged += new System.EventHandler(this.OnCategoryChanged);
            this.rdoPeace.MouseEnter += new System.EventHandler(this.RatUponCat);
            this.rdoPeace.MouseLeave += new System.EventHandler(this.RatLeftCat);
            // 
            // rdoTrivia
            // 
            this.rdoTrivia.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoTrivia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoTrivia.FlatAppearance.BorderSize = 2;
            this.rdoTrivia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoTrivia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdoTrivia.Location = new System.Drawing.Point(137, 3);
            this.rdoTrivia.Name = "rdoTrivia";
            this.rdoTrivia.Size = new System.Drawing.Size(128, 44);
            this.rdoTrivia.TabIndex = 10;
            this.rdoTrivia.Tag = "6";
            this.rdoTrivia.Text = "Trivia";
            this.rdoTrivia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoTrivia.UseVisualStyleBackColor = true;
            this.rdoTrivia.CheckedChanged += new System.EventHandler(this.OnCategoryChanged);
            this.rdoTrivia.MouseEnter += new System.EventHandler(this.RatUponCat);
            this.rdoTrivia.MouseLeave += new System.EventHandler(this.RatLeftCat);
            // 
            // rdoBrainiac
            // 
            this.rdoBrainiac.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoBrainiac.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoBrainiac.FlatAppearance.BorderSize = 2;
            this.rdoBrainiac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoBrainiac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdoBrainiac.Location = new System.Drawing.Point(137, 53);
            this.rdoBrainiac.Name = "rdoBrainiac";
            this.rdoBrainiac.Size = new System.Drawing.Size(128, 44);
            this.rdoBrainiac.TabIndex = 11;
            this.rdoBrainiac.Tag = "7";
            this.rdoBrainiac.Text = "Brainiac";
            this.rdoBrainiac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoBrainiac.UseVisualStyleBackColor = true;
            this.rdoBrainiac.CheckedChanged += new System.EventHandler(this.OnCategoryChanged);
            this.rdoBrainiac.MouseEnter += new System.EventHandler(this.RatUponCat);
            this.rdoBrainiac.MouseLeave += new System.EventHandler(this.RatLeftCat);
            // 
            // rdoSeeds
            // 
            this.rdoSeeds.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoSeeds.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoSeeds.FlatAppearance.BorderSize = 2;
            this.rdoSeeds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoSeeds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdoSeeds.Location = new System.Drawing.Point(137, 103);
            this.rdoSeeds.Name = "rdoSeeds";
            this.rdoSeeds.Size = new System.Drawing.Size(128, 44);
            this.rdoSeeds.TabIndex = 12;
            this.rdoSeeds.Tag = "8";
            this.rdoSeeds.Text = "Seeds";
            this.rdoSeeds.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoSeeds.UseVisualStyleBackColor = true;
            this.rdoSeeds.CheckedChanged += new System.EventHandler(this.OnCategoryChanged);
            this.rdoSeeds.MouseEnter += new System.EventHandler(this.RatUponCat);
            this.rdoSeeds.MouseLeave += new System.EventHandler(this.RatLeftCat);
            // 
            // flpControls
            // 
            this.flpControls.AutoScroll = true;
            this.flpControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpControls.Controls.Add(this.pnlHarvest);
            this.flpControls.Controls.Add(this.pnlEdible);
            this.flpControls.Controls.Add(this.pnlDock);
            this.flpControls.Controls.Add(this.pnlNeedles);
            this.flpControls.Controls.Add(this.pnlUpkeep);
            this.flpControls.Controls.Add(this.pnlPeace);
            this.flpControls.Controls.Add(this.pnlTrivials);
            this.flpControls.Controls.Add(this.pnlBrainiac);
            this.flpControls.Controls.Add(this.pnlSeeds);
            this.flpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpControls.Location = new System.Drawing.Point(0, 0);
            this.flpControls.Name = "flpControls";
            this.flpControls.Size = new System.Drawing.Size(691, 301);
            this.flpControls.TabIndex = 0;
            // 
            // pnlHarvest
            // 
            this.pnlHarvest.AutoScroll = true;
            this.pnlHarvest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHarvest.Controls.Add(this.cbxPayH2O);
            this.pnlHarvest.Controls.Add(this.cbxPayMilk);
            this.pnlHarvest.Controls.Add(this.cbxPayVeggies);
            this.pnlHarvest.Controls.Add(this.cbxPayGrocks);
            this.pnlHarvest.Controls.Add(this.tbxH2OStore);
            this.pnlHarvest.Controls.Add(this.tbxMilkStore);
            this.pnlHarvest.Controls.Add(this.tbxVegStore);
            this.pnlHarvest.Controls.Add(this.tbxGrocStore);
            this.pnlHarvest.Controls.Add(this.label4);
            this.pnlHarvest.Controls.Add(this.spnH2O);
            this.pnlHarvest.Controls.Add(this.lblH2O);
            this.pnlHarvest.Controls.Add(this.label3);
            this.pnlHarvest.Controls.Add(this.spnMilk);
            this.pnlHarvest.Controls.Add(this.lblMilk);
            this.pnlHarvest.Controls.Add(this.label2);
            this.pnlHarvest.Controls.Add(this.spnVeggies);
            this.pnlHarvest.Controls.Add(this.lblVeggies);
            this.pnlHarvest.Controls.Add(this.label1);
            this.pnlHarvest.Controls.Add(this.spnGrocks);
            this.pnlHarvest.Controls.Add(this.lblGrocks);
            this.pnlHarvest.Location = new System.Drawing.Point(3, 3);
            this.pnlHarvest.Name = "pnlHarvest";
            this.pnlHarvest.Size = new System.Drawing.Size(647, 142);
            this.pnlHarvest.TabIndex = 0;
            // 
            // cbxPayH2O
            // 
            this.cbxPayH2O.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayH2O.FormattingEnabled = true;
            this.cbxPayH2O.Location = new System.Drawing.Point(396, 99);
            this.cbxPayH2O.Name = "cbxPayH2O";
            this.cbxPayH2O.Size = new System.Drawing.Size(115, 25);
            this.cbxPayH2O.TabIndex = 11;
            this.cbxPayH2O.Tag = "3";
            this.cbxPayH2O.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayMilk
            // 
            this.cbxPayMilk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayMilk.FormattingEnabled = true;
            this.cbxPayMilk.Location = new System.Drawing.Point(396, 68);
            this.cbxPayMilk.Name = "cbxPayMilk";
            this.cbxPayMilk.Size = new System.Drawing.Size(115, 25);
            this.cbxPayMilk.TabIndex = 8;
            this.cbxPayMilk.Tag = "2";
            this.cbxPayMilk.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayVeggies
            // 
            this.cbxPayVeggies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayVeggies.FormattingEnabled = true;
            this.cbxPayVeggies.Location = new System.Drawing.Point(396, 37);
            this.cbxPayVeggies.Name = "cbxPayVeggies";
            this.cbxPayVeggies.Size = new System.Drawing.Size(115, 25);
            this.cbxPayVeggies.TabIndex = 5;
            this.cbxPayVeggies.Tag = "1";
            this.cbxPayVeggies.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayGrocks
            // 
            this.cbxPayGrocks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayGrocks.FormattingEnabled = true;
            this.cbxPayGrocks.Location = new System.Drawing.Point(396, 7);
            this.cbxPayGrocks.Name = "cbxPayGrocks";
            this.cbxPayGrocks.Size = new System.Drawing.Size(115, 25);
            this.cbxPayGrocks.TabIndex = 2;
            this.cbxPayGrocks.Tag = "0";
            this.cbxPayGrocks.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // tbxH2OStore
            // 
            this.tbxH2OStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxH2OStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxH2OStore.Location = new System.Drawing.Point(257, 99);
            this.tbxH2OStore.Name = "tbxH2OStore";
            this.tbxH2OStore.Size = new System.Drawing.Size(133, 25);
            this.tbxH2OStore.TabIndex = 10;
            this.tbxH2OStore.Tag = "3";
            this.tbxH2OStore.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxMilkStore
            // 
            this.tbxMilkStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxMilkStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxMilkStore.Location = new System.Drawing.Point(257, 68);
            this.tbxMilkStore.Name = "tbxMilkStore";
            this.tbxMilkStore.Size = new System.Drawing.Size(133, 25);
            this.tbxMilkStore.TabIndex = 7;
            this.tbxMilkStore.Tag = "2";
            this.tbxMilkStore.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxVegStore
            // 
            this.tbxVegStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxVegStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxVegStore.Location = new System.Drawing.Point(257, 37);
            this.tbxVegStore.Name = "tbxVegStore";
            this.tbxVegStore.Size = new System.Drawing.Size(133, 25);
            this.tbxVegStore.TabIndex = 4;
            this.tbxVegStore.Tag = "1";
            this.tbxVegStore.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxGrocStore
            // 
            this.tbxGrocStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxGrocStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxGrocStore.Location = new System.Drawing.Point(257, 8);
            this.tbxGrocStore.Name = "tbxGrocStore";
            this.tbxGrocStore.Size = new System.Drawing.Size(133, 25);
            this.tbxGrocStore.TabIndex = 1;
            this.tbxGrocStore.Tag = "0";
            this.tbxGrocStore.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "H2O :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnH2O
            // 
            this.spnH2O.DecimalPlaces = 2;
            this.spnH2O.Location = new System.Drawing.Point(131, 100);
            this.spnH2O.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnH2O.Name = "spnH2O";
            this.spnH2O.Size = new System.Drawing.Size(120, 25);
            this.spnH2O.TabIndex = 9;
            this.spnH2O.Tag = "3";
            this.spnH2O.ThousandsSeparator = true;
            this.spnH2O.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblH2O
            // 
            this.lblH2O.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH2O.Location = new System.Drawing.Point(517, 101);
            this.lblH2O.Name = "lblH2O";
            this.lblH2O.Size = new System.Drawing.Size(99, 23);
            this.lblH2O.TabIndex = 9;
            this.lblH2O.Text = "H2O :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Milk :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnMilk
            // 
            this.spnMilk.DecimalPlaces = 2;
            this.spnMilk.Location = new System.Drawing.Point(131, 69);
            this.spnMilk.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnMilk.Name = "spnMilk";
            this.spnMilk.Size = new System.Drawing.Size(120, 25);
            this.spnMilk.TabIndex = 6;
            this.spnMilk.Tag = "2";
            this.spnMilk.ThousandsSeparator = true;
            this.spnMilk.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblMilk
            // 
            this.lblMilk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMilk.Location = new System.Drawing.Point(517, 70);
            this.lblMilk.Name = "lblMilk";
            this.lblMilk.Size = new System.Drawing.Size(99, 23);
            this.lblMilk.TabIndex = 6;
            this.lblMilk.Text = "Milk :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Veggies :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnVeggies
            // 
            this.spnVeggies.DecimalPlaces = 2;
            this.spnVeggies.Location = new System.Drawing.Point(131, 38);
            this.spnVeggies.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnVeggies.Name = "spnVeggies";
            this.spnVeggies.Size = new System.Drawing.Size(120, 25);
            this.spnVeggies.TabIndex = 3;
            this.spnVeggies.Tag = "1";
            this.spnVeggies.ThousandsSeparator = true;
            this.spnVeggies.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblVeggies
            // 
            this.lblVeggies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVeggies.Location = new System.Drawing.Point(517, 39);
            this.lblVeggies.Name = "lblVeggies";
            this.lblVeggies.Size = new System.Drawing.Size(99, 23);
            this.lblVeggies.TabIndex = 3;
            this.lblVeggies.Text = "Veggies :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Groceries :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnGrocks
            // 
            this.spnGrocks.DecimalPlaces = 2;
            this.spnGrocks.Location = new System.Drawing.Point(131, 8);
            this.spnGrocks.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnGrocks.Name = "spnGrocks";
            this.spnGrocks.Size = new System.Drawing.Size(120, 25);
            this.spnGrocks.TabIndex = 0;
            this.spnGrocks.Tag = "0";
            this.spnGrocks.ThousandsSeparator = true;
            this.spnGrocks.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblGrocks
            // 
            this.lblGrocks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrocks.Location = new System.Drawing.Point(517, 9);
            this.lblGrocks.Name = "lblGrocks";
            this.lblGrocks.Size = new System.Drawing.Size(99, 23);
            this.lblGrocks.TabIndex = 0;
            this.lblGrocks.Text = "Groceries :";
            // 
            // pnlEdible
            // 
            this.pnlEdible.AutoScroll = true;
            this.pnlEdible.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEdible.Controls.Add(this.cbxPaySnacks);
            this.pnlEdible.Controls.Add(this.cbxPayDinner);
            this.pnlEdible.Controls.Add(this.cbxPayLunch);
            this.pnlEdible.Controls.Add(this.cbxPayBreakFast);
            this.pnlEdible.Controls.Add(this.lblBreakFast);
            this.pnlEdible.Controls.Add(this.lblSnacks);
            this.pnlEdible.Controls.Add(this.lblDinner);
            this.pnlEdible.Controls.Add(this.lblLunch);
            this.pnlEdible.Controls.Add(this.cbxSnacks);
            this.pnlEdible.Controls.Add(this.cbxDinner);
            this.pnlEdible.Controls.Add(this.cbxLunch);
            this.pnlEdible.Controls.Add(this.cbxBreakFast);
            this.pnlEdible.Controls.Add(this.label7);
            this.pnlEdible.Controls.Add(this.spnSnacks);
            this.pnlEdible.Controls.Add(this.label5);
            this.pnlEdible.Controls.Add(this.spnDinner);
            this.pnlEdible.Controls.Add(this.label9);
            this.pnlEdible.Controls.Add(this.spnLunch);
            this.pnlEdible.Controls.Add(this.label11);
            this.pnlEdible.Controls.Add(this.spnBreakFast);
            this.pnlEdible.Location = new System.Drawing.Point(3, 151);
            this.pnlEdible.Name = "pnlEdible";
            this.pnlEdible.Size = new System.Drawing.Size(647, 143);
            this.pnlEdible.TabIndex = 12;
            this.pnlEdible.Visible = false;
            // 
            // cbxPaySnacks
            // 
            this.cbxPaySnacks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaySnacks.FormattingEnabled = true;
            this.cbxPaySnacks.Location = new System.Drawing.Point(396, 100);
            this.cbxPaySnacks.Name = "cbxPaySnacks";
            this.cbxPaySnacks.Size = new System.Drawing.Size(115, 25);
            this.cbxPaySnacks.TabIndex = 23;
            this.cbxPaySnacks.Tag = "7";
            this.cbxPaySnacks.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayDinner
            // 
            this.cbxPayDinner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayDinner.FormattingEnabled = true;
            this.cbxPayDinner.Location = new System.Drawing.Point(396, 69);
            this.cbxPayDinner.Name = "cbxPayDinner";
            this.cbxPayDinner.Size = new System.Drawing.Size(115, 25);
            this.cbxPayDinner.TabIndex = 22;
            this.cbxPayDinner.Tag = "6";
            this.cbxPayDinner.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayLunch
            // 
            this.cbxPayLunch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayLunch.FormattingEnabled = true;
            this.cbxPayLunch.Location = new System.Drawing.Point(396, 38);
            this.cbxPayLunch.Name = "cbxPayLunch";
            this.cbxPayLunch.Size = new System.Drawing.Size(115, 25);
            this.cbxPayLunch.TabIndex = 21;
            this.cbxPayLunch.Tag = "5";
            this.cbxPayLunch.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayBreakFast
            // 
            this.cbxPayBreakFast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayBreakFast.FormattingEnabled = true;
            this.cbxPayBreakFast.Location = new System.Drawing.Point(396, 7);
            this.cbxPayBreakFast.Name = "cbxPayBreakFast";
            this.cbxPayBreakFast.Size = new System.Drawing.Size(115, 25);
            this.cbxPayBreakFast.TabIndex = 20;
            this.cbxPayBreakFast.Tag = "4";
            this.cbxPayBreakFast.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // lblBreakFast
            // 
            this.lblBreakFast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBreakFast.Location = new System.Drawing.Point(517, 9);
            this.lblBreakFast.Name = "lblBreakFast";
            this.lblBreakFast.Size = new System.Drawing.Size(99, 23);
            this.lblBreakFast.TabIndex = 19;
            this.lblBreakFast.Text = "Groceries :";
            // 
            // lblSnacks
            // 
            this.lblSnacks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSnacks.Location = new System.Drawing.Point(517, 102);
            this.lblSnacks.Name = "lblSnacks";
            this.lblSnacks.Size = new System.Drawing.Size(99, 23);
            this.lblSnacks.TabIndex = 18;
            this.lblSnacks.Text = "H2O :";
            // 
            // lblDinner
            // 
            this.lblDinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDinner.Location = new System.Drawing.Point(517, 71);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(99, 23);
            this.lblDinner.TabIndex = 17;
            this.lblDinner.Text = "Milk :";
            // 
            // lblLunch
            // 
            this.lblLunch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLunch.Location = new System.Drawing.Point(517, 40);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(99, 23);
            this.lblLunch.TabIndex = 16;
            this.lblLunch.Text = "Veggies :";
            // 
            // cbxSnacks
            // 
            this.cbxSnacks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSnacks.FormattingEnabled = true;
            this.cbxSnacks.Items.AddRange(new object[] {
            "Regular",
            "Outing",
            "Party"});
            this.cbxSnacks.Location = new System.Drawing.Point(257, 100);
            this.cbxSnacks.Name = "cbxSnacks";
            this.cbxSnacks.Size = new System.Drawing.Size(133, 25);
            this.cbxSnacks.TabIndex = 15;
            // 
            // cbxDinner
            // 
            this.cbxDinner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDinner.FormattingEnabled = true;
            this.cbxDinner.Items.AddRange(new object[] {
            "Regular",
            "Outing",
            "Party"});
            this.cbxDinner.Location = new System.Drawing.Point(257, 69);
            this.cbxDinner.Name = "cbxDinner";
            this.cbxDinner.Size = new System.Drawing.Size(133, 25);
            this.cbxDinner.TabIndex = 14;
            // 
            // cbxLunch
            // 
            this.cbxLunch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLunch.FormattingEnabled = true;
            this.cbxLunch.Items.AddRange(new object[] {
            "Regular",
            "Outing",
            "Party"});
            this.cbxLunch.Location = new System.Drawing.Point(257, 38);
            this.cbxLunch.Name = "cbxLunch";
            this.cbxLunch.Size = new System.Drawing.Size(133, 25);
            this.cbxLunch.TabIndex = 13;
            // 
            // cbxBreakFast
            // 
            this.cbxBreakFast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBreakFast.FormattingEnabled = true;
            this.cbxBreakFast.Items.AddRange(new object[] {
            "Regular",
            "Outing",
            "Party"});
            this.cbxBreakFast.Location = new System.Drawing.Point(257, 7);
            this.cbxBreakFast.Name = "cbxBreakFast";
            this.cbxBreakFast.Size = new System.Drawing.Size(133, 25);
            this.cbxBreakFast.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Snacks :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnSnacks
            // 
            this.spnSnacks.DecimalPlaces = 2;
            this.spnSnacks.Location = new System.Drawing.Point(131, 101);
            this.spnSnacks.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnSnacks.Name = "spnSnacks";
            this.spnSnacks.Size = new System.Drawing.Size(120, 25);
            this.spnSnacks.TabIndex = 10;
            this.spnSnacks.Tag = "7";
            this.spnSnacks.ThousandsSeparator = true;
            this.spnSnacks.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dinner :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnDinner
            // 
            this.spnDinner.DecimalPlaces = 2;
            this.spnDinner.Location = new System.Drawing.Point(131, 70);
            this.spnDinner.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnDinner.Name = "spnDinner";
            this.spnDinner.Size = new System.Drawing.Size(120, 25);
            this.spnDinner.TabIndex = 7;
            this.spnDinner.Tag = "6";
            this.spnDinner.ThousandsSeparator = true;
            this.spnDinner.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Lunch :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnLunch
            // 
            this.spnLunch.DecimalPlaces = 2;
            this.spnLunch.Location = new System.Drawing.Point(131, 39);
            this.spnLunch.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnLunch.Name = "spnLunch";
            this.spnLunch.Size = new System.Drawing.Size(120, 25);
            this.spnLunch.TabIndex = 4;
            this.spnLunch.Tag = "5";
            this.spnLunch.ThousandsSeparator = true;
            this.spnLunch.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Breakfast :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnBreakFast
            // 
            this.spnBreakFast.DecimalPlaces = 2;
            this.spnBreakFast.Location = new System.Drawing.Point(131, 8);
            this.spnBreakFast.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnBreakFast.Name = "spnBreakFast";
            this.spnBreakFast.Size = new System.Drawing.Size(120, 25);
            this.spnBreakFast.TabIndex = 1;
            this.spnBreakFast.Tag = "4";
            this.spnBreakFast.ThousandsSeparator = true;
            this.spnBreakFast.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // pnlDock
            // 
            this.pnlDock.AutoScroll = true;
            this.pnlDock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDock.Controls.Add(this.cbxPayFuel);
            this.pnlDock.Controls.Add(this.cbxPayCabs);
            this.pnlDock.Controls.Add(this.cbxPayJourney);
            this.pnlDock.Controls.Add(this.cbxPayCommute);
            this.pnlDock.Controls.Add(this.tbxCabs);
            this.pnlDock.Controls.Add(this.tbxJourney);
            this.pnlDock.Controls.Add(this.label6);
            this.pnlDock.Controls.Add(this.spnFuel);
            this.pnlDock.Controls.Add(this.lblFuel);
            this.pnlDock.Controls.Add(this.label10);
            this.pnlDock.Controls.Add(this.spnCabs);
            this.pnlDock.Controls.Add(this.lblCabs);
            this.pnlDock.Controls.Add(this.label13);
            this.pnlDock.Controls.Add(this.spnJourney);
            this.pnlDock.Controls.Add(this.lblJourney);
            this.pnlDock.Controls.Add(this.label15);
            this.pnlDock.Controls.Add(this.spnCommute);
            this.pnlDock.Controls.Add(this.lblCommute);
            this.pnlDock.Location = new System.Drawing.Point(3, 300);
            this.pnlDock.Name = "pnlDock";
            this.pnlDock.Size = new System.Drawing.Size(647, 144);
            this.pnlDock.TabIndex = 16;
            // 
            // cbxPayFuel
            // 
            this.cbxPayFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayFuel.FormattingEnabled = true;
            this.cbxPayFuel.Location = new System.Drawing.Point(396, 99);
            this.cbxPayFuel.Name = "cbxPayFuel";
            this.cbxPayFuel.Size = new System.Drawing.Size(115, 25);
            this.cbxPayFuel.TabIndex = 23;
            this.cbxPayFuel.Tag = "11";
            this.cbxPayFuel.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayCabs
            // 
            this.cbxPayCabs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayCabs.FormattingEnabled = true;
            this.cbxPayCabs.Location = new System.Drawing.Point(396, 68);
            this.cbxPayCabs.Name = "cbxPayCabs";
            this.cbxPayCabs.Size = new System.Drawing.Size(115, 25);
            this.cbxPayCabs.TabIndex = 22;
            this.cbxPayCabs.Tag = "10";
            this.cbxPayCabs.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayJourney
            // 
            this.cbxPayJourney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayJourney.FormattingEnabled = true;
            this.cbxPayJourney.Location = new System.Drawing.Point(396, 37);
            this.cbxPayJourney.Name = "cbxPayJourney";
            this.cbxPayJourney.Size = new System.Drawing.Size(115, 25);
            this.cbxPayJourney.TabIndex = 21;
            this.cbxPayJourney.Tag = "9";
            this.cbxPayJourney.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayCommute
            // 
            this.cbxPayCommute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayCommute.FormattingEnabled = true;
            this.cbxPayCommute.Location = new System.Drawing.Point(396, 7);
            this.cbxPayCommute.Name = "cbxPayCommute";
            this.cbxPayCommute.Size = new System.Drawing.Size(115, 25);
            this.cbxPayCommute.TabIndex = 20;
            this.cbxPayCommute.Tag = "8";
            this.cbxPayCommute.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // tbxCabs
            // 
            this.tbxCabs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxCabs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxCabs.Location = new System.Drawing.Point(257, 68);
            this.tbxCabs.Name = "tbxCabs";
            this.tbxCabs.Size = new System.Drawing.Size(133, 25);
            this.tbxCabs.TabIndex = 14;
            this.tbxCabs.Tag = "10";
            this.tbxCabs.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxJourney
            // 
            this.tbxJourney.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxJourney.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxJourney.Location = new System.Drawing.Point(257, 37);
            this.tbxJourney.Name = "tbxJourney";
            this.tbxJourney.Size = new System.Drawing.Size(133, 25);
            this.tbxJourney.TabIndex = 13;
            this.tbxJourney.Tag = "9";
            this.tbxJourney.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fuel :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnFuel
            // 
            this.spnFuel.DecimalPlaces = 2;
            this.spnFuel.Location = new System.Drawing.Point(131, 100);
            this.spnFuel.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnFuel.Name = "spnFuel";
            this.spnFuel.Size = new System.Drawing.Size(120, 25);
            this.spnFuel.TabIndex = 10;
            this.spnFuel.Tag = "11";
            this.spnFuel.ThousandsSeparator = true;
            this.spnFuel.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblFuel
            // 
            this.lblFuel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuel.Location = new System.Drawing.Point(517, 98);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(99, 23);
            this.lblFuel.TabIndex = 9;
            this.lblFuel.Text = "H2O :";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(16, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cabs :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnCabs
            // 
            this.spnCabs.DecimalPlaces = 2;
            this.spnCabs.Location = new System.Drawing.Point(131, 69);
            this.spnCabs.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnCabs.Name = "spnCabs";
            this.spnCabs.Size = new System.Drawing.Size(120, 25);
            this.spnCabs.TabIndex = 7;
            this.spnCabs.Tag = "10";
            this.spnCabs.ThousandsSeparator = true;
            this.spnCabs.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblCabs
            // 
            this.lblCabs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCabs.Location = new System.Drawing.Point(517, 70);
            this.lblCabs.Name = "lblCabs";
            this.lblCabs.Size = new System.Drawing.Size(99, 23);
            this.lblCabs.TabIndex = 6;
            this.lblCabs.Text = "Milk :";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(16, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Journey :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnJourney
            // 
            this.spnJourney.DecimalPlaces = 2;
            this.spnJourney.Location = new System.Drawing.Point(131, 38);
            this.spnJourney.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnJourney.Name = "spnJourney";
            this.spnJourney.Size = new System.Drawing.Size(120, 25);
            this.spnJourney.TabIndex = 4;
            this.spnJourney.Tag = "9";
            this.spnJourney.ThousandsSeparator = true;
            this.spnJourney.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblJourney
            // 
            this.lblJourney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJourney.Location = new System.Drawing.Point(517, 39);
            this.lblJourney.Name = "lblJourney";
            this.lblJourney.Size = new System.Drawing.Size(99, 23);
            this.lblJourney.TabIndex = 3;
            this.lblJourney.Text = "Veggies :";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(16, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "Commute :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnCommute
            // 
            this.spnCommute.DecimalPlaces = 2;
            this.spnCommute.Location = new System.Drawing.Point(131, 8);
            this.spnCommute.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnCommute.Name = "spnCommute";
            this.spnCommute.Size = new System.Drawing.Size(120, 25);
            this.spnCommute.TabIndex = 1;
            this.spnCommute.Tag = "8";
            this.spnCommute.ThousandsSeparator = true;
            this.spnCommute.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblCommute
            // 
            this.lblCommute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCommute.Location = new System.Drawing.Point(517, 9);
            this.lblCommute.Name = "lblCommute";
            this.lblCommute.Size = new System.Drawing.Size(99, 23);
            this.lblCommute.TabIndex = 0;
            this.lblCommute.Text = "Groceries :";
            // 
            // pnlNeedles
            // 
            this.pnlNeedles.AutoScroll = true;
            this.pnlNeedles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNeedles.Controls.Add(this.cbxPayHospital);
            this.pnlNeedles.Controls.Add(this.cbxPayMedicine);
            this.pnlNeedles.Controls.Add(this.tbxHospital);
            this.pnlNeedles.Controls.Add(this.tbxMedicine);
            this.pnlNeedles.Controls.Add(this.label17);
            this.pnlNeedles.Controls.Add(this.spnHospital);
            this.pnlNeedles.Controls.Add(this.lblHospital);
            this.pnlNeedles.Controls.Add(this.label19);
            this.pnlNeedles.Controls.Add(this.spnMedicine);
            this.pnlNeedles.Controls.Add(this.lblMedicine);
            this.pnlNeedles.Location = new System.Drawing.Point(3, 450);
            this.pnlNeedles.Name = "pnlNeedles";
            this.pnlNeedles.Size = new System.Drawing.Size(647, 76);
            this.pnlNeedles.TabIndex = 17;
            // 
            // cbxPayHospital
            // 
            this.cbxPayHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayHospital.FormattingEnabled = true;
            this.cbxPayHospital.Location = new System.Drawing.Point(396, 37);
            this.cbxPayHospital.Name = "cbxPayHospital";
            this.cbxPayHospital.Size = new System.Drawing.Size(115, 25);
            this.cbxPayHospital.TabIndex = 25;
            this.cbxPayHospital.Tag = "13";
            this.cbxPayHospital.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayMedicine
            // 
            this.cbxPayMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayMedicine.FormattingEnabled = true;
            this.cbxPayMedicine.Location = new System.Drawing.Point(396, 8);
            this.cbxPayMedicine.Name = "cbxPayMedicine";
            this.cbxPayMedicine.Size = new System.Drawing.Size(115, 25);
            this.cbxPayMedicine.TabIndex = 24;
            this.cbxPayMedicine.Tag = "12";
            this.cbxPayMedicine.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // tbxHospital
            // 
            this.tbxHospital.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxHospital.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxHospital.Location = new System.Drawing.Point(257, 37);
            this.tbxHospital.Name = "tbxHospital";
            this.tbxHospital.Size = new System.Drawing.Size(133, 25);
            this.tbxHospital.TabIndex = 13;
            this.tbxHospital.Tag = "13";
            this.tbxHospital.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxMedicine
            // 
            this.tbxMedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxMedicine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxMedicine.Location = new System.Drawing.Point(257, 7);
            this.tbxMedicine.Name = "tbxMedicine";
            this.tbxMedicine.Size = new System.Drawing.Size(133, 25);
            this.tbxMedicine.TabIndex = 12;
            this.tbxMedicine.Tag = "12";
            this.tbxMedicine.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(16, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "Hospital :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnHospital
            // 
            this.spnHospital.DecimalPlaces = 2;
            this.spnHospital.Location = new System.Drawing.Point(131, 38);
            this.spnHospital.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnHospital.Name = "spnHospital";
            this.spnHospital.Size = new System.Drawing.Size(120, 25);
            this.spnHospital.TabIndex = 4;
            this.spnHospital.Tag = "13";
            this.spnHospital.ThousandsSeparator = true;
            this.spnHospital.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblHospital
            // 
            this.lblHospital.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHospital.Location = new System.Drawing.Point(517, 39);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(99, 23);
            this.lblHospital.TabIndex = 3;
            this.lblHospital.Text = "Veggies :";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(16, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 17);
            this.label19.TabIndex = 2;
            this.label19.Text = "Medicine :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnMedicine
            // 
            this.spnMedicine.DecimalPlaces = 2;
            this.spnMedicine.Location = new System.Drawing.Point(131, 8);
            this.spnMedicine.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnMedicine.Name = "spnMedicine";
            this.spnMedicine.Size = new System.Drawing.Size(120, 25);
            this.spnMedicine.TabIndex = 1;
            this.spnMedicine.Tag = "12";
            this.spnMedicine.ThousandsSeparator = true;
            this.spnMedicine.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblMedicine
            // 
            this.lblMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMedicine.Location = new System.Drawing.Point(517, 10);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(99, 23);
            this.lblMedicine.TabIndex = 0;
            this.lblMedicine.Text = "Groceries :";
            // 
            // pnlUpkeep
            // 
            this.pnlUpkeep.AutoScroll = true;
            this.pnlUpkeep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpkeep.Controls.Add(this.cbxPayPhone);
            this.pnlUpkeep.Controls.Add(this.lxtPhone);
            this.pnlUpkeep.Controls.Add(this.spnTelephony);
            this.pnlUpkeep.Controls.Add(this.lblPhone);
            this.pnlUpkeep.Controls.Add(this.cbxPayLoan);
            this.pnlUpkeep.Controls.Add(this.cbxPayStrata);
            this.pnlUpkeep.Controls.Add(this.cbxPayEB);
            this.pnlUpkeep.Controls.Add(this.cbxDomH2O);
            this.pnlUpkeep.Controls.Add(this.cbxPayRent);
            this.pnlUpkeep.Controls.Add(this.label23);
            this.pnlUpkeep.Controls.Add(this.spnLoan);
            this.pnlUpkeep.Controls.Add(this.lblLoan);
            this.pnlUpkeep.Controls.Add(this.label8);
            this.pnlUpkeep.Controls.Add(this.spnStrata);
            this.pnlUpkeep.Controls.Add(this.lblStrata);
            this.pnlUpkeep.Controls.Add(this.label14);
            this.pnlUpkeep.Controls.Add(this.spnEB);
            this.pnlUpkeep.Controls.Add(this.lblEB);
            this.pnlUpkeep.Controls.Add(this.label18);
            this.pnlUpkeep.Controls.Add(this.spnDomH2O);
            this.pnlUpkeep.Controls.Add(this.lblDomH2O);
            this.pnlUpkeep.Controls.Add(this.label21);
            this.pnlUpkeep.Controls.Add(this.spnRent);
            this.pnlUpkeep.Controls.Add(this.lblRent);
            this.pnlUpkeep.Location = new System.Drawing.Point(3, 532);
            this.pnlUpkeep.Name = "pnlUpkeep";
            this.pnlUpkeep.Size = new System.Drawing.Size(498, 209);
            this.pnlUpkeep.TabIndex = 17;
            // 
            // cbxPayPhone
            // 
            this.cbxPayPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayPhone.FormattingEnabled = true;
            this.cbxPayPhone.Location = new System.Drawing.Point(257, 162);
            this.cbxPayPhone.Name = "cbxPayPhone";
            this.cbxPayPhone.Size = new System.Drawing.Size(115, 25);
            this.cbxPayPhone.TabIndex = 32;
            this.cbxPayPhone.Tag = "19";
            this.cbxPayPhone.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // lxtPhone
            // 
            this.lxtPhone.Location = new System.Drawing.Point(14, 165);
            this.lxtPhone.Name = "lxtPhone";
            this.lxtPhone.Size = new System.Drawing.Size(100, 17);
            this.lxtPhone.TabIndex = 31;
            this.lxtPhone.Text = "Phone :";
            this.lxtPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnTelephony
            // 
            this.spnTelephony.DecimalPlaces = 2;
            this.spnTelephony.Location = new System.Drawing.Point(131, 163);
            this.spnTelephony.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnTelephony.Name = "spnTelephony";
            this.spnTelephony.Size = new System.Drawing.Size(120, 25);
            this.spnTelephony.TabIndex = 30;
            this.spnTelephony.Tag = "19";
            this.spnTelephony.ThousandsSeparator = true;
            this.spnTelephony.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhone.Location = new System.Drawing.Point(378, 164);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(99, 23);
            this.lblPhone.TabIndex = 29;
            this.lblPhone.Text = "H2O :";
            // 
            // cbxPayLoan
            // 
            this.cbxPayLoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayLoan.FormattingEnabled = true;
            this.cbxPayLoan.Location = new System.Drawing.Point(257, 131);
            this.cbxPayLoan.Name = "cbxPayLoan";
            this.cbxPayLoan.Size = new System.Drawing.Size(115, 25);
            this.cbxPayLoan.TabIndex = 28;
            this.cbxPayLoan.Tag = "18";
            this.cbxPayLoan.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayStrata
            // 
            this.cbxPayStrata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayStrata.FormattingEnabled = true;
            this.cbxPayStrata.Location = new System.Drawing.Point(257, 100);
            this.cbxPayStrata.Name = "cbxPayStrata";
            this.cbxPayStrata.Size = new System.Drawing.Size(115, 25);
            this.cbxPayStrata.TabIndex = 27;
            this.cbxPayStrata.Tag = "17";
            this.cbxPayStrata.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayEB
            // 
            this.cbxPayEB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayEB.FormattingEnabled = true;
            this.cbxPayEB.Location = new System.Drawing.Point(257, 68);
            this.cbxPayEB.Name = "cbxPayEB";
            this.cbxPayEB.Size = new System.Drawing.Size(115, 25);
            this.cbxPayEB.TabIndex = 26;
            this.cbxPayEB.Tag = "16";
            this.cbxPayEB.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxDomH2O
            // 
            this.cbxDomH2O.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDomH2O.FormattingEnabled = true;
            this.cbxDomH2O.Location = new System.Drawing.Point(257, 37);
            this.cbxDomH2O.Name = "cbxDomH2O";
            this.cbxDomH2O.Size = new System.Drawing.Size(115, 25);
            this.cbxDomH2O.TabIndex = 25;
            this.cbxDomH2O.Tag = "15";
            this.cbxDomH2O.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayRent
            // 
            this.cbxPayRent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayRent.FormattingEnabled = true;
            this.cbxPayRent.Location = new System.Drawing.Point(257, 8);
            this.cbxPayRent.Name = "cbxPayRent";
            this.cbxPayRent.Size = new System.Drawing.Size(115, 25);
            this.cbxPayRent.TabIndex = 24;
            this.cbxPayRent.Tag = "14";
            this.cbxPayRent.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(16, 134);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 17);
            this.label23.TabIndex = 18;
            this.label23.Text = "Loan :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnLoan
            // 
            this.spnLoan.DecimalPlaces = 2;
            this.spnLoan.Location = new System.Drawing.Point(131, 132);
            this.spnLoan.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnLoan.Name = "spnLoan";
            this.spnLoan.Size = new System.Drawing.Size(120, 25);
            this.spnLoan.TabIndex = 17;
            this.spnLoan.Tag = "18";
            this.spnLoan.ThousandsSeparator = true;
            this.spnLoan.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblLoan
            // 
            this.lblLoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoan.Location = new System.Drawing.Point(378, 133);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(99, 23);
            this.lblLoan.TabIndex = 16;
            this.lblLoan.Text = "H2O :";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Strata :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnStrata
            // 
            this.spnStrata.DecimalPlaces = 2;
            this.spnStrata.Location = new System.Drawing.Point(131, 101);
            this.spnStrata.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnStrata.Name = "spnStrata";
            this.spnStrata.Size = new System.Drawing.Size(120, 25);
            this.spnStrata.TabIndex = 10;
            this.spnStrata.Tag = "17";
            this.spnStrata.ThousandsSeparator = true;
            this.spnStrata.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblStrata
            // 
            this.lblStrata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStrata.Location = new System.Drawing.Point(378, 102);
            this.lblStrata.Name = "lblStrata";
            this.lblStrata.Size = new System.Drawing.Size(99, 23);
            this.lblStrata.TabIndex = 9;
            this.lblStrata.Text = "H2O :";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(16, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Electricity Bill :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnEB
            // 
            this.spnEB.DecimalPlaces = 2;
            this.spnEB.Location = new System.Drawing.Point(131, 69);
            this.spnEB.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnEB.Name = "spnEB";
            this.spnEB.Size = new System.Drawing.Size(120, 25);
            this.spnEB.TabIndex = 7;
            this.spnEB.Tag = "16";
            this.spnEB.ThousandsSeparator = true;
            this.spnEB.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblEB
            // 
            this.lblEB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEB.Location = new System.Drawing.Point(378, 70);
            this.lblEB.Name = "lblEB";
            this.lblEB.Size = new System.Drawing.Size(99, 23);
            this.lblEB.TabIndex = 6;
            this.lblEB.Text = "Milk :";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(16, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 17);
            this.label18.TabIndex = 5;
            this.label18.Text = "Domestic H2O :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnDomH2O
            // 
            this.spnDomH2O.DecimalPlaces = 2;
            this.spnDomH2O.Location = new System.Drawing.Point(131, 38);
            this.spnDomH2O.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnDomH2O.Name = "spnDomH2O";
            this.spnDomH2O.Size = new System.Drawing.Size(120, 25);
            this.spnDomH2O.TabIndex = 4;
            this.spnDomH2O.Tag = "15";
            this.spnDomH2O.ThousandsSeparator = true;
            this.spnDomH2O.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblDomH2O
            // 
            this.lblDomH2O.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDomH2O.Location = new System.Drawing.Point(378, 39);
            this.lblDomH2O.Name = "lblDomH2O";
            this.lblDomH2O.Size = new System.Drawing.Size(99, 23);
            this.lblDomH2O.TabIndex = 3;
            this.lblDomH2O.Text = "Veggies :";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(16, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 17);
            this.label21.TabIndex = 2;
            this.label21.Text = "House Rent :";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnRent
            // 
            this.spnRent.DecimalPlaces = 2;
            this.spnRent.Location = new System.Drawing.Point(131, 8);
            this.spnRent.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnRent.Name = "spnRent";
            this.spnRent.Size = new System.Drawing.Size(120, 25);
            this.spnRent.TabIndex = 1;
            this.spnRent.Tag = "14";
            this.spnRent.ThousandsSeparator = true;
            this.spnRent.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblRent
            // 
            this.lblRent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRent.Location = new System.Drawing.Point(378, 9);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(99, 23);
            this.lblRent.TabIndex = 0;
            this.lblRent.Text = "Groceries :";
            // 
            // pnlPeace
            // 
            this.pnlPeace.AutoScroll = true;
            this.pnlPeace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPeace.Controls.Add(this.cbxPayTour);
            this.pnlPeace.Controls.Add(this.cbxPayCinemas);
            this.pnlPeace.Controls.Add(this.cbxPayMagazine);
            this.pnlPeace.Controls.Add(this.cbxPayNewsPaper);
            this.pnlPeace.Controls.Add(this.cbxPayInternet);
            this.pnlPeace.Controls.Add(this.cbxPayDTH);
            this.pnlPeace.Controls.Add(this.tbxTour);
            this.pnlPeace.Controls.Add(this.label35);
            this.pnlPeace.Controls.Add(this.spnTour);
            this.pnlPeace.Controls.Add(this.lblTour);
            this.pnlPeace.Controls.Add(this.tbxCinemas);
            this.pnlPeace.Controls.Add(this.label25);
            this.pnlPeace.Controls.Add(this.spnCinemas);
            this.pnlPeace.Controls.Add(this.lblCinemas);
            this.pnlPeace.Controls.Add(this.label27);
            this.pnlPeace.Controls.Add(this.spnMagazine);
            this.pnlPeace.Controls.Add(this.lblMagazine);
            this.pnlPeace.Controls.Add(this.label29);
            this.pnlPeace.Controls.Add(this.spnNewsPaper);
            this.pnlPeace.Controls.Add(this.lblNewspaper);
            this.pnlPeace.Controls.Add(this.label31);
            this.pnlPeace.Controls.Add(this.spnInternet);
            this.pnlPeace.Controls.Add(this.lblInternet);
            this.pnlPeace.Controls.Add(this.label33);
            this.pnlPeace.Controls.Add(this.spnDTH);
            this.pnlPeace.Controls.Add(this.lblDTH);
            this.pnlPeace.Location = new System.Drawing.Point(3, 747);
            this.pnlPeace.Name = "pnlPeace";
            this.pnlPeace.Size = new System.Drawing.Size(647, 206);
            this.pnlPeace.TabIndex = 20;
            // 
            // cbxPayTour
            // 
            this.cbxPayTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayTour.FormattingEnabled = true;
            this.cbxPayTour.Location = new System.Drawing.Point(396, 162);
            this.cbxPayTour.Name = "cbxPayTour";
            this.cbxPayTour.Size = new System.Drawing.Size(115, 25);
            this.cbxPayTour.TabIndex = 29;
            this.cbxPayTour.Tag = "25";
            this.cbxPayTour.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayCinemas
            // 
            this.cbxPayCinemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayCinemas.FormattingEnabled = true;
            this.cbxPayCinemas.Location = new System.Drawing.Point(396, 131);
            this.cbxPayCinemas.Name = "cbxPayCinemas";
            this.cbxPayCinemas.Size = new System.Drawing.Size(115, 25);
            this.cbxPayCinemas.TabIndex = 28;
            this.cbxPayCinemas.Tag = "24";
            this.cbxPayCinemas.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayMagazine
            // 
            this.cbxPayMagazine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayMagazine.FormattingEnabled = true;
            this.cbxPayMagazine.Location = new System.Drawing.Point(396, 100);
            this.cbxPayMagazine.Name = "cbxPayMagazine";
            this.cbxPayMagazine.Size = new System.Drawing.Size(115, 25);
            this.cbxPayMagazine.TabIndex = 27;
            this.cbxPayMagazine.Tag = "23";
            this.cbxPayMagazine.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayNewsPaper
            // 
            this.cbxPayNewsPaper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayNewsPaper.FormattingEnabled = true;
            this.cbxPayNewsPaper.Location = new System.Drawing.Point(396, 69);
            this.cbxPayNewsPaper.Name = "cbxPayNewsPaper";
            this.cbxPayNewsPaper.Size = new System.Drawing.Size(115, 25);
            this.cbxPayNewsPaper.TabIndex = 26;
            this.cbxPayNewsPaper.Tag = "22";
            this.cbxPayNewsPaper.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayInternet
            // 
            this.cbxPayInternet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayInternet.FormattingEnabled = true;
            this.cbxPayInternet.Location = new System.Drawing.Point(396, 38);
            this.cbxPayInternet.Name = "cbxPayInternet";
            this.cbxPayInternet.Size = new System.Drawing.Size(115, 25);
            this.cbxPayInternet.TabIndex = 25;
            this.cbxPayInternet.Tag = "21";
            this.cbxPayInternet.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayDTH
            // 
            this.cbxPayDTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayDTH.FormattingEnabled = true;
            this.cbxPayDTH.Location = new System.Drawing.Point(396, 7);
            this.cbxPayDTH.Name = "cbxPayDTH";
            this.cbxPayDTH.Size = new System.Drawing.Size(115, 25);
            this.cbxPayDTH.TabIndex = 24;
            this.cbxPayDTH.Tag = "20";
            this.cbxPayDTH.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // tbxTour
            // 
            this.tbxTour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxTour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxTour.Location = new System.Drawing.Point(257, 162);
            this.tbxTour.Name = "tbxTour";
            this.tbxTour.Size = new System.Drawing.Size(133, 25);
            this.tbxTour.TabIndex = 23;
            this.tbxTour.Tag = "25";
            this.tbxTour.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(12, 165);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(100, 17);
            this.label35.TabIndex = 22;
            this.label35.Text = "Tour :";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnTour
            // 
            this.spnTour.DecimalPlaces = 2;
            this.spnTour.Location = new System.Drawing.Point(131, 163);
            this.spnTour.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnTour.Name = "spnTour";
            this.spnTour.Size = new System.Drawing.Size(120, 25);
            this.spnTour.TabIndex = 21;
            this.spnTour.Tag = "25";
            this.spnTour.ThousandsSeparator = true;
            this.spnTour.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblTour
            // 
            this.lblTour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTour.Location = new System.Drawing.Point(517, 164);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(99, 23);
            this.lblTour.TabIndex = 20;
            this.lblTour.Text = "H2O :";
            // 
            // tbxCinemas
            // 
            this.tbxCinemas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxCinemas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxCinemas.Location = new System.Drawing.Point(257, 131);
            this.tbxCinemas.Name = "tbxCinemas";
            this.tbxCinemas.Size = new System.Drawing.Size(133, 25);
            this.tbxCinemas.TabIndex = 19;
            this.tbxCinemas.Tag = "24";
            this.tbxCinemas.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(16, 134);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 17);
            this.label25.TabIndex = 18;
            this.label25.Text = "Cinemas :";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnCinemas
            // 
            this.spnCinemas.DecimalPlaces = 2;
            this.spnCinemas.Location = new System.Drawing.Point(131, 132);
            this.spnCinemas.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnCinemas.Name = "spnCinemas";
            this.spnCinemas.Size = new System.Drawing.Size(120, 25);
            this.spnCinemas.TabIndex = 17;
            this.spnCinemas.Tag = "24";
            this.spnCinemas.ThousandsSeparator = true;
            this.spnCinemas.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblCinemas
            // 
            this.lblCinemas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCinemas.Location = new System.Drawing.Point(517, 133);
            this.lblCinemas.Name = "lblCinemas";
            this.lblCinemas.Size = new System.Drawing.Size(99, 23);
            this.lblCinemas.TabIndex = 16;
            this.lblCinemas.Text = "H2O :";
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(16, 103);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 17);
            this.label27.TabIndex = 11;
            this.label27.Text = "Magazine :";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnMagazine
            // 
            this.spnMagazine.DecimalPlaces = 2;
            this.spnMagazine.Location = new System.Drawing.Point(131, 101);
            this.spnMagazine.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnMagazine.Name = "spnMagazine";
            this.spnMagazine.Size = new System.Drawing.Size(120, 25);
            this.spnMagazine.TabIndex = 10;
            this.spnMagazine.Tag = "23";
            this.spnMagazine.ThousandsSeparator = true;
            this.spnMagazine.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblMagazine
            // 
            this.lblMagazine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMagazine.Location = new System.Drawing.Point(517, 102);
            this.lblMagazine.Name = "lblMagazine";
            this.lblMagazine.Size = new System.Drawing.Size(99, 23);
            this.lblMagazine.TabIndex = 9;
            this.lblMagazine.Text = "H2O :";
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(16, 72);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 17);
            this.label29.TabIndex = 8;
            this.label29.Text = "NewsPaper :";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnNewsPaper
            // 
            this.spnNewsPaper.DecimalPlaces = 2;
            this.spnNewsPaper.Location = new System.Drawing.Point(131, 70);
            this.spnNewsPaper.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnNewsPaper.Name = "spnNewsPaper";
            this.spnNewsPaper.Size = new System.Drawing.Size(120, 25);
            this.spnNewsPaper.TabIndex = 7;
            this.spnNewsPaper.Tag = "22";
            this.spnNewsPaper.ThousandsSeparator = true;
            this.spnNewsPaper.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblNewspaper
            // 
            this.lblNewspaper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNewspaper.Location = new System.Drawing.Point(517, 73);
            this.lblNewspaper.Name = "lblNewspaper";
            this.lblNewspaper.Size = new System.Drawing.Size(99, 23);
            this.lblNewspaper.TabIndex = 6;
            this.lblNewspaper.Text = "Milk :";
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(16, 41);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 17);
            this.label31.TabIndex = 5;
            this.label31.Text = "Internet :";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnInternet
            // 
            this.spnInternet.DecimalPlaces = 2;
            this.spnInternet.Location = new System.Drawing.Point(131, 39);
            this.spnInternet.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnInternet.Name = "spnInternet";
            this.spnInternet.Size = new System.Drawing.Size(120, 25);
            this.spnInternet.TabIndex = 4;
            this.spnInternet.Tag = "21";
            this.spnInternet.ThousandsSeparator = true;
            this.spnInternet.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblInternet
            // 
            this.lblInternet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInternet.Location = new System.Drawing.Point(517, 40);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(99, 23);
            this.lblInternet.TabIndex = 3;
            this.lblInternet.Text = "Veggies :";
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(16, 11);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(100, 17);
            this.label33.TabIndex = 2;
            this.label33.Text = "DTH :";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnDTH
            // 
            this.spnDTH.DecimalPlaces = 2;
            this.spnDTH.Location = new System.Drawing.Point(131, 8);
            this.spnDTH.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnDTH.Name = "spnDTH";
            this.spnDTH.Size = new System.Drawing.Size(120, 25);
            this.spnDTH.TabIndex = 1;
            this.spnDTH.Tag = "20";
            this.spnDTH.ThousandsSeparator = true;
            this.spnDTH.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblDTH
            // 
            this.lblDTH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDTH.Location = new System.Drawing.Point(517, 9);
            this.lblDTH.Name = "lblDTH";
            this.lblDTH.Size = new System.Drawing.Size(99, 23);
            this.lblDTH.TabIndex = 0;
            this.lblDTH.Text = "Groceries :";
            // 
            // pnlTrivials
            // 
            this.pnlTrivials.AutoScroll = true;
            this.pnlTrivials.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTrivials.Controls.Add(this.cbxPayFootWear);
            this.pnlTrivials.Controls.Add(this.cbxPayFurniture);
            this.pnlTrivials.Controls.Add(this.cbxPayUtensils);
            this.pnlTrivials.Controls.Add(this.cbxPayApparels);
            this.pnlTrivials.Controls.Add(this.cbxPayDress);
            this.pnlTrivials.Controls.Add(this.cbxPayElectronics);
            this.pnlTrivials.Controls.Add(this.cbxPayElectricals);
            this.pnlTrivials.Controls.Add(this.tbxFootwear);
            this.pnlTrivials.Controls.Add(this.label49);
            this.pnlTrivials.Controls.Add(this.spnFootwear);
            this.pnlTrivials.Controls.Add(this.lblFootwear);
            this.pnlTrivials.Controls.Add(this.tbxFurniture);
            this.pnlTrivials.Controls.Add(this.label37);
            this.pnlTrivials.Controls.Add(this.spnFurniture);
            this.pnlTrivials.Controls.Add(this.lblFurniture);
            this.pnlTrivials.Controls.Add(this.tbxUtensils);
            this.pnlTrivials.Controls.Add(this.label39);
            this.pnlTrivials.Controls.Add(this.spnUtensils);
            this.pnlTrivials.Controls.Add(this.lblUtensils);
            this.pnlTrivials.Controls.Add(this.tbxApparels);
            this.pnlTrivials.Controls.Add(this.tbxDress);
            this.pnlTrivials.Controls.Add(this.tbxElectronics);
            this.pnlTrivials.Controls.Add(this.tbxElectricals);
            this.pnlTrivials.Controls.Add(this.label41);
            this.pnlTrivials.Controls.Add(this.spnApparels);
            this.pnlTrivials.Controls.Add(this.lblApparels);
            this.pnlTrivials.Controls.Add(this.label43);
            this.pnlTrivials.Controls.Add(this.spnDress);
            this.pnlTrivials.Controls.Add(this.lblDress);
            this.pnlTrivials.Controls.Add(this.label45);
            this.pnlTrivials.Controls.Add(this.spnElectronics);
            this.pnlTrivials.Controls.Add(this.lblElectronics);
            this.pnlTrivials.Controls.Add(this.label47);
            this.pnlTrivials.Controls.Add(this.spnElectricals);
            this.pnlTrivials.Controls.Add(this.lblElectricals);
            this.pnlTrivials.Location = new System.Drawing.Point(3, 959);
            this.pnlTrivials.Name = "pnlTrivials";
            this.pnlTrivials.Size = new System.Drawing.Size(647, 231);
            this.pnlTrivials.TabIndex = 24;
            // 
            // cbxPayFootWear
            // 
            this.cbxPayFootWear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayFootWear.FormattingEnabled = true;
            this.cbxPayFootWear.Location = new System.Drawing.Point(396, 190);
            this.cbxPayFootWear.Name = "cbxPayFootWear";
            this.cbxPayFootWear.Size = new System.Drawing.Size(115, 25);
            this.cbxPayFootWear.TabIndex = 36;
            this.cbxPayFootWear.Tag = "32";
            this.cbxPayFootWear.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayFurniture
            // 
            this.cbxPayFurniture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayFurniture.FormattingEnabled = true;
            this.cbxPayFurniture.Location = new System.Drawing.Point(396, 159);
            this.cbxPayFurniture.Name = "cbxPayFurniture";
            this.cbxPayFurniture.Size = new System.Drawing.Size(115, 25);
            this.cbxPayFurniture.TabIndex = 35;
            this.cbxPayFurniture.Tag = "31";
            this.cbxPayFurniture.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayUtensils
            // 
            this.cbxPayUtensils.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayUtensils.FormattingEnabled = true;
            this.cbxPayUtensils.Location = new System.Drawing.Point(396, 128);
            this.cbxPayUtensils.Name = "cbxPayUtensils";
            this.cbxPayUtensils.Size = new System.Drawing.Size(115, 25);
            this.cbxPayUtensils.TabIndex = 34;
            this.cbxPayUtensils.Tag = "30";
            this.cbxPayUtensils.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayApparels
            // 
            this.cbxPayApparels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayApparels.FormattingEnabled = true;
            this.cbxPayApparels.Location = new System.Drawing.Point(396, 97);
            this.cbxPayApparels.Name = "cbxPayApparels";
            this.cbxPayApparels.Size = new System.Drawing.Size(115, 25);
            this.cbxPayApparels.TabIndex = 33;
            this.cbxPayApparels.Tag = "29";
            this.cbxPayApparels.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayDress
            // 
            this.cbxPayDress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayDress.FormattingEnabled = true;
            this.cbxPayDress.Location = new System.Drawing.Point(396, 66);
            this.cbxPayDress.Name = "cbxPayDress";
            this.cbxPayDress.Size = new System.Drawing.Size(115, 25);
            this.cbxPayDress.TabIndex = 32;
            this.cbxPayDress.Tag = "28";
            this.cbxPayDress.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayElectronics
            // 
            this.cbxPayElectronics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayElectronics.FormattingEnabled = true;
            this.cbxPayElectronics.Location = new System.Drawing.Point(396, 37);
            this.cbxPayElectronics.Name = "cbxPayElectronics";
            this.cbxPayElectronics.Size = new System.Drawing.Size(115, 25);
            this.cbxPayElectronics.TabIndex = 31;
            this.cbxPayElectronics.Tag = "27";
            this.cbxPayElectronics.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayElectricals
            // 
            this.cbxPayElectricals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayElectricals.FormattingEnabled = true;
            this.cbxPayElectricals.Location = new System.Drawing.Point(396, 7);
            this.cbxPayElectricals.Name = "cbxPayElectricals";
            this.cbxPayElectricals.Size = new System.Drawing.Size(115, 25);
            this.cbxPayElectricals.TabIndex = 30;
            this.cbxPayElectricals.Tag = "26";
            this.cbxPayElectricals.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // tbxFootwear
            // 
            this.tbxFootwear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxFootwear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxFootwear.Location = new System.Drawing.Point(257, 191);
            this.tbxFootwear.Name = "tbxFootwear";
            this.tbxFootwear.Size = new System.Drawing.Size(133, 25);
            this.tbxFootwear.TabIndex = 27;
            this.tbxFootwear.Tag = "32";
            this.tbxFootwear.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(16, 194);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(100, 17);
            this.label49.TabIndex = 26;
            this.label49.Text = "Footwear :";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnFootwear
            // 
            this.spnFootwear.DecimalPlaces = 2;
            this.spnFootwear.Location = new System.Drawing.Point(131, 191);
            this.spnFootwear.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnFootwear.Name = "spnFootwear";
            this.spnFootwear.Size = new System.Drawing.Size(120, 25);
            this.spnFootwear.TabIndex = 25;
            this.spnFootwear.Tag = "32";
            this.spnFootwear.ThousandsSeparator = true;
            this.spnFootwear.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblFootwear
            // 
            this.lblFootwear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFootwear.Location = new System.Drawing.Point(517, 192);
            this.lblFootwear.Name = "lblFootwear";
            this.lblFootwear.Size = new System.Drawing.Size(99, 23);
            this.lblFootwear.TabIndex = 24;
            this.lblFootwear.Text = "H2O :";
            // 
            // tbxFurniture
            // 
            this.tbxFurniture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxFurniture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxFurniture.Location = new System.Drawing.Point(257, 159);
            this.tbxFurniture.Name = "tbxFurniture";
            this.tbxFurniture.Size = new System.Drawing.Size(133, 25);
            this.tbxFurniture.TabIndex = 23;
            this.tbxFurniture.Tag = "31";
            this.tbxFurniture.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(16, 162);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(100, 17);
            this.label37.TabIndex = 22;
            this.label37.Text = "Furniture :";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnFurniture
            // 
            this.spnFurniture.DecimalPlaces = 2;
            this.spnFurniture.Location = new System.Drawing.Point(131, 160);
            this.spnFurniture.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnFurniture.Name = "spnFurniture";
            this.spnFurniture.Size = new System.Drawing.Size(120, 25);
            this.spnFurniture.TabIndex = 21;
            this.spnFurniture.Tag = "31";
            this.spnFurniture.ThousandsSeparator = true;
            this.spnFurniture.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblFurniture
            // 
            this.lblFurniture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFurniture.Location = new System.Drawing.Point(517, 161);
            this.lblFurniture.Name = "lblFurniture";
            this.lblFurniture.Size = new System.Drawing.Size(99, 23);
            this.lblFurniture.TabIndex = 20;
            this.lblFurniture.Text = "H2O :";
            // 
            // tbxUtensils
            // 
            this.tbxUtensils.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxUtensils.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxUtensils.Location = new System.Drawing.Point(257, 128);
            this.tbxUtensils.Name = "tbxUtensils";
            this.tbxUtensils.Size = new System.Drawing.Size(133, 25);
            this.tbxUtensils.TabIndex = 19;
            this.tbxUtensils.Tag = "30";
            this.tbxUtensils.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // label39
            // 
            this.label39.Location = new System.Drawing.Point(16, 131);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(100, 17);
            this.label39.TabIndex = 18;
            this.label39.Text = "Utensils :";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnUtensils
            // 
            this.spnUtensils.DecimalPlaces = 2;
            this.spnUtensils.Location = new System.Drawing.Point(131, 129);
            this.spnUtensils.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnUtensils.Name = "spnUtensils";
            this.spnUtensils.Size = new System.Drawing.Size(120, 25);
            this.spnUtensils.TabIndex = 17;
            this.spnUtensils.Tag = "30";
            this.spnUtensils.ThousandsSeparator = true;
            this.spnUtensils.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblUtensils
            // 
            this.lblUtensils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUtensils.Location = new System.Drawing.Point(517, 130);
            this.lblUtensils.Name = "lblUtensils";
            this.lblUtensils.Size = new System.Drawing.Size(99, 23);
            this.lblUtensils.TabIndex = 16;
            this.lblUtensils.Text = "H2O :";
            // 
            // tbxApparels
            // 
            this.tbxApparels.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxApparels.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxApparels.Location = new System.Drawing.Point(257, 97);
            this.tbxApparels.Name = "tbxApparels";
            this.tbxApparels.Size = new System.Drawing.Size(133, 25);
            this.tbxApparels.TabIndex = 15;
            this.tbxApparels.Tag = "29";
            this.tbxApparels.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxDress
            // 
            this.tbxDress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxDress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxDress.Location = new System.Drawing.Point(257, 66);
            this.tbxDress.Name = "tbxDress";
            this.tbxDress.Size = new System.Drawing.Size(133, 25);
            this.tbxDress.TabIndex = 14;
            this.tbxDress.Tag = "28";
            this.tbxDress.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxElectronics
            // 
            this.tbxElectronics.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxElectronics.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxElectronics.Location = new System.Drawing.Point(257, 37);
            this.tbxElectronics.Name = "tbxElectronics";
            this.tbxElectronics.Size = new System.Drawing.Size(133, 25);
            this.tbxElectronics.TabIndex = 13;
            this.tbxElectronics.Tag = "27";
            this.tbxElectronics.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxElectricals
            // 
            this.tbxElectricals.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxElectricals.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxElectricals.Location = new System.Drawing.Point(257, 7);
            this.tbxElectricals.Name = "tbxElectricals";
            this.tbxElectricals.Size = new System.Drawing.Size(133, 25);
            this.tbxElectricals.TabIndex = 12;
            this.tbxElectricals.Tag = "26";
            this.tbxElectricals.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(16, 100);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(100, 17);
            this.label41.TabIndex = 11;
            this.label41.Text = "Apparels :";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnApparels
            // 
            this.spnApparels.DecimalPlaces = 2;
            this.spnApparels.Location = new System.Drawing.Point(131, 98);
            this.spnApparels.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnApparels.Name = "spnApparels";
            this.spnApparels.Size = new System.Drawing.Size(120, 25);
            this.spnApparels.TabIndex = 10;
            this.spnApparels.Tag = "29";
            this.spnApparels.ThousandsSeparator = true;
            this.spnApparels.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblApparels
            // 
            this.lblApparels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApparels.Location = new System.Drawing.Point(517, 99);
            this.lblApparels.Name = "lblApparels";
            this.lblApparels.Size = new System.Drawing.Size(99, 23);
            this.lblApparels.TabIndex = 9;
            this.lblApparels.Text = "H2O :";
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(16, 69);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(100, 17);
            this.label43.TabIndex = 8;
            this.label43.Text = "Dress :";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnDress
            // 
            this.spnDress.DecimalPlaces = 2;
            this.spnDress.Location = new System.Drawing.Point(131, 67);
            this.spnDress.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnDress.Name = "spnDress";
            this.spnDress.Size = new System.Drawing.Size(120, 25);
            this.spnDress.TabIndex = 7;
            this.spnDress.Tag = "28";
            this.spnDress.ThousandsSeparator = true;
            this.spnDress.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblDress
            // 
            this.lblDress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDress.Location = new System.Drawing.Point(517, 68);
            this.lblDress.Name = "lblDress";
            this.lblDress.Size = new System.Drawing.Size(99, 23);
            this.lblDress.TabIndex = 6;
            this.lblDress.Text = "Milk :";
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(12, 40);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(100, 17);
            this.label45.TabIndex = 5;
            this.label45.Text = "Electronics :";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnElectronics
            // 
            this.spnElectronics.DecimalPlaces = 2;
            this.spnElectronics.Location = new System.Drawing.Point(131, 38);
            this.spnElectronics.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnElectronics.Name = "spnElectronics";
            this.spnElectronics.Size = new System.Drawing.Size(120, 25);
            this.spnElectronics.TabIndex = 4;
            this.spnElectronics.Tag = "27";
            this.spnElectronics.ThousandsSeparator = true;
            this.spnElectronics.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblElectronics
            // 
            this.lblElectronics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblElectronics.Location = new System.Drawing.Point(517, 39);
            this.lblElectronics.Name = "lblElectronics";
            this.lblElectronics.Size = new System.Drawing.Size(99, 23);
            this.lblElectronics.TabIndex = 3;
            this.lblElectronics.Text = "Veggies :";
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(16, 11);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(100, 17);
            this.label47.TabIndex = 2;
            this.label47.Text = "Electricals :";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnElectricals
            // 
            this.spnElectricals.DecimalPlaces = 2;
            this.spnElectricals.Location = new System.Drawing.Point(131, 8);
            this.spnElectricals.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnElectricals.Name = "spnElectricals";
            this.spnElectricals.Size = new System.Drawing.Size(120, 25);
            this.spnElectricals.TabIndex = 1;
            this.spnElectricals.Tag = "26";
            this.spnElectricals.ThousandsSeparator = true;
            this.spnElectricals.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblElectricals
            // 
            this.lblElectricals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblElectricals.Location = new System.Drawing.Point(517, 10);
            this.lblElectricals.Name = "lblElectricals";
            this.lblElectricals.Size = new System.Drawing.Size(99, 23);
            this.lblElectricals.TabIndex = 0;
            this.lblElectricals.Text = "Groceries :";
            // 
            // pnlBrainiac
            // 
            this.pnlBrainiac.AutoScroll = true;
            this.pnlBrainiac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBrainiac.Controls.Add(this.cbxPayFees);
            this.pnlBrainiac.Controls.Add(this.cbxPayNoteBooks);
            this.pnlBrainiac.Controls.Add(this.cbxPayBooks);
            this.pnlBrainiac.Controls.Add(this.cbxPayStationery);
            this.pnlBrainiac.Controls.Add(this.tbxFees);
            this.pnlBrainiac.Controls.Add(this.tbxNoteBooks);
            this.pnlBrainiac.Controls.Add(this.tbxBooks);
            this.pnlBrainiac.Controls.Add(this.tbxStationery);
            this.pnlBrainiac.Controls.Add(this.label57);
            this.pnlBrainiac.Controls.Add(this.spnFees);
            this.pnlBrainiac.Controls.Add(this.lblFees);
            this.pnlBrainiac.Controls.Add(this.label59);
            this.pnlBrainiac.Controls.Add(this.spnNoteBooks);
            this.pnlBrainiac.Controls.Add(this.lblNoteBooks);
            this.pnlBrainiac.Controls.Add(this.label61);
            this.pnlBrainiac.Controls.Add(this.spnBooks);
            this.pnlBrainiac.Controls.Add(this.lblBooks);
            this.pnlBrainiac.Controls.Add(this.label63);
            this.pnlBrainiac.Controls.Add(this.spnStationery);
            this.pnlBrainiac.Controls.Add(this.lblStationery);
            this.pnlBrainiac.Location = new System.Drawing.Point(3, 1196);
            this.pnlBrainiac.Name = "pnlBrainiac";
            this.pnlBrainiac.Size = new System.Drawing.Size(647, 143);
            this.pnlBrainiac.TabIndex = 28;
            // 
            // cbxPayFees
            // 
            this.cbxPayFees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayFees.FormattingEnabled = true;
            this.cbxPayFees.Location = new System.Drawing.Point(396, 99);
            this.cbxPayFees.Name = "cbxPayFees";
            this.cbxPayFees.Size = new System.Drawing.Size(115, 25);
            this.cbxPayFees.TabIndex = 27;
            this.cbxPayFees.Tag = "36";
            this.cbxPayFees.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayNoteBooks
            // 
            this.cbxPayNoteBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayNoteBooks.FormattingEnabled = true;
            this.cbxPayNoteBooks.Location = new System.Drawing.Point(396, 68);
            this.cbxPayNoteBooks.Name = "cbxPayNoteBooks";
            this.cbxPayNoteBooks.Size = new System.Drawing.Size(115, 25);
            this.cbxPayNoteBooks.TabIndex = 26;
            this.cbxPayNoteBooks.Tag = "35";
            this.cbxPayNoteBooks.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayBooks
            // 
            this.cbxPayBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayBooks.FormattingEnabled = true;
            this.cbxPayBooks.Location = new System.Drawing.Point(396, 37);
            this.cbxPayBooks.Name = "cbxPayBooks";
            this.cbxPayBooks.Size = new System.Drawing.Size(115, 25);
            this.cbxPayBooks.TabIndex = 25;
            this.cbxPayBooks.Tag = "34";
            this.cbxPayBooks.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayStationery
            // 
            this.cbxPayStationery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayStationery.FormattingEnabled = true;
            this.cbxPayStationery.Location = new System.Drawing.Point(396, 7);
            this.cbxPayStationery.Name = "cbxPayStationery";
            this.cbxPayStationery.Size = new System.Drawing.Size(115, 25);
            this.cbxPayStationery.TabIndex = 24;
            this.cbxPayStationery.Tag = "33";
            this.cbxPayStationery.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // tbxFees
            // 
            this.tbxFees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxFees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxFees.Location = new System.Drawing.Point(257, 100);
            this.tbxFees.Name = "tbxFees";
            this.tbxFees.Size = new System.Drawing.Size(133, 25);
            this.tbxFees.TabIndex = 15;
            this.tbxFees.Tag = "36";
            this.tbxFees.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxNoteBooks
            // 
            this.tbxNoteBooks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxNoteBooks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxNoteBooks.Location = new System.Drawing.Point(257, 69);
            this.tbxNoteBooks.Name = "tbxNoteBooks";
            this.tbxNoteBooks.Size = new System.Drawing.Size(133, 25);
            this.tbxNoteBooks.TabIndex = 14;
            this.tbxNoteBooks.Tag = "35";
            this.tbxNoteBooks.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxBooks
            // 
            this.tbxBooks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxBooks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxBooks.Location = new System.Drawing.Point(257, 38);
            this.tbxBooks.Name = "tbxBooks";
            this.tbxBooks.Size = new System.Drawing.Size(133, 25);
            this.tbxBooks.TabIndex = 13;
            this.tbxBooks.Tag = "34";
            this.tbxBooks.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxStationery
            // 
            this.tbxStationery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxStationery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxStationery.Location = new System.Drawing.Point(257, 7);
            this.tbxStationery.Name = "tbxStationery";
            this.tbxStationery.Size = new System.Drawing.Size(133, 25);
            this.tbxStationery.TabIndex = 12;
            this.tbxStationery.Tag = "33";
            this.tbxStationery.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // label57
            // 
            this.label57.Location = new System.Drawing.Point(16, 103);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(100, 17);
            this.label57.TabIndex = 11;
            this.label57.Text = "Fees :";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnFees
            // 
            this.spnFees.DecimalPlaces = 2;
            this.spnFees.Location = new System.Drawing.Point(131, 101);
            this.spnFees.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnFees.Name = "spnFees";
            this.spnFees.Size = new System.Drawing.Size(120, 25);
            this.spnFees.TabIndex = 10;
            this.spnFees.Tag = "36";
            this.spnFees.ThousandsSeparator = true;
            this.spnFees.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblFees
            // 
            this.lblFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFees.Location = new System.Drawing.Point(517, 101);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(99, 23);
            this.lblFees.TabIndex = 9;
            this.lblFees.Text = "H2O :";
            // 
            // label59
            // 
            this.label59.Location = new System.Drawing.Point(16, 72);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(100, 17);
            this.label59.TabIndex = 8;
            this.label59.Text = "NoteBooks :";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnNoteBooks
            // 
            this.spnNoteBooks.DecimalPlaces = 2;
            this.spnNoteBooks.Location = new System.Drawing.Point(131, 70);
            this.spnNoteBooks.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnNoteBooks.Name = "spnNoteBooks";
            this.spnNoteBooks.Size = new System.Drawing.Size(120, 25);
            this.spnNoteBooks.TabIndex = 7;
            this.spnNoteBooks.Tag = "35";
            this.spnNoteBooks.ThousandsSeparator = true;
            this.spnNoteBooks.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblNoteBooks
            // 
            this.lblNoteBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoteBooks.Location = new System.Drawing.Point(517, 70);
            this.lblNoteBooks.Name = "lblNoteBooks";
            this.lblNoteBooks.Size = new System.Drawing.Size(99, 23);
            this.lblNoteBooks.TabIndex = 6;
            this.lblNoteBooks.Text = "Milk :";
            // 
            // label61
            // 
            this.label61.Location = new System.Drawing.Point(16, 41);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(100, 17);
            this.label61.TabIndex = 5;
            this.label61.Text = "Books :";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnBooks
            // 
            this.spnBooks.DecimalPlaces = 2;
            this.spnBooks.Location = new System.Drawing.Point(131, 39);
            this.spnBooks.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnBooks.Name = "spnBooks";
            this.spnBooks.Size = new System.Drawing.Size(120, 25);
            this.spnBooks.TabIndex = 4;
            this.spnBooks.Tag = "34";
            this.spnBooks.ThousandsSeparator = true;
            this.spnBooks.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblBooks
            // 
            this.lblBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBooks.Location = new System.Drawing.Point(517, 40);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(99, 23);
            this.lblBooks.TabIndex = 3;
            this.lblBooks.Text = "Veggies :";
            // 
            // label63
            // 
            this.label63.Location = new System.Drawing.Point(16, 11);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(100, 17);
            this.label63.TabIndex = 2;
            this.label63.Text = "Stationery :";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnStationery
            // 
            this.spnStationery.DecimalPlaces = 2;
            this.spnStationery.Location = new System.Drawing.Point(131, 8);
            this.spnStationery.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnStationery.Name = "spnStationery";
            this.spnStationery.Size = new System.Drawing.Size(120, 25);
            this.spnStationery.TabIndex = 1;
            this.spnStationery.Tag = "33";
            this.spnStationery.ThousandsSeparator = true;
            this.spnStationery.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblStationery
            // 
            this.lblStationery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStationery.Location = new System.Drawing.Point(517, 9);
            this.lblStationery.Name = "lblStationery";
            this.lblStationery.Size = new System.Drawing.Size(99, 23);
            this.lblStationery.TabIndex = 0;
            this.lblStationery.Text = "Groceries :";
            // 
            // pnlSeeds
            // 
            this.pnlSeeds.AutoScroll = true;
            this.pnlSeeds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSeeds.Controls.Add(this.cbxPayHouseEMI);
            this.pnlSeeds.Controls.Add(this.cbxPayMetals);
            this.pnlSeeds.Controls.Add(this.cbxPayDeposits);
            this.pnlSeeds.Controls.Add(this.cbxPayInsurance);
            this.pnlSeeds.Controls.Add(this.tbxMetals);
            this.pnlSeeds.Controls.Add(this.tbxDeposits);
            this.pnlSeeds.Controls.Add(this.tbxInsurance);
            this.pnlSeeds.Controls.Add(this.label51);
            this.pnlSeeds.Controls.Add(this.spnHouseEMI);
            this.pnlSeeds.Controls.Add(this.lblHouseEMI);
            this.pnlSeeds.Controls.Add(this.label53);
            this.pnlSeeds.Controls.Add(this.spnMetals);
            this.pnlSeeds.Controls.Add(this.lblMetals);
            this.pnlSeeds.Controls.Add(this.label55);
            this.pnlSeeds.Controls.Add(this.spnDeposits);
            this.pnlSeeds.Controls.Add(this.lblDeposits);
            this.pnlSeeds.Controls.Add(this.label65);
            this.pnlSeeds.Controls.Add(this.spnInsurance);
            this.pnlSeeds.Controls.Add(this.lblInsurance);
            this.pnlSeeds.Location = new System.Drawing.Point(3, 1345);
            this.pnlSeeds.Name = "pnlSeeds";
            this.pnlSeeds.Size = new System.Drawing.Size(647, 147);
            this.pnlSeeds.TabIndex = 29;
            // 
            // cbxPayHouseEMI
            // 
            this.cbxPayHouseEMI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayHouseEMI.FormattingEnabled = true;
            this.cbxPayHouseEMI.Location = new System.Drawing.Point(396, 99);
            this.cbxPayHouseEMI.Name = "cbxPayHouseEMI";
            this.cbxPayHouseEMI.Size = new System.Drawing.Size(115, 25);
            this.cbxPayHouseEMI.TabIndex = 27;
            this.cbxPayHouseEMI.Tag = "40";
            this.cbxPayHouseEMI.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayMetals
            // 
            this.cbxPayMetals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayMetals.FormattingEnabled = true;
            this.cbxPayMetals.Location = new System.Drawing.Point(396, 68);
            this.cbxPayMetals.Name = "cbxPayMetals";
            this.cbxPayMetals.Size = new System.Drawing.Size(115, 25);
            this.cbxPayMetals.TabIndex = 26;
            this.cbxPayMetals.Tag = "39";
            this.cbxPayMetals.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayDeposits
            // 
            this.cbxPayDeposits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayDeposits.FormattingEnabled = true;
            this.cbxPayDeposits.Location = new System.Drawing.Point(396, 37);
            this.cbxPayDeposits.Name = "cbxPayDeposits";
            this.cbxPayDeposits.Size = new System.Drawing.Size(115, 25);
            this.cbxPayDeposits.TabIndex = 25;
            this.cbxPayDeposits.Tag = "38";
            this.cbxPayDeposits.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // cbxPayInsurance
            // 
            this.cbxPayInsurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayInsurance.FormattingEnabled = true;
            this.cbxPayInsurance.Location = new System.Drawing.Point(396, 7);
            this.cbxPayInsurance.Name = "cbxPayInsurance";
            this.cbxPayInsurance.Size = new System.Drawing.Size(115, 25);
            this.cbxPayInsurance.TabIndex = 24;
            this.cbxPayInsurance.Tag = "37";
            this.cbxPayInsurance.SelectedIndexChanged += new System.EventHandler(this.OnPayModeChanged);
            // 
            // tbxMetals
            // 
            this.tbxMetals.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxMetals.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxMetals.Location = new System.Drawing.Point(257, 68);
            this.tbxMetals.Name = "tbxMetals";
            this.tbxMetals.Size = new System.Drawing.Size(133, 25);
            this.tbxMetals.TabIndex = 14;
            this.tbxMetals.Tag = "39";
            this.tbxMetals.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxDeposits
            // 
            this.tbxDeposits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxDeposits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxDeposits.Location = new System.Drawing.Point(257, 37);
            this.tbxDeposits.Name = "tbxDeposits";
            this.tbxDeposits.Size = new System.Drawing.Size(133, 25);
            this.tbxDeposits.TabIndex = 13;
            this.tbxDeposits.Tag = "38";
            this.tbxDeposits.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // tbxInsurance
            // 
            this.tbxInsurance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxInsurance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxInsurance.Location = new System.Drawing.Point(257, 7);
            this.tbxInsurance.Name = "tbxInsurance";
            this.tbxInsurance.Size = new System.Drawing.Size(133, 25);
            this.tbxInsurance.TabIndex = 12;
            this.tbxInsurance.Tag = "37";
            this.tbxInsurance.TextChanged += new System.EventHandler(this.OnStoreChanged);
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(16, 102);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(100, 17);
            this.label51.TabIndex = 11;
            this.label51.Text = "House EMI :";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnHouseEMI
            // 
            this.spnHouseEMI.DecimalPlaces = 2;
            this.spnHouseEMI.Location = new System.Drawing.Point(131, 100);
            this.spnHouseEMI.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnHouseEMI.Name = "spnHouseEMI";
            this.spnHouseEMI.Size = new System.Drawing.Size(120, 25);
            this.spnHouseEMI.TabIndex = 10;
            this.spnHouseEMI.Tag = "40";
            this.spnHouseEMI.ThousandsSeparator = true;
            this.spnHouseEMI.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblHouseEMI
            // 
            this.lblHouseEMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHouseEMI.Location = new System.Drawing.Point(517, 101);
            this.lblHouseEMI.Name = "lblHouseEMI";
            this.lblHouseEMI.Size = new System.Drawing.Size(99, 23);
            this.lblHouseEMI.TabIndex = 9;
            this.lblHouseEMI.Text = "H2O :";
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(16, 71);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(100, 17);
            this.label53.TabIndex = 8;
            this.label53.Text = "Metals :";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnMetals
            // 
            this.spnMetals.DecimalPlaces = 2;
            this.spnMetals.Location = new System.Drawing.Point(131, 69);
            this.spnMetals.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnMetals.Name = "spnMetals";
            this.spnMetals.Size = new System.Drawing.Size(120, 25);
            this.spnMetals.TabIndex = 7;
            this.spnMetals.Tag = "39";
            this.spnMetals.ThousandsSeparator = true;
            this.spnMetals.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblMetals
            // 
            this.lblMetals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMetals.Location = new System.Drawing.Point(517, 70);
            this.lblMetals.Name = "lblMetals";
            this.lblMetals.Size = new System.Drawing.Size(99, 23);
            this.lblMetals.TabIndex = 6;
            this.lblMetals.Text = "Milk :";
            // 
            // label55
            // 
            this.label55.Location = new System.Drawing.Point(16, 40);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(100, 17);
            this.label55.TabIndex = 5;
            this.label55.Text = "Deposits :";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnDeposits
            // 
            this.spnDeposits.DecimalPlaces = 2;
            this.spnDeposits.Location = new System.Drawing.Point(131, 38);
            this.spnDeposits.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnDeposits.Name = "spnDeposits";
            this.spnDeposits.Size = new System.Drawing.Size(120, 25);
            this.spnDeposits.TabIndex = 4;
            this.spnDeposits.Tag = "38";
            this.spnDeposits.ThousandsSeparator = true;
            this.spnDeposits.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblDeposits
            // 
            this.lblDeposits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeposits.Location = new System.Drawing.Point(517, 39);
            this.lblDeposits.Name = "lblDeposits";
            this.lblDeposits.Size = new System.Drawing.Size(99, 23);
            this.lblDeposits.TabIndex = 3;
            this.lblDeposits.Text = "Veggies :";
            // 
            // label65
            // 
            this.label65.Location = new System.Drawing.Point(16, 11);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(100, 17);
            this.label65.TabIndex = 2;
            this.label65.Text = "Insurance :";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spnInsurance
            // 
            this.spnInsurance.DecimalPlaces = 2;
            this.spnInsurance.Location = new System.Drawing.Point(131, 8);
            this.spnInsurance.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.spnInsurance.Name = "spnInsurance";
            this.spnInsurance.Size = new System.Drawing.Size(120, 25);
            this.spnInsurance.TabIndex = 1;
            this.spnInsurance.Tag = "37";
            this.spnInsurance.ThousandsSeparator = true;
            this.spnInsurance.ValueChanged += new System.EventHandler(this.OnAmountChanged);
            // 
            // lblInsurance
            // 
            this.lblInsurance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInsurance.Location = new System.Drawing.Point(517, 10);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(99, 23);
            this.lblInsurance.TabIndex = 0;
            this.lblInsurance.Text = "Groceries :";
            // 
            // flpRecurrence
            // 
            this.flpRecurrence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpRecurrence.Controls.Add(this.rdoDaily);
            this.flpRecurrence.Controls.Add(this.rdoWeekly);
            this.flpRecurrence.Controls.Add(this.rdoMonthly);
            this.flpRecurrence.Controls.Add(this.rdoAnnual);
            this.flpRecurrence.Controls.Add(this.rdoOneTime);
            this.flpRecurrence.Location = new System.Drawing.Point(11, 35);
            this.flpRecurrence.Name = "flpRecurrence";
            this.flpRecurrence.Size = new System.Drawing.Size(447, 53);
            this.flpRecurrence.TabIndex = 1;
            // 
            // rdoDaily
            // 
            this.rdoDaily.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoDaily.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoDaily.FlatAppearance.BorderSize = 2;
            this.rdoDaily.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.rdoDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDaily.Location = new System.Drawing.Point(3, 3);
            this.rdoDaily.Name = "rdoDaily";
            this.rdoDaily.Size = new System.Drawing.Size(80, 36);
            this.rdoDaily.TabIndex = 9;
            this.rdoDaily.Tag = "0";
            this.rdoDaily.Text = "Daily";
            this.rdoDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoDaily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoDaily.UseVisualStyleBackColor = true;
            this.rdoDaily.CheckedChanged += new System.EventHandler(this.OnRecurrenceChanged);
            this.rdoDaily.MouseEnter += new System.EventHandler(this.RatUponRec);
            this.rdoDaily.MouseLeave += new System.EventHandler(this.RatLeftRec);
            // 
            // rdoWeekly
            // 
            this.rdoWeekly.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoWeekly.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoWeekly.FlatAppearance.BorderSize = 2;
            this.rdoWeekly.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.rdoWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoWeekly.Location = new System.Drawing.Point(89, 3);
            this.rdoWeekly.Name = "rdoWeekly";
            this.rdoWeekly.Size = new System.Drawing.Size(80, 36);
            this.rdoWeekly.TabIndex = 10;
            this.rdoWeekly.Tag = "1";
            this.rdoWeekly.Text = "Weekly";
            this.rdoWeekly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoWeekly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoWeekly.UseVisualStyleBackColor = true;
            this.rdoWeekly.CheckedChanged += new System.EventHandler(this.OnRecurrenceChanged);
            this.rdoWeekly.MouseEnter += new System.EventHandler(this.RatUponRec);
            this.rdoWeekly.MouseLeave += new System.EventHandler(this.RatLeftRec);
            // 
            // rdoMonthly
            // 
            this.rdoMonthly.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoMonthly.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoMonthly.FlatAppearance.BorderSize = 2;
            this.rdoMonthly.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.rdoMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMonthly.Location = new System.Drawing.Point(175, 3);
            this.rdoMonthly.Name = "rdoMonthly";
            this.rdoMonthly.Size = new System.Drawing.Size(80, 36);
            this.rdoMonthly.TabIndex = 11;
            this.rdoMonthly.Tag = "2";
            this.rdoMonthly.Text = "Monthly";
            this.rdoMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoMonthly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoMonthly.UseVisualStyleBackColor = true;
            this.rdoMonthly.CheckedChanged += new System.EventHandler(this.OnRecurrenceChanged);
            this.rdoMonthly.MouseEnter += new System.EventHandler(this.RatUponRec);
            this.rdoMonthly.MouseLeave += new System.EventHandler(this.RatLeftRec);
            // 
            // rdoAnnual
            // 
            this.rdoAnnual.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoAnnual.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoAnnual.FlatAppearance.BorderSize = 2;
            this.rdoAnnual.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.rdoAnnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAnnual.Location = new System.Drawing.Point(261, 3);
            this.rdoAnnual.Name = "rdoAnnual";
            this.rdoAnnual.Size = new System.Drawing.Size(80, 36);
            this.rdoAnnual.TabIndex = 12;
            this.rdoAnnual.Tag = "3";
            this.rdoAnnual.Text = "Annual";
            this.rdoAnnual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoAnnual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoAnnual.UseVisualStyleBackColor = true;
            this.rdoAnnual.CheckedChanged += new System.EventHandler(this.OnRecurrenceChanged);
            this.rdoAnnual.MouseEnter += new System.EventHandler(this.RatUponRec);
            this.rdoAnnual.MouseLeave += new System.EventHandler(this.RatLeftRec);
            // 
            // rdoOneTime
            // 
            this.rdoOneTime.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoOneTime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoOneTime.FlatAppearance.BorderSize = 2;
            this.rdoOneTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.rdoOneTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoOneTime.Location = new System.Drawing.Point(347, 3);
            this.rdoOneTime.Name = "rdoOneTime";
            this.rdoOneTime.Size = new System.Drawing.Size(80, 36);
            this.rdoOneTime.TabIndex = 13;
            this.rdoOneTime.Tag = "4";
            this.rdoOneTime.Text = "OneTime";
            this.rdoOneTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoOneTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoOneTime.UseVisualStyleBackColor = true;
            this.rdoOneTime.CheckedChanged += new System.EventHandler(this.OnRecurrenceChanged);
            this.rdoOneTime.MouseEnter += new System.EventHandler(this.RatUponRec);
            this.rdoOneTime.MouseLeave += new System.EventHandler(this.RatLeftRec);
            // 
            // btnYesterday
            // 
            this.btnYesterday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYesterday.Location = new System.Drawing.Point(542, 35);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(40, 25);
            this.btnYesterday.TabIndex = 7;
            this.btnYesterday.Text = "<";
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastMonth.Location = new System.Drawing.Point(476, 35);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(51, 25);
            this.btnLastMonth.TabIndex = 8;
            this.btnLastMonth.Text = "<<";
            this.btnLastMonth.UseVisualStyleBackColor = true;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomorrow.Location = new System.Drawing.Point(586, 35);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(40, 25);
            this.btnTomorrow.TabIndex = 9;
            this.btnTomorrow.Text = ">";
            this.btnTomorrow.UseVisualStyleBackColor = true;
            this.btnTomorrow.Click += new System.EventHandler(this.btnTomorrow_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextMonth.Location = new System.Drawing.Point(639, 35);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(51, 25);
            this.btnNextMonth.TabIndex = 10;
            this.btnNextMonth.Text = ">>";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(842, 459);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.btnTomorrow);
            this.Controls.Add(this.btnLastMonth);
            this.Controls.Add(this.btnYesterday);
            this.Controls.Add(this.flpRecurrence);
            this.Controls.Add(this.gbxExpense);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.stsBottom);
            this.Controls.Add(this.dtpExpensdOn);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TrX";
            this.stsBottom.ResumeLayout(false);
            this.stsBottom.PerformLayout();
            this.gbxExpense.ResumeLayout(false);
            this.sltExpenses.Panel1.ResumeLayout(false);
            this.sltExpenses.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sltExpenses)).EndInit();
            this.sltExpenses.ResumeLayout(false);
            this.flpCategories.ResumeLayout(false);
            this.flpControls.ResumeLayout(false);
            this.pnlHarvest.ResumeLayout(false);
            this.pnlHarvest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnH2O)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMilk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnVeggies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnGrocks)).EndInit();
            this.pnlEdible.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnSnacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnLunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnBreakFast)).EndInit();
            this.pnlDock.ResumeLayout(false);
            this.pnlDock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnJourney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCommute)).EndInit();
            this.pnlNeedles.ResumeLayout(false);
            this.pnlNeedles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMedicine)).EndInit();
            this.pnlUpkeep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnTelephony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnLoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnStrata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnEB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDomH2O)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnRent)).EndInit();
            this.pnlPeace.ResumeLayout(false);
            this.pnlPeace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCinemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMagazine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNewsPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnInternet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDTH)).EndInit();
            this.pnlTrivials.ResumeLayout(false);
            this.pnlTrivials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnFootwear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFurniture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnUtensils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnApparels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnElectronics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnElectricals)).EndInit();
            this.pnlBrainiac.ResumeLayout(false);
            this.pnlBrainiac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNoteBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnStationery)).EndInit();
            this.pnlSeeds.ResumeLayout(false);
            this.pnlSeeds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnHouseEMI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMetals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnInsurance)).EndInit();
            this.flpRecurrence.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DateTimePicker dtpExpensdOn;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.StatusStrip stsBottom;
        private System.Windows.Forms.ToolStripStatusLabel tslToday;
        private System.Windows.Forms.ToolStripStatusLabel tslNow;
        private System.Windows.Forms.ToolStripStatusLabel tslRecurrence;
        private System.Windows.Forms.Timer tmrInvoluntary;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.GroupBox gbxExpense;
        private System.Windows.Forms.SplitContainer sltExpenses;
        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private System.Windows.Forms.RadioButton rdoHarvest;
        private System.Windows.Forms.RadioButton rdoEdibles;
        private System.Windows.Forms.RadioButton rdoNeedles;
        private System.Windows.Forms.RadioButton rdoDock;
        private System.Windows.Forms.RadioButton rdoUpkeep;
        private System.Windows.Forms.RadioButton rdoPeace;
        private System.Windows.Forms.RadioButton rdoTrivia;
        private System.Windows.Forms.RadioButton rdoBrainiac;
        private System.Windows.Forms.FlowLayoutPanel flpControls;
        private System.Windows.Forms.RadioButton rdoSeeds;
        private System.Windows.Forms.Panel pnlHarvest;
        private System.Windows.Forms.Label lblGrocks;
        private System.Windows.Forms.NumericUpDown spnGrocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spnVeggies;
        private System.Windows.Forms.Label lblVeggies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown spnMilk;
        private System.Windows.Forms.Label lblMilk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown spnH2O;
        private System.Windows.Forms.Label lblH2O;
        private System.Windows.Forms.Panel pnlEdible;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown spnLunch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown spnBreakFast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown spnDinner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown spnSnacks;
        private System.Windows.Forms.ComboBox cbxBreakFast;
        private System.Windows.Forms.ComboBox cbxSnacks;
        private System.Windows.Forms.ComboBox cbxDinner;
        private System.Windows.Forms.ComboBox cbxLunch;
        private System.Windows.Forms.Label lblBreakFast;
        private System.Windows.Forms.Label lblSnacks;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.TextBox tbxGrocStore;
        private System.Windows.Forms.TextBox tbxH2OStore;
        private System.Windows.Forms.TextBox tbxMilkStore;
        private System.Windows.Forms.TextBox tbxVegStore;
        private System.Windows.Forms.Panel pnlDock;
        private System.Windows.Forms.TextBox tbxCabs;
        private System.Windows.Forms.TextBox tbxJourney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spnFuel;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown spnCabs;
        private System.Windows.Forms.Label lblCabs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown spnJourney;
        private System.Windows.Forms.Label lblJourney;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown spnCommute;
        private System.Windows.Forms.Label lblCommute;
        private System.Windows.Forms.ToolStripStatusLabel tslCategory;
        private System.Windows.Forms.Panel pnlNeedles;
        private System.Windows.Forms.TextBox tbxHospital;
        private System.Windows.Forms.TextBox tbxMedicine;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown spnHospital;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown spnMedicine;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.Panel pnlUpkeep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown spnStrata;
        private System.Windows.Forms.Label lblStrata;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown spnEB;
        private System.Windows.Forms.Label lblEB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown spnDomH2O;
        private System.Windows.Forms.Label lblDomH2O;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown spnRent;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown spnLoan;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Panel pnlPeace;
        private System.Windows.Forms.TextBox tbxTour;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown spnTour;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.TextBox tbxCinemas;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown spnCinemas;
        private System.Windows.Forms.Label lblCinemas;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown spnMagazine;
        private System.Windows.Forms.Label lblMagazine;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown spnNewsPaper;
        private System.Windows.Forms.Label lblNewspaper;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown spnInternet;
        private System.Windows.Forms.Label lblInternet;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown spnDTH;
        private System.Windows.Forms.Label lblDTH;
        private System.Windows.Forms.Panel pnlTrivials;
        private System.Windows.Forms.TextBox tbxFootwear;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.NumericUpDown spnFootwear;
        private System.Windows.Forms.Label lblFootwear;
        private System.Windows.Forms.TextBox tbxFurniture;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.NumericUpDown spnFurniture;
        private System.Windows.Forms.Label lblFurniture;
        private System.Windows.Forms.TextBox tbxUtensils;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown spnUtensils;
        private System.Windows.Forms.Label lblUtensils;
        private System.Windows.Forms.TextBox tbxApparels;
        private System.Windows.Forms.TextBox tbxDress;
        private System.Windows.Forms.TextBox tbxElectronics;
        private System.Windows.Forms.TextBox tbxElectricals;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown spnApparels;
        private System.Windows.Forms.Label lblApparels;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.NumericUpDown spnDress;
        private System.Windows.Forms.Label lblDress;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.NumericUpDown spnElectronics;
        private System.Windows.Forms.Label lblElectronics;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.NumericUpDown spnElectricals;
        private System.Windows.Forms.Label lblElectricals;
        private System.Windows.Forms.Panel pnlBrainiac;
        private System.Windows.Forms.TextBox tbxFees;
        private System.Windows.Forms.TextBox tbxNoteBooks;
        private System.Windows.Forms.TextBox tbxBooks;
        private System.Windows.Forms.TextBox tbxStationery;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.NumericUpDown spnFees;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.NumericUpDown spnNoteBooks;
        private System.Windows.Forms.Label lblNoteBooks;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.NumericUpDown spnBooks;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.NumericUpDown spnStationery;
        private System.Windows.Forms.Label lblStationery;
        private System.Windows.Forms.Panel pnlSeeds;
        private System.Windows.Forms.TextBox tbxMetals;
        private System.Windows.Forms.TextBox tbxDeposits;
        private System.Windows.Forms.TextBox tbxInsurance;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.NumericUpDown spnHouseEMI;
        private System.Windows.Forms.Label lblHouseEMI;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.NumericUpDown spnMetals;
        private System.Windows.Forms.Label lblMetals;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown spnDeposits;
        private System.Windows.Forms.Label lblDeposits;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.NumericUpDown spnInsurance;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.FlowLayoutPanel flpRecurrence;
        private System.Windows.Forms.RadioButton rdoOneTime;
        private System.Windows.Forms.RadioButton rdoAnnual;
        private System.Windows.Forms.RadioButton rdoMonthly;
        private System.Windows.Forms.RadioButton rdoWeekly;
        private System.Windows.Forms.RadioButton rdoDaily;
        private System.Windows.Forms.ComboBox cbxPayGrocks;
        private System.Windows.Forms.ComboBox cbxPayH2O;
        private System.Windows.Forms.ComboBox cbxPayMilk;
        private System.Windows.Forms.ComboBox cbxPayVeggies;
        private System.Windows.Forms.ComboBox cbxPaySnacks;
        private System.Windows.Forms.ComboBox cbxPayDinner;
        private System.Windows.Forms.ComboBox cbxPayLunch;
        private System.Windows.Forms.ComboBox cbxPayBreakFast;
        private System.Windows.Forms.ComboBox cbxPayFuel;
        private System.Windows.Forms.ComboBox cbxPayCabs;
        private System.Windows.Forms.ComboBox cbxPayJourney;
        private System.Windows.Forms.ComboBox cbxPayCommute;
        private System.Windows.Forms.ComboBox cbxPayHospital;
        private System.Windows.Forms.ComboBox cbxPayMedicine;
        private System.Windows.Forms.ComboBox cbxPayLoan;
        private System.Windows.Forms.ComboBox cbxPayStrata;
        private System.Windows.Forms.ComboBox cbxPayEB;
        private System.Windows.Forms.ComboBox cbxDomH2O;
        private System.Windows.Forms.ComboBox cbxPayRent;
        private System.Windows.Forms.ComboBox cbxPayTour;
        private System.Windows.Forms.ComboBox cbxPayCinemas;
        private System.Windows.Forms.ComboBox cbxPayMagazine;
        private System.Windows.Forms.ComboBox cbxPayNewsPaper;
        private System.Windows.Forms.ComboBox cbxPayInternet;
        private System.Windows.Forms.ComboBox cbxPayDTH;
        private System.Windows.Forms.ComboBox cbxPayFootWear;
        private System.Windows.Forms.ComboBox cbxPayFurniture;
        private System.Windows.Forms.ComboBox cbxPayUtensils;
        private System.Windows.Forms.ComboBox cbxPayApparels;
        private System.Windows.Forms.ComboBox cbxPayDress;
        private System.Windows.Forms.ComboBox cbxPayElectronics;
        private System.Windows.Forms.ComboBox cbxPayElectricals;
        private System.Windows.Forms.ComboBox cbxPayFees;
        private System.Windows.Forms.ComboBox cbxPayNoteBooks;
        private System.Windows.Forms.ComboBox cbxPayBooks;
        private System.Windows.Forms.ComboBox cbxPayStationery;
        private System.Windows.Forms.ComboBox cbxPayHouseEMI;
        private System.Windows.Forms.ComboBox cbxPayMetals;
        private System.Windows.Forms.ComboBox cbxPayDeposits;
        private System.Windows.Forms.ComboBox cbxPayInsurance;
        private System.Windows.Forms.ComboBox cbxPayPhone;
        private System.Windows.Forms.Label lxtPhone;
        private System.Windows.Forms.NumericUpDown spnTelephony;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ToolStripProgressBar tspProgress;
        private System.Windows.Forms.ToolStripStatusLabel tslLastAction;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnTomorrow;
        private System.Windows.Forms.Button btnNextMonth;
    }
}

