//16. Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//    Example:
//      Enter the first date: 27.02.2006
//      Enter the second date: 3.03.2006
//      Distance: 4 days

namespace FindTimespanInDays
{
    using System;
    using System.Globalization;

    class FindTimespanInDays
    {
        static void Main()
        {
            DateTime firstDate, secondDate;
            Console.Write("Input the first date (day.month.year) - ");
            //To use your own input you need to uncommend the lines below (select them all + Ctrl+K+U):
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.Write("Input the second date (day.month.year) - ");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            //Console.ForegroundColor = ConsoleColor.Gray; /*

            firstDate = DateTime.ParseExact("27.02.2006", "d.M.yyyy", CultureInfo.InvariantCulture);
            secondDate = DateTime.ParseExact("3.3.2006", "dd.M.yyyy", CultureInfo.InvariantCulture);// */
            //d - day in format 3 or 03
            //dd - day in format 03 only. It throws a format exception otherwise
            //... it's the same with the month.

            int span = (secondDate - firstDate).Days;

            Console.Clear();
            Console.Write("There are ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(span);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" days between {0:dd.MM.yyyy} and {1:dd.MM.yyyy}.", firstDate, secondDate);
        }
    }
}
