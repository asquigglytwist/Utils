using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrX
{
    class Expense
    {
        #region Non-Static
        private string _sUID, _sStore;
        private decimal _iAmount;
        private PaymentMode _pPayMode;

        internal Expense(int iFieldNum)
        {
            _sUID = iFieldNum.ToString("00") + God.ID;
            DateSpentOn = DateTime.Now;
        }
        internal void AllThree(decimal amount, PaymentMode paymode, string store)
        {
            _sStore = store;
            _iAmount = amount;
            _pPayMode = paymode;
        }

        internal string UID
        {
            get
            {
                return _sUID;
            }
            set
            {
                _sUID = value;
            }
        }
        internal string Store
        {
            get
            {
                return _sStore;
            }
            set
            {
                _sStore = value;
            }
        }
        internal decimal Amount
        {
            get
            {
                return _iAmount;
            }
            set
            {
                _iAmount = value;
            }
        }
        internal PaymentMode PayMode
        {
            get
            {
                return _pPayMode;
            }
            set
            {
                _pPayMode = value;
            }
        } 
        #endregion

        #region Static
        internal static DateTime DateSpentOn;
        internal static Decimal[] Others = new Decimal[frmMain._MaxFields];
        internal static void Reset()
        {
            for (int i = 0; i < Others.Length; i++)
                Others[i] = decimal.Zero;
        } 
        #endregion
    }
}
