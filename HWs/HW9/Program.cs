using System;
namespace Program;

class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine() ?? "";
        int term = int.Parse(Console.ReadLine() ?? "");

        USPresident president = new USPresident(name, term);

        Console.WriteLine("Хотите ли задать политическое решение? \n [0] Нет \n [1] Да");
        int questionOfDecision = int.Parse(Console.ReadLine() ?? "");
        if (questionOfDecision == 1)
        {
            Console.WriteLine("Задайте полит. решение");
            string decision = Console.ReadLine() ?? "";
            Console.WriteLine("Решение: " + president.MakeDecision(decision));
        }
    }
}

// class BankAccount
// {
//     public decimal Balance { get; set; }
//     public BankAccount(decimal balance)
//     {
//         Balance = balance;
//     }
//     public void Deposit(decimal amount)
//     {
//         Balance += amount;
//     }

//     public void Withdraw(decimal amount)
//     {
//         Balance -= amount;
//     }
// }
