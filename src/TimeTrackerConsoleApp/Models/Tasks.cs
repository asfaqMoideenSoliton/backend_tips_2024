using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerConsoleApp
{
    /// <summary>
    /// Holds the User Attributes
    /// </summary>
    public class Tasks
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tasks"/> class.
        /// </summary>
        /// <param name="id">Generated user id </param>
        /// <param name="name">Name Given by the user</param>
        /// <param name="category">Password provieded by the user </param>
        public Tasks(int id, string name, string category)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
        }

        /// <summary>
        /// Gets or sets user id
        /// </summary>
        /// <value>
        /// Value of Id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name
        /// </summary>
        /// <value>
        /// Nameof the user
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets password
        /// </summary>
        /// <value>
        /// Password
        /// </value>
        public string Category { get; set; }
    }
}
