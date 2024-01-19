namespace Assignments
{
  /// <summary>
  /// This is derived class manager from the base class Employee
  /// </summary>
  public class Manager: Employee
    {
       private double _salary;
       private string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        /// <param name="name">Ragu</param>
        /// <param name="salary">65000</param>
       public Manager(string name, double salary)
            : base(name)
        {
            this._salary = salary;
            this._name = name;
        }

        /// <summary>
        /// The Method to calculate bonus
        /// </summary>
        /// <returns>Bonus</returns>
       public override double CalculateBonus()
        {
            return this._salary*.15;
        }

        /// <summary>
        /// Method to print details
        /// </summary>
       public override void PrintDetails()
        {
            Console.WriteLine(this._name + "- Manager, Salary :" +_salary +" Bonus:"+ CalculateBonus());
        }
    }
}