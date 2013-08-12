//03. We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
//neighbor elements located on the same line, column or diagonal. Write a program that finds the longest 
//sequence of equal strings in the matrix. Example:
//   ha fifi   ho   hi                      s   qq  s
//   fo   ha   hi   xx  -> ha, ha, ha      pp   pp  s   -> s, s, s
//  xxx   ho   ha   xx                     pp   qq  s

using System;

class LongestSequenceOfEqualElements
{
    static void Main()
    {
        uint N, M;
        Console.Write("Please input the size N of the matrix (rows) - ");
        bool errorDetect = uint.TryParse(Console.ReadLine(), out N);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out N);
        }
        Console.Write("Please input the size M of the matrix (columns) - ");
        errorDetect = uint.TryParse(Console.ReadLine(), out M);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out M);
        }
        string[,] matrix = new string[N, M];
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write("Please input the element [ {0}, {1} ] of the matrix - ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        //За проверка може да се закоментира кода за въвеждане през конзолата и да се разкоментират следващите редове:
        //ПРОВЕРКА 1:
        //string[,] matrix = {
        //                    {"ha", "fifi", "ho", "hi"},
        //                    {"fo", "ha", "hi", "xx"},
        //                    {"xxx", "ho", "ha", "xx"},
        //                };

        //ПРОВЕРКА 2:
        //string[,] matrix = {
        //                    {"s", "qq", "s"},
        //                    {"pp", "pp", "s"},
        //                    {"pp", "qq", "s"},
        //                };

        Console.Clear();
        int currSeqence = 1;
        int maxSeqence = currSeqence;
        string mostRepeated = matrix[0, 0];

        for (int row = 0; row < matrix.GetLength(0); row++)         //Проверка за максимална последователност
        {                                                           //в хоризонтално направление
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currSeqence++;
                }
                else
                {
                    currSeqence = 1;
                }
                if (maxSeqence < currSeqence)
                {
                    maxSeqence = currSeqence;
                    mostRepeated = matrix[row, col];
                }
            }
            currSeqence = 1;
        }

        for (int col = 0; col < matrix.GetLength(1); col++)         //Проверка за максимална последователност
        {                                                           //във вертикално направление
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currSeqence++;
                }
                else
                {
                    currSeqence = 1;
                }
                if (maxSeqence < currSeqence)
                {
                    maxSeqence = currSeqence;
                    mostRepeated = matrix[row, col];
                }
            }
            currSeqence = 1;
        }

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)           //Проверка за максимална последователност
        {                                                           //в диагонално направление ляво->дясно (горе->долу)
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int row = i, col = j; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        currSeqence++;
                    }
                    else
                    {
                        currSeqence = 1;
                    }
                    if (maxSeqence < currSeqence)
                    {
                        maxSeqence = currSeqence;
                        mostRepeated = matrix[row, col];
                    }
                }
                currSeqence = 1;
            }
        }

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)           //Проверка за максимална последователност
        {                                                           //в диагонално направление дясно->ляво (горе->долу)
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                for (int row = i, col = j; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        currSeqence++;
                    }
                    else
                    {
                        currSeqence = 1;
                    }
                    if (maxSeqence < currSeqence)
                    {
                        maxSeqence = currSeqence;
                        mostRepeated = matrix[row, col];
                    }
                }
                currSeqence = 1;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)         //Отпечатване на матрицата и маркиране на всички
        {                                                           //елементи, равни на най-често повтарящия се
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == mostRepeated)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("{0,6} ", matrix[row, col]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.Write("{0,6} ", matrix[row, col]);
                }
            }
            Console.WriteLine();
        }

        if (maxSeqence > 1) //Изписване на резултата в случай, че е намерена последователност по-дълга от един елемент
        {
            Console.WriteLine("\nElement \"{0}\" appears {1} times in the longest sequence.\n", mostRepeated, maxSeqence);
        }
        else                //Изписване, че не съществува последователност в случай, че не е намерена такава
        {
            Console.WriteLine("\nNo element appears in a sequence.\n");
        }
    }
}