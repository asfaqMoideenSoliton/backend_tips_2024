namespace FilesStreamsReadWrite
{
    /// <summary>
    /// Log tester
    /// </summary>
    public class LogTester
    {
        private Thread[] _threads = new Thread[10];

        /// <summary>
        /// Log testeer
        /// </summary>
        public void Logtester()
        {
            for (int numberOfUsers = 0; numberOfUsers < 10; numberOfUsers++)
            {
                this._threads[numberOfUsers] = new Thread(() =>
                {
                    string userId = $"_user {Thread.CurrentThread.ManagedThreadId}";
                    for (int numberOfErrorMessage = 0; numberOfErrorMessage <= 10; numberOfErrorMessage++)
                    {
                        string errorMessage = $" User attempted{numberOfUsers} at the same time";
                        ModifiedLogError.ModifiedLogger(errorMessage, userId);
                    }
                });
                this._threads[numberOfUsers].Start();
            }

            foreach (Thread thread in this._threads)
            {
                thread.Join();
            }
        }
    }
}
