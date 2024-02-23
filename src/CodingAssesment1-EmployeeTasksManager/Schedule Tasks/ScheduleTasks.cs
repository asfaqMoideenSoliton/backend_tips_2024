using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CodingAssesment1
{
    /// <summary>
    /// Schedule the tasks
    /// </summary>
    internal class ScheduleTasks
    {
        private TasksManager _tasksManager;
        private EmployeeManager _employeeManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTasks"/> class.
        /// </summary>
        /// <param name="tasksManager">instance from program class</param>
        /// <param name="employeeManager">instance form program class</param>
        public ScheduleTasks(TasksManager tasksManager, EmployeeManager employeeManager)
        {
            this._tasksManager = tasksManager;
            this._employeeManager = employeeManager;
        }

        /// <summary>
        /// Sorts the list with lowest to highest deadline
        /// </summary>
        /// <returns>Sorted list</returns>
        public List<Tasks> PrioritiseTheTasks()
        {
            var prioritisedList = this._tasksManager.GetTasks().OrderBy(pi => pi.DeadlineInDays).ToList();
            return prioritisedList;
        }

        /// <summary>
        /// Starts Allocating Tasks
        /// </summary>
        /// <returns>+</returns>
        public (Employee, Tasks) GetMatchedEmployeeForTask()
        {
            foreach (Tasks tasks in this.PrioritiseTheTasks())
            {
                foreach (Employee employee in this._employeeManager.GetEmployees())
                {
                    if (employee.Skills.Contains(tasks.RequiredSkill))
                    {
                        return (employee, tasks);
                    }
                }
            }

            throw new Exception("No Matching Employee Found");
        }

        /// <summary>
        /// Splits the no of required hours
        /// </summary>
        /// <returns>Splitted working hours</returns>
        public double MatchedEmployeeCount()
        {
            double skillMatchedEmployeeCount = 0;
            foreach (Tasks tasks in this.PrioritiseTheTasks())
            {
                foreach (Employee employee in this._employeeManager.GetEmployees())
                {
                    bool isSkillMatched = employee.Skills.Contains(tasks.RequiredSkill);
                    if (isSkillMatched)
                    {
                        skillMatchedEmployeeCount++;
                    }
                }
            }
            return skillMatchedEmployeeCount;
        }

        /// <summary>
        /// Assign the tasks to employee
        /// </summary>
        /// <param name="employee">object employee with matched required skill</param>
        /// <param name="tasks">object task with matched employee skill</param>
        /// <param name="skillMatchedEmployeeCount"> double value of skill matched employee count
        public void AssignTheTaskToEmployee()
        {
            if (this.PrioritiseTheTasks().Any() && this._employeeManager.GetEmployees().Any())
            {
                var (employee, tasks) = this.GetMatchedEmployeeForTask();
                double skillMatchedEmployees = this.MatchedEmployeeCount();
                double splittedHours = tasks.RequiredHours / skillMatchedEmployees;
                if (tasks.RequiredHours > 0)
                {
                    employee.AssignedTask.Add(tasks.Name);

                    double employeeWillWorkFor = employee.AvailableDays * Employee.WorkingHours;

                    employee.AvailableDays -= splittedHours / Employee.WorkingHours;

                    tasks.RequiredHours -= Employee.WorkingHours * employeeWillWorkFor;

                    Console.WriteLine("Task : " + tasks.Name + "Allocated to: " + employee.Name);
                }
            }
            else
            {
                Console.WriteLine("No Tasks & Employees were Added");
            }
        }

        /// <summary>
        /// To Show the assigned tasks
        /// </summary>
        public void ShowLog()
        {
            foreach (Employee employee in this._employeeManager.GetEmployees())
            {
                if (employee.AssignedTask != null)
                {
                    Console.WriteLine("Tasks Allocated : " + employee.AssignedTask + "To :" + employee.Name);
                }
                else if (employee.AssignedTask == null)
                {
                    Console.WriteLine("No Tasks were allocated to :" + employee.Name);
                }
            }
        }
    }
}
