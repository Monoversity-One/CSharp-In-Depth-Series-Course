namespace _10.UnitTestingAndTDD
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string Owner { get; private set; }
        public decimal Balance { get; protected set; }
        public List<string> Transactions { get; private set; }

        public BankAccount(string accountNumber, string owner, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = initialBalance;
            Transactions = new List<string>();
            Transactions.Add($"Account created with initial balance {initialBalance:C}");
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            Balance += amount;
            Transactions.Add($"Deposited {amount:C}");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds.");

            Balance -= amount;
            Transactions.Add($"Withdrew {amount:C}");
        }

        public void Transfer(BankAccount destination, decimal amount)
        {
            if (destination == null)
                throw new ArgumentNullException(nameof(destination), "Destination account cannot be null.");

            Withdraw(amount);
            destination.Deposit(amount);
            Transactions.Add($"Transferred {amount:C} to {destination.AccountNumber}");
        }

        public abstract void ApplyInterest();
    }
}
