namespace School
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string firstName;
        private string lastName;

        public List<string> Comments { get; set; }

        public string FirstName
        {
            get { return this.firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { lastName = value; }
        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return string.Concat(this.FirstName + " " + this.LastName);
        }
    }
}