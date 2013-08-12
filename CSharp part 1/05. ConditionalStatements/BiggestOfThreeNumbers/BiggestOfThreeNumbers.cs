//Задача 3
//Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestOfThreeNumbers
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
        Console.Clear();    //Изчиства конзолата от горните въпроси и въведените отговори и продължава към изпълнението на 
        int maxValue;       //...същината на задачата
        if (firstNumber>secondNumber)       //Проверява дали първата въведена стойност е по-голяма от втората
        {
            if (firstNumber>thirdNumber)    //Ако първата стойност е по-голяма от втората, проверява дали 
            {                               //...първата не е по-голяма и от втората...
                maxValue = firstNumber;     //...ако е присвоява на променливата maxValue стойността на първата въведена стойност...
            }
            else
            {
                maxValue = thirdNumber;     //...а ако не е, значи третата стойност е най-голяма и нейната стойност се присвоява на maxValue.
            }
        }
        else if (secondNumber>thirdNumber)  //Ако първата стойност не е по-голама от втората, и втората Е по-голяма от третата,
        {                                   //...значи втората стойност е най-голяма и присвояваме нейната стойност към променливата
            maxValue = secondNumber;        //...maxValue
        }
        else
        {
            maxValue = thirdNumber;         //Ако предните две основни условия не са изпълнени, значи третата стойност е най-голямата.
        }
        Console.WriteLine("\nThe max value of {0}, {1}, {2} is {3}\n", firstNumber, secondNumber, thirdNumber, maxValue);
    }
}