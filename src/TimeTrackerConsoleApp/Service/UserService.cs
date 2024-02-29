namespace TimeTrackerConsoleApp
{
    /// <summary>
    /// Provides utitlity to user controller
    /// </summary>
    public class UserService
    {
        private readonly int _maxWrongPassword = 3;
        private List<User> _users;
        private int _userId = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        /// <param name="users">list of users</param>
        public UserService(List<User> users)
        {
            this._users = users;
        }

        /// <summary>
        /// Validates the user Credentials
        /// </summary>
        /// <returns>true if valid</returns>
        /// <param name="user">objcet user</param>
        public bool IsUserCredentialsValid(out User user)
        {
            user = this.SearchUserWithUserName(this.GetUsername());
            if (user == null)
            {
                throw new Exception("User name not Found");
            }

            return this.IsValidPassword(user);
        }

        private bool IsValidPassword(User user)
        {
            bool isPasswordValid = user.Password == UserViews.GetStringFromUser("Enter Password");

            if (!isPasswordValid)
            {
                for (int i = this._maxWrongPassword; i > 0 && !isPasswordValid; i--)
                {
                    UserViews.PrintMessage($"Wrong password try again, {i} tries left ");
                    isPasswordValid = user.Password == UserViews.GetStringFromUser("Enter Password");
                }

                throw new Exception("Max wrong password Entries");
            }

            return isPasswordValid;
        }

        /// <summary>
        /// Gets user details
        /// </summary>
        /// <returns>Object of user</returns>
        public User GetUserDetails()
        {
            string name = this.GetNameOfTheUser();
            string userName = this.GetNewUsername();
            string password = this.GetNewPassword();
            int id = this.GenerateUserId();

            return new User(id, name, password, userName);
        }

        /// <summary>
        /// Search the user
        /// </summary>
        /// <param name="userName">username to find</param>
        /// <returns>object containing user name</returns>
        public User SearchUserWithUserName(string userName)
        {
            return this._users.Find(u => u.UserName == userName)!;
        }

        /// <summary>
        /// Gets user name
        /// </summary>
        /// <returns>string user name</returns>
        public string GetUsername()
        {
            string userName;
            while (!UserInpuValidator.IsStringValid(userName = UserViews.GetStringFromUser("Enter Username")))
            {
                UserViews.PrintMessage("Try Again");
            }

            return userName;
        }

        private int GenerateUserId()
        {
            this._userId++;
            return this._userId;
        }

        /// <summary>
        /// Gets password from the user
        /// </summary>
        /// <returns>String of password</returns>
        /// <exception cref="Exception">If password dosen't match</exception>
        private string GetNewPassword()
        {
            string passwordFirstAttempt = UserViews.GetStringFromUser("Enter password");
            while (passwordFirstAttempt != UserViews.GetStringFromUser("Again Enter Password"))
            {
                UserViews.PrintMessage("Passwords Doesn't Match");
            }

            return passwordFirstAttempt;
        }

        private string GetNameOfTheUser()
        {
            string name;
            while (!UserInpuValidator.IsStringValid(name = UserViews.GetStringFromUser("Enter Name")))
            {
                UserViews.PrintMessage("Enter Valid Name");
            }

            return name;
        }

        private string GetNewUsername()
        {
            string newUserName = this.GetUsername();

            while (this._users.Any(p => p.UserName == newUserName))
            {
                UserViews.PrintMessage("Enter Unique User Name");
                newUserName = this.GetUsername();
            }

            return newUserName;
        }
    }
}