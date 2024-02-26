namespace BoilerControllerConsole
{
    /// <summary>
    /// Gets Valid Input from the user
    /// </summary>
    public class BoilerViews
    {
        /// <summary>
        /// gets option to perform from the main menu
        /// </summary>
        /// <returns>Integer value </returns>
        public static int GetOptionFromTheUser()
        {
            string userOption;
            Console.WriteLine("Enter a Operation to Perform.");
            while (!ConsoleInputValidator.IsOptionValid(userOption = Console.ReadLine() !))
            {
                Console.WriteLine("Enter a Valid Option (0 - 5).");
            }

            return int.Parse(userOption);
        }

        /// <summary>
        /// Gets userconfirmation for specific uses cases.
        /// </summary>
        /// <param name="useCaseForConfirmation"> Information to get confirmation</param>
        /// <returns>true if yes, else false</returns>
        public static bool GetUserConfirmation(string useCaseForConfirmation)
        {
            Console.WriteLine($"Press Tab to {useCaseForConfirmation}");
            return Console.ReadKey().Key == ConsoleKey.Tab;
        }
    }
}