//05. Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class NumberOfWorkdays
{
    static DateTime[] holidays =                    //An array with most national holidays for 2013 and 2014
    {
        new DateTime(2013, 01, 01), new DateTime(2013, 03, 03), new DateTime(2013, 05, 01), new DateTime(2013, 05, 06), 
        new DateTime(2013, 05, 24), new DateTime(2013, 09, 06), new DateTime(2013, 09, 22), new DateTime(2013, 11, 01),
        new DateTime(2013, 12, 24), new DateTime(2013, 12, 25), new DateTime(2013, 12, 26),
        new DateTime(2014, 01, 01), new DateTime(2014, 03, 03), new DateTime(2014, 05, 01), new DateTime(2014, 05, 06), 
        new DateTime(2014, 05, 24), new DateTime(2014, 09, 06), new DateTime(2014, 09, 22), new DateTime(2014, 11, 01),
        new DateTime(2014, 12, 24), new DateTime(2014, 12, 25), new DateTime(2014, 12, 26),
    };

    static DateTime DateInput()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        string[] dateInput = Console.ReadLine().Split('.'); //If the input is in the format 'DD.MM.YYYY' it is put in an array
        Console.ForegroundColor = ConsoleColor.Gray;        //and is turned into DateTime on the next row

        DateTime startDate = new DateTime(int.Parse(dateInput[2]), int.Parse(dateInput[1]), int.Parse(dateInput[0]));

        return startDate;
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter the start date of the interval in the format: DD.MM.YYYY - ");
            DateTime startDate = DateInput();
            Console.WriteLine("Please enter the end date of the interval in the format: DD.MM.YYYY - ");
            DateTime endDate = DateInput();

            int numberOfDays = Math.Abs((endDate - startDate).Days);       //Keeps the total number of days in the interval

            int workDayCounter = 0;     //Keeps the number of the workdays

            for (int i = 0; i < numberOfDays; i++)
            {
                bool isHoliday = false;
                startDate = startDate.AddDays(1);
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                {                                                                   //Remove all Saturdays and Sundays
                    for (int j = 0; j < holidays.Length; j++)   //Checks if the day is in the array of the national holidays and
                        if (startDate == holidays[j])           //if it is, that day is not counted as a workday
                        {
                            isHoliday = true;
                            break;
                        }

                    if (!isHoliday)
                        workDayCounter++;
                }
            }

            Console.Write("The number of days in the interval {0: dd.MM.yyyy} - {1: dd.MM.yyyy} is: ", startDate, endDate);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(workDayCounter);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }
    }
}