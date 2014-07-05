namespace RotatingWalkInMatrix
{
    using System;
    using System.Text;

    public class RotatingWalkInMatrix
    {
        private static int cellValue;
        private readonly static int[] directionX = new int[] { 1, 1, 1, 0, -1, -1, -1, 0 };
        private readonly static int[] directionY = new int[] { 1, 0, -1, -1, -1, 0, 1, 1 };

        public static void Main()
        {
            string input = Console.ReadLine();
            int size = 0;
            bool isValidInput = int.TryParse(input, out size);

            if (isValidInput)
            {
                int[,] matrix = GenerateMatrix(size);
                string matrixToString = GetMatrixAsString(matrix);
                Console.WriteLine(matrixToString);
            }
            else
            {
                throw new ArgumentException("Valid Range is [1..100].");
            }
        }

        public static string GetMatrixAsString(int[,] matrix)
        {
            StringBuilder toString = new StringBuilder();
            int matrixSize = matrix.GetLength(0);
            int maxDigitLength = (matrixSize * matrixSize).ToString().Length;

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    int currentDigitLength = matrix[row, col].ToString().Length;
                    int spacesToAppend = maxDigitLength - currentDigitLength;

                    if (col != 0)
                    {
                        spacesToAppend += 2;
                    }

                    toString.AppendFormat("{0}{1}", new string(' ', spacesToAppend), matrix[row, col]);
                }

                if (row != matrixSize - 1)
                {
                    toString.Append(Environment.NewLine);
                }
            }

            return toString.ToString();
        }

        public static int[,] GenerateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;

            cellValue = 1;
            // If I don't set it here all the unit tests break other than the first one that gets executed,
            // because each starts with the last cellValue of the last one + 1

            FillMatrix(matrix, ref row, ref col);

            if (n > 4)
            {
                // -- n <= 4 -> when moving there is always an empty neighbouring cell:
                //  1 10 11 12
                //  9  2 15 13
                //  8 16  3 14
                //  7  6  5  4
                // -- n = 5 -> we have to look for a way from one half of the square to the other
                //  1 13 14 15 16
                // 12  2 21 22 17
                // 11 23  3 20 18
                // 10 25 24  4 19
                //  9  8  7  6  5
                // So the first 4 need to be tested separately. So does 100 (the last possibe n) and some inbetween number.

                FindFreeCell(matrix, out row, out col);
                FillMatrix(matrix, ref row, ref col);
            }

            return matrix;
        }

        private static void FillMatrix(int[,] matrix, ref int row, ref int col)
        {
            int currentDirectionX = directionX[0];
            int currentDirectionY = directionY[0];

            while (true)
            {
                matrix[row, col] = cellValue;
                cellValue++;

                if (!HasWhereToGo(matrix, row, col))
                {
                    return;
                }

                int newRow = row + currentDirectionX;
                int newCol = col + currentDirectionY;

                while ((newRow < 0 || newRow >= matrix.GetLength(0)) ||
                    (newCol < 0 || newCol >= matrix.GetLength(0)) ||
                    matrix[newRow, newCol] != 0)
                {
                    ChangeDirection(ref currentDirectionX, ref currentDirectionY);
                    newRow = row + currentDirectionX;
                    newCol = col + currentDirectionY;
                }

                row += currentDirectionX;
                col += currentDirectionY;
            }
        }

        private static void ChangeDirection(ref int currentDirectionX, ref int currentDirectionY)
        {
            int currentDirectionIndex = 0;

            for (int i = 0, len = directionX.Length; i < len; i++)
            {
                if (directionX[i] == currentDirectionX && directionY[i] == currentDirectionY)
                {
                    currentDirectionIndex = i;
                    break;
                }
            }

            int newDirectionIndex = currentDirectionIndex + 1;

            if (newDirectionIndex >= directionX.Length)
            {
                newDirectionIndex %= directionX.Length;
            }

            currentDirectionX = directionX[newDirectionIndex];
            currentDirectionY = directionY[newDirectionIndex];
        }

        private static bool HasWhereToGo(int[,] arr, int row, int col)
        {
            for (int i = 0; i < directionX.Length; i++)
            {
                int nextRow = row + directionX[i];
                int nextCol = col + directionY[i];

                if (nextRow < 0 || arr.GetLength(0) <= nextRow)
                {
                    nextRow -= directionX[i];
                }

                if (nextCol < 0 || arr.GetLength(0) <= nextCol)
                {
                    nextCol -= directionY[i];
                }

                if (arr[nextRow, nextCol] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void FindFreeCell(int[,] matrix, out int emptyCellX, out int emptyCellY)
        {
            int matrixSize = matrix.GetLength(0);
            emptyCellX = 0;
            emptyCellY = 0;

            for (int row = 0; row < matrixSize; row++)
            {
                emptyCellX = row;

                for (int col = 0; col < matrixSize; col++)
                {
                    emptyCellY = col;

                    if (matrix[emptyCellX, emptyCellY] == 0)
                    {
                        return;
                    }
                }
            }
        }
    }
}
