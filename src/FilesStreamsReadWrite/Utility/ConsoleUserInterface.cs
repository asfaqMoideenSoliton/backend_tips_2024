using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesStreamsReadWrite
{
    /// <summary>
    /// Console Interface to get user option and execute
    /// </summary>
    public class ConsoleUserInterface
    {
        private ConsoleInputValidator _validator;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleUserInterface"/> class.
        /// </summary>
        public ConsoleUserInterface()
        {
            this._validator = new ConsoleInputValidator();
        }

        /// <summary>
        /// gets user input from user via console
        /// </summary>
        /// <returns>user option as int</returns>
        public static int GetOptionFromUser()
        {
            int option;
            Console.WriteLine("Enter Option to procced");
            ConsoleInputValidator.IsOptionInputValid(Console.ReadLine() !, out option);
            return option;
        }
    }
}
