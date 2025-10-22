using _09.DIAndIoC.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _09.DIAndIoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            var accountService = host.Services.GetRequiredService<IAccountService>();
            var interestService = host.Services.GetRequiredService<IInterestService>();

            accountService.CreateAccount("Account 1", "John Doe", 1000);
            accountService.CreateAccount("Account 2", "Jane Doe", 2000);

            var accounts = new[] { "Account 1", "Account 2" };
            foreach (var account in accounts)
            {
                accountService.Deposit(account, 500);
                accountService.Withdraw(account, 200);
                interestService.ApplyInterest(account);
                Console.WriteLine($"Balance for {account}: {accountService.GetBalance(account):C}");
            }
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services.AddSingleton<IAccountService, AccountService>()
                        .AddTransient<ILoggerService, LoggerService>()
                        .AddTransient<IInterestService, InterestService>());
    }
}
