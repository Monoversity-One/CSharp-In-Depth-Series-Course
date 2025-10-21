namespace _05.Loops
{
    public static class _03_RandomPasswordDemo
    {
        public static void Demo()
        {
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine($"Random password: {password}");
        }
    }
}
