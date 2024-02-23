namespace CodingAssesment1
{
    /// <summary>
    /// Initiates the Program
    /// </summary>
    internal class Program
    {
        private enum Option
        {
            Quit,
            EmployeeManager,
            TasksManager,
            Schedule,
            ShowLogs,
        }

        private static void Main()
        {
            bool exitFlag = false;
            TasksManager tasksManager = new TasksManager();
            EmployeeManager employeeManager = new EmployeeManager();
            ScheduleTasks scheduleTasks = new ScheduleTasks(tasksManager, employeeManager);

            while (!exitFlag)
            {
                Console.WriteLine("Welcome to Employee Tasks Manager");

                Console.WriteLine("Choose any option to proceed\n1.Manage Employee\n2.ManageTasks\n3.Run Schedule Task\n4.Show Log\n0.Quit");
                bool isOptionInt = int.TryParse(Console.ReadLine(), out int option);
                Option userOption = (Option)option;

                try
                {
                  exitFlag = ExecuteEmployeeTaskManager(tasksManager, employeeManager, scheduleTasks, userOption);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private static bool ExecuteEmployeeTaskManager(TasksManager tasksManager, EmployeeManager employeeManager, ScheduleTasks scheduleTasks, Option userOption)
        {
            switch (userOption)
            {
                case Option.EmployeeManager:
                    employeeManager.ExecuteEmployeemanager();
                    break;
                case Option.TasksManager:
                    tasksManager.ExecuteTasksmanager();
                    break;
                case Option.Schedule:
                    scheduleTasks.AssignTheTaskToEmployee();
                    break;
                case Option.ShowLogs:
                    scheduleTasks.ShowLog();
                    break;
                case Option.Quit:
                    return true;
                default:
                    break;
            }

            return false;
        }
    }
}