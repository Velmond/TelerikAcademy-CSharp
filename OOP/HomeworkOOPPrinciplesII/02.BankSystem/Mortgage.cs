namespace BankSystem
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal InterestAmount(uint months)
        {
            if (this.AccountHolder.IsCompany)
            {
                if (months > 12)    // Interest for companies' mortgage accounts is halved for the first year
                {
                    return (base.InterestAmount(months - 6));   // The first 12 months equal 6 months with regular interest
                }
                else
                {
                    return (base.InterestAmount(months) * 0.5m);
                }
            }
            else
            {
                if (months > 6)     // Interest for individual mortgage accounts is calculated after the first 6 months
                {
                    return base.InterestAmount(months - 6);
                }
                else                // No interest for individual mortgage accounts for the first 6 months
                {
                    return 0;
                }
            }
        }
    }
}