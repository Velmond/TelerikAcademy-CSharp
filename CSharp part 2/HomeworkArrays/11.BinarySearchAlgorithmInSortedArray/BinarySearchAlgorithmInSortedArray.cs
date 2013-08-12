//11. Write a program that finds the index of given element in a sorted array of integers by using
//the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearchAlgorithmInSortedArray
{
    static void Main()
    {
        int arraySize;
        Console.Write("What size should the array be? ");
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
        int soughtNumber;
        Console.Write("Witch number's index after sorting are we looking for? ");
        errorDetect = int.TryParse(Console.ReadLine(), out soughtNumber);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out soughtNumber);
        }

        //За проверка: 
        //int soughtNumber = 22;
        //int[] array = { 1, 2, 4, 8, 22, 36, 64, 120, 200 };

        Console.Clear();

        bool isThereSuchANumber = false;    //Проверявам дали търсеното число изобщо се намира в масива
        for (int i = 0; i < arraySize; i++)
        {
            if (array[i] == soughtNumber)
            {
                isThereSuchANumber = true;
            }
        }
        if (!isThereSuchANumber)            //Ако числото не е в масива, това се изписва на конзолата
        {
            Console.WriteLine("The number {0} is not in the array!", soughtNumber);
        }
        else                                //Ако числото е в масива, се преминава към търсене на индекса му в сортирания масив
        {
            Array.Sort(array);
            bool thisIsIt = false;
            int index = 0;
            int leftIndex = 0;
            int rightIndex = array.Length;
            int midIndex = (array.Length / 2);
            do
            {
                int number = array[midIndex];
                if (number == soughtNumber)
                {
                    thisIsIt = true;
                    index = midIndex;
                }
                else
                {
                    if (number > soughtNumber)
                    {
                        rightIndex = midIndex;
                        midIndex = ((rightIndex + leftIndex) / 2);
                    }
                    else if (number < soughtNumber)
                    {
                        leftIndex = midIndex;
                        midIndex = ((leftIndex + rightIndex) / 2);
                    }
                }
            } while (!thisIsIt);
            
            Console.WriteLine("The index of the number {0} in the sorted array is: {1}", soughtNumber, index);
        }
    }
}