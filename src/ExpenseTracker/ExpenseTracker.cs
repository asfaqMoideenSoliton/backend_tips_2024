namespace Assignments
{/// <summary>
/// Manipulates and stores the objects in the list declared in this class
/// </summary>
    internal class ExpenseTracker
    {
        private List<FinanceManager> _expense = new List<FinanceManager>();

        /// <summary>
        /// This is the Method to Add a Expense
        /// </summary>
        public void AddExpense()
        {
            bool temp;
            double newExpense;

            do
            {
                Console.WriteLine("Enter Expense (Type - Double)");
                string tempExpense = Console.ReadLine();
                temp = double.TryParse(tempExpense, out newExpense);
            }
            while (temp != true);
            Console.WriteLine("Enter Category");
            string expenseCategory = Console.ReadLine();
            Console.WriteLine("Enter Date");
            string date = Console.ReadLine();
            Console.WriteLine("Enter notes if any ");
            string notes = Console.ReadLine();

            Console.WriteLine("Expense Added");
            FinanceManager expensetracker = new FinanceManager
            {
                Amount = newExpense,
                Category = expenseCategory,
                Date = date,
                Notes = notes,
            };
            this._expense.Add(expensetracker);
            Console.WriteLine("[A]dd another Expense or [M]enu");
            string? option = Console.ReadLine();
            if (option == "A" || option == "a")
            {
                AddExpense();
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Redirecing to Menu");
            }
        }

        /// <summary>
        /// This is the Method to View All Expenses
        /// </summary>
        public void ViewExpense()
        {
            Console.WriteLine("Loading Expenses");
            {
                if (this._expense.Count > 0)
                {
                    Console.WriteLine("History of Expense");
                    foreach (var expense in this._expense)
                    {
                        Console.WriteLine("Expense Amouny" + "\t" + "Category" + "\t" + "Expended Date" + "Notes");
                        Console.WriteLine(expense.Amount + "\t" + expense.Category + "\t" + expense.Date + "\t" + expense.Notes);
                    }
                }
                else
                {
                    Console.WriteLine("No Expense History");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Redirecing to Menu");
                }
            }
        }
    }
}