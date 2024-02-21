namespace FilesStreamsReadWrite
{
    /// <summary>
    /// Executes the Main Menu Operations
    /// </summary>
    public class MainMenuExecutionManager
    {
        private enum MainMenuOperations
        {
            SyncStream = 1,
            AsyncStream,
            EfficientStream,
            ModifiedLogError,
        }

        /// <summary>
        /// Prints the Main Menu to the user.
        /// </summary>
        public void ShowMainMenu()
        {
            Console.WriteLine("Working with Files and Streams\n1.Synchronous File Stream" +
                "\n2.Asynchronous FieStream\n3.Efficient File Stream\n4.Modified " +
                " & UnModified Logger With Multiple users");
        }

        /// <summary>
        /// Execute MainMenu Operations
        /// </summary>
        /// <returns>Task.</placeholder></returns>
        public async Task ExecuteMainMenu()
        {
            this.ShowMainMenu();

            int userOption = ConsoleUserInterface.GetOptionFromUser();

            MainMenuOperations operationToBePerformed = (MainMenuOperations)userOption;

            switch (operationToBePerformed)
            {
                case MainMenuOperations.SyncStream:
                    SynchronousStreamProccessor synchronous = new ();
                    synchronous.ExecuteSyncStreams();
                    break;
                case MainMenuOperations.AsyncStream:
                    AsynchronousStreamProcessor asynchronous = new ();
                    await asynchronous.ExecuteAsyncStreams();
                    break;
                case MainMenuOperations.EfficientStream:
                    EfficiectStreamProcessor efficiectStream = new ();
                    efficiectStream.StreamWriter();
                    efficiectStream.StreamReader();
                    break;
                case MainMenuOperations.ModifiedLogError:
                    LogTester logTester = new ();
                    logTester.Logtester();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
