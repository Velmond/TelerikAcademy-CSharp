//Задача 7
//Write a program that finds the greatest of given 5 variables.

using System;

class GreatestOfFiveNumbers
{
    static void Main()
    {
        int firstNumber, secondNumber, thirdNumber, forthNumber, fifthNumber;
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
        Console.Write("Input third integer: ");
        errorDetect = int.TryParse(Console.ReadLine(), out thirdNumber);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out thirdNumber);
        }
        Console.Write("Input forth integer: ");
        errorDetect = int.TryParse(Console.ReadLine(), out forthNumber);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out forthNumber);
        }
        Console.Write("Input fifth integer: ");
        errorDetect = int.TryParse(Console.ReadLine(), out fifthNumber);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out fifthNumber);
        }
        Console.Clear();                //Изчиства конзолата от предните въпроси
        int maxValue = firstNumber;
        if (secondNumber > firstNumber && secondNumber >= thirdNumber && secondNumber >= forthNumber && secondNumber >= fifthNumber)
        {
            maxValue = secondNumber;
        }
        else if (thirdNumber > firstNumber && thirdNumber >= secondNumber && thirdNumber >= forthNumber && thirdNumber >= fifthNumber)
        {
            maxValue = thirdNumber;
        }
        else if (forthNumber > firstNumber && forthNumber >= secondNumber && forthNumber >= thirdNumber && forthNumber >= fifthNumber)
        {
            maxValue = forthNumber;
        }
        else if (fifthNumber > firstNumber && fifthNumber >= secondNumber && fifthNumber >= thirdNumber && fifthNumber >= forthNumber)
        {
            maxValue = fifthNumber;
        }

        // V Или с Math.Max()
        //int maxValue = Math.Max(firstNumber, secondNumber);
        //maxValue = Math.Max(maxValue, thirdNumber);
        //maxValue = Math.Max(maxValue, forthNumber);
        //maxValue = Math.Max(maxValue, fifthNumber);

        Console.WriteLine("The max value of {0}, {1}, {2}, {3} and {4} is {5}", firstNumber, secondNumber, thirdNumber, forthNumber, fifthNumber, maxValue);
    }
}