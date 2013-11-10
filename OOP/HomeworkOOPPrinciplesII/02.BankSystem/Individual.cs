namespace BankSystem
{
    using System;

    public class Individual : Customer
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("First name must be at least 2 letters long.");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Last name must be at least 4 letters long.");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public Individual(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IsCompany = false;
        }
    
        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}