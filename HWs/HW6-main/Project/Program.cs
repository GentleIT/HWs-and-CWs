using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            DepositATM deposit = new DepositATM();
            WithdrawalATM withdraw = new WithdrawalATM();

            deposit.PerformOperation(10000000);
            withdraw.PerformOperation(900000);
        }
    }
}
