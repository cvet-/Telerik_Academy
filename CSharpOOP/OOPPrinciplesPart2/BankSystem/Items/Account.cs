using System;

namespace BankSystem.Items
{
    public abstract class Account
    {
        private Customer owner;
        public decimal Balance { get; protected set; }
        public double InterestRate { get; protected set; }

        protected Account (Customer owner, decimal balance, double interestRate)
        {
            this.owner = owner;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public Customer Owner
        {
            get { return this.owner; }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Owner");
                }
                owner = value;
            }
        }      

        public virtual double GetInterestAmount(int months)
        {
            return (months * InterestRate) / 100;
        }
    }
}
