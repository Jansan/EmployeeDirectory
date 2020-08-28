namespace EmployeeDirectory
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

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

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
        //private string name;
        //private double salary;

        //  public string Name { get; set; }

        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        //public Employee(string name, double salary)
        //{
        //    this.name = name;
        //    this.salary = salary;
        //}

        //public void setName(string name)
        //{
        //    this.name = name;
        //}
        //public string GetName()
        //{
        //    return name;
        //}

        

    }
}