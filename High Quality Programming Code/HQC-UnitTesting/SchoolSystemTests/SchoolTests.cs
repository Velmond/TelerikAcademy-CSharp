namespace SchoolSystemTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void SchoolConstructorNoArgumentsOverloadTest()
        {
            School school = new School();
            Assert.IsNotNull(school);
        }

        [TestMethod]
        public void SchoolConstructorCoursesArgumentOverloadTest()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Assert.IsNotNull(school);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolAddCourseNullTest()
        {
            School school = new School();
            school.AddCourse(null);
        }

        [TestMethod]
        public void SchoolAddCourseTest()
        {
            School school = new School();
            Course course = new Course("HQPC");
            school.AddCourse(course);
            Assert.AreEqual("HQPC", course.Name, "Adding courses to school works incorrectly.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolRemoveCourseNullTest()
        {
            School school = new School();
            school.RemoveCourse(null);
        }

        [TestMethod]
        public void SchoolRemoveCourseTest()
        {
            List<Course> courses = new List<Course>
            {
                new Course("HQPC"),
                new Course("JS Fundamentals"),
                new Course("JS UIDOM"),
                new Course("JS OOP"),
                new Course("DSA")
            };

            School school = new School(courses);
            school.RemoveCourse(courses[1]); // JS Fundamentals
            int expectedCoursesCount = 4;

            Assert.AreEqual(expectedCoursesCount, school.Courses.Count, "Removing existing courses from school works incorrectly.");   // 4 courses remaining
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolRemoveCourseNonExistentTest()
        {
            List<Course> courses = new List<Course>
            {
                new Course("HQPC"),
                new Course("JS Fundamentals"),
                new Course("JS UIDOM"),
                new Course("JS OOP"),
                new Course("DSA")
            };

            Course toRemove = new Course("DB");

            School school = new School(courses);
            school.RemoveCourse(toRemove);
        }
    }
}
