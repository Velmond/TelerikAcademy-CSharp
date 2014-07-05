//-----------------------------------------------------------------------
// <copyright file="Course.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Courses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// A course that the academy is providing
    /// </summary>
    public abstract class Course
    {
        /// <summary>
        /// Subject of the course
        /// </summary>
        private string name;

        /// <summary>
        /// Name of the teacher leading the course 
        /// </summary>
        private string teacherName;

        /// <summary>
        /// Collection of the names of the students attending the course
        /// </summary>
        private IList<string> students;

        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class
        /// </summary>
        /// <param name="courseName">Subject of the course</param>
        /// <param name="teacherName">Name of the teacher leading the course</param>
        /// <param name="students">Collection of the names of the students attending the course</param>
        public Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        /// <summary>
        /// Gets or sets the subject of the course
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the teacher leading the course
        /// </summary>
        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                this.teacherName = value;
            }
        }

        /// <summary>
        /// Gets or sets the collection of the names of the students enrolled for the class
        /// </summary>
        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = new List<string>();
                foreach (var student in value)
                {
                    this.students.Add(student);
                }
            }
        }

        /// <summary>
        /// A method that gets us all the information about the course
        /// </summary>
        /// <returns>All the information about the course in a single string</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            if (this.Students.Count > 0)
            {
                result.Append("; Students = ");
                result.Append(this.GetStudentsAsString());
            }
            
            return result.ToString();
        }

        /// <summary>
        /// Gets all the names of the students and turns them into a single string
        /// </summary>
        /// <returns>A string of all the names of the students attending the course</returns>
        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
