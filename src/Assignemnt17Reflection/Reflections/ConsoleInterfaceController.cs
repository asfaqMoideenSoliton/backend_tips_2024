namespace Reflections
{
    /// <summary>
    /// Gets user opton form the user
    /// </summary>
    public class ConsoleInterfaceController
    {
        /// <summary>
        /// Gets user option for menu
        /// </summary>
        /// <returns>Integer Value</returns>
        public static int GetOptionFromTheUser()
        {
            int optionToPerform;
            Console.WriteLine("Enter a Operation to Perform");
            while (!int.TryParse(Console.ReadLine(), out optionToPerform))
            {
                Console.WriteLine("Enter Valid Option");
            }

            return optionToPerform;
        }

        /// <summary>
        /// Gets and validates the string input from the user
        /// </summary>
        /// <param name="useCase">Usecase when the function is called </param>
        /// <returns>valid string </returns>
        public static string GetStringFromTheUser(string useCase)
        {
            Console.WriteLine($"Enter value to {useCase}");
            string userInput;
            userInput = Console.ReadLine() !;
            while (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Should not be Empty");
                userInput = Console.ReadLine() !;
            }

            return userInput;
        }
    }
}
