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
    public class User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="id">Generated user id </param>
        /// <param name="name">Name Given by the user</param>
        /// <param name="password">Password provieded by the user </param>
        /// <param name="userName">Username provieded by the user</param>
        public User(int id, string name, string password, string userName)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
            this.UserName = userName;
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
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets username
        /// </summary>
        /// <value>
        /// username
        /// </value>
        public string UserName { get; set; }
    }
}
