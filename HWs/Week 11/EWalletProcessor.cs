namespace Program
{
    class EWalletProcessor : IPaymentProcessor
    {
        List<string> TransactionHistory = [];

        public void ProcessPayment(decimal amount)
        {
            TransactionHistory.Add("Платеж из электронного кошелька на сумму " + amount);
        }

        public void ShowTransactionHistory()
        {
            Console.WriteLine(string.Join(", ", TransactionHistory));
        }
    }
}