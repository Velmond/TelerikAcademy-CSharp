//Задача 8
//Write a program that calculates the greatest common divisor (GCD) of given two numbers.
//Use the Euclidean algorithm (find it in internet).

//http://www.wikihow.com/Find-the-Greatest-Common-Divisor-of-Two-Integers

using System;

class GCDWithEuclideanAlgorithm
{
    static void Main()
    {
        uint firstNumber, secondNumber;
        Console.Write("Input the first number (it has to be a positive integer) - ");
        bool inputError = uint.TryParse(Console.ReadLine(), out firstNumber);
        while (!inputError)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = uint.TryParse(Console.ReadLine(), out firstNumber);
        }
        Console.Write("Input the second number (it has to be a positive integer, too) - ");
        inputError = uint.TryParse(Console.ReadLine(), out secondNumber);
        while (!inputError)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = uint.TryParse(Console.ReadLine(), out secondNumber);
        }
        uint maxValue = 0, minValue = 0, GCD = 0;
        uint remainder;
        if (firstNumber != secondNumber)    //Започвам операция по намиране на най-голямото общо кратно само ако числата са различни
        {
            if (firstNumber > secondNumber) //Намирам кое от въведените стойности е по-голяма и я присвоявам на променливата maxValue
            {                               //... По-малката стойност остава в променливата minValue
                maxValue = firstNumber;
                minValue = secondNumber;
            }
            else if (firstNumber < secondNumber)
            {
                maxValue = secondNumber;
                minValue = firstNumber;
            }
            do                          //От тук започва същинския цикъл за определяне на най-голямото общо кратно.
            {                           //За това как работи може да се види в страницата на посочения най-горе линк (ред 5).
                remainder = maxValue % minValue;
                if (remainder == 0)
                {
                    GCD = minValue;
                }
                else
                {
                    maxValue = minValue;
                    minValue = remainder;
                }
            } while (remainder != 0);   //Повтаря се цикъла, докато не се получи остатък от целочисленото делене - 0
        }
        else                            //Ако числата са равни, най-голямото общо кратно е равно на тяхната стойност.
        {
            GCD = firstNumber;
        }
        Console.WriteLine("The GCD of {0} and {1} is: {2}", firstNumber, secondNumber, GCD);
    }
}
