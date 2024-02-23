namespace CodingAssesment1
{
    /// <summary>
    /// Tasks Manager
    /// </summary>
    internal class Tasks
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tasks"/> class.
        /// </summary>
        /// <param name="name">Task name </param>
        /// <param name="requiredHours">required hours to complete</param>
        /// <param name="deadlineInDays">deadline in days</param>
        /// <param name="requiredSkill">required skill</param>
        /// <param name="description"> descriotion</param>
        public Tasks(string name, double requiredHours, DateTime deadlineInDays, string requiredSkill, string description)
        {
            this.Name = name;
            this.RequiredHours = requiredHours;
            this.DeadlineInDays = deadlineInDays;
            this.RequiredSkill = requiredSkill;
        }

        /// <summary>
        /// Gets or sets task Name
        /// </summary>
        /// <value>
        /// Task Name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets required hours
        /// </summary>
        /// <value>
        /// Required Hours to complete
        /// </value>
        public double RequiredHours { get; set; }

        /// <summary>
        /// Gets or sets deadline
        /// </summary>
        /// <value>
        /// deadline in days to complet the task
        /// </value>
        public DateTime DeadlineInDays { get; set; }

        /// <summary>
        /// Gets or sets required Skills
        /// </summary>
        /// <value>
        /// required skill for this job
        /// </value>
        public string RequiredSkill { get; set; }
    }
}
