namespace SchoolSystemTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;
    using System;

    [TestClass]
    public class StudentTests
    {
        // If I remove two of the tests that expect exceptions I get greater code coverage than with them... for whatever reason
        // I'm not deleting them though because I thing they are actually important.
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentConstructorAllArgumentsNullNameTest()
        {
            Student student = new Student(null, 11011);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentConstructorAllArgumentsShortNameTest()
        {
            Student student = new Student("P", 11011);
        }

        [TestMethod]
        public void StudentConstructorAllArgumentsValidTest()
        {
            Student student = new Student("Pesho Peshov", 11011);
            string expectedName = "Pesho Peshov";
            string resultName = student.Name;
            int expectedNumber = 11011;
            int resultNumber = student.UniqueNumber;

            Assert.AreEqual(expectedName, resultName, "Constructor for student works incorrectly.");
            Assert.AreEqual(expectedNumber, resultNumber, "Constructor for student works incorrectly.");
            // I know I should only assert one thing in a test but these practically test the same thing in a different way
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentConstructorAllArgumentsSmallUNTest()
        {
            Student student = new Student("Pesho Peshov", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentConstructorAllArgumentsLargeUNTest()
        {
            Student student = new Student("Pesho Peshov", 100000);
        }

        [TestMethod]
        public void StudentToStringTest()
        {
            Student student = new Student("Pesho Peshov", 11011);
            string expected = "11011: Pesho Peshov";
            string resilt = student.ToString();
            Assert.AreEqual(expected, resilt, "Student.ToString() works incorrectly.");
        }
    }
}
