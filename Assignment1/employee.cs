namespace Assignments
{
  /// <summary>
  /// This is the Base class called Employee
  /// </summary>
  public abstract class Employee
    {
        private string _name;
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">returns name of the employee</param>
        public Employee(string name)
        {
            _name = name;
        }
        /// <summary>
        /// This method to calculate bonus
        /// </summary>
        /// <returns>bonus</returns>
        public abstract double CalculateBonus();
        /// <summary>
        /// this is themethod to print details
        /// </summary>
        public abstract void PrintDetails();
    } 
}