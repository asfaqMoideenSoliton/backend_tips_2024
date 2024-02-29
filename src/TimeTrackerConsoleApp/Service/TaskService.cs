using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerConsoleApp.Service
{
    /// <summary>
    /// Supports the Task Controller
    /// </summary>
    public class TaskService
    {
        private int _taskId = 0;
        private List<Tasks> _tasks;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskService"/> class.
        /// </summary>
        /// <param name="tasks">tasks</param>
        public TaskService(List<Tasks> tasks)
        {
            this._tasks = tasks;
        }

        /// <summary>
        /// Gets user details
        /// </summary>
        /// <returns>Object of user</returns>
        public Tasks GetTaskDetails()
        {
            string name = this.GetTaskName();
            string category = this.GetTaskCategory();
            int id = this.GenerateTaskId();

            return new Tasks(id, name, category);
        }

        /// <summary>
        /// Search the user
        /// </summary>
        /// <param name="taskId">username to find</param>
        /// <returns>object containing taskid</returns>
        public Tasks SearchUserWithUserName(int taskId)
        {
            return this._tasks.Find(t => t.Id == taskId) !;
        }

        private int GenerateTaskId() 
        {
            return this._taskId++;
        }

        private string GetTaskName()
        {
            string taskName;
            while (!UserInpuValidator.IsStringValid(taskName = UserViews.GetStringFromUser("Enter Task Name")))
            {
                UserViews.PrintMessage("Enter Valid Task Name");
            }

            return taskName;
        }

        private string GetTaskCategory()
        {
            string newUserName = this.GetTaskName();

            while (this._users.Any(p => p.UserName == newUserName))
            {
                UserViews.PrintMessage("Enter Unique User Name");
                newUserName = this.GetTaskName();
            }

            return newUserName;
        }
    }
}
