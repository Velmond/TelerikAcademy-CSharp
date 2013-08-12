//06. * Write a class Matrix, to holds a matrix of integers. Overload the operators for adding,
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;

class Matrix
{
    private int[,] matrix;

    public Matrix(int rows, int cols)           //За инициализиране на матрица
    {
        this.matrix = new int[rows, cols];
    }

    public int Rows                             //Дава броя на редове в матрицата
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    public int Columns                          //Дава броя на колони в матрицата
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public int this[int row, int col]           //Задаване и извличане на стойността на даден елемент от дадена матрица
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    public static Matrix operator +(Matrix first, Matrix second)   //Събиране на матрици
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] + second[row, col];
            }
        }
        return result;
    }

    public static Matrix operator -(Matrix first, Matrix second)   //Изваждане на матрици
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] - second[row, col];
            }
        }
        return result;
    }

    public static Matrix operator *(Matrix first, Matrix second)   //Умножение на матрици
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                for (int specIndex = 0; specIndex < first.Columns; specIndex++)
                {
                    result[row, col] += first[row, specIndex] * second[specIndex, col];
                }
            }
        }
        return result;
    }

    public override string ToString()           //Отпечатване на дадена матрица
    {
        string result = null;
        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.matrix.GetLength(1); col++)
            {
                result += Convert.ToString(matrix[row, col]).PadLeft(5, ' ');
            }
            result += Environment.NewLine;
        }
        return result;
    }
}

class WriteClassMatrixAndOverloadOperators
{
    static void Main()
    {
        //Идеята за генериране на матрици с произволни елементи взаимствах от jasssonpet,
        //което ми спести доста време от въвеждане на тестове, за което му дължа едно голямо "благодаря" :)
        Random randomNumber = new Random();
        int n = randomNumber.Next(2, 10);                       //Генерирам произволно число между 2 и 10 за размер на матриците
        Matrix firstMatrix = new Matrix(n, n);
        Matrix secondMatrix = new Matrix(n, n);
        for (int row = 0; row < firstMatrix.Rows; row++)        //Генерирам произволни числа между -10 и 10 за елементи на двете матрици
        {
            for (int col = 0; col < firstMatrix.Columns; col++)
            {
                firstMatrix[row, col] = randomNumber.Next(-10, 10);
                secondMatrix[row, col] = randomNumber.Next(-10, 10);
            }
        }

        Matrix sumResult = firstMatrix + secondMatrix;
        Matrix subtractionResult = firstMatrix - secondMatrix;
        Matrix multiplicationResult = firstMatrix * secondMatrix;

        Console.WriteLine("The first matrix' elements are:");   //Отпечатване на генерираните матрици и на резултатите
        Console.WriteLine(firstMatrix.ToString());
        Console.WriteLine("The second matrix' elements are:");
        Console.WriteLine(secondMatrix.ToString());
        Console.WriteLine("The sum of the two matrices is:");
        Console.WriteLine(sumResult.ToString());
        Console.WriteLine("The result of subtracting the second matrix from the first is:");
        Console.WriteLine(subtractionResult.ToString());
        Console.WriteLine("The result of multilpying the two matrices is:");
        Console.WriteLine(multiplicationResult.ToString());
    }
}