//05. Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}

using System;

class MaximumIncreasingSequence
{
    static void Main()
    {
        //Решението е абсолютно идентично с предната задача (4), като единствено се променят условията за увеличаване на
        //величините currCounter
        int arraySize;
        Console.Write("What size should the array you want checked be? ");
        bool errorDetect = int.TryParse(Console.ReadLine(), out arraySize);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out arraySize);
        }

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Input element {0} of the array: ", i);
            errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            while (!errorDetect)
            {
                Console.Write("Incorect input! Try again - ");
                errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            }
        }

        //За да се използва примера от условието трябва да се закоментират редове от предния коментар
        //до този и да се разкоментират следващите два:
        //int[] array = {3, 2, 3, 4, 2, 2, 4};
        //int arraySize = 7;

        Console.Clear();
        int currCounter = 1;
        int maxCounter = 1;
        int prevElement = array[0];
        int lastValueOfSequence = array[0];

        for (int i = 1; i < arraySize; i++)
        {
            if (array[i] == (prevElement + 1))
            {
                currCounter++;
                prevElement = array[i];
            }
            else
            {
                if (maxCounter < currCounter)
                {
                    maxCounter = currCounter;
                    lastValueOfSequence = array[i - 1];
                }
                currCounter = 1;
                prevElement = array[i];
            }
        }
        if (maxCounter < currCounter)
        {
            maxCounter = currCounter;
            lastValueOfSequence = prevElement - 1;
        }

        Console.Write("{");
        for (int i = (lastValueOfSequence - maxCounter + 1); i <= lastValueOfSequence; i++)
        {
            if (i < lastValueOfSequence)
            {
                Console.Write(" {0},", i);
            }
            else
            {
                Console.Write(" {0}", i);
            }
        }
        Console.WriteLine("}");
    }
}