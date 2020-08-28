using System;

namespace EmployeeDirectory
{
    class Program
    {
        //Create a new instance of payroll
        static Payroll payroll = new Payroll();
        static void Main(string[] args)
        {
            
            //Calls Add method on payroll instance
            //Only for demo purpose to have some data
            SeedData();


            do //Loop
            {
                PrintMeny();
               
            } while (true);

            
        }

        private static void PrintMeny()
        {
            Console.WriteLine("1. Add new Emloyee");
            Console.WriteLine("2. Print");
            Console.WriteLine("Q. Quit");

            switch (Console.ReadLine())
            {
                case "1":
                    Add();
                    break;
                case "2":
                    Print();
                    break;
                case "Q":
                    //Exit application
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        private static void Print()
        {
            //Get a copy of the payroll
            Employee[] employees = payroll.GetEmployees();

            //Loop on all employees in payroll
            foreach (Employee employee in employees)
            {
                //Console.WriteLine() method does a .ToString() on the Employee instance
                Console.WriteLine(employee);

                //Ternary conditional operator
                //Same as if else
                Console.WriteLine(employee.SalaryLevel.Equals(SalaryLevel.Junior) ? 
                    DoJuniorWork() : 
                    DoSeniorWork());

            }
        }

        private static string DoSeniorWork()
        {
            return "Do senior work";
        }

        private static string DoJuniorWork()
        {
            return "Do senior work";
        }

        private static void Add()
        {
            Console.WriteLine("Add a new Employee, Quit with Q");

            do
            {
                string name = Util.AskForString("Name: ");
                if (name == "Q") break; //Break exits the loop
                double salary = Util.AskForDouble("Salary: ");
                payroll.AddEmployee(name, salary);

            } while (true); //Endless loop
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
