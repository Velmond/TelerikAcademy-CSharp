//Задача №2
//Write a boolean expression that checks for given integer if it
//can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("What number would you like checked if it devides by 7 and 5? ");
        int number;
        bool errorDetect = int.TryParse(Console.ReadLine(), out number);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out number);
        }
        string check;
        if (number % 5 == 0 && number % 7 == 0)
        {
            check = "CAN";
        }
        else
        {
            check = "can NOT";
        }
        Console.Clear();
        Console.WriteLine("{0} {1} divide by 5 and 7!\n{0} / 5 = {2:f2}\n{0} / 7 = {3:f2}\n", number, check, number / 5.0, number / 7.0);
    }
}
