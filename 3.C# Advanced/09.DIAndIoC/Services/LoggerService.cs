namespace _09.DIAndIoC.Services
{
    public class LoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
