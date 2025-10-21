namespace _04.ControlFlowAndDecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If statement
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("Number is positive.");
            }



            // If-else statement
            int x = 5;
            int y = 3;
            if (x > y)
            {
                Console.WriteLine("X is greater than Y.");
            }
            else
            {
                Console.WriteLine("X is not greater than Y.");
            }



            // If-else if-else ladder
            int grade = 85;
            if (grade >= 90)
            {
                Console.WriteLine("Grade is A.");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Grade is B.");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Grade is C.");
            }
            else
            {
                Console.WriteLine("Grade is F.");
            }



            // Switch statement
            int dayOfWeek = 3;
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Weekend");
                    break;
            }



            // Ternary operator example
            int age = 20;
            string status = (age >= 18) ? "Adult" : "Minor";
            Console.WriteLine("Age status: " + status);
        }
    }
}
