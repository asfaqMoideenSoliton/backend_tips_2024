namespace Assignments
{
    /// <summary>
    /// Internal Class Program
    /// </summary>
    internal partial class Program
    {
        private static FinanceTracker _incometracker = new FinanceTracker();

        private static void Main(string[] args)
        {
            string option;
            Console.WriteLine("\t\tWelcome to Expense Tracker");
            do
            {
                Console.WriteLine("----------------------------------------------------------\n");
                Console.WriteLine("Please find the list of operations offered below:");
                Console.WriteLine("1. Add an expense \n2. Add an Income \n3. Show History\n4. Edit a Income/Expense\n5. Show Financial Summary \n6. Delete Income/Expense\n Q - Exit application\n");
                Console.Write("Choose one of the above listed option to proceed: ) ");
                option = Console.ReadLine();
                PerformOperation(option);
            }
            while (option != "q" && option != "Q");
        }

        private static void PerformOperation(string option)
        {
            switch (option)
            {
                case "1":
                    _incometracker.AddExpense();
                    break;
                case "2":
                    _incometracker.AddIncome();
                    break;

                case "3":
                    _incometracker.ShowRecord();
                    break;
                case "4":
                    _incometracker.EditRecord();
                    break;
                case "5":
                    _incometracker.GenerateFinancialSummary();
                    break;
                case "6":
                    _incometracker.DeleteRecord();
                    break;
            }
        }
    }
}