//Задача 14
//Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N 
//numbers arranged as a spiral. (виж презентацията)

using System;

class NNumbersArrangedAsASpiral
{
    static void Main()
    {
        byte size;
        Console.Write("Input an integer number (N < 20) - ");
        bool inputError = byte.TryParse(Console.ReadLine(), out size);
        while (!inputError || size <= 0 || size >= 20)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = byte.TryParse(Console.ReadLine(), out size);
        }

        int[,] matrix = new int[size, size];
        int counter = 1;
        int indexCol = 0;
        int indexRow = 1;
        while (counter <= size * size)
        {
            for (int col = indexCol; col < size - indexCol; col++)
            {
                matrix[indexRow - 1, col] = counter;
                counter++;
            }
            for (int row = indexRow; row < size - indexRow; row++)
            {
                matrix[row, size - indexCol - 1] = counter;
                counter++;
            }
            for (int col = size - indexCol - 1; col > indexCol; col--)
            {
                matrix[size - indexRow, col] = counter;
                counter++;
            }
            for (int row = size - indexRow; row > indexRow - 1; row--)
            {
                matrix[row, indexCol] = counter;
                counter++;
            }
            indexCol++;
            indexRow++;
        }

        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                Console.Write("{0,4}", matrix[col, row]);
            }
            Console.WriteLine();
        }
    }
}