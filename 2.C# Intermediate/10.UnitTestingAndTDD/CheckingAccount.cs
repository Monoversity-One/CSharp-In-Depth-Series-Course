namespace _10.UnitTestingAndTDD
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountNumber, string owner, decimal initialBalance)
            : base(accountNumber, owner, initialBalance)
        {
        }

        public override void ApplyInterest()
        {
            // No interest for checking accounts
        }
    }
}
