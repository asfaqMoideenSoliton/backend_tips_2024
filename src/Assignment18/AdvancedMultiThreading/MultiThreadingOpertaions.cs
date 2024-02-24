namespace Assignment18_MultiThreading
{
    /// <summary>
    /// Operates the math function in MultiThreading 
    /// </summary>
    public class MultiThreadingOpertaions
    {
        /// <summary>
        /// Runs the function in multi threaded manner
        /// </summary>
        public void MultiThreadingExecutor()
        {
            int sumOfInteger = 0;
            int sumOfRandom = 0;
            Thread thread1 = new Thread(() => sumOfInteger = MathCalculations.CalculateSumOfIntegerArray());
            Thread thread2 = new Thread(() => sumOfRandom = MathCalculations.SortRandomArrayandSum());

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            Console.WriteLine(sumOfInteger);
            Console.WriteLine(sumOfRandom);
        }
    }
}
