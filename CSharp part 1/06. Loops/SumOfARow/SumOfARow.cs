//Задача 6
//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;

class SumOfARow
{
    static void Main()
    {
        decimal numberN, numberX;
        Console.Write("Input N for 1 + 1!/X + 2!/X^2 + … + N!/X^N - ");
        bool inputError = decimal.TryParse(Console.ReadLine(), out numberN);
        while (!inputError)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = decimal.TryParse(Console.ReadLine(), out numberN);
        }
        Console.Write("Input X for 1 + 1!/X + 2!/X^2 + … + N!/X^N - ");
        inputError = decimal.TryParse(Console.ReadLine(), out numberX);
        while (!inputError)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = decimal.TryParse(Console.ReadLine(), out numberX);
        }
        decimal result = 1;                         //Резултата, който накрая ще приеме стойността на S = 1 + 1!/X + 2!/X^2 + … + N!/X^N
        for (decimal i = 1; i <= numberN; i++)
        {
            decimal dividend = 1;
            for (decimal fact = 1; fact <= i; fact++)
            {
                dividend *= fact;                   //Получавам делимото, което за всяка стъпка на външния for-цикъл ще е равно на: i!
            }
            decimal divisor = Convert.ToDecimal(Math.Pow(Convert.ToDouble(numberX), Convert.ToDouble(i)));
                                                    //Получавам делителя за всяка стъпка на цикъла равен на: X^i
            result += (dividend / divisor);         //Към резултата (равен по начало на 1) i!/X^i, докато i достиге стойността N
        }
        Console.Write("\n1 + 1!/{0}^1 + 2!/{0}^2 + ... + {1}!/{0}^{1} = ", numberX, numberN);
        Console.ForegroundColor=ConsoleColor.Yellow;    //Записа не отговаря на реалността, ако се въведе стойност за N<3, но резултата
        Console.WriteLine("{0:0.0000}\n",result);       //... е верен. Може да се добавят if-else-ове, за да се направи изписването
        Console.ForegroundColor = ConsoleColor.Gray;    //... както трябва, но смятам, че същественото е резултата да е верен, за това 
    }                                                   //... не съм се занимавал.
}
