//Задача 3
//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MinAndMaxOfSequence
{
    static void Main()
    {
        byte numberOfNumbers;
        Console.Write("Input the number of numbers (N) out of witch\nthe max and min value are to be extracted - ");
        bool inputError = byte.TryParse(Console.ReadLine(), out numberOfNumbers);
        while (inputError == false)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = byte.TryParse(Console.ReadLine(), out numberOfNumbers);
        }
        Console.Clear();
        decimal number;
        Console.Write("Input number #1 - ");
        inputError = decimal.TryParse(Console.ReadLine(), out number);
        while (inputError == false)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = decimal.TryParse(Console.ReadLine(), out number);
        }
        decimal minValue = number, maxValue = number;
        decimal nextNumber;
        for (int i = 2; i <= numberOfNumbers; i++)
        {
            Console.Write("Input number #{0} - ", i);
            inputError = decimal.TryParse(Console.ReadLine(), out nextNumber);
            while (inputError == false)
            {
                Console.Write("Incorect input! Try again - ");
                inputError = decimal.TryParse(Console.ReadLine(), out nextNumber);
            }
            if (nextNumber > maxValue)
            {
                maxValue = nextNumber;
            }
            if (nextNumber < minValue)
            {
                minValue = nextNumber;
            }
        }
        Console.WriteLine("The maximum value is: {0}", maxValue);
        Console.WriteLine("The minimum value is: {0}", minValue);
    }
}
