namespace _09.InputOutputBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console Output
            Console.WriteLine("Welcome to the Input/Output Basics in C#");

            // Console Input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");



            // Parsing input to different data types
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age;
            if (int.TryParse(ageInput, out age))
            {
                Console.WriteLine("You are " + age + " years old.");
            }
            else
            {
                Console.WriteLine("Invalid age input.");
            }



            // Reading a single character
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine(); // To move to the next line



            // File path (adjust as necessary)
            string filePath = "example.txt";



            // Writing to a file
            string[] lines = { "First line", "Second line", "Third line" };
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Text written to file.");



            // Reading from a file
            if (File.Exists(filePath))
            {
                string[] readLines = File.ReadAllLines(filePath);
                Console.WriteLine("Reading from file:");
                foreach (string line in readLines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }



            // Appending to a file
            string appendText = "Fourth line" + Environment.NewLine;
            File.AppendAllText(filePath, appendText);
            Console.WriteLine("Text appended to file.");



            // Reading the appended file content
            Console.WriteLine("Reading appended file:");
            string[] appendedLines = File.ReadAllLines(filePath);
            foreach (string line in appendedLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
