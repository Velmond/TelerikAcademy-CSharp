//03. Write a method that from a given array of students finds all students whose first name is
//    before its last name alphabetically. Use LINQ query operators.

namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsNamesLINQ
    {
        static Student[] FilterStudents(Student[] students) // This is the method required by the task description
        {
            var list = (from student in students
                        where student.FirstName.CompareTo(student.LastName) < 0
                        select student);                    // LINQ query

            return list.ToArray();                          // Return the result as a Student[] array
        }

        static void Main()
        {
            Student[] students = {
                                     new Student("Andrey", "Petrov"),
                                     new Student("Aleksandar", "Georgiev"),
                                     new Student("Petar", "Ivanov"),
                                     new Student("Maria", "Antoanetova"),
                                     new Student("Napoleon", "Bonapart"),
                                     new Student("Joro", "Bekamov"),
                                     new Student("Mara", "Otvarachkova"),
                                     new Student("Homer", "Simpson"),
                                     new Student("Alfred", "Melmakov"),
                                 };

            Student[] filteredStudents = FilterStudents(students);  // The result is returned in a new array of students

            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (Student student in filteredStudents)           // Write the result on the console
            {
                Console.WriteLine(student);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}