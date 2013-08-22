//02. Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//    If an invalid number or non-number text is entered, the method should throw an exception. 
//    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace ReadNumberMethod
{
    using System;
    using System.Text;

    public class ReadNumberMethod
    {
        public static int start = 1;
        public static int end = 100;
        public static int numberCount = 1;
        public static StringBuilder finalNumbers = new StringBuilder(string.Empty);

        public static int ReadNumber(int start, int end)    //This method gets a single number and checks if it's in range
        {
            Console.Write("Input number #{0:00} ({1}; {2}) - ", numberCount, start, end);
            Console.ForegroundColor = ConsoleColor.Yellow;
            int number = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;

            if (number <= start || number >= end)       //If the number is out of the set range a ArgumentOutOfRangeException
                throw new ArgumentOutOfRangeException();//... is thrown

            return number;
        }

        public static StringBuilder GetTenNumbers(int start, int end)   //This method gets all the numbers one by one...
        {
            int number = ReadNumber(start, end);                    //...checks each if it's in range using the above method...
            finalNumbers.Append(number + " < ");                    //...appends every number to the previous ones...
            numberCount++;

            if (numberCount <= 10)
                return GetTenNumbers(number, end);                  //...using recursion unlill 10 numbers are put in.
            else
                return finalNumbers;
        }

        public static void Main()
        {
            try
            {
                finalNumbers.Append(start + " < ");
                GetTenNumbers(start, end);
                finalNumbers.Append(end);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(finalNumbers);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (ArgumentNullException nullException)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(nullException.Message);
            }
            catch (FormatException formatException)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(formatException.Message);
            }
            catch (OverflowException overflowException)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(overflowException.Message);
            }
            catch (ArgumentOutOfRangeException outOfRangeException)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(outOfRangeException.Message);
            }
        }
    }
}
