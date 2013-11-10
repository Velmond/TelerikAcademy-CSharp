//03.  Define a class InvalidRangeException<T> that holds information about an error condition related to invalid
//    range. It should hold error message and a range definition [start … end].
//     Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
//    by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace InvalidRangeException
{
    using System;

    class TestApplication
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;

            try
            {
                TestInt(0, 100);
            }
            catch (InvalidRangeException<int> intEx)
            {
                Console.WriteLine();
                Console.WriteLine(intEx.Message);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

            try
            {
                TestDateTime(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            }
            catch (InvalidRangeException<DateTime> dateTimeEx)
            {
                Console.WriteLine();
                Console.WriteLine(dateTimeEx.Message);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
        }

        static void TestInt(int startValue, int endValue)
        {
            int number;

            Console.Write("Enter a number between {0} and {1}: ", startValue, endValue);
            Console.ForegroundColor = ConsoleColor.Yellow;

            while ((number = int.Parse(Console.ReadLine())) >= startValue && number <= endValue)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The number {0} is valid!", number);
                Console.Write("Enter next number: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.ForegroundColor = ConsoleColor.White;

            if (number < startValue || number > endValue)
            {
                throw new InvalidRangeException<int>(startValue, endValue);
            }
        }

        static void TestDateTime(DateTime startValue, DateTime endValue)
        {
            DateTime date;

            Console.Write("Enter a date between {0:dd.MM.yyyy} and {1:dd.MM.yyyy}: ", startValue, endValue);
            Console.ForegroundColor = ConsoleColor.Yellow;

            while ((date = DateTime.Parse(Console.ReadLine())) >= startValue && date <= endValue)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The date {0:dd.MM.yyyy} is valid!", date);
                Console.Write("Enter next date: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.ForegroundColor = ConsoleColor.White;

            if (date < startValue || date > endValue)
            {
                throw new InvalidRangeException<DateTime>(startValue, endValue);
            }
        }
    }
}