//Задача №10
//Write a boolean expression that returns if the bit at position p (counting from 0)
//in a given integer number v has value of 1. Example: v=5; p=1 => false.

using System;

class IsABitInANumber1
{
    static void Main()
    {
        Console.Write("What number's bit would you like checked? ");
        int number;
        bool errorDetectNumber = int.TryParse(Console.ReadLine(), out number);
        while (errorDetectNumber == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetectNumber = int.TryParse(Console.ReadLine(), out number);
        }
        Console.Write("What bit would you like checked (starting from 0)? ");
        int position;
        bool errorDetectPosition = int.TryParse(Console.ReadLine(), out position);
        while (errorDetectPosition == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetectPosition = int.TryParse(Console.ReadLine(), out position);
        }
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        bool check;
        if (bit == 0)
        {
            check = false;
        }
        else
        {
            check = true;
        }
        Console.Clear();
        Console.WriteLine("Number = {0} ({1}); Position = {2} -> {3} (the bit is {4})\n", number, Convert.ToString(number, 2), position, check, bit);
    }
}
