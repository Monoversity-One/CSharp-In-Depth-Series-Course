namespace _02.NamespacesAndAssemblies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using classes from different namespaces
            Console.WriteLine("Namespaces and Assemblies Example");
            Console.WriteLine();



            // Using classes from System namespace
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date and Time: {now}");
            Console.WriteLine();



            // Using classes from MyCompany.Utilities namespace
            string hashedPassword = SecurityHelper.ComputeHash("password123");
            Console.WriteLine($"Hashed Password: {hashedPassword}");
            Console.WriteLine();



            // Accessing classes from other assemblies
            MyClass myObject = new MyClass();
            string result = myObject.ProcessData("Data to process");
            Console.WriteLine($"Processed Data: {result}");
            Console.WriteLine();



            // Using nested namespaces
            LogManager.WriteLog("Log message from Example.cs");
        }
    }
}
