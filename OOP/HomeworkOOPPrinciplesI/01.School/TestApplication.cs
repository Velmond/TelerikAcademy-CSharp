//01. We are given a school. In the school there are classes of students. Each class has a set of teachers.
//    Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have
//    unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of
//    exercises. Both teachers and students are people. Students, classes, teachers and disciplines could
//    have optional comments (free text block).
//    Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate
//    their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace School
{
    using System;
    using System.Collections.Generic;

    public class TestApplication
    {
        static void Main()
        {
            Teacher tomas = new Teacher("Tomas", "Fernandes");
            tomas.Disciplines.Add(new SchoolDiscipline(Subject.Calculus, 30, 45));
            Class firstA = new Class("1a");
            firstA.AddStudent(new Student("ivan", "ivanoq", 12));
            firstA.AddStudent(new Student("iwan", "ivanqv", 15));
            firstA.AddStudent(new Student("ivrn", "ivaeov", 2));
            firstA.AddStudent(new Student("ivat", "ivynov", 22));
            firstA.AddStudent(new Student("yvan", "itanov", 35));
            firstA.AddStudent(new Student("eqan", "iranov", 5));
            firstA.AddStudent(new Student("vern", "evanov", 1));

            Console.Write("ShowStudent() method: ");
            firstA.ShowStudent(15);

            SchoolDiscipline biology = new SchoolDiscipline(Subject.Biology, 30, 30);

            firstA.AddTeacher(tomas);
            firstA.AddTeacher(new Teacher("Tom", "Ferandes", Subject.Algebra));
            firstA.AddTeacher(new Teacher("Tas", "Fernades", biology));
            firstA.AddTeacher(new Teacher("Tos", "Fernand"));
            firstA.AddTeacher(new Teacher("Toms", "Fendes"));
            firstA.AddTeacher(new Teacher("Toas", "Fende"));

            Console.Write("ShowTeacher() method: ");
            firstA.ShowTeacher(biology);

            Console.WriteLine("ToString() method for class: ");
            Console.WriteLine(firstA);
        }
    }
}