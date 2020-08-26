using System;

namespace EmployeeDirectory
{
    class Program
    {
        static Payroll payroll = new Payroll();
        static void Main(string[] args)
        {
            

            SeedData();

            Employee[] employees = payroll.GetEmployees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                
            }
        }

       

        private static void SeedData()
        {
            payroll.AddEmployee("Kalle", 10000);
            payroll.AddEmployee("Nisse", 20000);
            payroll.AddEmployee("Lisa", 15000);
            payroll.AddEmployee("Anne", 250000);
        }

       
    }
}
