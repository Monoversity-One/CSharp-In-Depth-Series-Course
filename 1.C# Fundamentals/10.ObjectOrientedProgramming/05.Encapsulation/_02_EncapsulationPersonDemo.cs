namespace _10.Object_OrientedProgramming._05.Encapsulation
{
    class Person
    {
        // Private fields
        private string name;
        private int age;

        // Public properties to access private fields
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be negative");
                }
            }
        }

        // Constructor
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // Method to display person details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
