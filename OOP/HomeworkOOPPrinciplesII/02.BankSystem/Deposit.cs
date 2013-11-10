namespace BankSystem
{
    using System;

    public class Deposit : Account, IWithdrawable
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount > this.Balance)
            {
                throw new ArgumentException("You can't withdraw more than you have in your balance.");
            }
            else
            {
                this.Balance -= withdrawAmount;
            }
        }

        public override decimal InterestAmount(uint months)
        {
            if (this.Balance < 0 || this.Balance > 1000)    // Interest doesn't get calculated if the balance is between 0 and 1000
            {
                return base.InterestAmount(months);
            }
            else
            {
                return 0;
            }
        }
    }
}