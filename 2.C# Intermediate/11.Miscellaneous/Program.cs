namespace _11.Miscellaneous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reviewing basic concepts from C# Fundamentals



            // Variables and basic types
            int age = 30;
            string name = "John Doe";
            double balance = 1000.50;
            bool isActive = true;

            Console.WriteLine($"Name: {name}, Age: {age}, Balance: {balance:C}, Active: {isActive}");



            // Control flow and decision making
            int marks = 75;
            string grade;

            if (marks >= 90)
            {
                grade = "A";
            }
            else if (marks >= 80)
            {
                grade = "B";
            }
            else if (marks >= 70)
            {
                grade = "C";
            }
            else if (marks >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            Console.WriteLine($"Marks: {marks}, Grade: {grade}");



            // Arrays and collections
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Numbers:");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();



            // Methods and functions
            int result = Add(5, 3);
            Console.WriteLine($"Result of addition: {result}");



            // Exception handling (basic example)
            try
            {
                int x = 10;
                int y = 0;
                int divisionResult = x / y; // This will throw a System.DivideByZeroException
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }



            // Object-oriented programming concepts (basic example)
            Person person = new Person("Jane Doe", 25);
            person.DisplayInfo();

            Console.WriteLine("Review of fundamentals completed.");
        }



        // Method for addition
        static int Add(int a, int b)
        {
            return a + b;
        }

    }



    // Class to demonstrate object-oriented programming
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
