//09. Write a program that finds the most frequent number in an array.
//Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

using System;

class MostFrequentNumber
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

        //За да се използва примера от условието трябва да се закоментират редове от предния коментар
        //до този и да се разкоментират следващите два:
        //int[] array = {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};
        //int arraySize = array.Length;

        Array.Sort(array);  //Сортирам масива, така че еднаквите стойности да се намират непосредствено една до друга
        Console.Clear();

        int currCounter = 1;
        int maxCounter = 1;
        int prevElement = array[0];
        int mostFreqElement = array[0];
        for (int i = 1; i < arraySize; i++)
        {
            if (array[i] == prevElement)        //Ако елемента е равен на предния, брояча се увеличава с 1
            {
                currCounter++;
                if (maxCounter < currCounter)   //Ако брояча стане по-голям от maxCounter, maxCounter приема неговата стойност,
                {                               //а дадената стойност се запазва като най-често срещана (в mostFreqElement)
                    maxCounter = currCounter;
                    mostFreqElement = prevElement;
                }
            }
            else                                //Ако елемента е различен от предния, брояча се връща на стойност 1, 
            {                                   //а стойността на новия елемент се запазва в prevElement
                prevElement = array[i];
                currCounter = 1;
            }
        }
        Console.WriteLine("{0} -> {1} times", mostFreqElement, maxCounter);
    }
}