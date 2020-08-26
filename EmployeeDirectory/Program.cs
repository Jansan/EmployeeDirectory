using System;

namespace EmployeeDirectory
{
    class Program
    {
        static Payroll payroll = new Payroll();
        static void Main(string[] args)
        {
            

            SeedData();

            Console.WriteLine("Add a new Employee, Quit with Q");

            do
            {
                string name = Util.AskForString("Name: ");
            } while (true);

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
