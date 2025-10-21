using System.Globalization;

namespace _12.DatesAndTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Current date and time
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine($"Now: {now:O}");
            Console.WriteLine($"Today: {today:yyyy-MM-dd}");

            var inTenDays = today.AddDays(10);
            TimeSpan diff = inTenDays - today;
            Console.WriteLine($"Diff days: {diff.TotalDays}");

            var parsed = DateTime.ParseExact("2025-10-20 21:30", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine($"Parsed: {parsed:ddd, dd MMM yyyy HH:mm}");

            var ts = TimeSpan.FromHours(2) + TimeSpan.FromMinutes(30);
            Console.WriteLine($"TimeSpan: {ts}");


            // Date and time components
            int year = now.Year;
            int month = now.Month;
            int day = now.Day;
            int hour = now.Hour;
            int minute = now.Minute;
            int second = now.Second;
            Console.WriteLine($"Year: {year}, Month: {month}, Day: {day}");
            Console.WriteLine($"Time: {hour}:{minute}:{second}");
            Console.WriteLine();



            // Date formatting
            string shortDate = now.ToShortDateString();
            string longDate = now.ToLongDateString();
            string shortTime = now.ToShortTimeString();
            string longTime = now.ToLongTimeString();
            Console.WriteLine($"Short Date: {shortDate}");
            Console.WriteLine($"Long Date: {longDate}");
            Console.WriteLine($"Short Time: {shortTime}");
            Console.WriteLine($"Long Time: {longTime}");
            Console.WriteLine();



            // Adding and subtracting time
            DateTime futureDate = now.AddDays(7);
            DateTime pastDate = now.AddMonths(-1);
            Console.WriteLine($"Date 7 days from now: {futureDate}");
            Console.WriteLine($"Date 1 month ago: {pastDate}");
            Console.WriteLine();



            // Comparing dates
            DateTime date1 = new DateTime(2023, 7, 1);
            DateTime date2 = new DateTime(2023, 7, 15);
            int comparisonResult = DateTime.Compare(date1, date2);
            string comparisonMessage = comparisonResult < 0 ? "Date1 is earlier than Date2"
                                   : comparisonResult > 0 ? "Date1 is later than Date2"
                                   : "Date1 and Date2 are the same";
            Console.WriteLine($"Comparison Result: {comparisonMessage}");
            Console.WriteLine();



            // Date parsing
            string dateStr = "2023-07-01";
            DateTime parsedDate = DateTime.Parse(dateStr);
            Console.WriteLine($"Parsed Date: {parsedDate}");
            Console.WriteLine();



            // Time span calculation
            DateTime start = new DateTime(2023, 7, 1, 10, 0, 0);
            DateTime end = new DateTime(2023, 7, 1, 12, 30, 0);
            TimeSpan duration = end - start;
            Console.WriteLine($"Duration between {start} and {end}: {duration}");
        }
    }
}
