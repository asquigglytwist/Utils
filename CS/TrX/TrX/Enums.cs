namespace TrX
{
    /// <summary>
    /// Enumerating known FileFormats.
    /// </summary>
    enum FileFormats
    {
        /// <summary>
        /// Quirks - Preferences FileFormat.
        /// </summary>
        Quirks,
        /// <summary>
        /// Timber - Log FileFormat.
        /// </summary>
        Timber,
        /// <summary>
        /// Stores - List of all known Stores (for AutoComplete list).
        /// </summary>
        Stores,
        /// <summary>
        /// Purpose - The very Purpose of this Application (Expenses).
        /// </summary>
        Purpose
    }
    /// <summary>
    /// Enumerating valid PaymentModes for an Expense.
    /// </summary>
    enum PaymentMode
    {
        /// <summary>
        /// Paid by Cash.
        /// </summary>
        Cash,
        /// <summary>
        /// Paid using Credit / Debit cards.
        /// </summary>
        Card,
        /// <summary>
        /// Paid using Meal Coupons (like Sodexo).
        /// </summary>
        MealCoupon,
        /// <summary>
        /// Paid online (NetBanking / other means).
        /// </summary>
        Online
    }
    /// <summary>
    /// Enumerating supported Recurrences.
    /// </summary>
    enum Recurrence
    {
        Annual,
        Monthly,
        Weekly,
        Daily,
        OneTime
    }
}