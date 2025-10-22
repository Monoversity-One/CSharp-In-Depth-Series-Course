namespace _01.StringsAndTextManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String declaration and initialization
            string message = "Hello, C# Intermediate Course!";



            // Display the original message
            Console.WriteLine("Original Message:");
            Console.WriteLine(message);
            Console.WriteLine();



            // String length
            int length = message.Length;
            Console.WriteLine($"Length of the message: {length}");
            Console.WriteLine();



            // Accessing characters in a string
            char firstChar = message[0];
            char lastChar = message[message.Length - 1];
            Console.WriteLine($"First character: {firstChar}");
            Console.WriteLine($"Last character: {lastChar}");
            Console.WriteLine();



            // Substring
            string substring = message.Substring(7, 12);
            Console.WriteLine($"Substring from index 7 to 19: {substring}");
            Console.WriteLine();



            // Concatenation
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine();



            // String interpolation
            int age = 30;
            string interpolatedMessage = $"Name: {firstName} {lastName}, Age: {age}";
            Console.WriteLine($"Interpolated Message: {interpolatedMessage}");
            Console.WriteLine();



            // String manipulation: converting case
            string lowerCaseMessage = message.ToLower();
            string upperCaseMessage = message.ToUpper();
            Console.WriteLine($"Lowercase message: {lowerCaseMessage}");
            Console.WriteLine($"Uppercase message: {upperCaseMessage}");
            Console.WriteLine();



            // String manipulation: replacing text
            string replacedMessage = message.Replace("Hello", "Hi");
            Console.WriteLine($"Replaced message: {replacedMessage}");
            Console.WriteLine();



            // String splitting
            string names = "John, Jane, Doe";
            string[] nameArray = names.Split(", ");
            Console.WriteLine("Names:");
            foreach (var name in nameArray)
            {
                Console.WriteLine(name);
            }
        }
    }
}
