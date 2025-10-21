namespace _10.Object_OrientedProgramming._99.Examples
{
    class Person
    {
        // Properties (fields)
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method
        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}
