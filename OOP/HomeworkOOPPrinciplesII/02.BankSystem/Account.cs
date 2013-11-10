namespace BankSystem
{
    using System;

    public abstract class Account : IDepositable
    {
        private Customer accountHolder;
        private decimal balance;
        private decimal interestRate;

        public Customer AccountHolder
        {
            get { return this.accountHolder; }
            set { this.accountHolder = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate can't be a negative number.");
                }

                this.interestRate = value;
            }
        }

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.AccountHolder = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public virtual void Deposit(decimal depositAmount)
        {
            if (depositAmount <= 0)
            {
                throw new ArgumentException("Deposited amount must be a positive number.");
            }
            else
            {
                this.Balance += depositAmount;
            }
        }

        public virtual decimal InterestAmount(uint months)
        {
            return (this.InterestRate * months);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} ({2}%)", this.AccountHolder, this.Balance, this.InterestRate);
        }
    }
}