namespace _10.Object_OrientedProgramming._08.Interfaces
{
    interface IPayment
    {
        void ProcessPayment(double amount);
        void DisplayPaymentInfo();
    }



    class CreditCardPayment : IPayment
    {
        public string CardNumber { get; set; }
        public string CardHolder { get; set; }

        public CreditCardPayment(string cardNumber, string cardHolder)
        {
            CardNumber = cardNumber;
            CardHolder = cardHolder;
        }

        // Implementing ProcessPayment method
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C} for {CardHolder}");
        }

        // Implementing DisplayPaymentInfo method
        public void DisplayPaymentInfo()
        {
            Console.WriteLine($"Credit Card Payment - Card Holder: {CardHolder}, Card Number: {CardNumber}");
        }
    }



    class PayPalPayment : IPayment
    {
        public string Email { get; set; }

        public PayPalPayment(string email)
        {
            Email = email;
        }

        // Implementing ProcessPayment method
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C} for {Email}");
        }

        // Implementing DisplayPaymentInfo method
        public void DisplayPaymentInfo()
        {
            Console.WriteLine($"PayPal Payment - Email: {Email}");
        }
    }



    class BitcoinPayment : IPayment
    {
        public string WalletAddress { get; set; }

        public BitcoinPayment(string walletAddress)
        {
            WalletAddress = walletAddress;
        }

        // Implementing ProcessPayment method
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Bitcoin payment of {amount:C} to wallet {WalletAddress}");
        }

        // Implementing DisplayPaymentInfo method
        public void DisplayPaymentInfo()
        {
            Console.WriteLine($"Bitcoin Payment - Wallet Address: {WalletAddress}");
        }
    }
}
