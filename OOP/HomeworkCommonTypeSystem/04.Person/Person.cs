namespace Person
{
    using System;
    using System.Text;

    class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == string.Empty || value == null || value.Length < 2)
                {
                    throw new ArgumentException("Name should be at least 2 characters long.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int? Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Age must be between 0 and 120.");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name)
            : this(name, null)
        { }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(string.Format("{0} ", this.Name));

            if (this.Age.HasValue)
            {
                toString.Append(string.Format("({0})", this.Age.Value));
            }
            else
            {
                toString.Append("(age not available)");
            }

            return toString.ToString();
        }
    }
}
