//01. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class IsAYearLeapYear
{
    static ushort InputYear()
    {
        ushort year;
        Console.WriteLine("Input year to check if it's a leap year:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        bool inputError = ushort.TryParse(Console.ReadLine(), out year);
        Console.ForegroundColor = ConsoleColor.Gray;

        while (!inputError)
        {
            Console.WriteLine("Incorrect input! Try again: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            inputError = ushort.TryParse(Console.ReadLine(), out year);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        return year;
    }

    //static bool IsLeapYear(ushort year)                               //I hadn't noticed that we have to use DateTime and
    //{                                                                 //thought we have to make our own methods so I did this.
    //    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)    //If DateTime.IsLeapYear didn't exist this is an easy 
    //        return true;                                              //method to check if a year is leap or not
    //    else
    //        return false;
    //}

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Press Ctrl+C at any point to stop the program.");
        Console.ForegroundColor = ConsoleColor.Gray;

        while (true)
        {
            ushort year = InputYear();

            string leapOrNot = "is NOT";
            if (DateTime.IsLeapYear(year))  //DateTime.IsLeapYear(int year) is the  easyest way of determining if a year is leap or not
                leapOrNot = "IS";

            Console.Write("The year ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0} {1} ", year, leapOrNot);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("leap year.");
        }
    }
}