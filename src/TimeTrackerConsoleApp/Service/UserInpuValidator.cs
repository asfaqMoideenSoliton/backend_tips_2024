namespace TimeTrackerConsoleApp
{
    /// <summary>
    /// Validates the user input
    /// </summary>
    public class UserInpuValidator
    {
        /// <summary>
        /// Checks whether the string empty or contains digit
        /// </summary>
        /// <param name="stringToValidate">string to valid</param>
        /// <returns>True if valid</returns>
        public static bool IsStringValid(string stringToValidate)
        {
            if (string.IsNullOrEmpty(stringToValidate))
            {
                UserViews.PrintMessage("Value Should not be empty");
                return false;
            }
            else if (stringToValidate.Any(char.IsDigit))
            {
                UserViews.PrintMessage("Should not conatain digits");
                return false;
            }

            return true;
        }

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