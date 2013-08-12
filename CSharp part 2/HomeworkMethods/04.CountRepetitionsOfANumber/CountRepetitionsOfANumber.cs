//04.01. Write a method that counts how many times given number appears in given array.
//04.02. Write a test program to check if the method is working correctly.

using System;

public class CountRepetitionsOfANumber
{
    public static int GetNumberOfRepetitions(int[] array)
    {
        Array.Sort(array);                      //Сортирам масива, така че еднаквите стойности да са една след друга
        int currCount = 1;
        int maxCount = currCount;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i-1])         //Ако дадената стойност е същата като предходната брояча се увеличава с 1
                currCount++;
            else
                currCount = 1;                  //В противен случай се връща на 1

            if (currCount > maxCount)           //Ако в даден момент се достигне стойност на брояча по-голяма от максималната намерена
                maxCount = currCount;           //до момента, то максималния брой се приема равен на настоящия
        }
        return maxCount;
    }

    static void Main()
    {
        uint arraySize;
        Console.Write("Input a number to get its last digit - ");
        bool errorDetect = uint.TryParse(Console.ReadLine(), out arraySize);
        while (!errorDetect)
        {
            Console.Write("Incorrect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out arraySize);
        }
        int[] array = new int[arraySize];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Input element {0} - ", i);
            errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            while (!errorDetect)
            {
                Console.Write("Incorrect input! Try again - ");
                errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            }
        }

        Console.Clear();

        Console.Write("The maximum number of times a number is repeated in the array is: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(GetNumberOfRepetitions(array));
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}