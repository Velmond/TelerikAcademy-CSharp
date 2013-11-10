//02. Define abstract class Human with first name and last name. Define new class Student which is derived from Human
//    and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay
//    and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and
//    properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order (use
//    LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in descending
//    order. Merge the lists and sort them by first name and last name.

namespace AbstractHuman
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class TestApplication
    {
        static List<Student> students;
        static List<Worker> workers;

        static void Main()
        {
            InitializeInput();
            /*========================================================================================================*/
            PrintList("STUDENTS:", students);
            /*========================================================================================================*/
            var sortedStudents = from student in students
                                 orderby student.Grade ascending
                                 select student;

            PrintList("STUDENTS (sorted by grades):", sortedStudents);
            /*========================================================================================================*/
            PrintList("WORKERS:", workers);
            /*========================================================================================================*/
            var sortedWorkers = from worker in workers
                                orderby worker.MoneyPerHour() descending
                                select worker;

            PrintList("WORKERS (sorted by money per hour made):", sortedWorkers);
            /*========================================================================================================*/
            var allPeople = sortedStudents.Concat<Human>(sortedWorkers).ToList();

            PrintList("ALL PEOPLE:", allPeople);
            /*========================================================================================================*/
            var sortedPeople = from human in allPeople
                               orderby human.FirstName, human.LastName
                               select human;

            PrintList("ALL PEOPLE (sorted by names):", sortedPeople);
            /*========================================================================================================*/
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        private static void PrintList(string title, IEnumerable collection)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        private static void InitializeInput()
        {
            students = new List<Student>();
            students.Add(new Student("Ivan", "Ivanov", 5.25));
            students.Add(new Student("Petar", "Petrov", 3.00));
            students.Add(new Student("Ivan", "Petrov", 5.75));
            students.Add(new Student("Petar", "Ivanov", 5.25));
            students.Add(new Student("Ivanina", "Dimitrova", 2.00));
            students.Add(new Student("Georgi", "Georgiev", 6.00));
            students.Add(new Student("Gergana", "Ivanova", 4.50));
            students.Add(new Student("Dimitar", "Dimitrov", 4.50));
            students.Add(new Student("Dimitar", "Georgiev", 3.75));
            students.Add(new Student("Dimitrina", "Petrova", 5.25));

            workers = new List<Worker>();
            workers.Add(new Worker("Ivan", "Ivanovski", 120.50, 8));
            workers.Add(new Worker("Peter", "Petrov", 250.00, 8));
            workers.Add(new Worker("Ivan", "Petrov", 85.30, 6));
            workers.Add(new Worker("Petar", "Ivanovich", 156.40, 8));
            workers.Add(new Worker("Ivanina", "Dimitrovska", 55.00, 4));
            workers.Add(new Worker("George", "Georgiev", 180.75, 8));
            workers.Add(new Worker("Gergana", "Ivanovaska", 46.05, 8));
            workers.Add(new Worker("Dimitar", "Dimitrovich", 124.20, 6));
            workers.Add(new Worker("Dimitar", "Georgievski", 130.80, 8));
            workers.Add(new Worker("Dimitrina", "Petrovska", 220.40, 8));
        }
    }
}