namespace _09.InputOutputBasics
{
    public static class _05_StringFormattingDemo
    {
        public static void Demo()
        {
            float f1 = 123.4f;
            int i1 = 2000;

            Console.WriteLine("{0,-15} {1,10}", "Float Val", "Int Val");
            Console.WriteLine("{0,-15} {1,10}", f1, i1);

            Console.WriteLine("{0,-15} {1,10}", "Float Val", "Int Val");
            Console.WriteLine($"{f1,-15} {i1,10}");
        }
    }
}
