//01. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
//a) 1   5   9  13      b) 1   8   9  16    c) 7  11  14  16      d*) 1  12  11  10      
//   2   6  10  14         2   7  10  15       4   8  12  15          2  13  16   9
//   3   7  11  15         3   6  11  14       2   5   9  13          3  14  15   8
//   4   8  12  16         4   5  12  13       1   3   6  10          4   5   6   7

using System;

class PrintAnArrayACertainWay
{
    static void Main()
    {
        uint N;
        Console.Write("Please input the size of the matrix - ");
        bool errorDetect = uint.TryParse(Console.ReadLine(), out N);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out N);
        }
        Console.WriteLine("Please input witch way you would like the matrix arranged (a, b, c or d) - ");
        string arrangement = Console.ReadLine().ToLower();
        while (arrangement != "a" && arrangement != "b" && arrangement != "c" && arrangement != "d")
        {
            Console.Write("Incorect input! Try again (a, b, c or d) - ");
            arrangement = Console.ReadLine().ToLower();
        }

        int[,] array = new int[N, N];

        if (arrangement == "a")
        {
            int count = 1;
            for (int col = 0; col < array.GetLength(1); col++)
            {
                for (int row = 0; row < array.GetLength(0); row++)
                {
                    array[row, col] = count;
                    count++;
                }
            }
        }
        else if (arrangement == "b")
        {
            int count = 1;
            for (int col = 0; col < array.GetLength(1); col++)
            {
                for (int row = 0; row < array.GetLength(0); row++)
                {
                    if (col % 2 == 0)
                    {
                        array[row, col] = count;
                        count++;
                    }
                    else
                    {
                        array[N - row - 1, col] = count;
                        count++;
                    }
                }
            }
        }
        else if (arrangement == "c")
        {
            int row = (int)(N - 1);
            int col = 0;
            int jump = 0;
            for (int count = 1; count <= (N * N); count++)
            {
                if (row >= 0 && col < N)
                {
                    array[row, col] = count;
                    if ((row + 1) < N && (col + 1) < N)
                    {
                        row = row + 1;
                        col = col + 1;
                    }
                    else
                    {
                        jump++;
                        int temp = (int)(jump % N);
                        if (jump < N)
                        {
                            row = row - temp;
                            col = 0;
                        }
                        else
                        {
                            row = 0;
                            col = temp + 1;
                        }
                    }
                }
            }
        }
        else if (arrangement == "d")
        {
            string direction = "down";
            int col = 0;
            int row = 0;
            for (int count = 1; count <= (N * N); count++)
            {
                if (direction == "down" && (row >= N || array[row, col] != 0))
                {
                    row--;
                    col++;
                    direction = "right";
                }
                else if (direction == "right" && (col >= N || array[row, col] != 0))
                {
                    row--;
                    col--;
                    direction = "up";
                }
                else if (direction == "up" && (row < 0 || array[row, col] != 0))
                {
                    row++;
                    col--;
                    direction = "left";
                }
                else if (direction == "left" && (col < 0 || array[row, col] != 0))
                {
                    row++;
                    col++;
                    direction = "down";
                }
                array[row, col] = count;
                if (direction == "down")
                {
                    row++;
                }
                else if (direction == "right")
                {
                    col++;
                }
                else if (direction == "up")
                {
                    row--;
                }
                else if (direction == "left")
                {
                    col--;
                }
            }
        }

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                Console.Write("{0,4} ", array[row, col]);
            }
            Console.WriteLine();
        }
    }
}