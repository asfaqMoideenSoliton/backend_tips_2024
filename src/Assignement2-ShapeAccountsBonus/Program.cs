using System;
using Assignments;

/// <summary>
/// This is main class called Program
/// </summary>
internal partial class Program
{
    private static void Main(string[] args)
    {
        Circle circle = new Circle("red", 1);
        circle.PrintDetails();

        Rectangle rectangle = new Rectangle("Blue", 5, 10);
        rectangle.PrintDetails();

        Developer developer = new Developer("Asfaq", 50000);
        developer.PrintDetails();

        Manager manager = new Manager("Ragu", 65000);
        manager.PrintDetails();

        CheckingAccount checkingAccount = new CheckingAccount("AOD1025", 0);
        SavingsAccount savingsAccount = new SavingsAccount("AOS1023", 500);

        savingsAccount.Deposit(10000);
        savingsAccount.Withdraw(100);

        checkingAccount.Deposit(100);
        checkingAccount.Withdraw(10000);

        Console.ReadKey();
    }

    /// <summary>
    /// This is
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// This is the method specified to calculate area
        /// </summary>
        /// <returns> Area of the Shape</returns>
        public abstract double CalculateArea();

        /// <summary>
        /// This is the method specfied to print the details
        /// </summary>
        public abstract void PrintDetails();
    }

    /// <summary>
    ///  Class 
    /// </summary>
    public abstract class Employee
    { /// <summary>
    /// variable to store name
    /// </summary>
        private string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">name of the employee</param>
        public Employee(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// Method initialization
        /// </summary>
        /// <returns> bonus</returns>
        public abstract double CalculateBonus();

        /// <summary>
        /// method Print details initialization
        /// </summary>
        public abstract void PrintDetails();
    }
}