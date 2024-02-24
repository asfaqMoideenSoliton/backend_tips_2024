namespace Assignment18_MultiThreading
{
    /// <summary>
    /// Initiates the program Execution
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the program
        /// </summary>
        private static async Task Main()
        {
            MultiLayeredOperation multiLayeredOperations = new MultiLayeredOperation();
            multiLayeredOperations.ExecuteMultiLayerAsyncAwait();
            DeadLock deadLock = new DeadLock();
            await deadLock.DeadlockMethod();
            Console.ReadKey();
        }
    }
}