//10. Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}

using System;

class FindSequenceWithGivenSum
{
    static void Main()
    {
        //Входа е аналогичен на предните задачи
        int arraySize, soughtSum;
        Console.Write("What size should the array be? (N) ");
        bool errorDetect = int.TryParse(Console.ReadLine(), out arraySize);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out arraySize);
        }
        Console.Write("What sum are we looking for? (S) ");
        errorDetect = int.TryParse(Console.ReadLine(), out soughtSum);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out soughtSum);
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

        Console.Clear();

        //За да се използва примера от условието трябва да се закоментират редове от предния коментар до този и да се разкоментират
        //следващите три. Могат да се направят допълнителни проверки със същия пример като се промени стойността на soughtSum:
        //int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        //int soughtSum = 11; //{4, 2, 5} -> 11; {4, 3, 1, 4} -> 12; {5, 8} -> 13; {4, 3, 1, 4, 2} -> 14; {3, 1, 4, 2, 5} -> 15
        //int arraySize = 7;

        bool sumIsPresent = false;
        int firstElementIndex = 0;
        int lastElementIndex = 0;
        for (int i = 0; i < arraySize; i++)
        {
            int sum = 0;
            for (int j = i; j < arraySize; j++)
            {
                if (sum < soughtSum)        //Ако сумата до тук е по-малка от търсената се добавя следващия елемент
                {
                    sum += array[j];
                }
                if (sum > soughtSum)        //Ако сумата до тук е по-голяма от търсената се прекъсва изпълнението на дадената
                {                           //стъпка на цикъла
                    firstElementIndex = (i + 1);    //Показва индекса на елемента, от който започва сумирането
                    break;
                }
                else if (sum == soughtSum)
                {
                    sumIsPresent = true;    //Ако е намерена сума от елементите равна на търсената се прекъсва цикъла
                    lastElementIndex = j;   //Показва индекса на елемента, с който завършва сумирането
                    break;
                }
            }
            if (sumIsPresent)   //Ако е намерена сума от елементите равна на търсената се прекъсва и външния цикъл
            {
                break;
            }
        }

        //Изписване на резултата на конзолата:
        if (sumIsPresent)
        {
            Console.WriteLine("S = {0}", soughtSum);
            Console.Write("{ ");
            for (int i = firstElementIndex; i <= lastElementIndex; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("}");
        }
        else if (!sumIsPresent)
        {
            Console.WriteLine("A sequence with the sum {0} can't be found!", soughtSum);
        }
    }
}