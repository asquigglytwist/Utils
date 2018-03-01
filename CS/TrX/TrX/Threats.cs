namespace TrX
{
    enum Threats
    {
        /// <summary>
        /// Unable to create Directory.
        /// </summary>
        DirNotCreated,
        /// <summary>
        /// Either Directory doesn't exist or is not accessible.
        /// </summary>
        DirNotFound,
        /// <summary>
        /// Unable to copy File.
        /// </summary>
        FileNotCopied,
        /// <summary>
        /// Either File doesn't exist or is not accessible.
        /// </summary>
        FileNotFound,
        /// <summary>
        /// Not able to load Preferences.
        /// </summary>
        NoPrefsLoaded,
        /// <summary>
        /// Preferences File is not understandable.
        /// </summary>
        PrefsCorrupted,
        /// <summary>
        /// Unable to save Preferences to File; Any changes done were lost.
        /// </summary>
        PrefsLost,
        /// <summary>
        /// Unknown FileFormat passed.
        /// </summary>
        UnknownType,
        /// <summary>
        /// Not able to save StoresList to File; Any changes done were lost.
        /// </summary>
        StoresLost,
        /// <summary>
        /// Not able to save Expenses to File; Any changes done were lost.
        /// </summary>
        ExpensesLost,
        /// <summary>
        /// Expenses File is not understandable.
        /// </summary>
        ExpenseCorrupted,
        /// <summary>
        /// Date passed is invalid.
        /// </summary>
        DateNotValid,
        /// <summary>
        /// Null value returned.
        /// </summary>
        GotNull,
        /// <summary>
        /// StoresList File is not understandable.
        /// </summary>
        StoresCorrupted,
        /// <summary>
        /// No Expenses for the mentioned date.
        /// </summary>
        NoExp4Date
    }
}