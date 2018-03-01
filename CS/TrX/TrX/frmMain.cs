using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrX
{
    public partial class frmMain : Form
    {
        #region Skeleton
        private int _CurCat, _CurRec;
        private static int _counter = 0;
        private const int _CatVGrowth = 4;
        private const int _CatHGrowth = 2;
        private const int _RecVGrowth = 4;
        private const int _RecHGrowth = 3;
        private const decimal _MinAmount = 0;
        private const string _DummyStore = "--pluto--";
        Panel[] panels;
        NumericUpDown spnTmp;
        /// <summary>
        /// Array of AllExpenses, initially with all "Null"s;
        /// </summary>
        Expense[] AllExpenses;
        /// <summary>
        /// Array of all PaymentMode ComboBoxes;
        /// </summary>
        ComboBox[] AllPayments;
        /// <summary>
        /// Array of all StoreName TextBoxes;
        /// </summary>
        TextBox[] AllStores;
        /// <summary>
        /// Array of all Amount Spinners
        /// </summary>
        NumericUpDown[] AllAmounts;
        internal const int _MaxFields = 41;
        #endregion

        #region Starters
        public frmMain()
        {
            Logger.LogT("Initializing MainForm.");
            InitializeComponent();
            Logger.LogT("MainForm Initialized.");
            Quirks.DeSerialize();
            InitPanels();
            InitAllControls();
            rdoHarvest.Checked = rdoDaily.Checked = true;
            Expense.Reset();
            dtpExpensdOn.Value = DateTime.Now;
            Logger.LogT("Initialization Complete.");
            tmrInvoluntary.Enabled = true;
        }

        private void InitAllControls()
        {
            InitAllStores();
            AllAmounts = InitAllAmounts();
            AllPayments = InitAllCombos();
            InitAllTotals();
        }

        private NumericUpDown[] InitAllAmounts()
        {
            NumericUpDown[] _allAmounts ={ spnGrocks, spnVeggies, spnMilk, spnH2O, spnBreakFast, spnLunch, spnDinner, spnSnacks,
                                         spnCommute, spnJourney, spnCabs, spnFuel, spnMedicine,spnHospital, spnRent, spnDomH2O,
                                         spnEB, spnStrata, spnLoan, spnTelephony, spnDTH, spnInternet, spnNewsPaper, spnMagazine,
                                         spnCinemas, spnTour, spnElectricals, spnElectronics, spnDress, spnApparels, spnUtensils,
                                         spnFurniture, spnFootwear, spnStationery, spnBooks, spnNoteBooks, spnFees, spnInsurance,
                                         spnDeposits, spnMetals, spnHouseEMI };
            Logger.LogT("--Begin Init:  All Amount Spinners--");
            for (int i = 0; i < _allAmounts.Length; i++)
                _allAmounts[i].Value = _allAmounts[i].Minimum;
            Logger.LogT("--End Init:  All Amount Spinners--");
            return _allAmounts;
        }

        private void InitAllStores()
        {
            AllStores = new TextBox[_MaxFields];
            TextBox[] _allStores ={ tbxGrocStore, tbxH2OStore, tbxMilkStore, tbxVegStore, tbxCabs, tbxJourney, tbxHospital, tbxMedicine, tbxTour, tbxCinemas,
                                      tbxFootwear, tbxFurniture, tbxUtensils, tbxApparels, tbxDress, tbxElectronics, tbxElectricals, tbxFees, tbxNoteBooks,
                                      tbxBooks, tbxStationery, tbxMetals, tbxDeposits, tbxInsurance };
            Logger.LogT("--Begin Init:  All Store TextBoxes--");
            for (int i = 0; i < _allStores.Length; i++)
            {
                AllStores[int.Parse(_allStores[i].Tag.ToString())] = _allStores[i];
                _allStores[i].AutoCompleteSource = AutoCompleteSource.CustomSource;
                _allStores[i].AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                _allStores[i].AutoCompleteCustomSource = Quirks.AllStores;
                _allStores[i].Text = string.Empty;
            }
            Logger.LogT("--End Init:  All Store TextBoxes--");
        }

        private void InitAllTotals()
        {
            Label[] _allTotals ={lblGrocks, lblVeggies, lblMilk, lblH2O, lblBreakFast, lblLunch, lblDinner, lblSnacks,
                                         lblCommute, lblJourney, lblCabs, lblFuel, lblMedicine,lblHospital, lblRent, lblDomH2O,
                                         lblEB, lblStrata, lblLoan, lblPhone, lblDTH, lblInternet, lblNewspaper, lblMagazine,
                                         lblCinemas, lblTour, lblElectricals, lblElectronics, lblDress, lblApparels, lblUtensils,
                                         lblFurniture, lblFootwear, lblStationery, lblBooks, lblNoteBooks, lblFees, lblInsurance,
                                         lblDeposits, lblMetals, lblHouseEMI};
            for (int i = 0; i < _allTotals.Length; i++)
            {
                _allTotals[i].Text = Expense.Others[i].ToString("000.00");
            }
        }

        private void InitPanels()
        {
            Logger.LogT("--Begin Init:  All Panels for enabling Adaption Behavior--");
            panels = new Panel[9];
            panels[0] = pnlHarvest;
            panels[1] = pnlEdible;
            panels[2] = pnlNeedles;
            panels[3] = pnlDock;
            panels[4] = pnlUpkeep;
            panels[5] = pnlPeace;
            panels[6] = pnlTrivials;
            panels[7] = pnlBrainiac;
            panels[8] = pnlSeeds;
            for (int i = 0; i < panels.Length; i++)
                panels[i].Hide();
            Logger.LogT("--End Init:  All Panels for enabling Adaption Behavior--");
        }

        private ComboBox[] InitAllCombos()
        {
            ComboBox[] _allPayments ={cbxPayGrocks, cbxPayVeggies, cbxPayMilk, cbxPayH2O, cbxPayBreakFast, cbxPayLunch, cbxPayDinner, cbxPaySnacks,
                                         cbxPayCommute, cbxPayJourney, cbxPayCabs, cbxPayFuel, cbxPayMedicine,cbxPayHospital, cbxPayRent, cbxDomH2O,
                                         cbxPayEB, cbxPayStrata, cbxPayLoan, cbxPayPhone, cbxPayDTH, cbxPayInternet, cbxPayNewsPaper, cbxPayMagazine,
                                         cbxPayCinemas, cbxPayTour, cbxPayElectricals, cbxPayElectronics, cbxPayDress, cbxPayApparels, cbxPayUtensils,
                                         cbxPayFurniture, cbxPayFootWear, cbxPayStationery, cbxPayBooks, cbxPayNoteBooks, cbxPayFees, cbxPayInsurance,
                                         cbxPayDeposits, cbxPayMetals, cbxPayHouseEMI };
            Logger.LogT("--Begin Init:  All PaymentMode ComboBoxes--");
            for(int i=0;i<_allPayments.Length;i++)
            {
                _allPayments[i].SelectedIndex = -1;
                _allPayments[i].Items.Add(PaymentMode.Cash);
                _allPayments[i].Items.Add(PaymentMode.Card);
                _allPayments[i].Items.Add(PaymentMode.MealCoupon);
                _allPayments[i].Items.Add(PaymentMode.Online);
            }
            Logger.LogT("--End Init:  All PaymentMode ComboBoxes--");
            return _allPayments;
        }
        #endregion

        #region Inconsequential
        private void tmrInvoluntary_Tick(object sender, EventArgs e)
        {
            if (_counter++ % 30 == 0)
            {
                tslToday.Text = DateTime.Today.ToString("MM/dd/yyyy");
                _counter = 0;
            }
            tslNow.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void RatUponCat(object sender, EventArgs e)
        {
            RadioButton rdoTmp = (RadioButton)sender;
            rdoTmp.Width += _CatVGrowth;
            rdoTmp.Height += _CatHGrowth;
        }

        private void RatLeftCat(object sender, EventArgs e)
        {
            RadioButton rdoTmp = (RadioButton)sender;
            rdoTmp.Width -= _CatVGrowth;
            rdoTmp.Height -= _CatHGrowth;
        }

        private void RatUponRec(object sender, EventArgs e)
        {
            RadioButton rdoTmp = (RadioButton)sender;
            rdoTmp.Width += _RecVGrowth;
            rdoTmp.Height += _RecHGrowth;
        }

        private void RatLeftRec(object sender, EventArgs e)
        {
            RadioButton rdoTmp = (RadioButton)sender;
            rdoTmp.Width -= 4;
            rdoTmp.Height -= 3;
        }

        private static string GetTypeName()
        {
            return "frmMain";
        }
        #endregion

        private void btnDebug_Click(object sender, EventArgs e)
        {
            //Logger.LogE(Threats.DirNotCreated, "Dummy Test.");
            SaveAllExpenses();
        }

        private void SaveAllExpenses()
        {
            _AdaptToCategory();
            Sky.Preserve(FileFormats.Purpose, AllExpenses);
        }

        #region Recurrence
        private void OnRecurrenceChanged(object sender, EventArgs e)
        {
            RadioButton rdoTmp = ((RadioButton)sender);
            _CurRec = int.Parse(rdoTmp.Tag.ToString());
            _AdaptToRecurrence();
            tslRecurrence.Text = rdoTmp.Text;
        }

        private void _AdaptToRecurrence()
        {
            switch (_CurRec)
            {
                case 0: // Daily
                    rdoHarvest.Visible = rdoEdibles.Visible = rdoDock.Visible = rdoHarvest.Checked = true;
                    rdoNeedles.Visible = rdoUpkeep.Visible = rdoPeace.Visible = rdoTrivia.Visible = rdoBrainiac.Visible = rdoSeeds.Visible = false;
                    break;
                case 1: // Weekly
                    rdoHarvest.Visible = rdoEdibles.Visible = rdoDock.Visible = rdoUpkeep.Visible = rdoPeace.Visible = rdoTrivia.Visible = rdoBrainiac.Visible = rdoSeeds.Visible = false;
                    rdoNeedles.Visible = rdoNeedles.Checked = true;
                    break;
                case 2: // Monthly
                    rdoHarvest.Visible = rdoEdibles.Visible = rdoDock.Visible = rdoNeedles.Visible = rdoPeace.Visible = rdoTrivia.Visible = rdoBrainiac.Visible = false;
                    rdoPeace.Visible = rdoUpkeep.Visible = rdoUpkeep.Checked = true;
                    break;
                case 3: // Annual
                    rdoHarvest.Visible = rdoEdibles.Visible = rdoDock.Visible = rdoNeedles.Visible = rdoPeace.Visible = rdoTrivia.Visible = rdoBrainiac.Visible = rdoUpkeep.Visible = false;
                    rdoSeeds.Visible = rdoSeeds.Checked = true;
                    break;
                case 4: // OneTime
                    rdoHarvest.Visible = rdoEdibles.Visible = rdoDock.Visible = rdoNeedles.Visible = rdoPeace.Visible = rdoSeeds.Visible = rdoUpkeep.Visible = false;
                    rdoTrivia.Checked = rdoTrivia.Visible = rdoBrainiac.Visible = true;
                    break;
            }
        }
        #endregion

        #region Category
        private void OnCategoryChanged(object sender, EventArgs e)
        {
            RadioButton rdoTmp = ((RadioButton)sender);
            if (!rdoTmp.Checked)
            {
                panels[int.Parse(rdoTmp.Tag.ToString())].Hide();
                _AdaptToCategory();
            }
            else
            {
                _CurCat = int.Parse(rdoTmp.Tag.ToString());
                panels[_CurCat].Show();
                tslCategory.Text = rdoTmp.Text;
            }
        }

        private void _AdaptToCategory()
        {
            string _store;
            decimal _amount;
            PaymentMode _pmode;
            int start = 0, end = 0;
            // Handle special cases here.
            switch (_CurCat)
            {
                case 0: // Harvest
                    start = 0;
                    end = 3;
                    break;
                case 1: // Edible
                    start = 4;
                    end = 7;
                    break;
                case 2: // Needles
                    start = 12;
                    end = 13;
                    break;
                case 3: // Dock
                    start = 8;
                    end = 11;
                    break;
                case 4: // Upkeep
                    start = 14;
                    end = 19;
                    break;
                case 5: // Peace
                    start = 20;
                    end = 25;
                    break;
                case 6: // Trivia
                    start = 26;
                    end = 32;
                    break;
                case 7: // Brainiac
                    start = 33;
                    end = 36;
                    break;
                case 8: // Seeds
                    start = 37;
                    end = 40;
                    break;
            }
            for (int i = start; i <= end; i++)
            {
                _amount = AllAmounts[i].Value;
                if (_amount > _MinAmount)
                {
                    _pmode = (PaymentMode)AllPayments[i].SelectedIndex;
                    _store = DoDummyStore(i);
                    if (AllExpenses[i] == null)
                        AllExpenses[i] = new Expense(i);
                    AllExpenses[i].AllThree(_amount, _pmode, _store);
                }
            }
        }

        private string DoDummyStore(int i)
        {
            string _store = null;
            if (AllStores[i] != null)
            {
                if (AllStores[i].Text.Trim().Length < 1)
                    _store = AllStores[i].Text = _DummyStore;
                else
                    _store = AllStores[i].Text.Trim().ToLower();
            }
            if (!Quirks.AllStores.Contains(_store))
            {
                Logger.LogT("Store: {0} is not available in Known Stores list; Adding to it.", _store);
                if (!Quirks.AddStore(_store))
                {
                    Logger.LogE(Threats.StoresLost, "Not able to add store: {0} to known stores list.", _store);
                }
            }
            return _store;
        }
        #endregion

        #region Date
        private void OnDateChanged(object sender, EventArgs e)
        {
            _AdaptToDate();
        }

        private void _AdaptToDate()
        {
            InitAllControls();
            Expense.DateSpentOn = dtpExpensdOn.Value;
            Sky.UpdateExpenseFileName();
            AllExpenses = (Expense[])Sky.Parse(FileFormats.Purpose);
            if (AllExpenses == null)
            {
                Logger.LogE(Threats.GotNull, "Null Expenses returned for Date: {0}; Either no entries or not abl to retrieve.", dtpExpensdOn.Value);
                Sky.Inform("No entries for date selected.");
            }
            else
            {
                for (int i = 0; i < _MaxFields; i++)
                {
                    if (AllExpenses[i] != null)
                    {
                        AllAmounts[i].Value = AllExpenses[i].Amount;
                        AllPayments[i].SelectedIndex = (int)AllExpenses[i].PayMode;
                        if (AllStores[i] != null)
                            AllStores[i].Text = AllExpenses[i].Store;
                    }
                }
            }
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            dtpExpensdOn.Value = dtpExpensdOn.Value.AddMonths(-1);
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            dtpExpensdOn.Value = dtpExpensdOn.Value.AddDays(-1);
        }

        private void btnTomorrow_Click(object sender, EventArgs e)
        {
            dtpExpensdOn.Value = dtpExpensdOn.Value.AddDays(1);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dtpExpensdOn.Value = dtpExpensdOn.Value.AddMonths(1);
        }
        #endregion

        #region EditExpense
		private void OnAmountChanged(object sender, EventArgs e)
        {
            if (AllExpenses == null)
                AllExpenses = new Expense[_MaxFields];
            spnTmp = (NumericUpDown)sender;
            int iFieldNum = int.Parse(spnTmp.Tag.ToString());
            if (AllExpenses[iFieldNum] != null)
            {
                // Handle updation of existing expense here;
                AllExpenses[iFieldNum].Amount = spnTmp.Value;
            }
            else
            {
                // Expense is probably incomplete;
                if (AllStores[iFieldNum] != null)
                {
                    if (AllStores[iFieldNum].Text.Trim().Length < 1)
                        AllStores[iFieldNum].Text = _DummyStore;
                }
                if (AllPayments[iFieldNum].SelectedIndex < 0)
                    AllPayments[iFieldNum].SelectedIndex = 0;
                if (_CurCat == 1)
                {
                    if (iFieldNum == 4)
                        cbxBreakFast.SelectedIndex = 1;
                    else if (iFieldNum == 5)
                        cbxLunch.SelectedIndex = 0;
                    else if (iFieldNum == 6)
                        cbxDinner.SelectedIndex = 1;
                    else if (iFieldNum == 7)
                        cbxSnacks.SelectedIndex = 0;
                }
            }
        }

        private void OnPayModeChanged(object sender, EventArgs e)
        {
            if (AllExpenses == null)
                AllExpenses = new Expense[_MaxFields];
            ComboBox cbxTmpPay = (ComboBox)sender;
            int iFieldNum = int.Parse(spnTmp.Tag.ToString());
            if (AllExpenses[iFieldNum] != null)
            {
                // Handle updation of existing expense here;
                AllExpenses[iFieldNum].PayMode = (PaymentMode)cbxTmpPay.SelectedIndex;
            }
        }

        private void OnStoreChanged(object sender, EventArgs e)
        {
            if (AllExpenses == null)
                AllExpenses = new Expense[_MaxFields];
            TextBox tbxTmpStore = (TextBox)sender;
            int iFieldNum = int.Parse(tbxTmpStore.Tag.ToString());
            if (AllExpenses[iFieldNum] != null)
            {
                AllExpenses[iFieldNum].Store = tbxTmpStore.Text;
            }
        }
        #endregion
    }
}
