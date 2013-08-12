//06. You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. 
//Example: string = "43 68 9 23 318" -> result = 461

using System;

class SumOfNumbersInAString
{
    static int[] Input()
    {
        Console.WriteLine("Input the numbers separated by just a space: ");
        Console.ForegroundColor = ConsoleColor.Yellow;      //Directly turns the input to an array of the values that were separated
        string[] inputNumbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);  //...by space
        Console.ForegroundColor = ConsoleColor.Gray;

        int[] numbersToSum = new int[inputNumbers.Length];  //The values are then parsed into an array of integers

        for (int i = 0; i < inputNumbers.Length; i++)
            numbersToSum[i] = int.Parse(inputNumbers[i]);

        return numbersToSum;
    }

    static int Sum(int[] numbersToSum)
    {
        int sum = 0;
        for (int i = 0; i < numbersToSum.Length; i++)       //The elements are sumed one by one
            sum += numbersToSum[i];

        return sum;
    }

    static void Main()
    {
        int[] inputNumbers = Input();
        int sum = Sum(inputNumbers);

        Console.Write("\nThe sum of the numbers is: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("{0}\n", sum);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}