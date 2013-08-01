//Задача 13
//Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
//N = 10 => N! = 3628800 => 2
//N = 20 => N! = 2432902008176640000 => 4
//Does your program work for N = 50 000?
//Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

using System;
using System.Numerics;

class HowManyZerosAfterNFact
{
    static void Main()
    {
        uint numberN;
        Console.Write("Input an integer number (N) - ");
        bool inputError = uint.TryParse(Console.ReadLine(), out numberN);
        while (!inputError)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = uint.TryParse(Console.ReadLine(), out numberN);
        }
        ulong result = 0;
        ulong divider;
        ulong check;
        for (byte i = 1; i <= 16; i++)
        {
            divider = Convert.ToUInt64(Math.Pow(5, i));
            result += (numberN / divider);  //Прибавям резултата от целочислено делене последователно на 5^1, 5^2, 5^3, 5^4, 5^5 и т.н.
            check = numberN / divider;
            if (check <= 0)                 //Ако числото, разделено на дадената степен на 5 е по-малко от 0, цикъла се прекъсва, за да
            {                               //не се губи време в излишни проверки за следващите степени на 5. Например за числото 30 има
                break;                      //смисъл да се проверява най-много до 25 (5^2), а не до 5^16, както е зададено в цикъла.
            }
        }
        Console.WriteLine("The number of zeros trailing {0}! is: {1}", numberN, result);

        // V Използвах това за проверка.
        //BigInteger nFact = 1;
        //for (int i = 2; i <= numberN; i++)
        //{
        //    nFact *= i;
        //}
        //Console.WriteLine(nFact);
    }
}
