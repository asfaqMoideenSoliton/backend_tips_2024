namespace Assignments
{ /// <summary>
/// This is a derived class Developer from the base class employee
/// </summary>
    public class Developer : Employee
    {
        /// <summary>
        /// Variable to store salary
        /// </summary>
        private double _salary;
        private string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Developer"/> class.
        /// This is the 
        /// </summary>
        /// <param name="name">Asfaq</param>
        /// <param name="salary">50000</param>
        public Developer(string name, double salary)
            : base(name)
        {
            this._salary = salary;
            this._name = name;
        }

        /// <summary>
        /// Method to calculate bonus
        /// </summary>
        /// <returns>the bonus 10%</returns>
        public override double CalculateBonus()
        {
            return this._salary * 0.10;
        }

        /// <summary>
        /// Method to print Details
        /// </summary>
        public override void PrintDetails()
        {
            Console.WriteLine(this._name + "- Developer, Salary :" + this._salary + " Bonus :" + this.CalculateBonus());
        }
    }
}