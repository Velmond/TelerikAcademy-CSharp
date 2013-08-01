//Задача 4
//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class NFactOverKFact
{
    static void Main()
    {
        decimal numberN, numberK;
        Console.Write("Input N for N!/K! - ");
        bool inputError = decimal.TryParse(Console.ReadLine(), out numberN);
        while (!inputError)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = decimal.TryParse(Console.ReadLine(), out numberN);
        }
        Console.Write("Input K for N!/K! - ");
        inputError = decimal.TryParse(Console.ReadLine(), out numberK);
        while (!inputError)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = decimal.TryParse(Console.ReadLine(), out numberK);
        }
        decimal result = 1;         //Резултата, който накрая ще приеме стойността на N!/K!
        Console.Clear();
        if (numberN > numberK)      //Резултата, който ще се получи, ако N>K ще е равен на N.(N-1)...(K+2).(K+1)
        {
            for (decimal i = (numberK + 1); i <= numberN; i++)
            {
                result *= i;        //Умножавам числата между N и (K+1)
            }
        }
        else                        //Резултата, който ще се получи, ако N<K ще е равен на 1/[(N+1).(N+2)...(K-1).K]
        {
            for (decimal i = (numberN + 1); i <= numberK; i++)
            {
                result /= i;        //Директно деля 1 на числата между (N+1) и K
            }
        }
        Console.WriteLine("The result of {0}!/{1}! is: {2}\n", numberN, numberK, result);
    }
}
