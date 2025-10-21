namespace _10.Object_OrientedProgramming._02.ConstructorsAndDestructors
{
    class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor with parameters
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Person created: {Name}, Age: {Age}");
        }

        // Default constructor
        public Person()
        {
            Name = "Unknown";
            Age = 0;
            Console.WriteLine("Person created with default values.");
        }

        // Destructor
        ~Person()
        {
            Console.WriteLine($"Person destructed: {Name}");
        }

        // Method to display person details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
