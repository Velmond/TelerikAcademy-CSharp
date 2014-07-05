//-----------------------------------------------------------------------
// <copyright file="LocalCourse.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Courses
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// A course that is held in the academy
    /// </summary>
    public class LocalCourse : Course
    {
        /// <summary>
        /// The lab in which the course is held
        /// </summary>
        private string lab;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class
        /// </summary>
        /// <param name="courseName">Subject of the course</param>
        /// <param name="teacherName">Name of the teacher leading the course</param>
        /// <param name="students">Collection of the names of the students attending the course</param>
        /// <param name="lab">The lab in which the course is held</param>
        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class
        /// </summary>
        /// <param name="courseName">Subject of the course</param>
        /// <param name="teacherName">Name of the teacher leading the course</param>
        /// <param name="students">Collection of the names of the students attending the course</param>
        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName, students, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class
        /// </summary>
        /// <param name="courseName">Subject of the course</param>
        /// <param name="teacherName">Name of the teacher leading the course</param>
        public LocalCourse(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>(), null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class
        /// </summary>
        /// <param name="name">Subject of the course</param>
        public LocalCourse(string name)
            : this(name, null, new List<string>(), null)
        {
        }

        /// <summary>
        /// Gets or sets the lab in which the course is held
        /// </summary>
        public string Lab
        {
            get { return this.lab; }
            set { this.lab = value; }
        }

        /// <summary>
        /// A method that gets us all the information about the course
        /// </summary>
        /// <returns>All the information about the course in a single string</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { ");
            result.Append(base.ToString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
