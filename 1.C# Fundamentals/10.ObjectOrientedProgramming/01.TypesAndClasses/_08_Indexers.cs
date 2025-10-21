namespace _10.Object_OrientedProgramming._01.TypesAndClasses
{
    class _08_Indexers
    {
        void SimpleMethod()
        {
            IndexersClass myObj = new IndexersClass();
            myObj[0] = "Hello";
            myObj[2] = "World";
            myObj[1] = "Data";
            Console.WriteLine(myObj[1]);
        }
    }

    class IndexersClass
    {
        private string[] name = new string[100];

        public string this[int index]
        {
            get { return name[index]; }
            set { name[index] = value; }
        }
    }
}
