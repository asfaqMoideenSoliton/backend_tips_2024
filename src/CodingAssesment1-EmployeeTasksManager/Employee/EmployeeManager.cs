using ConsoleTables;

namespace CodingAssesment1
{
    /// <summary>
    /// Manipulates and Manages Employee class
    /// </summary>
    internal class EmployeeManager
    {
        private List<Employee> _employees;
        private EmployeeIOConsole _console;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeManager"/> class.
        /// </summary>
        public EmployeeManager()
        {
            this._employees = new List<Employee>();
            this._console = new EmployeeIOConsole();
        }

        private enum Option
        {
            Add = 1,
            View,
            Remove,
        }

        /// <summary>
        /// To acces the employee list outside
        /// </summary>
        /// <returns>d</returns>
        public List<Employee> GetEmployees()
        {
            return this._employees;
        }

        /// <summary>
        /// Method to add an employee to the llist
        /// </summary>
        public void AddEmpoyee()
        {
            bool addEployye = true;
            while (addEployye)
            {
                Employee employee = this.GetEmployeeDetails();
                this._employees.Add(employee);
                Console.WriteLine($"Totally {this._employees.Count} were added");
                addEployye = this._console.IsAddAnotherEmployee("employee");
            }
        }

        /// <summary>
        /// Removes employee from the list
        /// </summary>
        public void RemoveEmpoyee()
        {
            string employeeName = this._console.GetEmployeeName();
            Employee searchResult = this.SearchEmployeeFromTheList(employeeName);
            this._employees.Remove(searchResult);
            Console.WriteLine($"Employee {employeeName} Deleted");
        }

        /// <summary>
        /// Traverse through the list and returns employee reference
        /// </summary>
        /// <param name="employeeName"> Emp</param>
        /// <returns>object of employee</returns>
        public Employee SearchEmployeeFromTheList(string employeeName)
        {
            if (this._employees.Any())
            {
                foreach (Employee employee in this._employees)
                {
                    if (employee.Name.ToLower() == employeeName.ToLower())
                    {
                        return employee;
                    }
                }
            }

            throw new Exception("No employees were added");
        }

        /// <summary>
        /// Shows all the Employees
        /// </summary>
        public void ViewAllEmployees()
        {
            Console.WriteLine(this._employees.Count());
            if (this._employees.Count() > 0)
            {
                var employeeTable = new ConsoleTable("Employee Name: ", "Skills: ", "AssignedTask: ", "Availability");
                foreach (Employee employee in this._employees)
                {
                    string skillSet = string.Join(",", employee.Skills);
                    string assignedTask = string.Join(",", employee.AssignedTask);
                    employeeTable.AddRow(employee.Name, skillSet, assignedTask, employee.AvailableDays);
                }

                employeeTable.Write();
            }
            else
            {
                Console.WriteLine("No elmployees were added");
            }
        }

        /// <summary>
        /// Executed the opertaion in employee manager
        /// </summary>
        /// <param name="option">option from the user</param>
        public void ExecuteEmployeemanager()
        {
            Console.WriteLine("Choose any Operation\n1.AddEmployee\n2.ViewAllEmployee\n3.RemoveEmployee");
            bool isOptionInt = int.TryParse(Console.ReadLine(), out int option);

            Option userOption = (Option)option;

            switch (userOption)
            {
                case Option.Add:
                    this.AddEmpoyee();
                    break;
                case Option.Remove:
                    this.RemoveEmpoyee();
                    break;
                case Option.View:
                    this.ViewAllEmployees();
                    break;
                default:
                    Console.WriteLine("Enter Valid Opton");
                    break;
            }
        }

        private Employee GetEmployeeDetails()
        {
            string employeeName = this._console.GetEmployeeName();
            List<string> employeeSkill = this._console.GetEmployeeSkills();
            double availableDays = this._console.GetEmployeeAvailableHours();
            List<string> taskAssigned = new List<string>();
            Employee employee = new Employee(employeeName, employeeSkill, taskAssigned, availableDays);
            return employee;
        }
    }
}
