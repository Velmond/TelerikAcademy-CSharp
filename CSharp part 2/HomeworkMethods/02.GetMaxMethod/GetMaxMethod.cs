//02.01. Write a method GetMax() with two parameters that returns the bigger of two integers.
//02.02. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

public class GetMaxMethod
{
    public static int GetMax(int firstValue, int secondValue)
    {
        if (firstValue < secondValue)           //Ако второто число е по-голямо, метода връща неговата стойност
            return secondValue;
        else
            return firstValue;                  //В противен случай, връща тази на първото число
    }

    static void Main()
    {
        int firstValue, secondValue;
        Console.Write("Input the first value for comparing - ");
        bool errorDetect = int.TryParse(Console.ReadLine(), out firstValue);
        while (!errorDetect)
        {
            Console.Write("Incorrect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out firstValue);
        }
        Console.Write("Input the second value for comparing - ");
        errorDetect = int.TryParse(Console.ReadLine(), out secondValue);
        while (!errorDetect)
        {
            Console.Write("Incorrect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out secondValue);
        }

        Console.WriteLine("The bigger of {0} and {1} is: {2}", firstValue, secondValue, GetMax(firstValue, secondValue));
    }
}