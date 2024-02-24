namespace Assignment18_MultiThreading
{
    /// <summary>
    /// Initiates the program execution
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the program
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("MultiThreading");
            MultiThreadingOpertaions multiThreadingOpertaions = new ();
            multiThreadingOpertaions.MultiThreadingExecutor();

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}