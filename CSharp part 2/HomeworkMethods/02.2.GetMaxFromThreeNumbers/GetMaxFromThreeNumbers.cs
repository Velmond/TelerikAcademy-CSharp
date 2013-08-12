//02.01. Write a method GetMax() with two parameters that returns the bigger of two integers.
//02.02. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class GetMaxFromThreeNumbers
{
    static void Main(string[] args)
    {
        int firstValue, secondValue, thirdValue;
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
        Console.Write("Input the third value for comparing - ");
        errorDetect = int.TryParse(Console.ReadLine(), out thirdValue);
        while (!errorDetect)
        {
            Console.Write("Incorrect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out thirdValue);
        }
        
        //Търся директно по-голямото от третото число и по-голямото от първото и второто
        int maxValue = GetMaxMethod.GetMax(GetMaxMethod.GetMax(firstValue, secondValue), thirdValue);

        Console.WriteLine("The bigger of {0},  {1} and {2} is: {3}", firstValue, secondValue, thirdValue, maxValue);
    }
}