using CollectionsAndGenerics;

namespace Assignments
{
    /// <summary>
    /// Initiates the program execution
    /// </summary>
    public class Program
    {
        private static ListManager<string> listManager = new ListManager<string>();
        private static StacksManager<char> stacks = new StacksManager<char>();
        private static QueuesManager<string> queues = new QueuesManager<string>();
        private static DictionaryManager<string, int> dictionaryManager = new DictionaryManager<string, int>();
        private static IEnumerableCollections readOnlyCollections = new IEnumerableCollections();

        private enum CollectionsAndGenerics
        {
            Quit,
            BookManager,
            Stacks,
            Queue,
            Dictionary,
            ReadOnlyCollections,
        }

        /// <summary>
        /// Starting point of the program
        /// </summary>
        public static void Main()
        {
            bool stop = false;
            do
            {
                try
                {
                    Console.WriteLine("Working With Collections\nEnter a Option to Proceed\n1.BookManager\n2.Stack Operations" +
                        "\n3.QueueOperations\n4.Dictionary Operations\n5.Read Only Collections\n0 or Press any key to Quit");
                    bool isUserOptionInt = int.TryParse(Console.ReadLine(), out int userOption);
                    CollectionsAndGenerics collectionsAndGenerics = (CollectionsAndGenerics)userOption;

                    stop = ExecuteUserOperation(stop, collectionsAndGenerics);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (!stop);
        }

        private static bool ExecuteUserOperation(bool stop, CollectionsAndGenerics collectionsAndGenerics)
        {
            switch (collectionsAndGenerics)
            {
                case CollectionsAndGenerics.BookManager:
                    listManager.ExecuteTheOperation();
                    break;
                case CollectionsAndGenerics.Quit:
                    stop = true;
                    break;
                case CollectionsAndGenerics.Stacks:
                    stacks.ReverseStringWithStacks();
                    break;
                case CollectionsAndGenerics.Queue:
                    queues.ExecuteTheOperation();
                    break;
                case CollectionsAndGenerics.Dictionary:
                    dictionaryManager.ExecuteTheOperation();
                    break;
                case CollectionsAndGenerics.ReadOnlyCollections:
                    readOnlyCollections.ExecuteReadOnlyCollections();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            return stop;
        }
    }
}