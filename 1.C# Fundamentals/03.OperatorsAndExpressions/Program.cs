namespace _03.OperatorsAndExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic operators
            int a = 10;
            int b = 3;
            int sum = a + b;        // Addition
            int difference = a - b; // Subtraction
            int product = a * b;    // Multiplication
            int quotient = a / b;   // Division (integer division)
            int remainder = a % b;  // Modulus (remainder)



            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);



            // Increment and decrement operators
            int num = 5;
            Console.WriteLine("Original value: " + num);
            num++;  // Increment operator (equivalent to num = num + 1)
            Console.WriteLine("After increment: " + num);
            num--;  // Decrement operator (equivalent to num = num - 1)
            Console.WriteLine("After decrement: " + num);



            // Relational and logical operators
            bool isEqual = (a == b);    // Equality comparison
            bool isGreater = (a > b);   // Greater than comparison
            bool isLessOrEqual = (a <= b);  // Less than or equal to comparison



            Console.WriteLine("Is equal: " + isEqual);
            Console.WriteLine("Is greater: " + isGreater);
            Console.WriteLine("Is less or equal: " + isLessOrEqual);



            // Conditional operator (ternary operator)
            int x = 10;
            int y = 5;
            int max = (x > y) ? x : y;  // If x > y, assign x to max; otherwise, assign y to max

            Console.WriteLine("Max value: " + max);



            // Bitwise operators (example of bitwise AND)
            int num1 = 5;   // Binary representation: 101
            int num2 = 3;   // Binary representation: 011
            int result = num1 & num2;   // Bitwise AND: 001 (decimal 1)

            Console.WriteLine("Bitwise AND result: " + result);
        }
    }
}
