namespace BoilerControllerConsole
{
    /// <summary>
    /// Validates options of Main Menu
    /// </summary>
    public class ConsoleInputValidator
    {
        /// <summary>
        /// Validtaes and Parses User Input to Integer
        /// </summary>
        /// <param name="userInputFormConsole">Users input as string value</param>
        /// <returns>True if its valid</returns>
        public static bool IsOptionValid(string userInputFormConsole)
        {
            int userOption;
            if (string.IsNullOrEmpty(userInputFormConsole))
            {
                throw new ArgumentNullException("Input Should hold some value");
            }
            else if (!int.TryParse(userInputFormConsole, out userOption))
            {
                throw new Exception("Option Should be a Number");
            }

            return true;
        }
    }
}