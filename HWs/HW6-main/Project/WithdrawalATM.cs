namespace Program
{
    class WithdrawalATM : ATM
    {
        private int _maxWithdrawal = 1000000;
        public WithdrawalATM() { }
        public override void PerformOperation(int withdrawal)
        {
            if (_balance - withdrawal >= 0 && withdrawal <= _maxWithdrawal)
            {
                _balance -= withdrawal;
                System.Console.WriteLine($"Вы сняли деньги на сумму {withdrawal} рублей!");
                System.Console.WriteLine($"Текущий баланс равняется {_balance}\n");
            }
            else
                System.Console.WriteLine("Внесенная сумма некоректна по отношению к программе или выходит за границу максимальной суммы снятия\n");
        }
    }
}