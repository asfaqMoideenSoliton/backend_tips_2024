﻿using Assignments;

namespace Assignemnts
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
        /// Starts Allocating Tasks
        /// </summary>
        public void StartAllocationgTasks()
        {
            foreach (Tasks tasks in this._tasksManager.GetTasks())
            {
                foreach (Employee employee in this._employeeManager.GetEmployees())
                {
                    if (tasks.RequiredSkill == employee.Skills && employee.AvailableDays >= tasks.DeadlineInDays)
                    {
                        this.AssignTheTaskToEmployee(employee, tasks);
                    }
                }
            }
        }

        /// <summary>
        /// Assign the tasks to employee
        /// </summary>
        /// <param name="employee">object employee</param>
        /// <param name="tasks">object tasks</param>
        public void AssignTheTaskToEmployee(Employee employee, Tasks tasks)
        {
            if (tasks.RequiredHours > 0)
            {
                employee.AssignedTask = tasks.Name;

                employee.AvailableDays -= tasks.RequiredHours / employee.WorkingHours;

                tasks.RequiredHours -= employee.WorkingHours * tasks.DeadlineInDays;

                Console.WriteLine("Task Allocated to: " + employee.Name);
            }
            else
            {
                Console.WriteLine("Task Already Allocated");
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
            }
        }
    }
}
