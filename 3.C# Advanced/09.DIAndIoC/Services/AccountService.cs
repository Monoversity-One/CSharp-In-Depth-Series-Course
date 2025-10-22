namespace _09.DIAndIoC.Services
{
    public class AccountService : IAccountService
    {
        private readonly ILoggerService _logger;
        private readonly Dictionary<string, BankAccount> _accounts;

        public AccountService(ILoggerService logger)
        {
            _logger = logger;
            _accounts = new Dictionary<string, BankAccount>();
        }

        public void CreateAccount(string accountNumber, string owner, decimal initialBalance)
        {
            var account = new BankAccount(accountNumber, owner, initialBalance);
            _accounts.Add(accountNumber, account);
            _logger.Log($"Account created for {owner} with initial balance {initialBalance:C}");
        }

        public void Deposit(string accountNumber, decimal amount)
        {
            if (_accounts.TryGetValue(accountNumber, out var account))
            {
                account.Deposit(amount);
                _logger.Log($"Deposited {amount:C} to account {accountNumber}");
            }
            else
            {
                _logger.Log($"Account {accountNumber} not found.");
            }
        }

        public void Withdraw(string accountNumber, decimal amount)
        {
            if (_accounts.TryGetValue(accountNumber, out var account))
            {
                account.Withdraw(amount);
                _logger.Log($"Withdrew {amount:C} from account {accountNumber}");
            }
            else
            {
                _logger.Log($"Account {accountNumber} not found.");
            }
        }

        public decimal GetBalance(string accountNumber)
        {
            if (_accounts.TryGetValue(accountNumber, out var account))
            {
                return account.Balance;
            }
            else
            {
                _logger.Log($"Account {accountNumber} not found.");
                return 0;
            }
        }
    }
}
