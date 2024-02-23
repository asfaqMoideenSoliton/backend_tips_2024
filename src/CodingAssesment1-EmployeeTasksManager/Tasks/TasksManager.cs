using ConsoleTables;

namespace CodingAssesment1
{
    /// <summary>
    ///  manipulates and manages  Class Tasks
    /// </summary>
    internal class TasksManager
    {
        private List<Tasks> _tasks;
        private TaskIOConsole _taskConsole;

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksManager"/> class.
        /// </summary>
        public TasksManager()
        {
            this._tasks = new List<Tasks>();
            this._taskConsole = new TaskIOConsole();
        }

        private enum Option
        {
            Add = 1,
            View,
            Remove,
        }

        /// <summary>
        /// to acces the list outside
        /// </summary>
        /// <returns>the list of tasks</returns>
        public List<Tasks> GetTasks()
        {
            return this._tasks;
        }

        /// <summary>
        /// Method to Add tasks
        /// </summary>
        public void AddTask()
        {
            bool isAddAnothertask = true;
            while (isAddAnothertask)
            {
                Tasks tasks = this.GetTaskDetails();
                this._tasks.Add(tasks);
                isAddAnothertask = this._taskConsole.IsAddAnother("Task");
            }
        }

        /// <summary>
        /// Removes tasks from the list
        /// </summary>
        public void RemoveTask()
        {
            string taskName = this._taskConsole.GetTaskName();
            Tasks searchResult = this.SearchTasksFromTheList(taskName);
            this._tasks.Remove(searchResult);
            Console.WriteLine($"Task {taskName} Deleted");
        }

        /// <summary>
        /// Traverse through the list and returns task reference
        /// </summary>
        /// <param name="taskName"> Task name</param>
        /// <returns>object of task</returns>
        public Tasks SearchTasksFromTheList(string taskName)
        {
            if (this._tasks != null)
            {
                foreach (Tasks tasks in this._tasks)
                {
                    if (tasks.Name.ToLower() == taskName.ToLower())
                    {
                        return tasks;
                    }
                }
            }

            throw new Exception("Task Not found");
        }

        /// <summary>
        /// Shows all the Tasks
        /// </summary>
        public void ViewAllTasks()
        {
            if (this._tasks.Any())
            {
                var tasksTable = new ConsoleTable("Task Name", "Required Skills", "Deadline in Days ", "Required Hours to Complete");
                foreach (Tasks tasks in this._tasks)
                {
                    tasksTable.AddRow(tasks.Name, tasks.RequiredSkill, tasks.DeadlineInDays, tasks.RequiredHours);
                }

                tasksTable.Write(Format.MarkDown);
            }
        }

        /// <summary>
        /// Executes the task mamanger
        /// </summary>
        public void ExecuteTasksmanager()
        {
            Console.WriteLine("Choose any Operation\n1.AddTask\n2.ViewAllTasks\n3.RemoveTasks");
            bool isOptionInt = int.TryParse(Console.ReadLine(), out int option);

            Option userOption = (Option)option;

            switch (userOption)
            {
                case Option.Add:
                    this.AddTask();
                    break;
                case Option.Remove:
                    this.RemoveTask();
                    break;
                case Option.View:
                    this.ViewAllTasks();
                    break;
                default:
                    Console.WriteLine("Enter Valid Opton");
                    break;
            }
        }

        private Tasks GetTaskDetails()
        {
            string taskName = this._taskConsole.GetTaskName();
            string taskDescription = this._taskConsole.GetTaskDescription();
            double requiredHours = this._taskConsole.GetTasksRequiredHours();
            DateTime taskDeadline = this._taskConsole.GetTaskDeadline();
            string requiredSkill = this._taskConsole.GetTaskRequiredSkills();
            Tasks tasks = new Tasks(taskName, requiredHours, taskDeadline, requiredSkill, taskDescription);
            return tasks;
        }
    }
}
