//04. Create a class Person with two fields – name and age. Age can be left unspecified
//    (may contain null value. Override ToString() to display the information of a person
//    and if age is not specified – to say so. Write a program to test this functionality.

namespace Person
{
    using System;

    class TestApplication
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Person pesho = new Person("Pesho Peshov", 98);
            Console.WriteLine(pesho);

            Person ivan = new Person("Ivan Ivanov");
            Console.WriteLine(ivan);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
