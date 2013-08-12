//19. * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
//Example: n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
                                        //N=8 отнема  1 минута и 18,5 секунди ( 40 320 комбинации, но проверява  16 777 216)
                                        //N=9 отнема 59 минути и  0,4 секунди (362 880 комбинации, но проверява 387 420 489)
                                        //Препоръчвам да се тества с по-малки числа
using System;
using System.Numerics;

class PermutationsOfNNumbers
{
    static void Main()
    {
        uint N;
        Console.Write("Please input the number N? ");
        bool errorDetect = uint.TryParse(Console.ReadLine(), out N);
        while (!errorDetect && (N < 0))
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out N);
        }

        BigInteger numberOfVariations = (BigInteger)Math.Pow(N, N);     //Общия брой на комбинациите, които могат да се направят
        uint[] tempArray = new uint[N];                                 //Въвеждам временен масив, който ще приема стойностите
                                                                        //на всяка комбинация до изписването и на конзолата.
        int count = 1;      //Използвам го за номера на конкретната комбинация
        for (BigInteger i = 0; i < numberOfVariations; i++)
        {
            BigInteger conv = i;
            bool print = true;                              //Променлива, показваща дали комбинацията трябва да се изпринтира
            for (uint j = 0; j < N; j++)
            {
                tempArray[N - j - 1] = (uint)(conv % N);
                conv = conv / N;
            }
            for (uint j = 0; j < N; j++)
            {
                for (uint k = 0; k < N; k++)
                {
                    if ((j != k) && (tempArray[j] == tempArray[k]))
                    {
                        print = false;                      //Ако два елемента в дадена комбинация са равни
                    }                                       //тази комбинация не се принтира на конзолата
                }
            }
            if (print)
            {
                Console.Write("{0} -> {1} ", count, '{');
                for (uint j = 0; j < N; j++)
                {
                    Console.Write("{0} ", (tempArray[j] + 1));
                }
                Console.WriteLine('}');
                count++;
            }
        }
    }
}