//Задача №4
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them
//such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class NoReminderAfterDevisionBy5
{
    static void Main()
    {
        int startingNumber;
        int lastNumber;
        bool errorDetect;
        Console.Write("Input starting number: ");
        errorDetect = int.TryParse(Console.ReadLine(), out startingNumber);
        while (errorDetect == false)
        {
            Console.Write("Invalid input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out startingNumber);
        }
        Console.Write("Input last number: ");
        errorDetect = int.TryParse(Console.ReadLine(), out lastNumber);
        while (errorDetect == false)
        {
            Console.Write("Invalid input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out lastNumber);
        }
        int count = 0;
        for (int i = startingNumber; i <= lastNumber; i++)
        {
            if (i % 5 == 0)
                count++;
        }
        Console.WriteLine("\nThere are {0} integer numbers divisible by 5 in the selected interval ({1},{2})\n",
                          count, startingNumber, lastNumber);
    }
}