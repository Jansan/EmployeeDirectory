using System;
using System.Collections.Generic;

namespace EmployeeDirectory
{
    internal class Payroll
    {
        private List<Employee> payroll;
        public Payroll()
        {
            payroll = new List<Employee>();
        }

        internal Employee[] GetEmployees()
        {
            return payroll.ToArray();
        }
        internal void AddEmployee(string name,  double salary)
        {
            payroll.Add(new Employee(name, salary));
        }
    }
}