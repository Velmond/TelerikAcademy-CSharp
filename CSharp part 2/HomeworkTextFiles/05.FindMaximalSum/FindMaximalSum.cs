//05. Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an 
//    area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size 
//    of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single 
//    number in a separate text file. 
//    Example:  4
//              2 3 3 4
//              0 2 3 4     ->     17
//              3 7 1 2
//              4 3 3 2

namespace FindMaximalSum
{
    using System;
    using System.IO;

    class FindMaximalSum
    {
        static int[,] InputMatrix(StreamReader inputFile)
        {
            int matrixSize;     //Keeps the size of the square matrix (from the first line in the file)
            int[,] matrix;      //Keeps all the members of the matrix

            using (inputFile)
            {
                matrixSize = int.Parse(inputFile.ReadLine());
                matrix = new int[matrixSize, matrixSize];

                for (int row = 0; row < matrixSize; row++)              //Fills the matrix by reading the content line by line
                {
                    string[] array = inputFile.ReadLine().Split(' ');   //...and splitting the numbers by the spaces between them

                    for (int col = 0; col < matrixSize; col++)
                        matrix[row, col] = int.Parse(array[col]);
                }
            }

            return matrix;
        }

        static int FindMaxSum(int[,] matrix, int padSize)   //We had to solve this problem in a previous homework so I won't go 
        {                                                   //...into detail by explaining it again
            int maxSum = int.MinValue;

            for (int row = 0; row < ((matrix.GetLength(0) - 1) - padSize); row++)
                for (int col = 0; col < ((matrix.GetLength(1) - 1) - padSize); col++)
                {
                    int currSum = 0;

                    for (int padRow = row; padRow < (row + padSize); padRow++)
                        for (int padCol = col; padCol < (col + padSize); padCol++)
                            currSum += matrix[padRow, padCol];

                    if (maxSum < currSum)
                        maxSum = currSum;
                }

            return maxSum;
        }

        static void Main()
        {
            string inputPath = @"..\..\Input.txt";

            int[,] matrix = InputMatrix(new StreamReader(inputPath));

            int maxSum = FindMaxSum(matrix, 2); //The program should work for however big submatrix you want. You just need to
                                                //...put as the size as the second parameter here (where the "2" is)
            using (StreamWriter output = new StreamWriter(@"..\..\Output.txt"))
                output.WriteLine(maxSum);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Done!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}