namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Course
    {
        public const byte MaxStudentsInACourse = 29;

        private string name;
        private IList<Student> students;

        public Course(string name, IList<Student> students)
        {
            this.Name = name;
            this.Students = students;
        }

        public Course(string name)
            : this(name, new List<Student>())
        {
            this.Name = name;
        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("students", "Students cannot take null as a value.");
                }

                this.students = value;
            }
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

                if (value.Length <= 2)
                {
                    throw new ArgumentException("Name of course cannot be less than 2 characters long.");
                }

                this.name = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Trying to add a student that is null.");
            }

            if (this.Students.Contains(student))
            {
                throw new ArgumentException("Trying to add student that has already been adde.");
            }

            if (this.Students.Count == MaxStudentsInACourse)
            {
                throw new ArgumentException("Trying to add student to a course that is already full.");
            }

            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Trying to remove a student that is null.");
            }
            else if (this.students.Contains(student))
            {
                this.Students.Remove(student);
            }
            else
            {
                throw new ArgumentException("The student does not exist in this course, so there is no need to remove it!");
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            toString.Append(string.Format("Course: {0}", this.Name));

            if (this.Students.Count > 0)
            {
                toString.Append("\nStudents:");

                for (int i = 0; i < this.Students.Count; i++)
                {
                    toString.Append("\n" + this.Students[i].ToString());
                }
            }

            return toString.ToString();
        }
    }
}
