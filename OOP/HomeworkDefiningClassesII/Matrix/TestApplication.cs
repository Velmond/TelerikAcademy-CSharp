namespace Matrix
{
    using System;
    using System.Text;

    public class TestApplication
    {
        static void Main()
        {
            // In this Main() I've tested some of the methods and properties, but there are far better tests in the 
            // ... Unit Test Project 08-10.02.MatrixTests so I won't explain in detail what is done here (it's pretty
            // ... self explanatory anyway)

            Matrix<int> matrix = new Matrix<int>(2, 3); // New matrix: 2 rows, 3 columns
            matrix[0, 0] = 1;       // Elements:
            matrix[0, 1] = 2;       // 1 2 3
            matrix[0, 2] = 3;       // 3 2 1
            matrix[1, 0] = 3;
            matrix[1, 1] = 2;
            matrix[1, 2] = 1;

            Console.Write("Number of columns: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(matrix.Cols); // Prints the number of columns
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Number of rows: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(matrix.Rows); // Prints the number of rows
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Matrix elements: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintMatrix(matrix);    // Uses the PrintMatrix() method to print the matrix on the console
            Console.ForegroundColor = ConsoleColor.Gray;

            Matrix<int> secondMatrix = new Matrix<int>(3, 5);
            secondMatrix[0, 0] = 1;     // 1 3 4 6 2
            secondMatrix[0, 1] = 3;     // 2 2 5 5 3
            secondMatrix[0, 2] = 4;     // 3 1 6 4 4
            secondMatrix[0, 3] = 6;
            secondMatrix[0, 4] = 2;
            secondMatrix[1, 0] = 2;
            secondMatrix[1, 1] = 2;
            secondMatrix[1, 2] = 5;
            secondMatrix[1, 3] = 5;
            secondMatrix[1, 4] = 3;
            secondMatrix[2, 0] = 3;
            secondMatrix[2, 1] = 1;
            secondMatrix[2, 2] = 6;
            secondMatrix[2, 3] = 4;
            secondMatrix[2, 4] = 4;

            Console.WriteLine("Second matrix: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintMatrix(secondMatrix);
            Console.ForegroundColor = ConsoleColor.Gray;

            Matrix<int> resultMultiply = matrix * secondMatrix;

            Console.WriteLine("Multiplication Result: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintMatrix(resultMultiply);
            Console.ForegroundColor = ConsoleColor.Gray;

            Matrix<int> thirdMatrix = new Matrix<int>(3, 5);
            thirdMatrix[0, 0] = 9;      // 9 7 6 4 8
            thirdMatrix[0, 1] = 7;      // 8 8 5 5 7
            thirdMatrix[0, 2] = 6;      // 7 9 4 6 6
            thirdMatrix[0, 3] = 4;
            thirdMatrix[0, 4] = 8;
            thirdMatrix[1, 0] = 8;
            thirdMatrix[1, 1] = 8;
            thirdMatrix[1, 2] = 5;
            thirdMatrix[1, 3] = 5;
            thirdMatrix[1, 4] = 7;
            thirdMatrix[2, 0] = 7;
            thirdMatrix[2, 1] = 9;
            thirdMatrix[2, 2] = 4;
            thirdMatrix[2, 3] = 6;
            thirdMatrix[2, 4] = 6;

            Console.WriteLine("Third matrix: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintMatrix(thirdMatrix);
            Console.ForegroundColor = ConsoleColor.Gray;

            Matrix<int> resultAdding = secondMatrix + thirdMatrix;

            Console.WriteLine("Addition result (second + third): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintMatrix(resultAdding);
            Console.ForegroundColor = ConsoleColor.Gray;

            Matrix<int> forthMatrix = new Matrix<int>(3, 5);
            forthMatrix[0, 0] = 9;      // 9 7 6 4 8
            forthMatrix[0, 1] = 7;      // 8 8 5 5 7
            forthMatrix[0, 2] = 6;      // 7 9 4 6 6
            forthMatrix[0, 3] = 4;
            forthMatrix[0, 4] = 8;
            forthMatrix[1, 0] = 8;
            forthMatrix[1, 1] = 8;
            forthMatrix[1, 2] = 5;
            forthMatrix[1, 3] = 5;
            forthMatrix[1, 4] = 7;
            forthMatrix[2, 0] = 7;
            forthMatrix[2, 1] = 9;
            forthMatrix[2, 2] = 4;
            forthMatrix[2, 3] = 6;
            forthMatrix[2, 4] = 6;

            Console.WriteLine("Forth matrix: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintMatrix(forthMatrix);
            Console.ForegroundColor = ConsoleColor.Gray;

            Matrix<int> resultSubtracting = thirdMatrix - forthMatrix;

            Console.WriteLine("Subtraction result (third - forth): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintMatrix(resultSubtracting);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void PrintMatrix(Matrix<int> matrix)
        {
            StringBuilder resutl = new StringBuilder();

            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    resutl.Append(matrix[row, col]);

                    if (col < matrix.Cols - 1)
                    {
                        resutl.Append(" ");
                    }
                }

                if (row < matrix.Rows - 1)
                {
                    resutl.Append(Environment.NewLine);
                }
            }

            Console.WriteLine(resutl.ToString());
        }
    }
}