using System.Threading.Tasks;
using TimeTrackerConsoleApp.Service;

namespace TimeTrackerConsoleApp
{
    /// <summary>
    /// Conrols the task attributes
    /// </summary>
    public class TaskController
    {
        private List<Tasks> _tasks;
        private TaskService _taskService;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskController"/> class.
        /// </summary>
        public TaskController()
        {
            this._tasks = new List<Tasks>();
            this._taskService = new TaskService();
        }

        /// <summary>
        /// Adds a new task
        /// </summary>
        public void AddNewTask()
        {
            Tasks newTask = this._taskService.GetTaskDetails();

            this._tasks.Add(newTask);

            // this._userLog.AddToLog(newUser);
            string taskNoun = this._tasks.Count == 1 ? "task was" : "tasks were";
            UserViews.PrintMessage($"Totally {this._tasks.Count()}  {taskNoun}  Added");
        }

        /// <summary>
        /// Remove user from the list
        /// </summary>
        public void RemoveTask()
        {
            string userName = this._taskService.GetTaskName();

            Tasks taskToBeDeleted = this._taskService.SearchUserWithUserName(userName);

            if (UserViews.GetConfirmation($"Remove User with {userToBeDeleted.Name} and {userToBeDeleted.Id}"))
            {
                this._tasks.Remove(userToBeDeleted);
                this._userLog.RemoveFromLog(userToBeDeleted);
                UserViews.PrintMessage($"User With {userToBeDeleted.Name} Removed Succesfully");
                return;
            }

            UserViews.PrintMessage("Removal Operation Cancelled");
        }

        /// <summary>
        /// Updates the user details
        /// </summary>
        public void UpdateTask()
        {
            string userName = this._taskService.GetTaskName();

            User userToBeUpdated = this._taskService.SearchUserWithUserName(userName);

            if (UserViews.GetConfirmation($"Edit User with {userToBeUpdated.Name} and {userToBeUpdated.Id}"))
            {
                // Logic goes here
                UserViews.PrintMessage($"User With {userToBeUpdated.Name} Edited Succesfully");
                return;
            }

            UserViews.PrintMessage("User Updation Operation Cancelled");
        }
    }
}