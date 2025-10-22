namespace _02.NamespacesAndAssemblies
{
    public static class LogManager
    {
        public static void WriteLog(string message)
        {
            // Simulated logging operation
            Console.WriteLine($"[Log] {DateTime.Now}: {message}");
        }
    }
}
