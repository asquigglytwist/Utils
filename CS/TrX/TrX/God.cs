using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrX
{
    static class God
    {
        static char[] Encoding;
        static int BaseYear;

        static God()
        {
            Logger.LogD("If you're religious, please ignore this line.  Now, initializing God.");
            string extras = "1234567890!@#$%&*+-/_";
            StringBuilder temp1 = new StringBuilder();
            StringBuilder temp2 = new StringBuilder();
            int diff = 32;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                temp1.Append(i);
                temp2.Append((char)(i + diff));
            }
            temp1.Append(temp2);
            temp1.Append(extras);
            Encoding= temp1.ToString().ToCharArray();
            BaseYear = int.Parse(Quirks.Get("BaseYear"));
        }

        /// <summary>
        /// Generate the UniqueID value that is used by all classes in the namespace.  The ID is an encoded string form of the current value of DateTime.Now object.
        /// The six character encoding format is as below:
        /// 0 = Year - BaseYear [2012 by default]
        /// 1 = Month - 1
        /// 2 = Day - 1
        /// 3 = Hour [00 to 23]
        /// 4 = Minute [00 to 59]
        /// 5 = Second [00 to 59]
        /// </summary>
        internal static string ID
        {
            get
            {
                DateTime _now = DateTime.Now;
                StringBuilder _uid = new StringBuilder(6);
                _uid.Append(Encoding[_now.Year - BaseYear]).Append(Encoding[_now.Month - 1]).Append(Encoding[_now.Day - 1]);
                //_uid.Append(Encoding[_now.Hour]).Append(Encoding[_now.Minute]).Append(Encoding[_now.Second]);
                return _uid.ToString();
            }
        }
    }
}
