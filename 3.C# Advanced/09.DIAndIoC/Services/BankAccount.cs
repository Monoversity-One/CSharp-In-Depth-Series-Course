namespace _09.DIAndIoC.Services
{
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string Owner { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, string owner, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            Balance -= amount;
        }
    }
}
