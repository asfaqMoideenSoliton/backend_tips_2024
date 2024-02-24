using System.Reflection;
using System.Runtime.InteropServices;

namespace Reflections
{
    /// <summary>
    /// Holds proeprties of Student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="name">student name</param>
        /// <param name="grade">student grade</param>
        /// <param name="id">studenst id</param>
        public Student(string name, string grade, string id)
        {
           this.Name = name;
           this.Grade = grade;
           this.StudentId = id;
        }
        /// <summary>
        /// Gets or sets Student Name
        /// </summary>
        /// <value>
        /// Student Name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Student Grade
        /// </summary>
        /// <value>
        /// Student Grade
        /// </value>
        public string Grade { get; set; }

        /// <summary>
        /// Gets or sets Student Id
        /// </summary>
        /// <value>
        /// Student Id
        /// </value>
        public string StudentId { get; set; }
    }
}
