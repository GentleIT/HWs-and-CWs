namespace Program
{
    public abstract class ATM
    {
        protected static int _balance;
        public abstract void PerformOperation(int deposit);
    }
}