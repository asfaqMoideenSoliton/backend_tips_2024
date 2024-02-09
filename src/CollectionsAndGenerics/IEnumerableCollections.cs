using System;
using System.Collections;

namespace CollectionsAndGenerics
{
    /// <summary>
    /// Creates, Holds, Manipulates the in-memory Collection in IEnumerable Interface
    /// </summary>
    public class IEnumerableCollections
    {
        /// <summary>
        /// Execute the operation in the Class ReadOnlyCollections
        /// </summary>
        public void ExecuteReadOnlyCollections()
        {
            Console.WriteLine("IEnumerable Collections ");

            this.GenerateCollections(out List<int> integerList, out int[] integerArray, out Queue<int> integerQueue, out Stack<int> integerStack);
            this.PrintDetailsInCollections(integerList, integerArray, integerQueue, integerStack);

            IReadOnlyDictionary<string, int> immutableDictionary = this.GenerateDictionary();
            this.PrintDictionary(immutableDictionary);
        }

        /// <summary>
        /// prints the Collection passed to it
        /// </summary>
        /// <param name="integerList">List of Integers</param>
        /// <param name="integerArray">Array of Integers</param>
        /// <param name="integerQueue">Queue of Integers</param>
        /// <param name="integerStack">Statck of Integers</param>
        private void PrintDetailsInCollections(List<int> integerList, int[] integerArray, Queue<int> integerQueue, Stack<int> integerStack)
        {
            Console.WriteLine($"Sum of elements in List {this.SumOfElements(integerList)}");

            Console.WriteLine($"Sum of elements in Array {this.SumOfElements(integerArray)}");

            Console.WriteLine($"Sum of elements in Queue {this.SumOfElements(integerQueue)}");

            Console.WriteLine($"Sum of elements in Stack {this.SumOfElements(integerStack)}");
        }

        /// <summary>
        /// Generated IEnumerable based in-memory Collection
        /// </summary>
        /// <param name="integerList">List of Integers</param>
        /// <param name="integerArray">Array of Integers</param>
        /// <param name="integerQueue">Queue of Integer</param>
        /// <param name="integerStack">Stack of Integer</param>
        private void GenerateCollections(out List<int> integerList, out int[] integerArray, out Queue<int> integerQueue, out Stack<int> integerStack)
        {
            integerList = new List<int> { 1, 2, 2, 4, 6, 7 };

            integerArray = integerList.ToArray();

            integerQueue = new Queue<int>();

            foreach (int integer in integerArray)
            {
                integerQueue.Enqueue(integer);
            }

            integerStack = new Stack<int>();
            foreach (int integer in integerArray)
            {
                integerStack.Push(integer);
            }
        }

        /// <summary>
        /// Calculates the sum of elements in the given collection
        /// </summary>
        /// <param name="collection">Any type of collection under IEnumerable</param>
        /// <returns>The sum of elemsts as integer</returns>
        private int SumOfElements(IEnumerable<int> collection)
        {
            int sumOfElements = 0;
            foreach (int element in collection)
            {
                sumOfElements += element;
            }

            return sumOfElements;
        }

        /// <summary>
        /// Generates Immutable Dictionary with Key and  Value
        /// </summary>
        /// <returns>Readonly Dictionary</returns>
        private IReadOnlyDictionary<string, int> GenerateDictionary()
        {
            Dictionary<string, int> alphabetDictionary = new Dictionary<string, int>();

            string tKey = string.Empty;

            for (int i = 65; i < 120; i++)
            {
                char tKeychar = (char)i;
                alphabetDictionary.Add(tKeychar.ToString(), i);
            }

            IReadOnlyDictionary<string, int> immutableAlphabetDictionary = alphabetDictionary;

            return immutableAlphabetDictionary;
        }

        /// <summary>
        /// Prints the key value pairs from the passed dictionary.
        /// </summary>
        /// <param name="dictionaryToBePrinted">Dictionary in  IReadOnlyDictionaryFormat</param>
        private void PrintDictionary(IReadOnlyDictionary<string, int> dictionaryToBePrinted)
        {
            foreach (KeyValuePair<string, int> pair in dictionaryToBePrinted)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }
    }
}
