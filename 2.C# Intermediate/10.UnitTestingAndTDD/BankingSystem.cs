namespace _10.UnitTestingAndTDD
{
    public class BankingSystem
    {
        private List<BankAccount> accounts = new List<BankAccount>();

        public void AddAccount(BankAccount account)
        {
            if (account == null)
                throw new ArgumentNullException(nameof(account), "Account cannot be null.");

            accounts.Add(account);
        }

        public BankAccount GetAccount(string accountNumber)
        {
            return accounts.SingleOrDefault(a => a.AccountNumber == accountNumber);
        }

        public void ApplyMonthlyInterest()
        {
            foreach (var account in accounts.OfType<SavingsAccount>())
            {
                account.ApplyInterest();
            }
        }

        public void PrintAccountDetails(string accountNumber)
        {
            var account = GetAccount(accountNumber);
            if (account != null)
            {
                Console.WriteLine($"Account Number: {account.AccountNumber}");
                Console.WriteLine($"Owner: {account.Owner}");
                Console.WriteLine($"Balance: {account.Balance:C}");
                Console.WriteLine("Transactions:");
                foreach (var transaction in account.Transactions)
                {
                    Console.WriteLine($" - {transaction}");
                }
            }
            else
            {
                Console.WriteLine($"Account with number {accountNumber} not found.");
            }
        }
    }
}
