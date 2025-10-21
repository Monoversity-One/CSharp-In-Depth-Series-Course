namespace _10.Object_OrientedProgramming._99.Examples
{
    class BankAccount
    {
        // Private fields
        private double balance;

        // Public property for balance with only a getter (read-only)
        public double Balance
        {
            get { return balance; }
        }

        // Constructor
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: ${amount}. New Balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: ${amount}. New Balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
    }

}
