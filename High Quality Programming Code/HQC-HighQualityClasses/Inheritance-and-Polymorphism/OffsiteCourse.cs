﻿//-----------------------------------------------------------------------
// <copyright file="OffsiteCourse.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Courses
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// A course that is held outside the academy
    /// </summary>
    public class OffsiteCourse : Course
    {
        /// <summary>
        /// The town in which the course is held
        /// </summary>
        private string town;

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class
        /// </summary>
        /// <param name="courseName">Subject of the course</param>
        /// <param name="teacherName">Name of the teacher leading the course</param>
        /// <param name="students">Collection of the names of the students attending the course</param>
        /// <param name="town">The town in which the course is held</param>
        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class
        /// </summary>
        /// <param name="courseName">Subject of the course</param>
        /// <param name="teacherName">Name of the teacher leading the course</param>
        /// <param name="students">Collection of the names of the students attending the course</param>
        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName, students, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class
        /// </summary>
        /// <param name="courseName">Subject of the course</param>
        /// <param name="teacherName">Name of the teacher leading the course</param>
        public OffsiteCourse(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>(), null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class
        /// </summary>
        /// <param name="name">Subject of the course</param>
        public OffsiteCourse(string name)
            : this(name, null, new List<string>(), null)
        {
        }

        /// <summary>
        /// Gets or sets the town in which the course is held
        /// </summary>
        public string Town
        {
            get { return this.town; }
            set { this.town = value; }
        }

        /// <summary>
        /// A method that gets us all the information about the course
        /// </summary>
        /// <returns>All the information about the course in a single string</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { ");
            result.Append(base.ToString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
