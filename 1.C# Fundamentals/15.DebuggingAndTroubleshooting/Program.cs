namespace _15.DebuggingAndTroubleshooting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define bank accounts
            int aliceAccountNumber = 101;
            decimal aliceBalance = 500;
            int bobAccountNumber = 201;
            decimal bobBalance = 1000;

            // Display initial account balances
            Console.WriteLine($"Initial Balances:");
            DisplayAccountBalance("Alice", aliceAccountNumber, aliceBalance);
            DisplayAccountBalance("Bob", bobAccountNumber, bobBalance);

            // Simulate transactions
            // Intentionally introduce bugs to debug and fix

            // Scenario 1: Deposit into Bob's account
            Deposit(bobAccountNumber, 200);
            Console.WriteLine();

            // Scenario 2: Withdraw from Alice's account
            Withdraw(aliceAccountNumber, 600);
            Console.WriteLine();

            // Scenario 3: Transfer from Alice to Bob
            Transfer(aliceAccountNumber, bobAccountNumber, 300);
            Console.WriteLine();

            // Display final account balances
            Console.WriteLine($"Final Balances after transactions:");
            DisplayAccountBalance("Alice", aliceAccountNumber, aliceBalance);
            DisplayAccountBalance("Bob", bobAccountNumber, bobBalance);
        }



        static double CalculateAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i <= numbers.Length; i++) // Intentional bug: should be i < numbers.Length
            {
                sum += numbers[i];
            }
            return (double)sum / numbers.Length;
        }



        static void Deposit(int accountNumber, decimal amount)
        {
            Console.WriteLine($"Depositing {amount:C} into Account {accountNumber}");

            // Simulate deposit operation
            if (accountNumber == 201) // Intentional bug: only allow deposits to Alice's account (101)
            {
                Console.WriteLine($"Error: Cannot deposit into Bob's account ({accountNumber}).");
                return;
            }

            // Actual deposit operation
            if (amount > 0)
            {
                if (accountNumber == 101)
                {
                    aliceBalance += amount;
                }
                else if (accountNumber == 201)
                {
                    bobBalance += amount;
                }
                Console.WriteLine($"Deposit successful. New balance of Account {accountNumber}: {GetBalance(accountNumber):C}");
            }
            else
            {
                Console.WriteLine("Error: Invalid deposit amount.");
            }
        }



        static void Withdraw(int accountNumber, decimal amount)
        {
            Console.WriteLine($"Withdrawing {amount:C} from Account {accountNumber}");

            // Simulate withdrawal operation
            if (amount > GetBalance(accountNumber))
            {
                Console.WriteLine($"Error: Insufficient funds in Account {accountNumber} to withdraw {amount:C}.");
                return;
            }

            // Actual withdrawal operation
            if (amount > 0)
            {
                if (accountNumber == 101)
                {
                    aliceBalance -= amount;
                }
                else if (accountNumber == 201)
                {
                    bobBalance -= amount;
                }
                Console.WriteLine($"Withdrawal successful. New balance of Account {accountNumber}: {GetBalance(accountNumber):C}");
            }
            else
            {
                Console.WriteLine("Error: Invalid withdrawal amount.");
            }
        }



        static void Transfer(int fromAccount, int toAccount, decimal amount)
        {
            Console.WriteLine($"Transferring {amount:C} from Account {fromAccount} to Account {toAccount}");

            // Simulate transfer operation
            if (amount > GetBalance(fromAccount))
            {
                Console.WriteLine($"Error: Insufficient funds in Account {fromAccount} to transfer {amount:C}.");
                return;
            }

            // Actual transfer operation
            if (amount > 0)
            {
                if (fromAccount == 101)
                {
                    aliceBalance -= amount;
                }
                else if (fromAccount == 201)
                {
                    bobBalance -= amount;
                }

                if (toAccount == 101)
                {
                    aliceBalance += amount;
                }
                else if (toAccount == 201)
                {
                    bobBalance += amount;
                }

                Console.WriteLine($"Transfer successful.");
                Console.WriteLine($"New balance of Account {fromAccount}: {GetBalance(fromAccount):C}");
                Console.WriteLine($"New balance of Account {toAccount}: {GetBalance(toAccount):C}");
            }
            else
            {
                Console.WriteLine("Error: Invalid transfer amount.");
            }
        }



        static decimal GetBalance(int accountNumber)
        {
            if (accountNumber == 101)
            {
                return aliceBalance;
            }
            else if (accountNumber == 201)
            {
                return bobBalance;
            }
            else
            {
                Console.WriteLine($"Error: Account {accountNumber} does not exist.");
                return 0;
            }
        }



        static void DisplayAccountBalance(string accountHolder, int accountNumber, decimal balance)
        {
            Console.WriteLine($"Account Holder: {accountHolder}, Account Number: {accountNumber}, Balance: {balance:C}");
        }

        // Initial account balances
        static decimal aliceBalance = 500;
        static decimal bobBalance = 1000;
    }
}
