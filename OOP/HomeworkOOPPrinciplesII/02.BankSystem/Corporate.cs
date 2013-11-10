namespace BankSystem
{
    using System;

    public class Corporate : Customer
    {
        private string name;
        private string type;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Company name must be at least 2 letters long.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string Type
        {
            get { return this.type; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Type can't be less than 2 letters long.");
                }
                else
                {
                    this.type = value;
                }
            }
        }

        public Corporate(string companyName, string companyType)
        {
            this.Name = companyName;
            this.Type = companyType;
            this.IsCompany = true;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Name, this.Type);
        }
    }
}