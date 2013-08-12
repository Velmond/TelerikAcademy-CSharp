//Задача 7
//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;

class SumOfNFibonacciNumbers
{
    static void Main()
    {
        int number;
        Console.Write("Input the number of Fibonacci numbers you'd like summed up - ");
        bool inputError = int.TryParse(Console.ReadLine(), out number);
        while (!inputError)
        {
            Console.Write("Incorect input! Try again - ");
            inputError = int.TryParse(Console.ReadLine(), out number);
        }
        decimal fibonacciNumber = 0;
        decimal nextFibonacciNumber = 1;
        decimal sum = fibonacciNumber;
        Console.Clear();
        for (int i = 1; i <= number; i++)
        {
            if (i > 1)                                  //Отчита, че първия член е 0
            {
                decimal prevNumber = fibonacciNumber;   //Започвам процедура за изчисляване на членовете на реда на Фибоначи
                fibonacciNumber = nextFibonacciNumber;
                nextFibonacciNumber = prevNumber + fibonacciNumber;
                sum += fibonacciNumber;                 //Прибавям към сумата стойността на всеки следващ член на реда
            }
            if (i < number)                             //Реших да изпиша на конзолата и самите стойности на реда, а не само сумата им
            {
                Console.WriteLine("Fibonacci #{0}|{1} + ", Convert.ToString(i).PadLeft(3, ' '), 
                                                           Convert.ToString(fibonacciNumber).PadLeft(32, ' '));
            }
            else
            {
                Console.WriteLine("Fibonacci #{0}|{1} = ", Convert.ToString(i).PadLeft(3, ' '), 
                                                           Convert.ToString(fibonacciNumber).PadLeft(32, ' '));
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Convert.ToString(sum).PadLeft(47, ' '));
        Console.ForegroundColor = ConsoleColor.Gray;

    }
}
