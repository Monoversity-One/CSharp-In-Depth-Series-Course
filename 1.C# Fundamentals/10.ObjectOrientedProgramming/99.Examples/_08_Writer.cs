namespace _10.Object_OrientedProgramming._99.Examples
{
    public class Writer
    {
        public Writer()
        {

        }

        public Writer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _numberOfPublication;

        public int NumberOfPublications
        {
            get => _numberOfPublication;
            set => _numberOfPublication = value < 0 ? 0 : value;
        }

        public string GetFullName()
        {
            return LastName + " " + FirstName;
        }

        public string CheckAge(int age)
        {
            if (age > 18)
            {
                return "Adult";
            }

            //if (age < 18 && age > 10)
            //{
            //    return "Teenage";
            //}

            //Pattern
            if (age is < 18 and > 10)
            {
                return "Teenage";
            }

            return "Child";
        }
    }
}
