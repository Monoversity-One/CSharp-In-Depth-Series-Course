namespace _10.Object_OrientedProgramming._03.FieldsAndProperties
{
    class Person
    {
        // Private fields
        private string name;
        private int age;

        // Public property for 'name' with get and set accessors
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Public property for 'age' with get and set accessors
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0) // Validation to ensure age is non-negative
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be negative");
                }
            }
        }

        // Auto-implemented property for 'address'
        public string Address { get; set; }

        // Constructor
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.Age = age; // Using the property to leverage validation
            this.Address = address;
        }

        // Method to display person details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
        }
    }
}
