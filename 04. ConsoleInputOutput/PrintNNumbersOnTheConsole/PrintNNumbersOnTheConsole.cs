//Задача №8
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n],
//each on a single line.

using System;

class PrintNNumbersOnTheConsole
{
    static void Main()
    {
        int numberOfNumbers;
        Console.Write("Input number of numbers: ");
        bool error = int.TryParse(Console.ReadLine(), out numberOfNumbers);
        while (error==false)
        {
            Console.Write("Invalid input! Try again: ");
            error = int.TryParse(Console.ReadLine(), out numberOfNumbers);
        }
        Console.Clear();
        for (int i = 1; i <= numberOfNumbers; i++)
        {
            Console.WriteLine(i);
        }
    }
}