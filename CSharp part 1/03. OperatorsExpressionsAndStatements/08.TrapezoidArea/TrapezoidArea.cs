//Задача №8
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("What is the trapezoid's first base? ");
        double base1;
        bool errorDetect = double.TryParse(Console.ReadLine(), out base1);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number.\nDid you use \".\" or \",\"? Try again - ");
            errorDetect = double.TryParse(Console.ReadLine(), out base1);
        }
        Console.Write("What is the trapezoid's second base? ");
        double base2;
        errorDetect = double.TryParse(Console.ReadLine(), out base2);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = double.TryParse(Console.ReadLine(), out base2);
        }
        Console.Write("What is the trapezoid's height? ");
        double height;
        errorDetect = double.TryParse(Console.ReadLine(), out height);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = double.TryParse(Console.ReadLine(), out height);
        }
        double area = (0.5 * (base1 + base2) * height);
        Console.Clear();
        Console.WriteLine("A = {0:f2}\nB= {1:f2}\nH= {2:f2}\n\nA = (A+B)*H/2 = ( {0:f2} + {1:f2} ) * {2:f2} / 2 = {3:f2}\n", base1, base2, height, area);
    }
}
