namespace _10.Object_OrientedProgramming._99.Examples._05_Company
{
    public class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            Name = "One";
            FirstName = "Elliot";
            Salary = 50000;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("I'm working.");
        }

        public void Pause()
        {
            Console.WriteLine("I'm having a break.");
        }
    }
}
