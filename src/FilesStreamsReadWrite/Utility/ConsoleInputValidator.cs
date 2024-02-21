namespace FilesStreamsReadWrite
{
    /// <summary>
    /// Console Input Validator
    /// </summary>
    public class ConsoleInputValidator
    {
        /// <summary>
        /// validates user input
        /// </summary>
        /// <param name="optionInput">string input form the user</param>
        /// <param name="option">Valid integer output</param>
        /// <returns>True if The input is valid</returns>
        public static bool IsOptionInputValid(string optionInput, out int option)
        {
            if (string.IsNullOrEmpty(optionInput))
            {
                throw new Exception("Option sould not be empty");
            }
            else if (!int.TryParse(optionInput, out option))
            {
                throw new Exception("Should be a Number");
            }

            return true;
        }
    }
}
