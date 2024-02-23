namespace CodingAssesment1
{   /// <summary>
    /// Employee Entity
    /// </summary>
    internal class Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">Employee Name</param>
        /// <param name="workingHours">Working Hours of the emloyee</param>
        /// <param name="skills">skills of the employee</param>
        /// <param name="assignedTask">assigned taskof the employee</param>
        /// <param name="availableDays">Available days of the employee</param>
        public Employee(string name, List<string> skills, List<string> assignedTask, double availableDays)
        {
            this.Name = name;
            WorkingHours = 8;
            this.Skills = skills;
            this.AssignedTask = assignedTask;
            this.AvailableDays = availableDays;
        }

        /// <summary>
        /// Gets or sets employee working hours
        /// </summary>
        /// <value>
        /// employee working hours
        /// </value>
        public static double WorkingHours { get; set; }

        /// <summary>
        /// Gets or sets name 
        /// </summary>
        /// <value>
        /// Employee name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Skills
        /// </summary>
        /// <value>
        /// employee skills
        /// </value>
        public List <string> Skills { get; set; }

        /// <summary>
        /// Gets or sets employee's assigned task
        /// </summary>
        /// <value>
        /// task as string
        /// </value>
        public List<string> AssignedTask { get; set; }

        /// <summary>
        /// Gets or sets employee availale days
        /// </summary>
        /// <value>
        /// Employee availale days
        /// </value>
        public double AvailableDays { get; set; }
    }
}
