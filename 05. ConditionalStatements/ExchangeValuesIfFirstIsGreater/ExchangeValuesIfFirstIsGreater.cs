//Задача 1
//Write an if statement that examines two integer variables and exchanges their values
//if the first one is greater than the second one.

using System;

class ExchangeValuesIfFirstIsGreater
{
    static void Main()
    {
        int firstNumber, secondNumber;
        bool errorDetect;
        Console.Write("Input first integer: ");
        errorDetect = int.TryParse(Console.ReadLine(), out firstNumber);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out firstNumber);
        }
        Console.Write("Input second integer: ");
        errorDetect = int.TryParse(Console.ReadLine(), out secondNumber);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out secondNumber);
        }
        Console.Clear();
        Console.WriteLine("Starting with:\nFirst number:\t{0}\nSecond number:\t{1}", firstNumber, secondNumber);
        if (firstNumber > secondNumber)
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
        }
        Console.WriteLine("\nEnding with:\nFirst number (smaller one):\t{0}\nSecond number (greater one):\t{1}\n", firstNumber, secondNumber);
    }
}