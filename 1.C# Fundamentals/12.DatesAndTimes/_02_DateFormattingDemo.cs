using System.Globalization;

namespace _12.DatesAndTimes
{
    public static class _02_DateFormattingDemo
    {
        public static void Demo()
        {
            DateTime aprFools = new DateTime(2025, 4, 1, 13, 23, 30);

            Console.WriteLine($"{aprFools:d}");
            Console.WriteLine($"{aprFools:D}");
            Console.WriteLine($"{aprFools:f}");
            Console.WriteLine($"{aprFools:F}");
            Console.WriteLine($"{aprFools:g}");
            Console.WriteLine($"{aprFools:G}");

            Console.WriteLine(aprFools.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));

            Console.WriteLine($"{aprFools:dddd, MMMM d yyyy}");
            Console.WriteLine($"{aprFools:ddd h:mm:ss tt}");
            Console.WriteLine($"{aprFools:MMM d yyyy}");
        }
    }
}
