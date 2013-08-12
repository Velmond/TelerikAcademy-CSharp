//02. Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
//that has maximal sum of its elements.

using System;

class MaxSumOf3By3SquareInAMatrix
{
    static void Main()
    {
        uint N, M;
        Console.Write("Please input the size N of the matrix (rows) - ");
        bool errorDetect = uint.TryParse(Console.ReadLine(), out N);
        while (!errorDetect || N < 3)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out N);
        }
        Console.Write("Please input the size M of the matrix (columns) - ");
        errorDetect = uint.TryParse(Console.ReadLine(), out M);
        while (!errorDetect || M < 3)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out M);
        }
        int[,] matrix = new int[N, M];
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write("Please input the element [ {0}, {1} ] of the matrix - ", row, col);
                errorDetect = int.TryParse(Console.ReadLine(), out matrix[row, col]);
                while (!errorDetect)
                {
                    Console.Write("Incorect input! Try again - ");
                    errorDetect = int.TryParse(Console.ReadLine(), out matrix[row, col]);
                }
            }
        }

        //За проверка може да се закоментира кода за въвеждане през конзолата и да се разкоментират следващите редове:
        //int[,] matrix = {
        //                    {0, 1, -5, 2, -3, 5},
        //                    {5, -3, 1, 8, 5, -4},
        //                    {4, 2, -8, 0, 2, -1},
        //                    {-1, 0, 5, 4, -1, 2},
        //                };
        //uint N = 4;
        //uint M = 6;

        int maxSum = int.MinValue;
        uint maxColIndex = 0;
        uint maxRowIndex = 0;

        for (uint row = 0; row <= N - 3; row++)
        {
            for (uint col = 0; col <= M - 3; col++)
            {
                int currSum = 0;
                for (uint subsetRow = row; subsetRow < (row + 3); subsetRow++)
                {
                    for (uint subsetCol = col; subsetCol < (col + 3); subsetCol++)
                    {
                        currSum += matrix[subsetRow, subsetCol];
                    }
                }
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    maxColIndex = col;
                    maxRowIndex = row;
                }
            }
        }

        for (uint row = 0; row < N; row++)
        {
            for (uint col = 0; col < M; col++)
            {
                if (row >= maxRowIndex && row < (maxRowIndex + 3) && col >= maxColIndex && col < (maxColIndex + 3))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("{0,4}", matrix[row, col]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("{0,4}", matrix[row, col]);
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("The submatrix with the maximum sum is: ");
        for (uint row = maxRowIndex; row < maxRowIndex + 3; row++)
        {
            for (uint col = maxColIndex; col < maxColIndex + 3; col++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine();
        Console.Write("The maximum sum of a 3x3 submatrix is: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(maxSum);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine();
    }
}