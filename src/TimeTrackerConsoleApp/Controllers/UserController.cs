using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerConsoleApp
{
    /// <summary>
    /// Controls the Attributes of User
    /// </summary>
    public class UserController
    {
        private List<User> _users;
        private UserService _userSerive;
        private UserLog _userLog;
        private TaskController _taskController;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        public UserController()
        {
            this._users = new List<User>();
            this._userSerive = new UserService(this._users);
            this._userLog = new UserLog();
            this._taskController = new TaskController();
        }

        /// <summary>
        /// Execute Task Controls for Existig User
        /// </summary>
        public void ExecuteTaskControlsForExistingUser()
        {
            if (!this._users.Any())
            {
                throw new Exception("No users were added yet");
            }

            if (this._userSerive.IsUserCredentialsValid(out User user))
            {
                this._taskController.ExecuteTaskController();
            }
        }

        /// <summary>
        /// Add user to the in-memory List
        /// </summary>
        public void AddUser()
        {
            User newUser = this._userSerive.GetUserDetails();

            this._users.Add(newUser);

            // this._userLog.AddToLog(newUser);
            string userNoun = this._users.Count == 1 ? "User was" : "Users were";
            UserViews.PrintMessage($"Totally {this._users.Count()}  {userNoun}  Added");
        }

        /// <summary>
        /// Remove user from the list
        /// </summary>
        public void RemoveUser()
        {
            string userName = this._userSerive.GetUsername();

            User userToBeDeleted = this._userSerive.SearchUserWithUserName(userName);

            if (UserViews.GetConfirmation($"Remove User with {userToBeDeleted.Name} and {userToBeDeleted.Id}"))
            {
                this._users.Remove(userToBeDeleted);
                this._userLog.RemoveFromLog(userToBeDeleted);
                UserViews.PrintMessage($"User With {userToBeDeleted.Name} Removed Succesfully");
                return;
            }

            UserViews.PrintMessage("Removal Operation Cancelled");
        }

        /// <summary>
        /// Updates the user details
        /// </summary>
        public void UpdateUser()
        {
            string userName = this._userSerive.GetUsername();

            User userToBeUpdated = this._userSerive.SearchUserWithUserName(userName);

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
