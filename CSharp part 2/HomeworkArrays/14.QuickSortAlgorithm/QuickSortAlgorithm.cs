//14. Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

class QuickSortAlgorithm
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
        string[] array = new string[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Input element {0}: ", i);
            array[i] = Console.ReadLine();
        }

        //За проверка: 
        //string[] array = { "Pesho", "Joro", "Mitko", "Ana", "Aleksandyr", "Ivan", "Iordan", 
        //                   "Stefka", "Gergana", "Natalia", "Nikolai", "Maria", "Martin" };
        //int arraySize = array.Length;

        Console.Clear();

        Console.WriteLine("Before sorting:");
        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine("{0,3}. {1}", (i + 1), array[i]);
        }
        Console.WriteLine();

        for (int i = 0; i < arraySize; i++)
        {
            string minValue = array[i];
            int minIndex = i;
            string tempValue = minValue;

            for (int j = i; j < arraySize; j++)
            {
                if (minValue.CompareTo(array[j]) >= 0)
                {
                    minValue = array[j];
                    minIndex = j;
                }
            }
            tempValue = array[i];
            array[i] = minValue;
            array[minIndex] = tempValue;
        }

        Console.WriteLine("After sorting:");
        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine("{0,3}. {1}", (i + 1), array[i]);
        }
        Console.WriteLine();
    }
}