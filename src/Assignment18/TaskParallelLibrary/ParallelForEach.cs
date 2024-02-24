using System.Diagnostics;
using System.Net.Http.Headers;

namespace TaskParallelLibrary
{
    /// <summary>
    /// Uses Paralle Foreach to calculate square of integers
    /// </summary>
    public class ParallelForEach
    {
        /// <summary>
        /// Squares the Integer Array
        /// </summary>
        public void SqaureIntegerArray()
        {
            int[] integerArray = new int[10000];

            int index = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Parallel.ForEach(integerArray, element =>
            {
                integerArray[index] = index * index;
                index++;
            });
            stopwatch.Stop();
            Console.WriteLine($"Time taken uisng Parallel ForEach{stopwatch.Elapsed}");

            foreach (int element in integerArray)
            {
                Console.Write(element);
            }

            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < integerArray.Length; i++)
            {
                integerArray[i] = i * i;
            }

            stopwatch.Stop();
            Console.WriteLine($"Time Elapse in Normal Foreach{stopwatch.Elapsed}");
            foreach (int element in integerArray)
            {
                Console.Write(element);
            }
        }
    }
}
