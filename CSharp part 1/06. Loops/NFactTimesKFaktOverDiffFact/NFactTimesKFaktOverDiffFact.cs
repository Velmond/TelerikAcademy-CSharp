//Задача 5
//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;

class NFactTimesKFaktOverDiffFact
{
    static void Main()
    {
        decimal numberN, numberK;
        Console.Write("Input N for N!*K!/(K-N)! (N > 1) - ");
        bool inputError = decimal.TryParse(Console.ReadLine(), out numberN);
        while (!inputError || numberN <= 1)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = decimal.TryParse(Console.ReadLine(), out numberN);
        }
        Console.Write("Input K for N!*K!/(K-N)! (K > N) - ");
        inputError = decimal.TryParse(Console.ReadLine(), out numberK);
        while (!inputError || numberK <= numberN)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = decimal.TryParse(Console.ReadLine(), out numberK);
        }
        decimal result = 1;                     //Резултата, който накрая ще приеме стойността на N!*K!/(K-N)!
        Console.Clear();
        for (decimal i = ((numberK - numberN) + 1); i <= numberK; i++)
        {
            result *= i;                        //Умножавам числата между (K-N+1) и K, като резултата е К!/(K-N)!
        }
        for (decimal i = 2; i <= numberN; i++)
        {
            result *= i;                        //Получения резултат по-горе умножавам по N!, за да получа N!*K!/(K-N)!
        }
        Console.WriteLine("The result of {0}!*{1}!/({1}-{0})! is: {2}\n", numberN, numberK, result);
    }
}