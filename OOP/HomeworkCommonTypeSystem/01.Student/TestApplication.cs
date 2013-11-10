//01. Define a class Student, which contains data about a student – first, middle and last name, SSN,
//    permanent address, mobile phone, e-mail, course, specialty, university, faculty. Use an enumeration
//    for the specialties, universities and faculties. Override the standard methods, inherited by
//    System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//02. Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's
//    fields into a new object of type Student.
//03. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in
//    lexicographic order) and by social security number (as second criteria, in increasing order).

namespace Student
{
    using System;

    class TestApplication
    {
        static void Main()
        {
            // Test the constructors and ToString()
            Student pesho = new Student("Pesho", "Peshov", "Petrov", "9201020304", University.SU, Faculty.Philosophy, Specialty.Philosophy, 2);
            Student peshoFull = new Student("Pesho", "Peshov", "Petrov", "9201020304", "Sofia, Pirotska 21", "0888123456", "peshkata@yahoo.com", University.SU, Faculty.Philosophy, Specialty.Philosophy, 2);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ORIGINAL STUDENTS:");
            Console.WriteLine();
            Console.WriteLine(pesho);
            Console.WriteLine();
            Console.WriteLine(peshoFull);
            Console.WriteLine();

            // Test Clone
            Student ivan = pesho.Clone() as Student;        // Clone() returns object so it has to be casted to Student
            Student ivanFull = peshoFull.Clone() as Student;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("CLONED STUDENTS:");
            Console.WriteLine();
            Console.WriteLine(ivan);
            Console.WriteLine();
            Console.WriteLine(ivanFull);
            Console.WriteLine();

            //Change property of clone and see if it changes for the original
            ivan.FirstName = "Ivan";
            ivanFull.FirstName = "Ivan";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ORIGINAL STUDENTS:");
            Console.WriteLine();
            Console.WriteLine(pesho);
            Console.WriteLine();
            Console.WriteLine(peshoFull);
            Console.WriteLine();
            Console.WriteLine("CLONED STUDENTS:");
            Console.WriteLine();
            Console.WriteLine(ivan);
            Console.WriteLine();
            Console.WriteLine(ivanFull);
            Console.WriteLine();

            // Test CompareTo(), == , !=
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("COMPARETO() TEST:");
            Console.WriteLine();
            Console.WriteLine(pesho.CompareTo(ivan));       // 1    -> P > I (in lexicographic order)
            Console.WriteLine(pesho.CompareTo(ivanFull));   // 1    -> P > I (in lexicographic order)
            Console.WriteLine(ivan.CompareTo(pesho));       // -1   -> I < P (in lexicographic order)
            Console.WriteLine(ivan.CompareTo(peshoFull));   // -1   -> I < P (in lexicographic order)
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("== AND != TEST:");
            Console.WriteLine();
            Console.WriteLine(pesho == ivan);       // False
            Console.WriteLine(pesho != ivan);       // True
            Console.WriteLine(pesho == ivanFull);   // False
            Console.WriteLine(pesho != ivanFull);   // True
            Console.WriteLine(pesho == peshoFull);  // True
            Console.WriteLine(pesho != peshoFull);  // False
            Console.WriteLine();

            // Test Equals()
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("EQUALS() TEST:");
            Console.WriteLine();
            Console.WriteLine(pesho.Equals(peshoFull)); // True
            Console.WriteLine(pesho.Equals(ivan));      // False
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
