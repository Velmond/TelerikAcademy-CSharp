//Задача №5
//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class GreaterOfTwoNumbers
{
    static void Main()
    {
        double firstNumber;
        double secondNumber;
        bool errorDetect;
        Console.Write("Input first number: ");
        errorDetect = double.TryParse(Console.ReadLine(), out firstNumber);
        while (errorDetect == false)
        {
            Console.Write("Input first number: ");
            errorDetect = double.TryParse(Console.ReadLine(), out firstNumber);
        }
        Console.Write("Input second number: ");
        errorDetect = double.TryParse(Console.ReadLine(), out secondNumber);
        while (errorDetect == false)
        {
            Console.Write("Input first number: ");
            errorDetect = double.TryParse(Console.ReadLine(), out secondNumber);
        }
        double maxValue = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater of {0} and {1} is: {2}", firstNumber, secondNumber, maxValue);
    }
}