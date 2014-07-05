namespace SchoolSystem
{
    using System;

    public class Student
    {
        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be missing!");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Name of student cannot be less than 3 characters long");
                }
                 
                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("Trying to set a unique number that is not between 10000 and 99999.");
                }
                
                this.uniqueNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", this.UniqueNumber, this.Name);
        }
    }
}
