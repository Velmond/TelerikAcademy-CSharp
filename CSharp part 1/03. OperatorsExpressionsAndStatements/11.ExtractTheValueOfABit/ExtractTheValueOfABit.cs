//Задача №11
//Write an expression that extracts from a given integer i the value of a given bit number b.
//Example: i=5; b=2 => value=1.

using System;

class ExtractTheValueOfABit
{
    static void Main()
    {
        Console.Write("What number would you like to extract a bit from? ");
        int number;
        bool errorDetect = int.TryParse(Console.ReadLine(), out number);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out number);
        }
        Console.Write("Witch bit would you like to extracted (starting from 0)? ");
        int position;
        errorDetect = int.TryParse(Console.ReadLine(), out position);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out position);
        }
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bitValue = numberAndMask >> position;
        Console.Clear();
        Console.WriteLine("The value of bit {0} out of the number {1} ({2}) is: {3}\n", position, number, Convert.ToString(number,2), bitValue);
    }
}
