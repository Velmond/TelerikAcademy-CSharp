//08. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
//09. Implement an indexer this[row, col] to access the inner matrix cells.
//10. Implement the operators + and - (addition and subtraction of matrices of the same size) 
//    and * for matrix multiplication. Throw an exception when the operation cannot be performed.
//    Implement the true operator (check for non-zero elements).

namespace Matrix
{
    using System;

    public class Matrix<T>
        where T : IComparable<T>
    {
        private int row;
        private int col;
        private T[,] matrix;

        // Property for getting the number of rows in the matrix
        public int Rows
        {
            get { return this.row; }
        }

        // Property for getting the number of columns in the matrix
        public int Cols
        {
            get { return this.col; }
        }

        // This class has only the following constructor as any other would make no sense whatsoever
        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.matrix = new T[row, col];
        }

        // Indexer this[row, col] to access the inner matrix cells.
        public T this[int row, int col]
        {
            get
            {
                if (col < 0 || col >= this.Cols || row < 0 || row >= this.Rows) // If the index is out of range throw an exception
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                else
                {
                    return matrix[row, col];
                }
            }
            set
            {
                if (col < 0 || col >= this.Cols || row < 0 || row >= this.Rows) // If the index is out of range throw an exception
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                else
                {
                    this.matrix[row, col] = value;
                }
            }
        }

        // Addition
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Cols || firstMatrix.Rows != secondMatrix.Rows)
            {
                throw new InvalidOperationException("Matrices must be of same sizes to sum them.");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] + (dynamic)secondMatrix[row, col];
                }
            }

            return result;
        }

        // Subtraction
        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Cols || firstMatrix.Rows != secondMatrix.Rows)
            {
                throw new InvalidOperationException("Matrices must be of same sizes to subtract them.");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] - (dynamic)secondMatrix[row, col];
                }
            }

            return result;
        }

        // Multiplication
        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new InvalidOperationException("The number of columns in the first matrix must equal the number of rows in the second to multiply them.");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = (dynamic)0;

                    for (int elementToMultiply = 0; elementToMultiply < secondMatrix.Rows; elementToMultiply++)
                    {
                        result[row, col] += (dynamic)firstMatrix[row, elementToMultiply] * (dynamic)secondMatrix[elementToMultiply, col];
                    }
                }
            }

            return result;
        }

        // Wasn't really sure what 'true' is supposed to mean so I made it so if there is a single element that is different
        // ... than 0 we get true. Otherwise we get false.
        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (!matrix[row, col].Equals(0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (!matrix[row, col].Equals(0))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}