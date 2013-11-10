namespace AbstractHuman
{
    using System;

    class Student : Human
    {
        private double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Concat(this.FirstName + " " + this.LastName + " (Grade: " + this.Grade + ")");
        }
    }
}
