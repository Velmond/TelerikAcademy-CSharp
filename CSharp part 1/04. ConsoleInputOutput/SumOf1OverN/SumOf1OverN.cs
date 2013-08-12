//Задача №10
//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumOf1OverN
{
    static void Main()
    {
        float sum = 1;
        for (int i = 2; i <= 1000; i++)    //След i=1000 няма разлика в резултата преди третия знак след запетаята
        {
            if (i % 2 == 0)
            {
                sum += (1 / (float)i);
            }
            else
            {
                sum -= (1 / (float)i);
            }
        }
        Console.Write("The sum of 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... is: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("{0:0.000}", sum);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}