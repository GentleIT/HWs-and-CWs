using System;
namespace Program
{
    class Program
    {
        public delegate string DecisionDelegate(string parameter);

        public static void ProcessDecision(DecisionDelegate decisionMaker)
        {
            Console.WriteLine("Введите политическое решение:");
            string input = Console.ReadLine() ?? "";
            Console.WriteLine("Результат обработки: " + decisionMaker(input));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя и срок: ");
            string name = Console.ReadLine() ?? "";
            int term = int.Parse(Console.ReadLine() ?? "");

            USPresident president = new USPresident(name, term);

            DecisionDelegate decisionDelegate = new(USPresident.MakeDecision);


            Console.WriteLine("Хотите ли задать политическое решение? \n [0] Нет \n [1] Да");
            int questionOfDecision = int.Parse(Console.ReadLine() ?? "");

            if (questionOfDecision == 1)
            {
                ProcessDecision(decisionDelegate);
            }
        }
    }
}
