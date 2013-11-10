namespace School
{
    using System;

    public class Student : Person, ICommentable
    {
        private int uniqueClassNumber;

        public int UCN
        {
            get { return uniqueClassNumber; }
            set
            {
                if (value > 0 && value <= 36)
                {
                    uniqueClassNumber = value;
                }
                else
                {
                    throw new ArgumentException("Student's unique class number can't be less than 1 or more than 36.");
                }
            }
        }

        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        { }

        public Student(string firstName, string lastName, int uniqueClassNumber)
            : this(firstName, lastName)
        {
            this.UCN = uniqueClassNumber;
        }

        public override string ToString()
        {
            return string.Concat(this.UCN + ". " + this.FirstName + " " + this.LastName);
        }
    }
}