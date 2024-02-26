namespace BoilerControllerConsoleApplication
{
    /// <summary>
    /// Holds the property of boiler switches
    /// </summary>
    public class Boiler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Boiler"/> class.
        /// </summary>
        /// <param name="interLock">Interlock switch of the boiler</param>
        /// <param name="lockoutReset">LockoutSwitch If it faces any failiure</param>
        public Boiler(bool interLock, bool lockoutReset)
        {
            this.InterLock = interLock;
            this.LockoutReset = lockoutReset;
        }

        /// <summary>
        /// Status of the boiler controller
        /// </summary>
        public enum SystemStatus
        {
            /// <summary>
            /// When the system caught with errors and not initialised
            /// </summary>
            Lockout,

            /// <summary>
            /// When the system is ready to start sequence
            /// </summary>
            Ready,

            /// <summary>
            /// While the system is runing on pre-purge cycle
            /// </summary>
            PrePurge,

            /// <summary>
            /// While the system is runing on Ingnition cycle
            /// </summary>
            Ingnition,

            /// <summary>
            /// When the system is operational
            /// </summary>
            Opeational,
        }

        /// <summary>
        /// Gets or sets the status of the system
        /// </summary>
        /// <value>
        /// Value of the status
        /// <value>
        public SystemStatus Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether InterLock Switch
        /// </summary>
        /// <value>
        /// Default open(false) and true if closed
        /// </value>
        public bool InterLock { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether LockoutReset value
        /// </summary>
        /// <value>
        /// opens when the system caught with failiure
        /// </value>
        public bool LockoutReset { get; set; }
    }
}
