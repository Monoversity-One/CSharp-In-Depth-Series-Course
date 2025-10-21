namespace _10.Object_OrientedProgramming._04.AccessModifiers
{
    internal class _02_Course
    {
        public string? Title { get; set; }
        public string? Code { get; set; }
        public int Credit { get; set; }

        public _02_Course() { }
        public _02_Course(string title, string code, int credit)
        {
            Title = title;
            Code = code;
            Credit = credit;
        }
    }
}
