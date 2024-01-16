namespace Assignments
{
    /// <summary>
    /// Manipulates and stores the objects as list declared in this class
    /// </summary>
    public class IncomeTracker
    {
        private List<FinanceManager> _incomes = new List<FinanceManager>();
        /// <summary>
        /// A method wthout any return, initialises elenst in the income list
        /// </summary>
        public void AddIncome()
        {
            bool temp;
            double newIncome;

            do
            {
                Console.WriteLine("Enter Income (Type - Double)");
                string tempIncome = Console.ReadLine();
                temp = double.TryParse(tempIncome, out newIncome);
            }
            while (temp != true);
            Console.WriteLine("Enter Category");
            string incomeCategory = Console.ReadLine();
            Console.WriteLine("Enter Date");
            string date = Console.ReadLine();
            Console.WriteLine("Enter notes if any ");
            string notes = Console.ReadLine();

            Console.WriteLine("Income Added");
            FinanceManager incometracker = new FinanceManager
            {
                Amount = newIncome,
                Category = incomeCategory,
                Date = date,
                Notes = notes
            };
            _incomes.Add(incometracker );
            Console.WriteLine("[A]dd another Income or [M]enu");
            string option = Console.ReadLine();
            if (option == "A" || option == "a")
            {
                AddIncome();
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Redirecing to Menu");
            }
        }
        /// <summary>
        /// Method inside this calss to prints incomes
        /// </summary>
        public void ViewIncome()
        {
            Console.WriteLine("Income");
            {
                if (_incomes.Count > 0)
                {
                    Console.WriteLine("History of Incomes");
                    foreach (var incomes in _incomes)
                    {
                       // Console.WriteLine("P" + "\t" + "Product ID" + "\t" + "Product Price" + "Available Quantity");
                        Console.WriteLine(incomes.Amount+ "\t" + incomes.Category + "\t" + incomes.Date + "\t" + incomes.Notes);
                    }
                }
                else
                {
                    Console.WriteLine("No Incomes History");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Redirecing to Menu");
                }
            }
        }
    }
}