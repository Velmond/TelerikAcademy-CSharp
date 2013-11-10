namespace AbstractHuman
{
    using System;

    abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public override string ToString()
        {
            return string.Concat(this.FirstName + " " + this.LastName);
        }
    }
}