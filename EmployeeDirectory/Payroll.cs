using System;
using System.Collections.Generic;

namespace EmployeeDirectory
{
    internal class Payroll
    {
        //Private collection of employee objects
        //Only accessable from inside this class
        private List<Employee> payroll;

        //Constructor runs when a payroll is created ( new Payroll() )
        public Payroll()
        {
            //Initializes a new List
            payroll = new List<Employee>();
        }

        internal Employee[] GetEmployees()
        {
            //Returns a copy of employee List
            return payroll.ToArray();
        }
        internal void AddEmployee(string name,  double salary)
        {
            //New instance of employee
            //Add employee to list
            payroll.Add(new Employee(name, salary));
        }
    }
}