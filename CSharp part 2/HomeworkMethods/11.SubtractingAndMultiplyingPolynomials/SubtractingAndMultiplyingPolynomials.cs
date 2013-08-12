//12. Extend the program (from exercise 11) to support also subtraction and multiplication of Polynomials.

using System;

class SubtractingAndMultiplyingPolynomials
{
    static int[] InputPolynomialDegree()
    {
        uint input;
        Console.ForegroundColor = ConsoleColor.Yellow;
        bool errorCheck = uint.TryParse(Console.ReadLine(), out input);
        Console.ForegroundColor = ConsoleColor.Gray;
        while (!errorCheck)
        {
            Console.Write("Invalid input! Try again - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            errorCheck = uint.TryParse(Console.ReadLine(), out input);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        int[] Polynomial = new int[input + 1];

        return Polynomial;
    }

    static int InputPolynomialElement()
    {
        int input;
        Console.ForegroundColor = ConsoleColor.Yellow;
        bool errorCheck = int.TryParse(Console.ReadLine(), out input);
        Console.ForegroundColor = ConsoleColor.Gray;
        while (!errorCheck)
        {
            Console.Write("Invalid input! Try again - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            errorCheck = int.TryParse(Console.ReadLine(), out input);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        return input;
    }

    static int[] AddPolynomials(int[] firstPolynomial, int[] secondPolynomial)  //Като задача 11
    {
        uint resultSize = (uint)firstPolynomial.Length;
        if (firstPolynomial.Length < secondPolynomial.Length)
            resultSize = (uint)secondPolynomial.Length;

        int[] result = new int[resultSize];

        for (int i = 0; i < result.Length; i++)
        {
            if (i < firstPolynomial.Length && i < secondPolynomial.Length)
                result[i] = firstPolynomial[i] + secondPolynomial[i];
            else if (i >= firstPolynomial.Length)
                result[i] = secondPolynomial[i];
            else if (i >= secondPolynomial.Length)
                result[i] = firstPolynomial[i];
        }

        return result;
    }

    static int[] SubtractPolynomials(int[] firstPolynomial, int[] secondPolynomial) //Идентично на събирането, но елементите не се
    {                                                                               //сумират, а се вадят едни от друг
        uint resultSize = (uint)firstPolynomial.Length;
        if (firstPolynomial.Length < secondPolynomial.Length)
            resultSize = (uint)secondPolynomial.Length;

        int[] result = new int[resultSize];

        for (int i = 0; i < result.Length; i++)
        {
            if (i < firstPolynomial.Length && i < secondPolynomial.Length)
                result[i] = firstPolynomial[i] - secondPolynomial[i];
            else if (i >= firstPolynomial.Length)
                result[i] = -secondPolynomial[i];
            else if (i >= secondPolynomial.Length)
                result[i] = firstPolynomial[i];
        }

        return result;
    }

    static int[] MultiplyPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        uint resultSize = (uint)(firstPolynomial.Length + secondPolynomial.Length); //Защото х^3.х^2 = х^5

        int[] result = new int[resultSize];     //По начало елементите са равни на 0

        for (int i = 0; i < firstPolynomial.Length; i++)
            for (int j = 0; j < secondPolynomial.Length; j++)
                result[i + j] += (firstPolynomial[i] * secondPolynomial[j]);

        return result;
    }

    static void PrintPolynomial(int[] PolynomialCoef)
    {
        string Polynomial = "";
        for (int i = (PolynomialCoef.Length - 1); i >= 0; i--)
        {
            char sign = '+';
            if (PolynomialCoef[i] < 0)
                sign = '-';

            if (PolynomialCoef[i] != 0)
            {
                if (i != 0)
                    Polynomial += sign + " " + Math.Abs(PolynomialCoef[i]) + ".x^" + i + " ";
                else
                    Polynomial += sign + " " + Math.Abs(PolynomialCoef[i]);
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Polynomial);
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static void Main()
    {
        Console.Write("Input the degree of the first Polynomial (highest exponent of x): ");
        int[] firstPolynomial = InputPolynomialDegree();
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            Console.Write("Input the coefficient in front of x^{0}: ", (i));
            firstPolynomial[i] = InputPolynomialElement();
        }

        Console.Write("Input the degree of the second Polynomial (highest exponent of x): ");
        int[] secondPolynomial = InputPolynomialDegree();
        for (int i = 0; i < secondPolynomial.Length; i++)
        {
            Console.Write("Input the coefficient in front of x^{0}: ", (i));
            secondPolynomial[i] = InputPolynomialElement();
        }

        //int[] firstPolynomial = { 1, 2, 3, 4, };
        //int[] secondPolynomial = { -1, -2, -3, -4, -5, };

        Console.Clear();
        Console.WriteLine("The first polynomial is: ");
        PrintPolynomial(firstPolynomial);
        Console.WriteLine("The second polynomial is: ");
        PrintPolynomial(secondPolynomial);

        Console.WriteLine();
        int[] sum = AddPolynomials(firstPolynomial, secondPolynomial);
        Console.WriteLine("The result after adding the polynomials is: ");
        PrintPolynomial(sum);

        int[] diff = SubtractPolynomials(firstPolynomial, secondPolynomial);
        Console.WriteLine("The result after subtracting the polynomials is: ");
        PrintPolynomial(diff);

        int[] result = MultiplyPolynomials(firstPolynomial, secondPolynomial);
        Console.WriteLine("The result after multiplying the polynomials is: ");
        PrintPolynomial(result);
        Console.WriteLine();
    }
}