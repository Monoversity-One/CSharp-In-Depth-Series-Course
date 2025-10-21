namespace _06.ArraysAndCollections
{
    public static class _04_StringSplitJoin
    {
        public static void Demo()
        {
            var csv = "one,two,three,four";
            var parts = csv.Split(',');
            Console.WriteLine(string.Join(" | ", parts));

            var sentence = "The quick brown fox";
            var words = sentence.Split(' ');
            Console.WriteLine(string.Join("-", words));
        }
    }
}
