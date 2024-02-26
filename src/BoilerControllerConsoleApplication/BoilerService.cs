namespace BoilerControllerConsoleApplication
{
    /// <summary>
    /// Holds, Constrols the Timer Operations
    /// </summary>
    public class BoilerService
    {
        private int _invokeCount = 0;
        private int _maxCount = 10;
        private Boiler _boiler;
        private LogFileService _logFileService;

        /// <summary>
        /// Initializes a new instance of the <see cref="BoilerService"/> class.
        /// </summary>
        /// <param name="boiler">Boiler</param>
        /// <param name="logFileService">Log file service</param>
        public BoilerService(Boiler boiler, LogFileService logFileService)
        {
            this._boiler = boiler;
            this._logFileService = logFileService;
        }

        /// <summary>
        /// Displays the Switch Positions
        /// </summary>
        public void DisplaySwitchPositions()
        {
            var displayInterLockSwitch = this._boiler.InterLock ? $"Inter Lock Switch is Open" : $"Interlock switch is Closed";
            Console.WriteLine(displayInterLockSwitch);
            var displayLockoutResetSwitch = this._boiler.LockoutReset ? $"Lockout Reset Switch is Open" : $"Lockout Reset switch is Closed";
            Console.WriteLine(displayLockoutResetSwitch);
        }

        /// <summary>
        /// Starts the Ignition Procces
        /// </summary>
        public void StartIgnition()
        {
            this._boiler.Status = Boiler.SystemStatus.Ingnition;
            this._logFileService.WriteToFile("Ignition Started");
            this.RunTimer();
            this._logFileService.WriteToFile("Ignition Completed");
        }

        /// <summary>
        /// Starts the pre-purge
        /// </summary>
        public void StartPrePurge()
        {
            this._boiler.Status = Boiler.SystemStatus.PrePurge;
            this._logFileService.WriteToFile("Pre-Purge Started");
            this.RunTimer();
            this._logFileService.WriteToFile("Pre-Purge Completed");
        }

        /// <summary>
        /// Resest the Boiler
        /// </summary>
        public void ResetBoiler()
        {
            this._boiler.Status = Boiler.SystemStatus.Lockout;
            this._logFileService.WriteToFile(nameof(Boiler.SystemStatus.Lockout));
            this._boiler.LockoutReset = false;
            this._boiler.InterLock = false;
        }

        /// <summary>
        /// Starts the run timer
        /// </summary>
        public void RunTimer()
        {
            var autoEvent = new AutoResetEvent(false);

            Console.WriteLine($"{DateTime.Now} Starting{this._boiler.Status}.\n");

            var stateTimer = new Timer(this.TimerStatus !, autoEvent, 1000, 250);

            autoEvent.WaitOne();
            stateTimer.Dispose();
        }

        private void TimerStatus(object stateInfo)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;
            Console.WriteLine($"{DateTime.Now}, {this._boiler.Status}, {(++this._invokeCount).ToString()}");

            if (this._invokeCount == this._maxCount)
            {
                this._invokeCount = 0;
                autoEvent.Set();
            }
        }
    }
}
