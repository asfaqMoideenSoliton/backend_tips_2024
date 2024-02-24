namespace Assignment18_MultiThreading
{
    /// <summary>
    /// Initiate the program execution
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry point of the program
        /// </summary>
        private static async Task Main()
        {
            ConfigureAwait configureAwait = new ConfigureAwait();
            ExceptionsInAsync exceptionsInAsync = new ExceptionsInAsync();
            try
            {
                await configureAwait.MethodA();
                exceptionsInAsync.VoidMethod();
                await exceptionsInAsync.TaskMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}