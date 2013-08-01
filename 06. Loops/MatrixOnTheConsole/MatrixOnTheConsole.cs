//Задача 12
//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix. (виж презентацията)

using System;

class MatrixOnTheConsole
{
    static void Main()
    {
        byte numberN;
        Console.Write("Input an integer number (N < 20) - ");
        bool inputError = byte.TryParse(Console.ReadLine(), out numberN);
        while (!inputError || numberN >= 20)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = byte.TryParse(Console.ReadLine(), out numberN);
        }
        for (int i = 1; i <= numberN; i++)
        {
            for (int j = i; j <= (i + numberN); j++)
            {
                if (j < i + numberN)
                {
                    Console.Write("{0}", Convert.ToString(j).PadLeft(3, ' '));
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
