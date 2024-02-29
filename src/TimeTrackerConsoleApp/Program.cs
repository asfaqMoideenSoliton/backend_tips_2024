using TimeTrackerConsoleApp.Controllers;

namespace Assignments
{
    /// <summary>
    /// Initiates the Program Execution
    /// </summary>
    public class Program
    {
        private static void Main()
        {
            bool exitFlag = false;
            UserFrontPanelController userFrontPanelController = new ();

            while (!exitFlag)
            {
                try
                {
                    exitFlag = userFrontPanelController.ExecuteFrontPanel();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}