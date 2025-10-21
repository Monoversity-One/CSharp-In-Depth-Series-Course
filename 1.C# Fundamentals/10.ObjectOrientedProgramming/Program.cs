using _10.Object_OrientedProgramming._99.Examples;

namespace _10.Object_OrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating objects (instances of the Person class)
            Person person1 = new Person("Alice", 30);
            Person person2 = new Person("Bob", 25);

            // Accessing properties and methods
            person1.Introduce();
            person2.Introduce();



            // Creating a bank account object
            BankAccount account = new BankAccount(1000);

            // Accessing the balance (read-only)
            Console.WriteLine($"Initial Balance: ${account.Balance}");

            // Depositing and withdrawing money
            account.Deposit(500);
            account.Withdraw(200);
            account.Withdraw(1500); // Attempt to withdraw more than the balance
        }
    }
}
