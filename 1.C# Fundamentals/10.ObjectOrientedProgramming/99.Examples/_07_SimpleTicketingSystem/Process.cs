namespace _10.Object_OrientedProgramming._99.Examples._07_SimpleTicketingSystem
{
    public class Process
    {
        public static int _counter = 0;
        private string _firstName;
        private string _lastName;
        private string _gender;
        private int _age;

        public void MakeReservation()
        {
            _counter++;

            Console.WriteLine("Enter first name:");
            _firstName = Console.ReadLine();

            Console.WriteLine("Enter age:");
            _age = Convert.ToInt32(Console.ReadLine());
        }

        public string CheckAge()
        {
            string result = string.Empty;

            if (_age < 18)
            {
                result = $"{_firstName} X";
            }

            if (_age is 18 or > 18)
            {
                Console.WriteLine("Enter last name:");
                _lastName = Console.ReadLine();

                Console.WriteLine("Enter gender using M or F:");
                _gender = Console.ReadLine();

                result = $"{(_gender.ToLower() == "m" ? "Mr." : "Mrs.")} {_lastName} is allowed into the program.";
            }

            return result;
        }
    }
}
