namespace _12.DatesAndTimes
{
    public static class _03_DateParsingDemo
    {
        public static void Demo()
        {
            string[] sampleDateTimes =
            {
                "January 1, 2025 9:30 AM",
                "1/1/2025",
                "Jan 1, 2025 7:30PM",
                "Jan 1, 25",
                "1/2025",
                "1/1 7PM",
                "Jan 1 '15",
            };

            foreach (var datestr in sampleDateTimes)
            {
                if (DateTime.TryParse(datestr, out var result))
                {
                    Console.WriteLine($"{datestr,-25} => {result}");
                }
                else
                {
                    Console.WriteLine($"Could not parse '{datestr}'");
                }
            }
        }
    }
}
