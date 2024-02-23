namespace CodingAssesment1
{
    /// <summary>
    /// Gets employee name from the user
    /// </summary>
    internal class EmployeeIOConsole
    {
        /// <summary>
        /// Get Employee Name from the user
        /// </summary>
        /// <returns>Employee name</returns>
        public string GetEmployeeName()
        {
            string? employeeName;
            do
            {
                Console.WriteLine("Enter Employee Name");
                employeeName = Console.ReadLine() !;
            }
            while (employeeName.Length == 0);
            return employeeName;
        }

        /// <summary>
        /// Get employee skills from the user
        /// </summary>
        /// <returns>Skills as string</returns>
        public List <string> GetEmployeeSkills()
        {
            List<string> skillsList = new List<string>();
            string? employeeSkills;
            bool addSkill = true;
            while (addSkill)
            {
                do
                {
                    Console.WriteLine("Enter Employee Skills");
                    employeeSkills = Console.ReadLine() !;
                }
                while (employeeSkills.Length == 0);
                skillsList.Add(employeeSkills);
                addSkill = this.IsAddAnotherEmployee("Skill");
            }

            return skillsList;
        }

        /// <summary>
        /// Get Available Days from the User
        /// </summary>
        /// <returns>availabel days as double</returns>
        public double GetEmployeeAvailableHours()
        {
            double availableDays;
            bool isAvailableDaysDouble;
            Console.WriteLine("Enter employe availablility in days");
            do
            {
                isAvailableDaysDouble = double.TryParse(Console.ReadLine(), out availableDays);
            }
            while (!isAvailableDaysDouble && availableDays > 0);
            return availableDays;
        }

        /// <summary>
        /// Get the option to add another employee
        /// </summary>
        /// <param name="format">parameter as string</param>
        /// <returns>true if yes </returns>
        internal bool IsAddAnotherEmployee(string format)
        {
            Console.WriteLine($"Need to add Another {format}\n1.Yes\nPress any key to skip");
            string option = Console.ReadLine() !;
            return option == "1";
        }
    }
}
