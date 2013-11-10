//05.01. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by
//       first name and last name in descending order.
//05.02. Rewrite the same with LINQ.

namespace OrderStudentsByNameLambda
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students;         //Adding reference for task 3's solution and pointing to the namespace where class Student is created

    class OrderStudentsByNameLambda
    {
        static void Main()
        {
            Student[] students = {
                                     new Student("Andrey", "Petrov"),
                                     new Student("Andrey", "Georgiev"),
                                     new Student("Petar", "Ivanov"),
                                     new Student("Maria", "Antoanetova"),
                                     new Student("Napoleon", "Bonapart"),
                                     new Student("Joro", "Bekamov"),
                                     new Student("Maria", "Otvarachkova"),
                                     new Student("Homer", "Simpson"),
                                     new Student("Alfred", "Melmakov"),
                                 };

            var sortedStudents = students.OrderByDescending(student => student.FirstName)
                                         .ThenByDescending(student => student.LastName);    // The lambda expression that's required

            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var student in sortedStudents)   // Write the result on the console
            {
                Console.WriteLine(student);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}