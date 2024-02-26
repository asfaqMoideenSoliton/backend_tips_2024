using BoilerControllerConsoleApplication;

namespace BoilerControllerConsole
{
    /// <summary>
    /// Holds, manages the Boiler Controller Operations
    /// </summary>
    public class BoilerController
    {
        private Boiler _boiler;
        private BoilerService _service;
        private LogFileService _logFileService;

        /// <summary>
        /// Initializes a new instance of the <see cref="BoilerController"/> class.
        /// </summary>
        public BoilerController()
        {
            this._boiler = new (false, false);
            this._logFileService = new LogFileService();
            this._service = new BoilerService(this._boiler, this._logFileService);
            this._logFileService.WriteToFile("Boiler Controller Initialzed");
            this._boiler.Status = Boiler.SystemStatus.Lockout;
        }

        /// <summary>
        /// Handles the interlock switch
        /// </summary>
        public void RunInterLockSwitch()
        {
            this._service.DisplaySwitchPositions();

            if (BoilerViews.GetUserConfirmation("To Change Swicth State"))
            {
                this.ToogleInterlock();
            }

            var displayInterLockSwitch = this._boiler.InterLock ? $"Inter Lock Switch toggled to Open" : $"Interlock switch is Closed";

            this._service.DisplaySwitchPositions();

            this._logFileService.WriteToFile(displayInterLockSwitch);
        }

        /// <summary>
        /// Toogle the Interlock Switch
        /// </summary>
        /// <exception cref="Exception">If the Reset swicth is Close</exception>
        public void ToogleInterlock()
        {
            if (!this._boiler.LockoutReset)
            {
                throw new Exception("First Open Reset Lockout Switch");
            }

            this._boiler.InterLock = true;
            this._boiler.Status = Boiler.SystemStatus.Ready;
            this._logFileService.WriteToFile(nameof(Boiler.SystemStatus.Ready));
        }

        /// <summary>
        /// runs reset lockout swicth
        /// </summary>
        public void LockoutReset()
        {
            this._service.DisplaySwitchPositions();

            if (BoilerViews.GetUserConfirmation("To Change Swicth State"))
            {
                this._boiler.LockoutReset = true;
            }

            var displayLockoutResetSwitch = this._boiler.LockoutReset ? $"Lockout Reset Switch toggled to Open" : $"Lockout Reset switch is Closed";

            this._service.DisplaySwitchPositions();

            this._logFileService.WriteToFile(displayLockoutResetSwitch);
        }

        /// <summary>
        /// Shows the Event Log to the User
        /// </summary>
        public void ShowEventLog()
        {
            this._logFileService.ReadFromFile();
        }

        /// <summary>
        /// Starts the boiler sequence
        /// </summary>
        public void StartBoilerSequence()
        {
            if (this._boiler.Status != Boiler.SystemStatus.Ready)
            {
                throw new InvalidOperationException("Boiler not Ready - Please Close Switches to Start Boiler Sequence");
            }

            Console.WriteLine("You're All set to Start the Boiler  Sequence");

            this._service.StartPrePurge();

            this._service.StartIgnition();

            this._boiler.Status = Boiler.SystemStatus.Opeational;

            this._logFileService.WriteToFile(nameof(Boiler.SystemStatus.Opeational));
        }

        /// <summary>
        /// Stops the boiler sequence
        /// </summary>
        public void StopBoilerSequence()
        {
            if (!(this._boiler.Status == Boiler.SystemStatus.Opeational))
            {
                throw new InvalidOperationException("System status is not in Operational Mode");
            }

            this._service.ResetBoiler();
        }

        /// <summary>
        /// Simluate the Errors on the boiler
        /// </summary>
        public void SimulateBoilerErrors()
        {
            if (!(this._boiler.Status == Boiler.SystemStatus.Opeational))
            {
                throw new InvalidOperationException("System status is not in Operational Mode");
            }

            this._service.ResetBoiler();
        }
    }
}