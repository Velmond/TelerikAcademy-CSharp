namespace Student
{
    using System;
    using System.Text;

    class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string address;
        private string mobilePhone;
        private string eMail;
        private byte course;
        private Specialty specialty;
        private University university;
        private Faculty faculty;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null || value.Length < 2)
                {
                    throw new ArgumentException("First name should be at least 2 characters long.");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (value != string.Empty && value.Length < 1)
                {
                    throw new ArgumentException("Middle name should be at least 1 characters long.");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null || value.Length < 4)
                {
                    throw new ArgumentException("Middle name should be at least 4 characters long.");
                }

                this.lastName = value;
            }
        }

        public string SSN
        {
            get { return this.ssn; }
            set
            {
                if (value == null || value.Length != 10)
                {
                    throw new ArgumentException("SSN must contain 10 characters.");
                }

                foreach (char digit in value)
                {
                    if (!char.IsDigit(digit))
                    {
                        throw new ArgumentException("Invalid SSN entrie. SSN can only contain digits.");
                    }
                }

                this.ssn = value;
            }
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                if (value != null && value.Length < 10)
                {
                    throw new ArgumentException("Address must contain at least 10 characters.");
                }

                this.address = value;
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set
            {
                if (value != null && value.Length != 10)
                {
                    throw new ArgumentException("Phone number must contain 10 characters.");
                }

                if (value != null)
                {
                    foreach (char digit in value)
                    {
                        if (!char.IsDigit(digit))
                        {
                            throw new ArgumentException("Phone number can only contain digits.");
                        }
                    }
                }

                this.mobilePhone = value;
            }
        }

        public string EMail
        {
            get { return this.eMail; }
            set
            {
                if (value != null && value.Length < 10)
                {
                    throw new ArgumentException("E-Mail must contain at least 10 characters.");
                }

                this.eMail = value;
            }
        }

        public byte Course
        {
            get { return this.course; }
            set
            {
                if (value < 1 || value > 7)
                {
                    throw new ArgumentException("Course only takes values from 1 to 7.");
                }

                this.course = value;
            }
        }

        public Specialty Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }

        public University University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public Faculty Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        public Student(string firstName, string middleName, string lastName,
            string ssn, string address, string mobilePhone, string eMail,
            University university, Faculty faculty, Specialty specialty, byte course)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.EMail = eMail;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
            this.Course = course;
        }

        public Student(string firstName, string middleName, string lastName, string ssn,
            University university, Faculty faculty, Specialty specialty, byte course)
            : this(firstName, middleName, lastName, ssn, null, null, null, university, faculty, specialty, course)
        { }

        public override bool Equals(object obj)
        {
            Student other = obj as Student;

            if ((object)other == null)
            {
                return false;
            }

            if (!object.Equals(this.FirstName, other.FirstName))
            {
                return false;
            }

            if (!object.Equals(this.MiddleName, other.MiddleName))
            {
                return false;
            }

            if (!object.Equals(this.LastName, other.LastName))
            {
                return false;
            }

            if (!object.Equals(this.SSN, other.SSN))
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !Student.Equals(first, second);
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendLine(string.Format("Student: {0} {1} {2} / SSN: {3}",
                                              this.FirstName, this.MiddleName, this.LastName, this.SSN));
            toString.Append(string.Format("University: {0}, Faculty: {1}, Specialty: {2} / Course: {3}",
                                              this.University, this.Faculty, this.Specialty, this.Course));

            if (this.Address != null)
            {
                toString.AppendLine();
                toString.AppendLine(string.Format("Address: {0}", this.Address));
            }

            if (this.MobilePhone != null)
            {
                toString.Append(string.Format("Phone: {0}, ", this.MobilePhone));
            }

            if (this.EMail != null)
            {
                toString.Append(string.Format("e-mail: {0} ", this.EMail));
            }

            return toString.ToString();
        }

        public override int GetHashCode()
        {
            return (this.LastName.GetHashCode() ^ this.SSN.GetHashCode());
        }

        public object Clone()
        {
            Student clone;

            if (this.Address != null && this.MobilePhone != null && this.EMail != null)
            {
                clone = new Student(this.firstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone, this.EMail, this.University, this.Faculty, this.Specialty, this.Course);
            }
            else
            {
                clone = new Student(this.firstName, this.MiddleName, this.LastName, this.SSN, this.University, this.Faculty, this.Specialty, this.Course);
            }

            return clone;
        }

        public int CompareTo(Student other)
        {
            if (string.Compare(this.FirstName, other.FirstName) != 0)
            {
                return string.Compare(this.FirstName, other.FirstName);
            }

            if (string.Compare(this.MiddleName, other.MiddleName) != 0)
            {
                return string.Compare(this.MiddleName, other.MiddleName);
            }

            if (string.Compare(this.LastName, other.LastName) != 0)
            {
                return string.Compare(this.LastName, other.LastName);
            }

            if (string.Compare(this.SSN, other.SSN) != 0)
            {
                return string.Compare(this.SSN, other.SSN);
            }

            return 0;
        }
    }
}
