//Задача №5
//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class WhatIsBit3
{
    static void Main()
    {
        Console.Write("What number's 3rd bit would you like checked? ");
        int number;
        bool errorDetect = int.TryParse(Console.ReadLine(), out number);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out number);
        }
        int mask = 1 << 3;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> 3;
        bool isTheBitZero;
        if (bit == 0)
        {
            isTheBitZero = true;
        }
        else
        {
            isTheBitZero = false;
        }
        Console.Clear();
        if (isTheBitZero == true)
        {
            Console.WriteLine("Number: {0} ({1})\nThe bit at the 3rd position (starting from 0) is: 0\n", number, Convert.ToString(number, 2));
        }
        else
        {
            Console.WriteLine("Number: {0} ({1})\nThe bit at the 3rd position (starting from 0) is: 1\n", number, Convert.ToString(number, 2));
        }
    }
}
