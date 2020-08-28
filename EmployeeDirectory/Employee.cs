namespace EmployeeDirectory
{
    public class Employee
    {
        //Property
        //prop snippet
        public string Name { get; set; }
        public double Salary { get; set; }

        //Property only get!
        public SalaryLevel SalaryLevel
        {
            get
            {
                if (Salary < 15000)
                {
                    return SalaryLevel.Junior;
                }
                else
                {
                    return SalaryLevel.Senior;
                }
            }
        }

        //Constructor
        //Constructor requires name and salary, removes the empty contructor
        //ctor snippet
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        //This method runs when you call ToString() on a employee instance
        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
        

    }
}