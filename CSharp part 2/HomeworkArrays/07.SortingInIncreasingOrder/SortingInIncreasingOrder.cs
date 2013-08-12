//07. Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc.

using System;

class SortingInIncreasingOrder
{
    static void Main()
    {
        //Входа е аналогичен на предните задачи
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

        //За по-лесна проверка може да се закоментират горните редове и да се разкоментират следващите два:
        //int[] array = { 12, 53, 13, 13, 9, 54, 12, 10 };
        //int arraySize = array.Length;         //След сортиране масива ще има вида: { 9, 10, 12, 12, 13, 13, 53, 54 }

        Console.Clear();
        Console.Write("Before sorting: ");      //Изписвам масива преди да е сортиран, като база за сравнение след сортирането
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        int minIndex = 0;   //Променлива, пазеща индекса на най-малката намерена стойност при обхождане на масива с for цикъл

        for (int i = 0; i < arraySize; i++)
        {
            int minValue = array[i];    //Приемам, че стойността на i-тия елемент е най-малка и започвам проверки дали е така
            for (int j = i; j < arraySize; j++)
            {
                if (minValue >= array[j])   //Ако даден елемент е по-малък от приетата за най-малка стойност, то приемам, че той
                {                           //е най-малкия елемент
                    minValue = array[j];
                    minIndex = j;
                }
            }
            for (int k = minIndex; k >= i; k--) //След като се намери най-малката стойност, се пренареждат елементите, така
            {                                   //че тя да заеме i-тата позиция
                if (k > i)
                {
                    array[k] = array[k - 1];
                }
                else
                {
                    array[k] = minValue;
                }
            }
        }

        Console.Write("After sorting: ");       //Изписвам масива след като е сортиран
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}