//13. Write a program that can solve these tasks:
//    - Reverses the digits of a number
//    - Calculates the average of a sequence of integers
//    - Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//    - The decimal number should be non-negative
//    - The sequence should not be empty
//    - a should not be equal to 0

using System;
using System.Collections.Generic;

class MultiPurposeProgram
{
    static byte Input()                         //Вход за първоначалния избор ("1", "2" или "3")
    {
        byte choise;
        Console.WriteLine("For reversing digits press 1");
        Console.WriteLine("For getting the average of a set of numbers press 2");
        Console.WriteLine("For calculating a linear equation press 3");
        Console.Write("What would you like to do? ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        bool inputError = byte.TryParse(Console.ReadLine(), out choise);
        Console.ForegroundColor = ConsoleColor.Gray;
        while (!inputError || (choise != 1 && choise != 2 && choise != 3))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorect input!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("For reversing digits press 1");
            Console.WriteLine("For getting the average of a set of numbers press 2");
            Console.WriteLine("For calculating a linear equation press 3");
            Console.Write("What would you like to do? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            inputError = byte.TryParse(Console.ReadLine(), out choise);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        return choise;
    }

    static void ReverseDigits()                 //Вход и изход при избор "1" - обръщане на цифрите на дадено число
    {
        int number;
        Console.Write("Enter a number to reverse its digits: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        bool inputError = int.TryParse(Console.ReadLine(), out number);
        Console.ForegroundColor = ConsoleColor.Gray; while (!inputError)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorect input!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Enter a number to reverse its digits: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            inputError = int.TryParse(Console.ReadLine(), out number);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        Console.Write("Reversed number: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(SolveReverseDigits(number, number.ToString().Length));
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static int SolveReverseDigits(int numberToReverse, int numberOfDigits)       //За обръщане на числото използвам кода от задача 7
    {
        string reversed = "";
        for (int i = 0; i < numberOfDigits; i++)
        {
            reversed += numberToReverse % 10;
            numberToReverse /= 10;
        }

        return int.Parse(reversed);
    }

    static void FindAverage()                   //Вход и изход при избор "2" - намиране на средно аритметично
    {
        uint numberOfNumbers;
        Console.Write("Enter the number of elements to get the average out of: ");  //Въвеждане на броя на числата, от които се търси
        Console.ForegroundColor = ConsoleColor.Yellow;                              //средно аритметично
        bool inputError = uint.TryParse(Console.ReadLine(), out numberOfNumbers);
        Console.ForegroundColor = ConsoleColor.Gray;
        while (!inputError || numberOfNumbers == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorect input!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Enter the number of elements to get the average out of: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            inputError = uint.TryParse(Console.ReadLine(), out numberOfNumbers);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        int[] array = new int[numberOfNumbers];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter element {0}: ", (i + 1));                      //Въвеждане на числата в масив
            Console.ForegroundColor = ConsoleColor.Yellow;
            inputError = int.TryParse(Console.ReadLine(), out array[i]);
            Console.ForegroundColor = ConsoleColor.Gray;
            while (!inputError)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorect input!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Enter element {0}: ", (i + 1));
                Console.ForegroundColor = ConsoleColor.Yellow;
                inputError = int.TryParse(Console.ReadLine(), out array[i]);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        
        Console.Write("The average is: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("{0:f2}", SolveFindAverage(array));
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static decimal SolveFindAverage(int[] array)
    {
        int sum = 0;
        decimal average = 0;
        foreach (var number in array)
            sum += number;

        average = (decimal)sum / array.Length;      //Всички числа се сумират и след това се разделят на броя елементи в масива

        return average;
    }

    static void LinearEquation()                   //Вход и изход при избор "3" - решаване на линейно уравнение
    {
        decimal a;
        Console.Write("Enter coeficient a for \"a.x + b = 0\" (a != 0): ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        bool inputError = decimal.TryParse(Console.ReadLine(), out a);
        Console.ForegroundColor = ConsoleColor.Gray;
        while (!inputError || a == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorect input!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Enter coeficient a for \"a.x + b = 0\" (a != 0): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            inputError = decimal.TryParse(Console.ReadLine(), out a);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        decimal b;
        Console.Write("Enter coeficient b for \"a.x + b = 0\": ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        inputError = decimal.TryParse(Console.ReadLine(), out b);
        Console.ForegroundColor = ConsoleColor.Gray;
        while (!inputError)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorect input!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Enter coeficient b for \"a.x + b = 0\": ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            inputError = decimal.TryParse(Console.ReadLine(), out b);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        Console.Write("x = ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("{0:f2}", SolveLinearEquation(a, b));
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static decimal SolveLinearEquation(decimal a, decimal b)
    {
        decimal result = (decimal)-b / a;
        return result;
    }

    static void Main()
    {
        byte choise = Input();
        Console.Clear();

        if (choise == 1)
        {
            Console.WriteLine("You have chosen \"1\" - Reversing the digits of a number.");
            ReverseDigits();
        }
        else if (choise == 2)
        {
            Console.WriteLine("You have chosen \"2\" - Finding the average of a set of numbers.");
            FindAverage();
        }
        else
        {
            Console.WriteLine("You have chosen \"3\" - Solving a linear equation.");
            LinearEquation();
        }
    }
}