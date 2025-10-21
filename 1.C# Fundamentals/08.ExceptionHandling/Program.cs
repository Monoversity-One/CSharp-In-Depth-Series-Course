namespace _08.ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basic try-catch example
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine("Accessing element at index 5: " + numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



            // Try-catch-finally example
            try
            {
                int result = Divide(10, 0);
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }



            // Multiple catch blocks
            try
            {
                string str = null;
                Console.WriteLine("String length: " + str.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null Reference Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
            }



            // Custom exception example
            try
            {
                ValidateAge(15);
            }
            catch (AgeException ex)
            {
                Console.WriteLine("Age Exception: " + ex.Message);
            }



            // Throwing an exception manually
            try
            {
                ThrowException();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Manual Exception: " + ex.Message);
            }
        }



        static int Divide(int a, int b)
        {
            return a / b;
        }



        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new AgeException("Age must be 18 or older.");
            }
            Console.WriteLine("Age is valid.");
        }



        static void ThrowException()
        {
            throw new InvalidOperationException("This is a manually thrown exception.");
        }
    }



    // Custom exception class
    public class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {
        }
    }
}
