using System.Reflection;

namespace _10.Reflection
{
    public class _01_Assembly
    {
        void ThisIsMain()
        {
            Console.WriteLine(Assembly.GetEntryAssembly()?.Location);
            Console.WriteLine(Assembly.GetEntryAssembly()?.FullName);
        }
    }
}
