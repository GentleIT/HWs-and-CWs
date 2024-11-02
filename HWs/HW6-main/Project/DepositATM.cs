namespace Program
{
    class DepositATM : ATM
    {
        private int _maxDep = 10000000;

        public DepositATM()
        {
            _balance = 0;
        }
        public override void PerformOperation(int deposit)
        {
            if (deposit > 0 && deposit + _balance <= _maxDep)
            {
                _balance += deposit;
                System.Console.WriteLine($"Сумма {deposit} рублей успешно внесена в счёт!");
                System.Console.WriteLine($"Текущая сумма: {_balance}\n");
                // Сюда бы внедрить метод, который заменяет окончания рубля/рублей в зависимости от конечной цифры.
            }
            else
                System.Console.WriteLine("Внесенная сумма некоректна по отношению к программе или выходит за границу максимальной суммы депозита\n");
        }
    }
}