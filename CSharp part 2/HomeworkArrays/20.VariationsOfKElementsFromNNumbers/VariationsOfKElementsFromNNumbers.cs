//20. Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;
using System.Numerics;

class VariationsOfKElementsFromNNumbers
{
    static void Main()
    {
        uint N;
        Console.Write("What should the maximum number in a combination be? (N) ");
        bool errorDetect = uint.TryParse(Console.ReadLine(), out N);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out N);
        }
        uint K;
        Console.Write("How many numbers should each combination contain? (K) ");
        errorDetect = uint.TryParse(Console.ReadLine(), out K);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out K);
        }

        //За проверка:
        //uint N = 5;
        //uint K = 3;

        BigInteger numberOfVariations = (BigInteger) Math.Pow(N, K);    //Общия брой на комбинациите, които трябва да се изпишат
        uint[] tempArray = new uint[K];                                 //Въвеждам временен масив, който ще приема стойностите
                                                                        //на всяка комбинация до изписването и на конзолата.
        for (BigInteger i = 0; i < numberOfVariations; i++)
        {
            BigInteger conv = i;
            for (uint j = 0; j < K; j++)
            {
                tempArray[K - j - 1] = (uint) conv % N;     //Попълването на масива става от последния член към първия
                conv = conv / N;
            }
            Console.Write("{0} -> {1} ", i+1, '{');         //Изписване на дадената комбинация
            for (int j = 0; j < K; j++)
            {
                Console.Write("{0} ", (tempArray[j] + 1));
            }
            Console.WriteLine("}");
        }
    }
}