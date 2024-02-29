namespace TimeTrackerConsoleApp.Controllers
{
    /// <summary>
    /// Front Panel Controller
    /// </summary>
    public class UserFrontPanelController
    {
        private UserController _userController;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFrontPanelController"/> class.
        /// </summary>
        public UserFrontPanelController()
        {
            this._userController = new UserController();
        }

        private enum FrontPanelOptions
        {
            Quit,
            SignIn,
            SignUp,
        }

        /// <summary>
        /// Executes the front panel operations
        /// </summary>
        /// <returns>true if user press quit</returns>
        public bool ExecuteFrontPanel()
        {
            this.ShowFrontPanelMenu();

            int userOption = UserViews.GetOptionFromTheUser();

            FrontPanelOptions operationToPerform = (FrontPanelOptions)userOption;

            switch (operationToPerform)
            {
                case FrontPanelOptions.SignIn:
                    this._userController.ExecuteTaskControlsForExistingUser();
                    break;
                case FrontPanelOptions.SignUp:
                    this._userController.AddUser();
                    break;
                case FrontPanelOptions.Quit:
                    return true;
            }

            return false;
        }

        private void ShowFrontPanelMenu()
        {
            Console.WriteLine("1." + FrontPanelOptions.SignIn);
            Console.WriteLine("2." + FrontPanelOptions.SignUp);
            Console.WriteLine("0." + FrontPanelOptions.Quit);
        }
    }
}
