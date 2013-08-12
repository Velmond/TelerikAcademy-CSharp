//07. * Write a program that finds the largest area of equal neighbor elements 
//in a rectangular matrix and print its size. Example:
//  1  !3!  2   2   2   4
// !3! !3! !3!  2   4   4
//  4  !3!  1   2  !3! !3!  ->  13
//  4  !3!  1  !3! !3!  1
//  4  !3! !3! !3!  1   1
//Hint: you can use the algorithm "Depth-first search" or "Breadth-first search" (find them in Wikipedia).

using System;

class FindTheLargestAreaOfEqualElements
{
    //Проверка 1:
    static int[,] matrix = {
                           { 1, 3, 2, 2, 2, 4 },
                           { 3, 3, 3, 2, 4, 4 },
                           { 4, 3, 1, 2, 3, 3 },
                           { 4, 3, 1, 3, 3, 1 },
                           { 4, 3, 3, 3, 1, 1 }, 
                           };
    //Проверка 2:
    //static int[,] matrix = { 
    //                       { 1, 2, 2, 2, 2, 4 },
    //                       { 2, 2, 2, 2, 4, 4 },
    //                       { 4, 3, 1, 2, 3, 3 },
    //                       { 4, 3, 1, 3, 3, 1 },
    //                       { 4, 3, 3, 3, 1, 1 },
    //                       };
    //Проверка 3:
    //static int[,] matrix = { 
    //                       { 1, 3, 2, 2, 2, 4 },
    //                       { 3, 3, 3, 2, 4, 4 },
    //                       { 4, 4, 4, 4, 4, 3 },
    //                       { 4, 3, 1, 3, 3, 1 },
    //                       { 4, 3, 3, 3, 1, 1 },
    //                       };
    //Проверка 4:
    //static int[,] matrix = {
    //                       { 1, 3, 2, 2, 2, 4 },
    //                       { 1, 1, 3, 2, 4, 4 },
    //                       { 4, 1, 1, 2, 3, 1 },
    //                       { 4, 3, 1, 1, 1, 1 },
    //                       { 4, 3, 3, 3, 1, 1 }, 
    //                       };

    static bool[,] isChecked = new bool[matrix.GetLength(0), matrix.GetLength(1)];

    static bool InRangeDetect(int row, int col)
    {
        bool inRange = true;
        if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1)) //Проверява дали стойностите на row и col 
        {                                                                                   //не излизат извън обсега на масива
            inRange = false;
        }
        if (inRange && isChecked[row, col])         //В случай, че не сме извън обсега на масива, проверяваме дали 
        {                                           //дадената клетка не е била преброена вече
            inRange = false;
        }
        return inRange;
    }

    static int GetCount(int row, int col, int checkedElement)
    {
        int currCount = 0;
        if (InRangeDetect(row, col) == false)
        {
            return currCount;
        }
        else
        {
            if (matrix[row, col] == checkedElement)
            {
                currCount++;
                isChecked[row, col] = true;
                currCount += GetCount(row - 1, col, checkedElement);     //Рекурсия проверяваща съседните клетки на дадена клетка и
                currCount += GetCount(row, col - 1, checkedElement);     //съседните на тях и т.н., докато никъде в съседство не се
                currCount += GetCount(row, col + 1, checkedElement);     //намира конкретната стойност, за която се прави проверката.
                currCount += GetCount(row + 1, col, checkedElement);
            }
        }
        return currCount;
    }

    static void PrintResult(int[,] matrix, int mostRepeated)        //Отпечатване на резултата
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == mostRepeated)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("{0,3}", matrix[row, col]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int maxCount = 1;
        int mostRepeated = matrix[0, 0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int currCount = GetCount(i, j, matrix[i, j]);
                if (currCount > maxCount)
                {
                    maxCount = currCount;
                    mostRepeated = matrix[i, j];
                }
            }
        }
        PrintResult(matrix, mostRepeated);  //Оцветяването на елементите става само на база на това дали са равни на този, който се
                                            //явява в най-дългата верига, т.е. ще се оцветят и елементите, които не са от веригата,
                                            //но са равни на дадения елемент. Нямам време да измисля как да го оправя това.
        Console.Write("\nThe maximum number of repetitions of an element is: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(maxCount + "\n");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}