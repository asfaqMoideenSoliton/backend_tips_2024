﻿using System;
using System.Collections;

namespace CollectionsAndGenerics
{
    /// <summary>
    /// Creates Holds and Manipulates Queues.
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    public class QueuesManager<T>
    {
        private Queue<T> _queueOfPerons = new Queue<T>();
        private CommonMethods<T> _commonMethods = new CommonMethods<T>();

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
        /// Gets input from the user and adds the persons in the queue
        /// </summary>
        private void AddPersons()
        {
            bool addPersons = true;
            while (addPersons)
            {
                T bookTitleT = this._commonMethods.GetAndConvertStringToType("Add a new Person");

                this._queueOfPerons.Enqueue(bookTitleT);

                Console.WriteLine($"Totally {this._queueOfPerons.Count()} were Added");
                addPersons = this._commonMethods.IsAddAnotherDetail("Person");
            }
        }

        /// <summary>
        /// Removes the book from the list
        /// </summary>
        private void RemoveFirstPerson()
        {
            this._queueOfPerons.Dequeue();
        }

        /// <summary>
        /// Search the books from the List
        /// </summary>
        private void ShowAllPersons()
        {
            foreach (var person in this._queueOfPerons)
            {
                Console.WriteLine(person);
            }
        }
    }
}