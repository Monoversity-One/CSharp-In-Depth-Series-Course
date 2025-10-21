namespace _02.VariablesAndDataTypesAndTypeConversion
{
    public static class _06_StringSummaryDemo
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length <= maxLength)
                return text;

            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var summaryWords = new List<string>();
            var total = 0;

            foreach (var word in words)
            {
                // +1 for the space that will be inserted when joining
                if (total + word.Length + (summaryWords.Count > 0 ? 1 : 0) > maxLength)
                    break;

                summaryWords.Add(word);
                total += word.Length + (summaryWords.Count > 1 ? 1 : 0);
            }

            return string.Join(" ", summaryWords) + "...";
        }

        public static void Demo()
        {
            var sentence = "This is a really really really really really long text.";
            var summary = SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}
