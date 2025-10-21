namespace _01.BasicSyntaxAndStructure
{
    internal class Program
    {
        // Main method is the entry point of a C# application
        static void Main(string[] args)
        {
            // Variable declaration and initialization
            int number = 10;
            double pi = 3.14159;
            string greeting = "Hello, C#!";



            // Outputting variables
            Console.WriteLine(greeting);
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Pi: " + pi);



            // Conditional statement
            if (number > 0)
            {
                Console.WriteLine("Number is positive.");
            }
            else
            {
                Console.WriteLine("Number is zero or negative.");
            }



            // Loop example (for loop)
            Console.WriteLine("Printing numbers from 1 to 5:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }



            // Arrays and collections
            int[] numbersArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Elements of array:");
            foreach (var num in numbersArray)
            {
                Console.WriteLine(num);
            }



            // Method call
            DisplayMessage("C# Syntax");



            // End of program
            Console.WriteLine("End of program.");
        }

        // Method definition
        static void DisplayMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }
    }
}
