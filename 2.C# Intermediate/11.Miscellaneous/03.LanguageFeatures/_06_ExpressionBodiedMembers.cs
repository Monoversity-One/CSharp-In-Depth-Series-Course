namespace _11.Miscellaneous._03.LanguageFeatures
{
    class _06_ExpressionBodiedMembers
    {
        void ThisIsMain()
        {

        }

        //Expression bodied method
        public int AddNumbers(int x, int y) => x + y;
        public void SayHi() => Console.WriteLine("Hello");
    }

    class ExpressionBodiedClass
    {
        private int age;
        public int Age
        {
            get => age;
            set => age = value;
        }

        public ExpressionBodiedClass() => Console.WriteLine("Constructor is here!");
    }
}
