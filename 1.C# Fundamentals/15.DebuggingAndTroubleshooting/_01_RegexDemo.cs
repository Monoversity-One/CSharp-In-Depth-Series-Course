using System.Diagnostics;
using System.Text.RegularExpressions;

namespace _15.DebuggingAndTroubleshooting
{
    public static class _01_RegexDemo
    {
        public static void FindAndReplace()
        {
            string teststr1 = "The quick brown Fox jumps over the lazy Dog";
            string teststr2 = "the quick brown fox jumps over the lazy dog";

            Regex capWords = new(@"[A-Z]\w+");
            Console.WriteLine(capWords.IsMatch(teststr1));
            Console.WriteLine(capWords.IsMatch(teststr2));

            Regex noCase = new(@"fox", RegexOptions.IgnoreCase);
            Console.WriteLine(noCase.IsMatch(teststr1));

            var m = capWords.Match(teststr1);
            while (m.Success)
            {
                Console.WriteLine($"'{m.Value}' at {m.Index}");
                m = m.NextMatch();
            }

            var replaced = capWords.Replace(teststr1, "***");
            Console.WriteLine(teststr1);
            Console.WriteLine(replaced);
        }

        public static void WithTimeout()
        {
            const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            TimeSpan timeout = TimeSpan.FromMilliseconds(1000);
            try
            {
                var sw = Stopwatch.StartNew();
                Regex r = new(@"(a+a+)+b", RegexOptions.None, timeout);
                var mc = r.Matches(thestr);
                sw.Stop();
                Console.WriteLine($"Found {mc.Count} matches in {sw.Elapsed}");
            }
            catch (RegexMatchTimeoutException e)
            {
                Console.WriteLine($"Regex timed out: {e.MatchTimeout}");
            }
        }
    }
}
