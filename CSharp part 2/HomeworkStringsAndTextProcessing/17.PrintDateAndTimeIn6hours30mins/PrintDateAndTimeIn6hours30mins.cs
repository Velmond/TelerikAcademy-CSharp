//17. Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints 
//    the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

namespace PrintDateAndTimeIn6hours30mins
{
    using System;
    using System.Globalization;

    class PrintDateAndTimeIn6hours30mins
    {
        static void Main()
        {
            string input = string.Empty;
            Console.Write("Input the date in time in the following format:\nday.month.year hour:minute:second -> ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //To use your own input uncomment the line below:
            //input = Console.ReadLine();/*
            input = "28.2.2012 22:45:34";// */
            Console.ForegroundColor = ConsoleColor.Gray;

            DateTime dateTime = DateTime.ParseExact(input, "d.M.yyyy HH:mm:ss", CultureInfo.InvariantCulture); 
            dateTime = dateTime.AddHours(6).AddMinutes(30);

            Console.Clear();
            Console.WriteLine("6 hours and 30 minutes from the inputed date it will be: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} {1}", dateTime, dateTime.ToString("dddd", new CultureInfo("bg-BG")));
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
