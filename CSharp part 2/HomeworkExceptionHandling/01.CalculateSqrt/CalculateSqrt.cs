//01. Write a program that reads an integer number and calculates and prints its square root. 
//    If the number is invalid or negative, print "Invalid number". 
//    In all cases finally print "Good bye". Use try-catch-finally.

namespace CalculateSqrt
{
    using System;

    public class CalculateSqrt
    {
        public static void Main()
        {
            Console.Write("Input a number to get its sqare root - ");

            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                uint number = uint.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;

                double result = Math.Sqrt(number);

                Console.WriteLine("The square root of ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(number);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" is: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0:f2}",result);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Good bye!\n");
            }
        }
    }
}