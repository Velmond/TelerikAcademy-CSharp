namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private IList<Course> courses;

        public School(IList<Course> courses)
        {
            this.Courses = courses;
        }

        public School()
            : this(new List<Course>())
        {
        }

        public IList<Course> Courses
        {
            get
            {
                return this.courses;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("courses", "Courses cannot take null as value.");
                }

                this.courses = value;
            }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Cannot add null as a course");
            }

            this.Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Trying to remove course that is null.");
            }
            else if (this.Courses.Contains(course))
            {
                this.Courses.Remove(course);
            }
            else
            {
                throw new ArgumentException("Trying to remove course that does not exist.");
            }
        }
    }
}
