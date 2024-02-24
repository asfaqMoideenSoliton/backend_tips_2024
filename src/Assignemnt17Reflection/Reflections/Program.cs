using Reflections;

namespace Assignments
{
    /// <summary>
    /// Initiates the Program Execution
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the Program
        /// </summary>
        private static void Main()
        {
            bool exitFlag = false;
            MainMenuExecutionManager mainMenuExecutionManager = new ();

            while (!exitFlag)
            {
                try
                {
                    exitFlag = mainMenuExecutionManager.ExecuteMainMenu();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}