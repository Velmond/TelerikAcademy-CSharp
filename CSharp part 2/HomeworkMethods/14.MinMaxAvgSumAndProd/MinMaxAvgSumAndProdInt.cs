//14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;

class MinMaxAvgSumAndProdInt
{
    static int FindMaxValue(params int[] array) 
    {
        int maxNumber = array[0];
        for (int i = 0; i < array.Length; i++)
            if (array[i] > maxNumber)
                maxNumber = array[i];

        return maxNumber;
    }

    static int FindMinValue(params int[] array)
    {
        int minNumber = array[0];
        for (int i = 0; i < array.Length; i++)
            if (array[i] < minNumber)
                minNumber = array[i];

        return minNumber;
    }

    static decimal FindAvg(params int[] array)
    {
        int counter = 0;
        int sum = 0;
        decimal average = 0;
        foreach (var number in array)
        {
            sum += number;
            counter++;
        }
        average = (decimal)sum / counter;

        return average;
    }

    static int FindSum(params int[] array)
    {
        int sum = 0;
        foreach (var number in array)
            sum += number;

        return sum;
    }
    static int FindProduct(params int[] array)
    {
        int product = 1;
        foreach (var number in array)
            product *= number;

        return product;
    }
    static void Main()
    {
        Console.Write("Min value:\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(FindMinValue(-1, 2, -3, 4, -5, 6, -7, 8, -9, 10));
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write("Max value:\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(FindMaxValue(-1, 2, -3, 4, -5, 6, -7, 8, -9, 10));
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write("Average value:\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(FindAvg(-1, 2, -3, 4, -5, 6, -7, 8, -9, 10));
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write("Sum:\t\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(FindSum(-1, 2, -3, 4, -5, 6, -7, 8, -9, 10));
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write("Product:\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(FindProduct(-1, 2, -3, 4, -5, 6, -7, 8, -9, 10));
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}