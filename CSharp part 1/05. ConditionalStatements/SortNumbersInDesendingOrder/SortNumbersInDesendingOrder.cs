//Задача 4
//Sort 3 real values in descending order using nested if statements.

using System;

class SortNumbersInDesendingOrder
{
    static void Main()
    {
        int firstNumber, secondNumber, thirdNumber;
        bool errorDetect;
        Console.Write("Input first integer: ");
        errorDetect = int.TryParse(Console.ReadLine(), out firstNumber);
        while (errorDetect == false)
        {
            Console.Write("Incorect input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out firstNumber);
        }
        Console.Write("Input second integer: ");
        errorDetect = int.TryParse(Console.ReadLine(), out secondNumber);
        while (errorDetect == false)
        {
            Console.Write("Incorect input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out secondNumber);
        }
        Console.Write("Input third integer: ");
        errorDetect = int.TryParse(Console.ReadLine(), out thirdNumber);
        while (errorDetect == false)
        {
            Console.Write("Incorect input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out thirdNumber);
        }
        Console.Clear();    //Изчиства конзолата от предните въпроси
        int maxValue, midValue, minValue;
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                maxValue = firstNumber;
                if (thirdNumber > secondNumber)
                {
                    midValue = thirdNumber;
                    minValue = secondNumber;
                }
                else
                {
                    midValue = secondNumber;
                    minValue = thirdNumber;
                }
            }
            else
            {
                maxValue = thirdNumber;
                midValue = firstNumber;
                minValue = secondNumber;
            }
        }
        else if (thirdNumber > secondNumber)
        {
            maxValue = thirdNumber;
            midValue = secondNumber;
            minValue = firstNumber;
        }
        else
        {
            maxValue = secondNumber;
            if (thirdNumber > firstNumber)
            {
                midValue = thirdNumber;
                minValue = firstNumber;
            }
            else
            {
                midValue = firstNumber;
                minValue = thirdNumber;
            }
        }
        Console.WriteLine("The numbers {0}, {1} and {2}, sorted in desending order are:\n\n\t{3}\n\t{4}\n\t{5}\n", firstNumber,
                                                            secondNumber, thirdNumber, maxValue, midValue, minValue);
    }
}