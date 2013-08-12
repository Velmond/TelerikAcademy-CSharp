//06. Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class KElementsWithMaxSum
{
    static void Main()
    {
        int N, K;
        Console.Write("What size should the array be? (N) ");
        bool errorDetect = int.TryParse(Console.ReadLine(), out N);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out N);
        }
        Console.Write("The maximum sum of how many elements should be found? (K) ");
        errorDetect = int.TryParse(Console.ReadLine(), out K);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out K);
        }

        int[] array = new int[N];

        for (int i = 0; i < N; i++)
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
        //int[] array = { 1, 3, 4, 2, 5, 7, 3, 4, 8 };
        //int N = array.Length;
        //int K = 4;                    //Отговора за този пример би следвало да е: 8 + 7 + 5 + 4 = 24

        Array.Sort(array);              //Сортирам масива, за да най-големите стойности да се окажат в последните му елементи
        Console.Clear();

        int sum = 0;
        for (int i = (N - 1); i >= (N - K); i--)    //Сумирам елементите от последния до (последния - К)
        {
            sum += array[i];
        }

        Console.Write("The {0} max elements are: ", K);
        Console.Write("{ ");
        for (int i = (N - 1); i >= (N - K); i--)    //Изписвам елементите от последния до (последния - К)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine("}");
        Console.WriteLine("Their sum is: {0}", sum);//Изписвам сумата от елементите
    }
}