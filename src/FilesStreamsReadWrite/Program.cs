using System.Collections.Generic;
using System.Diagnostics;
using FilesStreamsReadWrite;

namespace Assignments
{
    /// <summary>
    /// Initiates the program execution
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the program
        /// </summary>
        private static async Task Main()
        {
            MainMenuExecutionManager mainMenu = new ();
            Console.WriteLine("File Stream Manager");
            try
            {
                await mainMenu.ExecuteMainMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}