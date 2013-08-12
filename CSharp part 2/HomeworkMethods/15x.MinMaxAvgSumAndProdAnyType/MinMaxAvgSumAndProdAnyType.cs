//15. *Modify your last program and try to make it work for any number type, not just integer
//(e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).

using System;

class MinMaxAvgSumAndProdAnyType
{
    static T FindMaxValue<T>(params T[] array)    //Чрез "Т" се показва, че ще работим с тип данни, който ще стане известен едва
    {                                           //когато се въвеждат стойностите при изпълнение на програмата (за примера е decimal)
        dynamic maxNumber = array[0];             //а чрез param, че ще работим с брой на применливите, който също ще стане известен 
        for (int i = 0; i < array.Length; i++)    //при въвеждането им
            if (array[i] > maxNumber)
                maxNumber = array[i];

        return maxNumber;
    }

    static T FindMinValue<T>(params T[] array)
    {
        dynamic minNumber = array[0];
        for (int i = 0; i < array.Length; i++)
            if (array[i] < minNumber)
                minNumber = array[i];

        return minNumber;
    }

    static T FindAvg<T>(params T[] array)
    {
        int counter = 0;
        dynamic sum = 0;
        dynamic average = 0;
        foreach (var number in array)
        {
            sum += number;
            counter++;
        }
        average = sum / counter;

        return average;
    }

    static T FindSum<T>(params T[] array)
    {
        dynamic sum = 0;
        foreach (var number in array)
            sum += number;

        return sum;
    }

    static T FindProduct<T>(params T[] array)
    {
        dynamic product = 1;
        foreach (var number in array)
            product *= number;

        return product;
    }

    static void Main()
    {
        Console.Write("Min value:\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(FindMinValue(-1, 2, -3, 4, -5, 6, -7, 8, -9, 10m));   //Тъй като 10 е зададено като тип decimal, това ще е
        Console.ForegroundColor = ConsoleColor.Gray;                            //типа данни, с който ще работи програмата

        Console.Write("Max value:\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(FindMaxValue(-1, 2, -3, 4, -5, 6, -7, 8, -9, 10m));
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write("Average value:\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(FindAvg(-1, 2, -3, 4, -5, 6, -7, 8, -9, 10m));
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write("Sum:\t\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(FindSum(-1, 2, -3, 4, -5, 6, -7, 8, -9, 10m));
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write("Product:\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(FindProduct(-1, 2, -3, 4, -5, 6, -7, 8, -9, 10m));
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}