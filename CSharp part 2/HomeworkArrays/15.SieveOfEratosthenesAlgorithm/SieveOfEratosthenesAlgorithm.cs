//15. Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class SieveOfEratosthenesAlgorithm
{
    static void Main()
    {
        Console.BufferHeight = Int16.MaxValue - 1;  //Правя буфера на конзолата с максималната му височина, така че да се съберат
                                                    //максимално много стойности (нормално се събират ~300 реда, ако не се лъжа)
        bool[] isPrime = new bool[10000000];        //Правя булев масив с елементи, колкото е последното число, за което искам
        for (uint i = 2; i < 10000000; i++)         //да проверя дали е просто.
        {
            isPrime[i] = true;                      //Приемам като начало, че всички числа са прости
        }

        for (uint i = 2; i < Math.Sqrt(10000000); i++)
        {
            if (isPrime[i])
            {
                for (uint j = 2; (i * j) < 10000000; j++)
                {
                    isPrime[i * j] = false;
                }
            }
        }

        uint count = 0;
        for (uint i = 1; i < 10000000; i++)          //Изписване на простите числа на конзолата
        {
            if (isPrime[i])
            {
                count++;
                Console.Write("{0}\t", i);          //Ако се закоментира този ред, програмата ще "преброи" простите числа
            }                                       //много по-бързо, без да ги изписва на конзолата
        }
        Console.WriteLine("\nThe total number of prime numbers from 1 to 10000000 is: {0}", count);
    }
}