//-----------------------------------------------------------------------
// <copyright file="Student.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Methods
{
    using System;

    /// <summary>
    /// Creates a student with all its information (names, birth date and everything else that is needed)
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The first name of the student
        /// </summary>
        private string firstName;

        /// <summary>
        /// The last name of the student
        /// </summary>
        private string lastName;

        /// <summary>
        /// The student's birth date
        /// </summary>
        private DateTime birthDate;
        
        /// <summary>
        /// Additional information about the student
        /// </summary>
        private string otherInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class
        /// </summary>
        public Student()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class
        /// </summary>
        /// <param name="firstName">The first name of the student</param>
        /// <param name="lastName">The last name of the student</param>
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class
        /// </summary>
        /// <param name="firstName">The first name of the student</param>
        /// <param name="lastName">The last name of the student</param>
        /// <param name="birthDate">The student's birth date</param>
        public Student(string firstName, string lastName, DateTime birthDate)
            : this(firstName, lastName)
        {
            this.BirthDate = birthDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class
        /// </summary>
        /// <param name="firstName">The first name of the student</param>
        /// <param name="lastName">The last name of the student</param>
        /// <param name="birthDate">The student's birth date</param>
        /// <param name="additionalInfo">Additional information about the student</param>
        public Student(string firstName, string lastName, DateTime birthDate, string additionalInfo)
            : this(firstName, lastName, birthDate)
        {
            this.OtherInfo = additionalInfo;
        }

        /// <summary>
        /// Gets or sets the first name of the student
        /// </summary>
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        /// <summary>
        /// Gets or sets the last name of the student
        /// </summary>
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        /// <summary>
        /// Gets or sets the birth date of the student
        /// </summary>
        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        /// <summary>
        /// Gets or sets the additional information about the student
        /// </summary>
        public string OtherInfo
        {
            get { return this.otherInfo; }
            set { this.otherInfo = value; }
        }

        /// <summary>
        /// Compares this student to another one by their birth dates
        /// </summary>
        /// <param name="otherStudent">The student to compare to</param>
        /// <returns>True if this student is older than the other one</returns>
        public bool IsOlderThan(Student otherStudent)
        {
            DateTime firstDate = this.BirthDate;            // DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            DateTime secondDate = otherStudent.BirthDate;   // DateTime.Parse(otherStudent.OtherInfo.Substring(otherStudent.OtherInfo.Length - 10));
            return firstDate < secondDate;
        }
    }
}
