//21. Write a program that reads two numbers N and K and generates 
//all the combinations of K distinct elements from the set [1..N]. 
//Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;
using System.Numerics;

class VariationsOfKDistinctElementsFromNNumbers
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
        //uint K = 2;

        BigInteger numberOfVariations = (BigInteger) Math.Pow(N, K);    //Общия брой на комбинациите, които могат да се направят
        uint[] tempArray = new uint[K];                                 //Въвеждам временен масив, който ще приема стойностите
                                                                        //на всяка комбинация до изписването и на конзолата.
        uint count = 1;      //Използвам го за номера на конкретната комбинация
        for (BigInteger i = 0; i < numberOfVariations; i++)
        {
            BigInteger conv = i;
            bool print = true;                          //Променлива, показваща дали комбинацията трябва да се изпринтира
            for (uint j = 0; j < K; j++)
            {
                tempArray[K - j - 1] = (uint)(conv % N);
                conv = conv / N;
                if ((j > 0) && (tempArray[j] <= tempArray[j - 1]))  //Ако някой елемент е по-малък или равен на предхождащия
                {                                                   //го, тази комбинация не се принтира на конзолата
                    print = false;
                }
            }
            if (print)
            {
                Console.Write("{0,6} -> {1} ", count, '{');
                for (int j = 0; j < K; j++)
                {
                    Console.Write("{0} ", (tempArray[j] + 1));
                }
                Console.WriteLine('}');
                count++;
            }
        }
    }
}