namespace Program
{
    class CreditCardProcessor : IPaymentProcessor
    {
        List<string> TransactionHistory = [];

        public void ProcessPayment(decimal amount)
        {
            TransactionHistory.Add("Платёж с карты на сумму " + amount);
        }

        public void ShowTransactionHistory()
        {
            Console.WriteLine(string.Join(", ", TransactionHistory));
        }
    }
}