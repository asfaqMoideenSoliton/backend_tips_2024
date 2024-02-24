namespace Assignment18_MultiThreading
{
    /// <summary>
    /// Exceptions handling async
    /// </summary>
    public class ExceptionsInAsync
    {
        /// <summary>
        /// async void method
        /// </summary>
        public async void VoidMethod()
        {
            throw new Exception("this method is async void");
        }

        /// <summary>
        /// Async task
        /// </summary>
        /// <returns>Task </returns>
        public async Task TaskMethod()
        {
            throw new Exception("This method is async Task");
        }
    }
}
