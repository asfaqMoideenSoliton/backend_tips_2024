namespace TaskParallelLibrary
{
    /// <summary>
    /// Initiate the program execution
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the program
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Square of integer array");
            ParallelForEach parallelForEach = new ParallelForEach();
            parallelForEach.SqaureIntegerArray();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}