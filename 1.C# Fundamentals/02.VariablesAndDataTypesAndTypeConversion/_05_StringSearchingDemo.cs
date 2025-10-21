namespace _02.VariablesAndDataTypesAndTypeConversion
{
    public static class _05_StringSearchingDemo
    {
        public static void Demo()
        {
            string teststr = "The quick brown Fox jumps over the lazy Dog";

            Console.WriteLine(teststr.Contains("fox"));
            Console.WriteLine(teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine(teststr.StartsWith("the"));
            Console.WriteLine(teststr.StartsWith("the", StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(teststr.EndsWith("dog"));
            Console.WriteLine(teststr.EndsWith("dog", StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine(teststr.IndexOf("the"));
            Console.WriteLine(teststr.IndexOf("the", StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(teststr.LastIndexOf("the"));

            string str1 = null;
            string str2 = "   ";
            string str3 = string.Empty;
            Console.WriteLine(string.IsNullOrEmpty(str1));
            Console.WriteLine(string.IsNullOrEmpty(str3));
            Console.WriteLine(string.IsNullOrWhiteSpace(str2));
        }
    }
}
