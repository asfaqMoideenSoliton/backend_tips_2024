namespace Assignments
{/// <summary>
/// Entity class to stores and access Expense entity
/// </summary>
        public class ExpenseEntity
        {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseEntity"/> class.
        /// </summary>
        /// <param name="amount">Income or Expense amount</param>
        /// <param name="category">source or category</param>
        /// <param name="createdAt">Date of the transction</param>
        /// <param name="updatedAt">any further notes if applicable</param>
        public ExpenseEntity(double amount, string category, DateTime createdAt, DateTime updatedAt)
        {
            this.Amount = amount;
            this.Category = category;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or sets /Gets or sets asda
        /// </summary>
        /// <value>
        /// Income Amoungt
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets odskfls
        /// </summary>
        /// <value>
        /// expense amount
        /// </value>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets expense date when created
        /// </summary>
        /// <value>
        /// date of the expense
        /// </value>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets when edited
        /// </summary>
        /// <value>
        /// date of update expense
        /// </value>
        public DateTime UpdatedAt { get; set; }
        }
}
