namespace _10.Object_OrientedProgramming._99.Examples._05_Company
{
    public class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(int workingHours, int schoolHours, string name, string firstName, int salary)
        : base(name, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }


        public void Learn()
        {
            Console.WriteLine("I'm learning for {0} hours!", SchoolHours);
        }

        public new void Work()
        {
            Console.WriteLine("I work for {0} hours.", WorkingHours);
        }
    }
}
