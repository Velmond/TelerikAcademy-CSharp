//11. Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//    percentage and in scientific notation. Format the output aligned right in 15 symbols.

namespace NumberAsDecimalHexPercentAndSci
{
    using System;

    class NumberAsDecimalHexPercentAndSci
    {
        static void Main()
        {
            int number = int.MinValue;
            Console.Write("Input an integer: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Incorect input. Try again: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("As decimal:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0, 15}", number);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("As hexadecimal:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,15:X}", number);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("As pecentage:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,15:P}", number);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("As scientific notation:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,15:e}", number);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
