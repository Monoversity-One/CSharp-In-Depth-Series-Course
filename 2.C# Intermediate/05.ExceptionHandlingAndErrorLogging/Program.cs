namespace _05.ExceptionHandlingAndErrorLogging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Simulate a method that may throw exceptions
                ProcessData();
            }
            catch (Exception ex)
            {
                // Handle and log the exception
                LogException(ex);
                Console.WriteLine("An error occurred. Please try again later.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }



        static void ProcessData()
        {
            // Simulate processing data that may cause exceptions
            Random random = new Random();
            int randomNumber = random.Next(0, 2); // Randomly choose between 0 and 1

            if (randomNumber == 0)
            {
                throw new IOException("File not found."); // Simulating an IOException
            }
            else
            {
                throw new ArgumentException("Invalid argument."); // Simulating an ArgumentException
            }
        }



        static void LogException(Exception ex)
        {
            // Simulate logging the exception to a file
            string logFilePath = "error.log";

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"Timestamp: {DateTime.Now}");
                writer.WriteLine($"Exception Type: {ex.GetType()}");
                writer.WriteLine($"Message: {ex.Message}");
                writer.WriteLine($"Stack Trace:\n{ex.StackTrace}");
                writer.WriteLine(new string('-', 50)); // Separator for each exception entry
            }

            Console.WriteLine($"Exception logged to {logFilePath}");
        }
    }
}
