using System.Text;

namespace _02.VariablesAndDataTypesAndTypeConversion
{
    public static class _04_StringBuilderDemo
    {
        public static void Demo()
        {
            var builder = new StringBuilder("Hello World");

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine("First char: " + builder[0]);
        }
    }
}
