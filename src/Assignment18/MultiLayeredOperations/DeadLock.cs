namespace Assignment18_MultiThreading
{
    /// <summary>
    /// Methods conatainig deadlock operations
    /// </summary>
    public class DeadLock
    {
        /// <summary>
        /// Deadlock method
        /// </summary>
        /// <returns> task </returns>
        public async Task DeadlockMethod()
        {
            var result = await this.SomeAsyncOperation();
            Console.WriteLine(result);
        }

        private async Task<string> SomeAsyncOperation()
        {
            await Task.Delay(10);
            return "Hii";
        }
    }
}
