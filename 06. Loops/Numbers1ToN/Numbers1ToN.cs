//Задача 1
//Write a program that prints all the numbers from 1 to N.

using System;

class Numbers1ToN
{
    static void Main()
    {
        int number;
        Console.Write("How many numbers would you like printed? ");
        bool inputError = int.TryParse(Console.ReadLine(), out number);
        while (inputError == false)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = int.TryParse(Console.ReadLine(), out number);
        }
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
