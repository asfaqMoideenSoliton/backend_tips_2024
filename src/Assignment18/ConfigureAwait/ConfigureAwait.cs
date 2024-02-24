namespace Assignment18_MultiThreading
{
    /// <summary>
    /// Usage of Configure awiat
    /// </summary>
    public class ConfigureAwait
    {
        /// <summary>
        /// uses configure await
        /// </summary>
        /// <returns>Task </returns>
        public async Task MethodB()
        {
            Console.WriteLine("Hey, Method A called me");
            await Task.Delay(1000).ConfigureAwait(false);
        }

        /// <summary>
        /// Calls method A
        /// </summary>
        /// <returns>Task</returns>
        public async Task MethodA()
        {
            Console.WriteLine($"The Thread before addition is {Thread.CurrentThread.ManagedThreadId}");
            await this.MethodB();
            Console.WriteLine($"The Thread ID After addition {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
