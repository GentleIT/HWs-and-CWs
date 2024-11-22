using System;
using Microsoft.VisualBasic;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool desicion = true;
            bool desicion1 = true;

            CreditCardProcessor card = new CreditCardProcessor();
            EWalletProcessor wallet = new EWalletProcessor();

            List<IPaymentProcessor> q = [];
            q.Add(card);
            q.Add(wallet);

            foreach (var el in q)
            {
                if (el is CreditCardProcessor) // Стыдно признавать, но я использовал совет от ЧатаЖПТ узнав от него об этом способе. Про is я знал, но не догадался :(
                {
                    while (desicion)
                    {
                        Console.WriteLine("Работа с картой!");
                        Question("карты", el);
                        desicion = false;
                        QuiestionAgain("карты", el, desicion);
                    }
                }
                else
                {
                    while (desicion1)
                    {
                        Console.WriteLine("Работа с эл. кошельком!");
                        Question("кошелька", el);
                        desicion1 = false;
                        QuiestionAgain("кошелька", el, desicion1);
                    }
                }
            }
            Console.Write("История платежей с карты: ");
            card.ShowTransactionHistory();
            Console.Write("История платежей с эл. кошелька: ");
            wallet.ShowTransactionHistory();

            void Question(string agregat, IPaymentProcessor el)
            {
                Console.WriteLine($"На какую сумму хотите сделать платеж с {agregat}?");
                int n = int.Parse(Console.ReadLine() ?? "");
                el.ProcessPayment(n);
            }

            void QuiestionAgain(string agregat, IPaymentProcessor el, bool desicion)
            {
                Console.WriteLine("Хотите сделать повторный платёж? 1 / 0");
                int tf = int.Parse(Console.ReadLine() ?? "");

                if (tf == 1)
                {
                    Question(agregat, el);
                    desicion = true;
                }
                else if (tf == 0)
                {
                    desicion = false;
                }
                else
                {
                    Console.WriteLine("Не 1 и не 2, так что закончим прогу");
                    desicion = false;
                }
            }

        }

    }
}
