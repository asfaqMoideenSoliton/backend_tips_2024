using System.Security.Cryptography;

namespace Assignment18_MultiThreading
{
    /// <summary>
    /// Program that holds many methdos in Async methods
    /// </summary>
    public class MathCalculations
    {
        /// <summary>
        /// Calculates the sum of integer array
        /// </summary>
        /// <returns>Sum of the integer array</returns>
        public static int CalculateSumOfIntegerArray()
        {
            int sum = 0;
            int[] integerArrayToSum = new int[100];

            for (int i = 0; i < integerArrayToSum.Length; i++)
            {
                integerArrayToSum[i] = i;
                sum += integerArrayToSum[i];
            }
            
            return sum;
        }

        /// <summary>
        /// Sorts the random array
        /// </summary>
        /// <returns>sumof random array</returns>
        public static int SortRandomArrayandSum()
        {
            int sum = 0;
            int[] randomArrayToSum = new int[100];
            Random random = new Random();

            for (int i = 0; i < randomArrayToSum.Length; i++)
            {
                randomArrayToSum[i] = random.Next(100000);
                sum += randomArrayToSum[i];
            }
            return sum;
        }
    }
}
