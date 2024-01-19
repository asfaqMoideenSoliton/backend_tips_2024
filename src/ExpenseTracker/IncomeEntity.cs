namespace Assignments
{/// <summary>
/// Entity class to store income fields
/// </summary>
        public class IncomeEntity
        {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeEntity"/> class.
        /// </summary>
        /// <param name="amount">Income Amount</param>
        /// <param name="source">Income source</param>
        /// <param name="createdAt">created date</param>
        /// <param name="updatedAt">updated date</param>
        public IncomeEntity(double amount, string source, DateTime createdAt, DateTime updatedAt)
        {
            this.Amount = amount;
            this.Source = source;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or sets Income Amount
        /// </summary>
        /// <value>
        /// Income Amount
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets Income Source
        /// </summary>
        /// <value>
        /// expense amount
        /// </value>
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets Income Created date
        /// </summary>
        /// <value>
        /// date of the income or expense
        /// </value>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets updated date
        /// </summary>
        /// <value>
        /// Stores the value of updated date
        /// </value>
        public DateTime UpdatedAt { get; set; }
        }
}
