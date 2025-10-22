namespace _10.UnitTestingAndTDD
{
    public class SavingsAccount : BankAccount
    {
        private const decimal InterestRate = 0.05m; // 5% annual interest

        public SavingsAccount(string accountNumber, string owner, decimal initialBalance)
            : base(accountNumber, owner, initialBalance)
        {
        }

        public override void ApplyInterest()
        {
            decimal interest = Balance * InterestRate;
            Balance += interest;
            Transactions.Add($"Applied interest: {interest:C}");
        }
    }
}
