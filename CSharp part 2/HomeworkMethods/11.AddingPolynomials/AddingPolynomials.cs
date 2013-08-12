//11. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//	  x^2 + 5 = 1.x^2 + 0.x + 5  -> |5|0|1|

using System;

class AddingPolynomials
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
        int[] polynomial = new int[input + 1];

        return polynomial;
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

    static int[] AddPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        uint resultSize = (uint)firstPolynomial.Length;
        if (firstPolynomial.Length < secondPolynomial.Length)
            resultSize = (uint)secondPolynomial.Length;     //Резултата е масив с размер равен на по-големия от сумираните масиви

        int[] result = new int[resultSize];

        for (int i = 0; i < result.Length; i++)
        {
            if (i < firstPolynomial.Length && i < secondPolynomial.Length)  //Двата масива просто се сумират, там където и двата имат
                result[i] = firstPolynomial[i] + secondPolynomial[i];       //стойности и се преписват тъм, където само един от масивите
            else if (i >= firstPolynomial.Length)                           //има стойност
                result[i] = secondPolynomial[i];
            else if (i >= secondPolynomial.Length)
                result[i] = firstPolynomial[i];
        }

        return result;
    }

    static void PrintPolynomial(int[] polynomialCoef)
    {
        string polynomial = "";
        for (int i = (polynomialCoef.Length - 1); i >= 0; i--)
        {
            char sign = '+';
            if (polynomialCoef[i] < 0)
                sign = '-';

            if (polynomialCoef[i] != 0)     //Резултата за конкретна степен на Х се принтира само, ако коефициента е различен от 0
            {
                if (i != 0)
                    polynomial += sign + " " + Math.Abs(polynomialCoef[i]) + ".x^" + i + " ";
                else
                    polynomial += sign + " " + Math.Abs(polynomialCoef[i]);
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(polynomial);
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static void Main()
    {
        Console.Write("Input the degree of the first polynomial (highest exponent of x): ");
        int[] firstPolynomial = InputPolynomialDegree();
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            Console.Write("Input the coefficient in front of x^{0}: ", (i));
            firstPolynomial[i] = InputPolynomialElement();
        }

        Console.Write("Input the degree of the second polynomial (highest exponent of x): ");
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

        int[] sum = AddPolynomials(firstPolynomial, secondPolynomial);

        Console.WriteLine("The sum of the polynomials is: ");
        PrintPolynomial(sum);
    }
}