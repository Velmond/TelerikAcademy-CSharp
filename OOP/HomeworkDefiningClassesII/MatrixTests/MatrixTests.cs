namespace MatrixTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Matrix;

    [TestClass]
    public class MatrixTests
    {
        // To run all the unit tests press [Ctrl+R, A] or go to [TEST -> Run -> All Tests]
        // If the results don't show up go to [TEST -> Windows -> Test Explorer]
        
        [TestMethod]
        public void ValidAssigningSetGetTest()
        {
            Matrix<int> matrix = new Matrix<int>(1, 2);
            matrix[0, 0] = 123;
            matrix[0, 1] = matrix[0, 0];

            Assert.AreEqual(123, matrix[0, 0]);
        }

        [TestMethod]
        public void InvalidAssigningGetTest()
        {
            Matrix<int> matrix = new Matrix<int>(1, 2);
            matrix[0, 0] = 123;

            try
            {
                matrix[0, 1] = matrix[0, 2];
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.AreEqual(e.Message, "Index is out of range.");
            }
        }

        [TestMethod]
        public void InvalidAssigningSetTest()
        {
            Matrix<int> matrix = new Matrix<int>(1, 2);
            matrix[0, 0] = 123;
            matrix[0, 1] = matrix[0, 0];

            try
            {
                matrix[0, 2] = matrix[0, 1];
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.AreEqual(e.Message, "Index is out of range.");
            }
        }

        [TestMethod]
        public void ValidAdditionTest()
        {
            Matrix<int> firstMatrix = new Matrix<int>(3, 5);
            firstMatrix[0, 0] = 1;
            firstMatrix[0, 1] = 3;
            firstMatrix[0, 2] = 4;
            firstMatrix[0, 3] = 6;
            firstMatrix[0, 4] = 2;
            firstMatrix[1, 0] = 2;
            firstMatrix[1, 1] = 2;
            firstMatrix[1, 2] = 5;
            firstMatrix[1, 3] = 5;
            firstMatrix[1, 4] = 3;
            firstMatrix[2, 0] = 3;
            firstMatrix[2, 1] = 1;
            firstMatrix[2, 2] = 6;
            firstMatrix[2, 3] = 4;
            firstMatrix[2, 4] = 4;

            Matrix<int> secondMatrix = new Matrix<int>(3, 5);
            secondMatrix[0, 0] = 9;
            secondMatrix[0, 1] = 7;
            secondMatrix[0, 2] = 6;
            secondMatrix[0, 3] = 4;
            secondMatrix[0, 4] = 8;
            secondMatrix[1, 0] = 8;
            secondMatrix[1, 1] = 8;
            secondMatrix[1, 2] = 5;
            secondMatrix[1, 3] = 5;
            secondMatrix[1, 4] = 7;
            secondMatrix[2, 0] = 7;
            secondMatrix[2, 1] = 9;
            secondMatrix[2, 2] = 4;
            secondMatrix[2, 3] = 6;
            secondMatrix[2, 4] = 6;

            Matrix<int> result = firstMatrix + secondMatrix;

            Matrix<int> expexted = new Matrix<int>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < expexted.Rows; row++)
            {
                for (int col = 0; col < expexted.Cols; col++)
                {
                    expexted[row, col] = 10;
                }
            }

            for (int row = 0; row < expexted.Rows; row++)
            {
                for (int col = 0; col < expexted.Cols; col++)
                {
                    Assert.AreEqual(result[row, col], expexted[row, col]);
                }
            }
        }

        [TestMethod]
        public void InvalidAdditionTest()
        {
            Matrix<int> firstMatrix = new Matrix<int>(3, 5);
            Matrix<int> secondMatrix = new Matrix<int>(3, 4);

            try
            {
                Matrix<int> result = firstMatrix + secondMatrix;
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual(e.Message, "Matrices must be of same sizes to sum them.");
            }
        }

        [TestMethod]
        public void ValidSubtractionTest()
        {
            Matrix<int> firstMatrix = new Matrix<int>(3, 5);
            firstMatrix[0, 0] = 9;
            firstMatrix[0, 1] = 7;
            firstMatrix[0, 2] = 6;
            firstMatrix[0, 3] = 4;
            firstMatrix[0, 4] = 8;
            firstMatrix[1, 0] = 8;
            firstMatrix[1, 1] = 8;
            firstMatrix[1, 2] = 5;
            firstMatrix[1, 3] = 5;
            firstMatrix[1, 4] = 7;
            firstMatrix[2, 0] = 7;
            firstMatrix[2, 1] = 9;
            firstMatrix[2, 2] = 4;
            firstMatrix[2, 3] = 6;
            firstMatrix[2, 4] = 6;

            Matrix<int> secondMatrix = new Matrix<int>(3, 5);
            secondMatrix[0, 0] = 9;
            secondMatrix[0, 1] = 7;
            secondMatrix[0, 2] = 6;
            secondMatrix[0, 3] = 4;
            secondMatrix[0, 4] = 8;
            secondMatrix[1, 0] = 8;
            secondMatrix[1, 1] = 8;
            secondMatrix[1, 2] = 5;
            secondMatrix[1, 3] = 5;
            secondMatrix[1, 4] = 7;
            secondMatrix[2, 0] = 7;
            secondMatrix[2, 1] = 9;
            secondMatrix[2, 2] = 4;
            secondMatrix[2, 3] = 6;
            secondMatrix[2, 4] = 6;

            Matrix<int> result = firstMatrix - secondMatrix;

            Matrix<int> expexted = new Matrix<int>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < expexted.Rows; row++)
            {
                for (int col = 0; col < expexted.Cols; col++)
                {
                    expexted[row, col] = 0;
                }
            }

            for (int row = 0; row < expexted.Rows; row++)
            {
                for (int col = 0; col < expexted.Cols; col++)
                {
                    Assert.AreEqual(result[row, col], expexted[row, col]);
                }
            }
        }

        [TestMethod]
        public void InvalidSubtractionTest()
        {
            Matrix<int> firstMatrix = new Matrix<int>(3, 5);
            Matrix<int> secondMatrix = new Matrix<int>(3, 4);

            try
            {
                Matrix<int> result = firstMatrix - secondMatrix;
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual(e.Message, "Matrices must be of same sizes to subtract them.");
            }
        }

        [TestMethod]
        public void ValidMultiplicationTest()
        {
            Matrix<int> firstMatrix = new Matrix<int>(2, 3);
            firstMatrix[0, 0] = 1;
            firstMatrix[0, 1] = 2;
            firstMatrix[0, 2] = 3;
            firstMatrix[1, 0] = 3;
            firstMatrix[1, 1] = 2;
            firstMatrix[1, 2] = 1;

            Matrix<int> secondMatrix = new Matrix<int>(3, 5);
            secondMatrix[0, 0] = 1;
            secondMatrix[0, 1] = 3;
            secondMatrix[0, 2] = 4;
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

            Matrix<int> result = firstMatrix * secondMatrix;

            Matrix<int> expexted = new Matrix<int>(firstMatrix.Rows, secondMatrix.Cols);
            expexted[0, 0] = 14;
            expexted[0, 1] = 10;
            expexted[0, 2] = 32;
            expexted[0, 3] = 28;
            expexted[0, 4] = 20;
            expexted[1, 0] = 10;
            expexted[1, 1] = 14;
            expexted[1, 2] = 28;
            expexted[1, 3] = 32;
            expexted[1, 4] = 16;

            for (int row = 0; row < expexted.Rows; row++)
            {
                for (int col = 0; col < expexted.Cols; col++)
                {
                    Assert.AreEqual(result[row, col], expexted[row, col]);
                }
            }
        }

        [TestMethod]
        public void InvalidMultiplicationTest()
        {
            Matrix<int> firstMatrix = new Matrix<int>(3, 5);
            Matrix<int> secondMatrix = new Matrix<int>(3, 5);

            try
            {
                Matrix<int> result = firstMatrix * secondMatrix;
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual(e.Message, "The number of columns in the first matrix must equal the number of rows in the second to multiply them.");
            }
        }
    }
}