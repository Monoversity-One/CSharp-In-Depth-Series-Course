namespace _09.InputOutputBasics
{
    public static class _03_NumberParsingDemo
    {
        public static void Demo()
        {
            string[] samples = { "  1 ", " 1.45  ", "-100", "5e+04 " };

            foreach (var s in samples)
            {
                try
                {
                    float f = float.Parse(s);
                    Console.WriteLine($"Parsed float: '{s}' => {f}");
                    int i = int.Parse(s);
                    Console.WriteLine($"Parsed int:   '{s}' => {i}");
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Could not parse '{s}': {e.Message}");
                }
            }

            if (int.TryParse(samples[0], out var ti))
                Console.WriteLine($"TryParse int ok: '{samples[0]}' => {ti}");
            if (float.TryParse(samples[1], out var tf))
                Console.WriteLine($"TryParse float ok: '{samples[1]}' => {tf}");
            Console.WriteLine($"TryParse int on '{samples[2]}': {int.TryParse(samples[2], out ti)} => {ti}");
            Console.WriteLine($"TryParse float on '{samples[3]}': {float.TryParse(samples[3], out tf)} => {tf}");
        }
    }
}
