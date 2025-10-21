namespace _05.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For loop example
            Console.WriteLine("For loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }



            // While loop example
            Console.WriteLine("\nWhile loop:");
            int counter = 1;
            while (counter <= 5)
            {
                Console.WriteLine("Count: " + counter);
                counter++;
            }



            // Do-while loop example
            Console.WriteLine("\nDo-while loop:");
            int number = 1;
            do
            {
                Console.WriteLine("Number: " + number);
                number++;
            } while (number <= 5);



            // Foreach loop example with an array
            Console.WriteLine("\nForeach loop:");
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var num in numbers)
            {
                Console.WriteLine("Number: " + num);
            }



            // Nested loop example (for loop inside another for loop)
            Console.WriteLine("\nNested loops:");
            for (int row = 1; row <= 3; row++)
            {
                for (int col = 1; col <= 3; col++)
                {
                    Console.Write($"({row}, {col}) ");
                }
                Console.WriteLine();
            }



            // Infinite loop example using while (use with caution)
            /*
            Console.WriteLine("\nInfinite loop:");
            while (true)
            {
                Console.WriteLine("This is an infinite loop!");
                // Add break condition to exit loop
            }
            */



            // Breaking out of a loop example
            Console.WriteLine("\nBreak statement:");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 6)
                {
                    break; // Exit the loop when i equals 6
                }
                Console.WriteLine("Iteration: " + i);
            }



            // Skipping iteration example using continue
            Console.WriteLine("\nContinue statement:");
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue; // Skip iteration when i equals 3
                }
                Console.WriteLine("Iteration: " + i);
            }
        }
    }
}
