namespace BankSystem
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal InterestAmount(uint months)
        {
            if (this.AccountHolder.IsCompany)
            {
                if (months > 2)     // Interest for companies' loan accounts is 0 for the first 2 months
                {
                    return base.InterestAmount(months - 2);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (months > 3)     // Interest for individual loan accounts is 0 for the first 3 months
                {
                    return base.InterestAmount(months - 3);
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}