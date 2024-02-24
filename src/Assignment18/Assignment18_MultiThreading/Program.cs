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
        private static void Main()
        {
           AsyncAwait asyncAwait = new AsyncAwait();
           asyncAwait.ExecuteAsyncAwait();

           Console.ReadKey();
        }
    }
}