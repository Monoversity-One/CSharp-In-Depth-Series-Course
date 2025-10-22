namespace _09.WindowsFormsDevelopment
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name, string position, int age)
        {
            Id = id;
            Name = name;
            Position = position;
            Age = age;
        }
    }
}
