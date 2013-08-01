//Задача 2
//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        int endNumber;
        Console.Write("Input the end number of the interval 1 to N - ");
        bool inputError = int.TryParse(Console.ReadLine(), out endNumber);
        while (inputError == false)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = int.TryParse(Console.ReadLine(), out endNumber);
        }
        int count = 0;
        Console.Clear();
        for (int i = 1; i <= endNumber; i++)
        {
            if (i % 21 != 0)
            {
                Console.WriteLine(i);
                count++;
            }
        }
        Console.WriteLine("\nThe number of numbers not divisible by 3 and 7 at the same time\nin the interval 1 to {0} is: {1}\n", endNumber, count);
    }
}
