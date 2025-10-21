namespace _07.MethodsAndFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling a simple method
            SayHello();



            // Calling a method with parameters
            int sum = AddNumbers(5, 3);
            Console.WriteLine("Sum: " + sum);



            // Calling a method with return value and output parameter
            int result;
            Multiply(4, 6, out result);
            Console.WriteLine("Multiplication result: " + result);



            // Calling a method with optional parameters
            PrintMessage("Hello"); // Will use default value for 'count'



            // Calling a method with named arguments
            PrintMessage(message: "Hi", count: 3);



            // Method overloading example
            Console.WriteLine("Area of rectangle: " + CalculateArea(5, 3));
            Console.WriteLine("Area of circle: " + CalculateArea(5));



            // Recursion example (factorial function)
            int factorial = Factorial(5);
            Console.WriteLine("Factorial of 5: " + factorial);
        }



        // Simple method (void, no parameters)
        static void SayHello()
        {
            Console.WriteLine("Hello, methods!");
        }



        // Method with parameters and return value
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }



        // Method with output parameter
        static void Multiply(int x, int y, out int result)
        {
            result = x * y;
        }



        // Method with optional parameter
        static void PrintMessage(string message, int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }



        // Method overloading
        static int CalculateArea(int length, int width)
        {
            return length * width;
        }



        static double CalculateArea(int radius)
        {
            return Math.PI * radius * radius;
        }



        // Recursive method (factorial)
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
