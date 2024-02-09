using System;
using System.Collections;

namespace CollectionsAndGenerics
{
    /// <summary>
    /// Creates Holds and Manipulates Queues.
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    public class QueuesManager<T>
    {
        private Queue<T> _queueOfPersons = new Queue<T>();

        private enum QueueOperations
        {
            Quit,
            AddPerson,
            Remove,
            ShowAll,
        }

        /// <summary>
        /// Execute the list operations according to the users choice
        /// </summary>
        public void ExecuteTheOperation()
        {
            bool stop = false;
            do
            {
                Console.WriteLine("Queue Operations Manager\nChoose any option to proced\n1.Add Persons to queue" +
                    "\n2.Remove first person from queue\n3.Show all Persons after removal\n0.Quit");
                bool isUserOptionInt = int.TryParse(Console.ReadLine(), out int userOption);
                QueueOperations queueOperations = (QueueOperations)userOption;
                switch (queueOperations)
                {
                    case QueueOperations.AddPerson:
                        this.AddPersons();
                        break;
                    case QueueOperations.Remove:
                        this.RemoveFirstPerson();
                        break;
                    case QueueOperations.ShowAll:
                        this.ShowAllPersons();
                        break;
                    case QueueOperations.Quit:
                        stop = true;
                        break;
                    default:
                        break;
                }
            }
            while (!stop);
        }

        /// <summary>
        /// Gets input from the user and adds the persons in the in-memory queue
        /// </summary>
        private void AddPersons()
        {
            bool addPersons = true;
            while (addPersons)
            {
                T bookTitleT = CommonMethods.GetAndConvertStringToType<T>("Add a new Person");

                this._queueOfPersons.Enqueue(bookTitleT);

                Console.WriteLine($"Totally {this._queueOfPersons.Count()} were Added");
                addPersons = CommonMethods.IsAddAnotherDetail("Person");
            }
        }

        /// <summary>
        /// Removes person from in-memory Queue
        /// </summary>
        private void RemoveFirstPerson()
        {
            this._queueOfPersons.Dequeue();
        }

        /// <summary>
        /// Search person from in-memory Queue
        /// </summary>
        private void ShowAllPersons()
        {
            foreach (var person in this._queueOfPersons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
