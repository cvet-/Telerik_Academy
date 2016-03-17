namespace BankSystem.Items
{
    class DepositAccount : DepositableAccount, IWithdrawable
    {
        public DepositAccount(Customer owner, double interestRate)
            : this(owner, 0, interestRate)
        {

        }
        public DepositAccount(Customer owner, decimal balance, double interestRate)
            : base(owner, balance, interestRate)
        {

        }
        public void Withdraw(decimal money)
        {
            this.Balance -= money;
        }
        public override double GetInterestAmount(int months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            return base.GetInterestAmount(months);
        }
    }
}
