using Xunit;

namespace _10.UnitTestingAndTDD
{
    public class BankAccountTests
    {
        [Fact]
        public void Deposit_ValidAmount_ShouldIncreaseBalance()
        {
            // Arrange
            var account = new CheckingAccount("12345", "John Doe", 1000);

            // Act
            account.Deposit(500);

            // Assert
            Assert.Equal(1500, account.Balance);
        }

        [Fact]
        public void Withdraw_ValidAmount_ShouldDecreaseBalance()
        {
            // Arrange
            var account = new CheckingAccount("12345", "John Doe", 1000);

            // Act
            account.Withdraw(500);

            // Assert
            Assert.Equal(500, account.Balance);
        }

        [Fact]
        public void Transfer_ValidAmount_ShouldTransferFunds()
        {
            // Arrange
            var sourceAccount = new CheckingAccount("12345", "John Doe", 1000);
            var destinationAccount = new CheckingAccount("67890", "Jane Doe", 500);

            // Act
            sourceAccount.Transfer(destinationAccount, 200);

            // Assert
            Assert.Equal(800, sourceAccount.Balance);
            Assert.Equal(700, destinationAccount.Balance);
        }

        [Fact]
        public void ApplyInterest_SavingsAccount_ShouldIncreaseBalance()
        {
            // Arrange
            var account = new SavingsAccount("12345", "John Doe", 1000);

            // Act
            account.ApplyInterest();

            // Assert
            Assert.Equal(1050, account.Balance);
        }
    }

    public class BankingSystemTests
    {
        [Fact]
        public void AddAccount_ShouldAddAccountToSystem()
        {
            // Arrange
            var system = new BankingSystem();
            var account = new CheckingAccount("12345", "John Doe", 1000);

            // Act
            system.AddAccount(account);

            // Assert
            Assert.Equal(account, system.GetAccount("12345"));
        }

        [Fact]
        public void ApplyMonthlyInterest_ShouldApplyInterestToAllSavingsAccounts()
        {
            // Arrange
            var system = new BankingSystem();
            var savingsAccount = new SavingsAccount("12345", "John Doe", 1000);
            var checkingAccount = new CheckingAccount("67890", "Jane Doe", 1000);

            system.AddAccount(savingsAccount);
            system.AddAccount(checkingAccount);

            // Act
            system.ApplyMonthlyInterest();

            // Assert
            Assert.Equal(1050, savingsAccount.Balance);
            Assert.Equal(1000, checkingAccount.Balance);
        }

        [Fact]
        public void PrintAccountDetails_ShouldPrintDetailsToConsole()
        {
            // Arrange
            var system = new BankingSystem();
            var account = new CheckingAccount("12345", "John Doe", 1000);

            system.AddAccount(account);

            // Act
            system.PrintAccountDetails("12345");

            // Assert
            // No assertion here as we are printing to console, just ensure it runs without exception
        }
    }
}
