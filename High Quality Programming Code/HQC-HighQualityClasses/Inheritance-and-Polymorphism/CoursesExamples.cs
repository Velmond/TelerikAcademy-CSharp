//-----------------------------------------------------------------------
// <copyright file="CoursesExamples.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Courses   // This is task 03
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for testing the courses
    /// </summary>
    public class CoursesExamples
    {
        /// <summary>
        /// Main method for the program
        /// </summary>
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);
            Console.WriteLine();

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);
            Console.WriteLine();

            localCourse.Students = new List<string>() { "Peter", "Maria" };
            Console.WriteLine(localCourse);
            Console.WriteLine();

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);
            Console.WriteLine();

            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development",
                "Mario Peshev",
                new List<string>() { "Thomas", "Ani", "Steve" });
            Console.WriteLine(offsiteCourse);
            Console.WriteLine();

            List<Course> courses = new List<Course>();
            courses.Add(localCourse);
            courses.Add(offsiteCourse);

            Console.WriteLine("---------------------------");
            Console.WriteLine("As a collection of courses:");
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("---------------------------");
        }
    }
}
