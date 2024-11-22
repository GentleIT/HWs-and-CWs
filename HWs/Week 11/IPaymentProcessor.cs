using System.Security.Cryptography.X509Certificates;

namespace Program
{
    interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
        void ShowTransactionHistory();
    }
}