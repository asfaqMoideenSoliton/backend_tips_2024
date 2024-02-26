using System.Net.Http.Headers;

namespace BoilerControllerConsole
{
    /// <summary>
    /// Initiates the Program Execution
    /// </summary>
    public class Program
    {
         /// <summary>
         /// Entfry point of the Program
         /// </summary>
        private static void Main()
        {
            bool exitFlag = false;
            MainMenuOperationsManager operationsManager = new ();

            while (!exitFlag)
            {
                try
                {
                    exitFlag = operationsManager.ExecuteMainMenu();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}