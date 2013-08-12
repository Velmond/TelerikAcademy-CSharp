//16. * We are given an array of integers and a number S. Write a program to find if there exists a subset
//of the elements of the array that has a sum S.
//Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)

using System;

class IsThereASubsetWithAGivenSum
{
    static void Main()
    {
        int arraySize, soughtSum;
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
        Console.Write("What sum are we looking for? (S) ");
        errorDetect = int.TryParse(Console.ReadLine(), out soughtSum);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out soughtSum);
        }

        //За проверка:
        //int soughtSum = 14;
        //int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
        //uint arraySize = (uint)array.Length;

        Console.Clear();

        uint numberOfSums = (uint)Math.Pow(2, arraySize);
        bool sumExists = false;
        uint count = 1;

        for (int i = 1; i < numberOfSums; i++)
        {
            string subset = "";
            int currSum = 0;
            for (int j = 0; j < arraySize; j++)
            {
                int mask = 1 << j;
                int bit = (i & mask) >> j;
                if (bit == 1)
                {
                    currSum = currSum + array[j];
                    if (array[j] < 0 || subset == "")
                    {
                        subset = subset + array[j];
                    }
                    else
                    {
                        subset = subset + '+' + array[j];
                    }
                }
            }
            if (currSum == soughtSum)
            {
                Console.WriteLine("YES -> {0,3}. {1}", count, subset);
                sumExists = true;
                count++;
            }
        }
        if (!sumExists)
        {
            Console.WriteLine("There is no way to get the given sum in the array!");
        }
    }
}