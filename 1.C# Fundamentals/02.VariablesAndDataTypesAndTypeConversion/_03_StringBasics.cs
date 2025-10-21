namespace _02.VariablesAndDataTypesAndTypeConversion
{
    public static class _03_StringBasics
    {
        public static void Demo()
        {
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";

            Console.WriteLine(str1.Length);
            Console.WriteLine(str1[14]);

            foreach (char ch in str1)
            {
                Console.Write(ch);
                if (ch == 'b') { Console.WriteLine(); break; }
            }

            bool isEqual = str2.Equals(str3);
            Console.WriteLine(isEqual);

            int result = string.Compare(str2, "This is a string");
            Console.WriteLine(result);

            string replaced = str1.Replace("fox", "cat");
            Console.WriteLine(replaced);
        }
    }
}
