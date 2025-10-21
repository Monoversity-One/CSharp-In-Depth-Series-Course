namespace _02.VariablesAndDataTypesAndTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables and data types
            int number = 10;                // Integer
            double pi = 3.14159;            // Double
            char character = 'A';           // Character
            string message = "Hello";       // String
            bool isTrue = true;             // Boolean



            // Output variables
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Pi: " + pi);
            Console.WriteLine("Character: " + character);
            Console.WriteLine("Message: " + message);
            Console.WriteLine("Is true? " + isTrue);



            // Type conversion examples
            // Implicit conversion (int to double)
            double result1 = number;  // Implicitly converts int to double
            Console.WriteLine("Implicit conversion result: " + result1);



            // Explicit conversion (double to int)
            double num2 = 20.5;
            int result2 = (int)num2;  // Explicitly converts double to int
            Console.WriteLine("Explicit conversion result: " + result2);




            // Parsing string to int
            string strNum = "30";
            int parsedNum = int.Parse(strNum);
            Console.WriteLine("Parsed number from string: " + parsedNum);



            // Conversion using Convert class
            string strDouble = "45.67";
            double convertedDouble = Convert.ToDouble(strDouble);
            Console.WriteLine("Converted double from string: " + convertedDouble);



            // Type conversion with exceptions
            string invalidStr = "invalid";
            try
            {
                int invalidNum = int.Parse(invalidStr);  // Attempting to parse invalid string
                Console.WriteLine("Parsed invalid string to int: " + invalidNum);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



            // Checking for conversion success (TryParse method)
            string numStr = "123";
            int parsedValue;
            if (int.TryParse(numStr, out parsedValue))
            {
                Console.WriteLine("Successfully parsed string to int: " + parsedValue);
            }
            else
            {
                Console.WriteLine("Failed to parse string to int.");
            }
        }
    }
}
