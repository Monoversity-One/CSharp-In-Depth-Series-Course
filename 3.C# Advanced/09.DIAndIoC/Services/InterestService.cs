namespace _09.DIAndIoC.Services
{
    public class InterestService : IInterestService
    {
        private readonly IAccountService _accountService;
        private readonly ILoggerService _logger;
        private const decimal InterestRate = 0.05m; // 5% annual interest

        public InterestService(IAccountService accountService, ILoggerService logger)
        {
            _accountService = accountService;
            _logger = logger;
        }

        public void ApplyInterest(string accountNumber)
        {
            var balance = _accountService.GetBalance(accountNumber);
            var interest = balance * InterestRate;
            _accountService.Deposit(accountNumber, interest);
            _logger.Log($"Applied interest of {interest:C} to account {accountNumber}");
        }
    }
}
