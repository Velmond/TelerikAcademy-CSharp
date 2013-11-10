//04. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace StudentsAgeLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students;         //Adding reference for task 3's solution and pointing to the namespace where class Student is created

    class StudentsAgeLINQ
    {
        static void Main()
        {
            Student[] students = {
                                     new Student("Andrey", "Petrov", 22),
                                     new Student("Aleksandar", "Georgiev", 18),
                                     new Student("Petar", "Ivanov", 25),
                                     new Student("Maria", "Antoanetova", 24),
                                     new Student("Napoleon", "Bonapart", 21),
                                     new Student("Joro", "Bekamov",33),
                                     new Student("Mara", "Otvarachkova", 21),
                                     new Student("Homer", "Simpson", 20),
                                     new Student("Alfred", "Melmakov", 23),
                                 };

            var filteredStudents = (from student in students
                                    where (student.Age >= 18 && student.Age <= 24)
                                    select student);        // The LINQ query that's required by the task's description
            
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (Student student in filteredStudents)   // Write the result on the console
            {
                Console.WriteLine(student);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}