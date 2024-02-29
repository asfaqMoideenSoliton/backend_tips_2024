namespace TimeTrackerConsoleApp
{
    /// <summary>
    /// User interface for User controls
    /// </summary>
    public class UserViews
    {
        /// <summary>
        /// Get user confirmation to procced with critical user operations
        /// </summary>
        /// <param name="useCaseToGetConfirmation">Interpoled String </param>
        /// <returns>true if user press tab</returns>
        public static bool GetConfirmation(string useCaseToGetConfirmation)
        {
            Console.WriteLine($"Press Tab to Confirm {useCaseToGetConfirmation}");
            return Console.ReadKey().Key == ConsoleKey.Tab;
        }

        /// <summary>
        /// Gets string from user
        /// </summary>
        /// <param name="useCase">Usecase to get string</param>
        /// <returns>string</returns>
        public static string GetStringFromUser(string useCase)
        {
            Console.Write(useCase + " :");
            return Console.ReadLine() !;
        }

        /// <summary>
        /// gets option to perform from the main menu
        /// </summary>
        /// <returns>Integer value </returns>
        public static int GetOptionFromTheUser()
        {
            string userOption;
            Console.WriteLine("Enter a Operation to Perform.");
            while (!UserInpuValidator.IsOptionValid(userOption = Console.ReadLine()!))
            {
                Console.WriteLine("Enter a Valid Option as Number");
            }

            return int.Parse(userOption);
        }

        /// <summary>
        /// Prints the message to the user
        /// </summary>
        /// <param name="stringToDisplayed">stringToDisplayed</param>
        internal static void PrintMessage(string stringToDisplayed)
        {
            Console.WriteLine(stringToDisplayed);
        }
    }
}