using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrX
{
    internal static class Quirks
    {
        static bool bRequiresSave = false;
        static Dictionary<string, string> dPrefs;
        private static System.Windows.Forms.AutoCompleteStringCollection _stores = null;

        static Quirks()
        {
            _stores = (System.Windows.Forms.AutoCompleteStringCollection)Sky.Parse(FileFormats.Stores);
        }

        /// <summary>
        /// Retrieves the value of the mentioned Preference.
        /// </summary>
        /// <param name="sQName">Preference whose value is to be retrieved.</param>
        /// <returns>Value of the mentioned Preference.</returns>
        internal static string Get(string sQName)
        {
            Logger.LogT("Getting Preference for {0}.", sQName);
            return dPrefs[sQName];
        }

        /// <summary>
        /// Sets the value of the mentioned Preference to the mentioned value.
        /// </summary>
        /// <param name="sQName">Preference whose value is to be set.</param>
        /// <param name="sQVal">Value to be set for the Preference.</param>
        internal static void Set(string sQName, string sQVal)
        {
            Logger.LogT("Setting Preference for {0} = {1}.", sQName, sQVal);
            bRequiresSave = true;
            dPrefs[sQName] = sQVal;
        }

        /// <summary>
        /// Serialize the Quirks to FileSystem.
        /// </summary>
        /// <returns>Result of the Serialization: True on success; False otherwise.</returns>
        internal static bool Serialize()
        {
            Logger.LogT("Save all Prefs.");
            if (bRequiresSave)
                return Sky.Preserve(FileFormats.Quirks, dPrefs);
            return true;
        }

        /// <summary>
        /// DeSerializes the Quirks from FileSystem.
        /// </summary>
        /// <returns>Result of the DeSerialization: True on success; False otherwise.</returns>
        internal static bool DeSerialize()
        {
            Logger.LogT("Load all Prefs.");
            dPrefs = (Dictionary<string, string>)Sky.Parse(FileFormats.Quirks);
            if (dPrefs == null)
            {
                Logger.LogE(Threats.NoPrefsLoaded, "Unable to load prefs.");
                return false;
            }
            Logger.LogT("Loading Prefs success.");
            return true;
        }

        internal static string GetTypeName()
        {
            return "prefs";
        }

        public static System.Windows.Forms.AutoCompleteStringCollection AllStores
        {
            get
            {
                return _stores;
            }
            //set
            //{
            //    _stores = value;
            //    Sky.Preserve(FileFormats.Stores, _stores);
            //}
        }

        internal static bool AddStore(string sStore)
        {
            _stores.Add(sStore);
            return Sky.Preserve(FileFormats.Stores, _stores);
        }
    }
}
