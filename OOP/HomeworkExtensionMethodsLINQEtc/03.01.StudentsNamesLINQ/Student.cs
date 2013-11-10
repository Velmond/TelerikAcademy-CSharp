namespace Students
{
    using System;

    public class Student    // This class is made in the way that it is because it's used in all tasks that need it (3, 4, 5)
    {
        // Private fields
        private string firstName;
        private string lastName;
        private int? age;

        // Public properties for accessing the fields
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

        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Student(string firstName, string lastName, int? age) // Constructor used in task 4
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student(string firstName, string lastName)           // Constructor used in tasks 3, 5.1 and 5.2
            : this(firstName, lastName, null)
        {
        }

        public override string ToString()   // Override the method 'ToString' to make displaying the results simpler
        {
            if (this.Age != null)   // ToString for task 4
            {
                return string.Format("{0} {1} ({2})", this.FirstName, this.LastName, this.Age);
            }
            else                    // ToString for tasks 3, 5.1 and 5.2
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }
    }
}