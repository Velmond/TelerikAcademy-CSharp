namespace SchoolSystemTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CourseConstructorOneArgumentOverloadTest()
        {
            Course course = new Course("HQPC");
            Assert.AreEqual("HQPC", course.Name, "Constructor for Course with argument \"name\" does not work.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseConstructorOneArgumentOverloadShortNameTest()
        {
            Course course = new Course("A");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseConstructorTwoArgumentsOverloadNullStudentsTest()
        {
            Course course = new Course("HQPC", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseConstructorTwoArgumentsOverloadNullNameTest()
        {
            Course course = new Course(null, new List<Student>());
        }

        [TestMethod]
        public void CourseConstructorTwoArgumentsOverloadTest()
        {
            IList<Student> students = new List<Student> {
                new Student("Pesho Peshov", 11011),
                new Student("Gosho Goshov", 11001)
            };

            Course course = new Course("HQPC", students);

            Assert.AreEqual("HQPC", course.Name, "Constructor for Course with both arguments does not work.");
            Assert.AreEqual(2, course.Students.Count, "Constructor for Course with both arguments does not work.");
            // I know I should only assert one thing in a test but these practically test the same thing in a different way
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseAddStudentNullTest()
        {
            Course course = new Course("HQPC");
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseAddStudentExistingStudentTest()
        {
            Course course = new Course("HQPC");
            Student student = new Student("Pesho Peshov", 11011);
            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseAddStudentTooManyStudentsTest()
        {
            string charsForNames = "abcdefghijklmnopqestuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Course course = new Course("HQPC");
            for (int i = 0; i < 30; i++)
            {
                // \/ These names should be unique.
                string name = charsForNames[i].ToString() +
                    charsForNames[charsForNames.Length - 1 - i].ToString() +
                    charsForNames[i / 2] +
                    charsForNames[(charsForNames.Length - 1 - i) / 2];
                Student student = new Student(name, 10000 + i);
                course.AddStudent(student);
            }
        }

        [TestMethod]
        public void CourseAddStudentTest()
        {
            Course course = new Course("HQPC");
            Student student = new Student("Pesho Peshov", 11011);
            course.AddStudent(student);

            int expectedStudentsCount = 1;
            int resultStudentsCount = course.Students.Count;
            string expectedStudent = "11011: Pesho Peshov";
            string resultStudent = course.Students[0].ToString();

            Assert.AreEqual(expectedStudentsCount, resultStudentsCount, "Adding students to course works incorrectly.");
            Assert.AreEqual(expectedStudent, resultStudent, "Adding students to course works incorrectly.");
            // I know I should only assert one thing in a test but these practically test the same thing in a different way
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseRemoveStudentNullTest()
        {
            Course course = new Course("HQPC");
            course.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseRemoveStudentNonExistingStudentTest()
        {
            Course course = new Course("HQPC");
            Student student = new Student("Pesho Peshov", 11011);
            course.RemoveStudent(student);
        }

        [TestMethod]
        public void CourseRemoveStudentExistingStudentTest()
        {
            Student student = new Student("Pesho Peshov", 11011);
            IList<Student> students = new List<Student> {
                student,
                new Student("Gosho Goshov", 11001)
            };

            Course course = new Course("HQPC", students);
            course.RemoveStudent(student);

            int expectedStudentsCount = 1;
            int resultStudentsCount = course.Students.Count;
            string expectedStudent = "11001: Gosho Goshov";
            string resultStudent = course.Students[0].ToString();

            Assert.AreEqual(expectedStudentsCount, resultStudentsCount, "Removing students from course works incorrectly.");
            Assert.AreEqual(expectedStudent, resultStudent, "Removing students from course works incorrectly.");
            // I know I should only assert one thing in a test but these practically test the same thing in a different way
        }


        [TestMethod]
        public void CourseToStringNoStudentsTest()
        {
            Course course = new Course("HQPC");
            string expected = "Course: HQPC";
            string result = course.ToString();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CourseToStringWithStudentsTest()
        {
            IList<Student> students = new List<Student> {
                new Student("Pesho Peshov", 11011),
                new Student("Gosho Goshov", 11001)
            };

            Course course = new Course("HQPC", students);
            string expected = "Course: HQPC\nStudents:\n11011: Pesho Peshov\n11001: Gosho Goshov";
            string result = course.ToString();
            Assert.AreEqual(expected, result);

        }
    }
}
