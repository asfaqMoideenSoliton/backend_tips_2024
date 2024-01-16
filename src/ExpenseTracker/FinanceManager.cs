namespace Assignments
{/// <summary>
/// Manipulates and shows the properties of this class and accesible to get and set from other classes
/// </summary>  
        public class FinanceManager
        {
        /// <summary>
        /// Gets or sets Ampount as string
        /// </summary>
        /// <value>
        /// Income Amoungt
        /// </value>
        public double Amount { get; set; }
        /// <summary>
        /// Gets or sets category as list
        /// </summary>
        /// <value>
        /// expense amount
        /// </value>
        public string Category { get; set; }
        /// <summary>
        /// Gets or sets date as string
        /// </summary>
        /// <value>
        /// date of the income
        /// </value>
        public string Date { get; set; }
        /// <summary>
        /// Gets or sets notes as strings
        /// </summary>
        /// <value>
        /// notes
        /// </value>
        public string Notes { get; set; }
        }
}
