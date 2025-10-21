namespace _13.Enums
{
    // Enumeration defining days of the week
    enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    enum Seasons
    {
        //indexes start from 0
        Spring,
        Summer,
        Fall,
        Winter
    }

    enum Season
    {
        Spring = 1,
        Summer = 2,
        Autumn = 3,
        Winter = 4
    }

    class MyCalendar
    {
        public Seasons Seasons = Seasons.Fall;
        public DayOfWeek WeekDay = DayOfWeek.Saturday;

        string day = DayOfWeek.Friday.ToString();
        int dayNumber = (int)DayOfWeek.Monday;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Using enums
            DayOfWeek today = DayOfWeek.Wednesday;
            Console.WriteLine($"Today is: {today}");
            Console.WriteLine();



            // Switch statement with enums
            switch (today)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's Sunday!");
                    break;
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    Console.WriteLine("It's a weekday.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("It's Friday!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("It's Saturday!");
                    break;
                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }

            Console.WriteLine();



            // Constants
            const double Pi = 3.14159;
            Console.WriteLine($"Value of Pi: {Pi}");
            Console.WriteLine();



            // Using constants in calculations
            double radius = 5.0;
            double area = Pi * radius * radius;
            Console.WriteLine($"Area of a circle with radius {radius}: {area}");

            Season current = Season.Autumn;
            Console.WriteLine($"Current: {current} ({(int)current})");

            int value = 2;
            var fromInt = (Season)value;
            Console.WriteLine($"From int 2 => {fromInt}");

            var parsed = Enum.Parse<Season>("Winter");
            Console.WriteLine($"Parsed => {parsed}");
        }
    }
}
