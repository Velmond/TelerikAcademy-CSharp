//09. Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order

using System;

class FindMaxElementInRangeOfArrayAndSortIt
{
    static uint Input()
    {
        uint inputValue;
        Console.ForegroundColor = ConsoleColor.Yellow;
        bool errorDetect = uint.TryParse(Console.ReadLine(), out inputValue);
        Console.ForegroundColor = ConsoleColor.Gray;
        while (!errorDetect)
        {
            Console.Write("Incorrect input! Try again - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            errorDetect = uint.TryParse(Console.ReadLine(), out inputValue);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        return inputValue;
    }

    static int[] Input(uint arraySize)
    {
        int[] array = new int[arraySize];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Input element {0} - ", i);
            Console.ForegroundColor = ConsoleColor.Yellow;
            bool errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            Console.ForegroundColor = ConsoleColor.Gray;
            while (!errorDetect)
            {
                Console.Write("Incorrect input! Try again - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        return array;
    }

    static bool ChoiseInput()
    {
        byte input;
        Console.ForegroundColor = ConsoleColor.Yellow;
        bool errorDetect = byte.TryParse(Console.ReadLine(), out input);
        Console.ForegroundColor = ConsoleColor.Gray;
        while (!errorDetect || (input != 1 && input != 2))
        {
            Console.Write("Incorrect input! Try again - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            errorDetect = byte.TryParse(Console.ReadLine(), out input);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        bool choise = false;
        if (input == 1)
            choise = true;

        return choise;
    }

    static int FindMaxElementInRange(int[] array, uint rangeStart, uint rangeEnd)
    {
        int maxElementInRange = array[rangeStart];
        for (uint i = rangeStart; i <= rangeEnd; i++)
            if (array[i] > maxElementInRange)
                maxElementInRange = array[i];       //Проверява се дали между двата въведени индекса има число по-голямо от началното

        return maxElementInRange;
    }

    static int[] SortArray(int[] array, bool inAscendingOrder)
    {
        if (inAscendingOrder)       //Сортирането е направено по почти еднакъв начив във възходящ и в низходящ ред, като разликата
            for (uint i = (uint)array.Length - 1; i >= 0 && i < array.Length; i--)  //... е в посоката в която се обхожда масива
            {
                uint indexOfMax = i;
                int maxValue = FindMaxElementInRange(array, 0, i);
                if (array[i] < maxValue)
                {
                    for (uint j = i; j >= 0; j--)
                        if (array[j] == maxValue)
                        {
                            indexOfMax = j;
                            break;
                        }
                    array[i] += array[indexOfMax];
                    array[indexOfMax] = array[i] - array[indexOfMax];
                    array[i] = array[i] - array[indexOfMax];
                }
            }
        else
            for (uint i = 0; i < array.Length; i++)
            {
                uint indexOfMax = i;
                int maxValue = FindMaxElementInRange(array, i, ((uint)array.Length - 1));
                if (array[i] < maxValue)
                {
                    for (uint j = i; j < array.Length; j++)
                        if (array[j] == maxValue)
                        {
                            indexOfMax = j;
                            break;
                        }
                    array[i] += array[indexOfMax];
                    array[indexOfMax] = array[i] - array[indexOfMax];
                    array[i] = array[i] - array[indexOfMax];
                }
            }

        return array;
    }

    static void OutputSortedArray(int[] array, bool inAscendingOrder)
    {
        if (inAscendingOrder)
            Console.WriteLine("The array sorted in ascending order is: ");
        else
            Console.WriteLine("The array sorted in descending order is: ");

        Console.ForegroundColor = ConsoleColor.Yellow;
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Pleas input the size of the array - ");
        uint arraySize = Input();
        int[] array = Input(arraySize);
        Console.Clear();

        //int[] array = { 1, 5, 2, 5, 3, 3, 7, 4, 6, 8, 5, 8, 4, 3, 3, 0, 8, 6, 8, 6, 9, 0, 7, 8, 6, 9, 5, 4, 7 };
        //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 10 };
        //int[] array = { 1, 2, 3, 6, 5, 4, 7, 8, 9, 10, 11, 12 };

        Console.Write("Input the first index for the area we're going to search for the max value in.\n" +
                      "(If you input more than {0} an error will occure) - ", (array.Length - 1));
        uint rangeStart = Input();
        Console.WriteLine();
        Console.Write("Input the second index for the area we're going to search for the max value in.\n" +
                      "(If you input more than {0} an error will occure) - ", (array.Length - 1));
        uint rangeEnd = Input();
        Console.WriteLine();

        if (rangeEnd < rangeStart)          //В случай, че се въведе първо втория индекс, а след това първия, те се разменят
        {
            rangeStart = rangeStart + rangeEnd;
            rangeEnd = rangeStart - rangeEnd;
            rangeStart = rangeStart - rangeEnd;
        }

        int maxElementInRange = FindMaxElementInRange(array, rangeStart, rangeEnd);

        Console.Write("The max value inbetween elements {0} and {1} is: ", rangeStart, rangeEnd);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(maxElementInRange);
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.WriteLine();
        Console.WriteLine("In what order would you like the array sorted?\nAscending = 1, Descending = 2");
        Console.Write("What do you choose? ");
        bool choise = ChoiseInput();

        SortArray(array, choise);
        Console.WriteLine();
        OutputSortedArray(array, choise);
        Console.WriteLine();
    }
}