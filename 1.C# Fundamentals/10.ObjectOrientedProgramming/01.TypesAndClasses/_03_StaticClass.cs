namespace _10.Object_OrientedProgramming._01.TypesAndClasses
{
    public static class _03_StaticClass
    {
        public static string data;
        public static void SimpleMethod()
        {
            Console.WriteLine("Hello form static class!");
        }
    }

    class AnotherClass2
    {
        //Error : can't be instantiated and inherited
        //_03_StaticClass first = new _03_StaticClass();

        public void AnotherMethod()
        {
            _03_StaticClass.SimpleMethod();
        }
    }
}
