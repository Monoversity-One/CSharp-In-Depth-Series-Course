namespace _10.Object_OrientedProgramming._99.Examples._07_SimpleTicketingSystem
{
    public class Receptionist
    {
        public string TicketPrint()
        {
            Console.WriteLine("Enter the number of applicants: ");
            int numberOfApplicants = Convert.ToInt32(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < numberOfApplicants; i++)
            {
                Process temp = new Process();

                temp.MakeReservation();
                result += temp.CheckAge() + "\n";
            }

            return result;
        }
    }
}
