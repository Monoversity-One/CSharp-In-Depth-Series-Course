namespace _11.NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            Console.WriteLine($"HasValue: {x.HasValue}");

            int valueOrDefault = x ?? 42; // null-coalescing
            Console.WriteLine($"Value or default: {valueOrDefault}");

            DateTime? when = null;
            Console.WriteLine($"Year? {when?.Year}"); // null-conditional

            when ??= DateTime.Today; // null-coalescing assignment
            Console.WriteLine($"When: {when:yyyy-MM-dd}");
        }
    }
}
