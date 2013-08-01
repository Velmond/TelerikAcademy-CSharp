//Задача 9
//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula: (виж презентацията)

//Задача 10
//Write a program to calculate the Nth Catalan number by given N.

//http://en.wikipedia.org/wiki/Catalan_number
//Числата за n = 1, 2, 3, 4, 5, 6, 7... са съответно 1, 2, 5, 14, 42, 132, 429...

using System;
using System.Numerics;

class CatalanNumberCalculation
{
    static void Main()
    {
        uint numberN;
        Console.Write("Input the number (N) - ");
        bool inputError = uint.TryParse(Console.ReadLine(), out numberN);
        while (!inputError)                     //При въвеждане на стойност над 13 в decimal се получава overflow, така че полечаване
        {                                       //...на по-големистойности използвам BigInteger
            Console.Write("Incorect input! Try again - ");
            inputError = uint.TryParse(Console.ReadLine(), out numberN);
        }
        BigInteger dividend = 1;                //Въвеждам променливи, които ще приемат стойностите на делимото и на делителя
        BigInteger divisor = 1;
        Console.Clear();
        for (uint i = 1; i <= (2 * numberN); i++)
        {
            dividend *= i;                      //Делимото (2.N)!
        }
        for (uint i = 1; i <= numberN; i++)
        {
            if (i < numberN)
            {
                divisor *= (i * i);             //Делителя (n+1)!.n! представям като: (1.1)+(2.2)+(3.3)+(4.4)+(5.5)+...+(n-1).(n-1)
            }
            else
            {
                divisor *= (i * i * (i + 1));   //Произведение горе умножавам с n.n.(n+1), за да получа окончателната стойност на делителя
            }
        }
        BigInteger result = dividend / divisor;
        Console.WriteLine("For N={0}, the result of {1}!/({2}!*{0}!) is: {3}\n", numberN, 2 * numberN, numberN + 1, result);
    }
}
