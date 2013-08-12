//Задача №1
//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class SumOf3Numbers
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;
        bool errorDetect;
        Console.Write("Please input the first number: ");
        errorDetect = int.TryParse(Console.ReadLine(), out firstNumber);
        while (errorDetect == false)
        {
            Console.Write("Invalid input! Please try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out firstNumber);
        }
        Console.Write("Please input the second number: ");
        errorDetect = int.TryParse(Console.ReadLine(), out secondNumber);
        while (errorDetect == false)
        {
            Console.Write("Invalid input! Please try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out secondNumber);
        }
        Console.Write("Please input the third number: ");
        errorDetect = int.TryParse(Console.ReadLine(), out thirdNumber);
        while (errorDetect == false)
        {
            Console.Write("Invalid input! Please try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out thirdNumber);
        }
        int sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("\n{0} + {1} + {2} = {3}\n", firstNumber, secondNumber, thirdNumber, sum);
    }
}
