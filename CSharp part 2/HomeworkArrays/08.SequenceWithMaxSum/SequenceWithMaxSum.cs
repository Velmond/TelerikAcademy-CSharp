//08. Write a program that finds the sequence of maximal sum in given array.
//Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class SequenceWithMaxSum
{
    static void Main()
    {
        int arraySize;
        Console.Write("What size should the array be? (N) ");
        bool errorDetect = int.TryParse(Console.ReadLine(), out arraySize);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out arraySize);
        }
        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Input element {0}: ", i);
            errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            while (!errorDetect)
            {
                Console.Write("Incorect input! Try again - ");
                errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            }
        }

        //За проверка:
        //int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        //int arraySize = array.Length;

        Console.Clear();

        int firstElement = 0;
        int tempFirstElement = 0;
        int currCounter = 1;
        int finalCounter = 1;
        int sum = array[0];
        int maxSum = sum;

        for (int i = 1; i < arraySize; i++)
        {
            if (array[i] + sum > array[i])
            {
                sum += array[i];
                currCounter++;
            }
            else
            {
                sum = array[i];
                tempFirstElement = i;
                currCounter = 1;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                finalCounter = currCounter;
                firstElement = tempFirstElement;
            }
        }

        Console.Write("The sequence with the biggest sum is: ");       //Изписва резултата
        for (int i = firstElement; i < firstElement + finalCounter; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("\nTheir sum is: {0}", maxSum);
    }
}