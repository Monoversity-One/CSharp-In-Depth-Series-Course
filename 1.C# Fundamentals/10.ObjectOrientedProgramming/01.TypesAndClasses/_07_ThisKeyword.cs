namespace _10.Object_OrientedProgramming._01.TypesAndClasses
{
    public class _07_ThisKeyword
    {
        Person2 person = new Person2();
        void GetPersinData()
        {
            person.Display();
        }
    }
    class Person2
    {
        string firstName;
        string lastName;
        public string Display()
        {
            //this: the current instance of the class
            return this.firstName + " " + this.lastName;
        }
        
        public Person2()
        {
            firstName = "No FirstName";
            lastName = string.Empty;
        }

        //Same name for parameters and fields
        public Person2(string lastName)
        {
            this.lastName = lastName;
        }
    }
}
