using System;
using System.Collections;
using System.Reflection.Metadata;

namespace CollectionsAndGenerics
{
    /// <summary>
    /// Creates,Holds and manipulates the stacks
    /// </summary>
    /// <typeparam name="T">generic type</typeparam>
    public class StacksManager<T>
    {
        private Stack<T> _stacks = new Stack<T>();
        private T[] _characterArray;

        /// <summary>
        /// Prints the reversed string with operation in stack
        /// </summary>
        public void ReverseStringWithStacks()
        {
            this.CreateCharacterArray();
            this.PushCharecterArrayToStack();
            this.PopCharectersFromStack();
        }

        /// <summary>
        /// Craetes a Character Array with strings
        /// </summary>
        private void CreateCharacterArray()
        {
            Console.WriteLine("Enter a String to Reverse");
            string? stringFromUser = Console.ReadLine();
            stringFromUser = stringFromUser ?? string.Empty;

            this._characterArray = (T[])Convert.ChangeType(stringFromUser.ToCharArray(), typeof(T[]));

            foreach (var character in this._characterArray)
            {
                Console.WriteLine(character);
            }
        }

        /// <summary>
        /// Pushes the character in the array to a stack
        /// </summary>
        private void PushCharecterArrayToStack()
        {
            foreach (var character in this._characterArray)
            {
                this._stacks.Push(character);
            }
        }

        /// <summary>
        /// Pops the characters stored in the stack and creates a string
        /// </summary>
        private void PopCharectersFromStack()
        {
            string newStringFromStack = string.Empty;

            do
            {
               newStringFromStack += this._stacks.Peek();
               this._stacks.Pop();
            }
            while (this._stacks.Any());

            Console.WriteLine($"The reveresed string is {newStringFromStack}");
        }
    }
}
