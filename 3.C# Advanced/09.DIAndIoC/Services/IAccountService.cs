namespace _09.DIAndIoC.Services
{
    public interface IAccountService
    {
        void CreateAccount(string accountNumber, string owner, decimal initialBalance);
        void Deposit(string accountNumber, decimal amount);
        void Withdraw(string accountNumber, decimal amount);
        decimal GetBalance(string accountNumber);
    }
}
