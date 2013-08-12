//Задача №7
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class IsANumberPrime
{
    static void Main()
    {
        int number;
        Console.Write("What number would you like checked if it is prime? ");
        bool errorDetect = int.TryParse(Console.ReadLine(), out number);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out number);
        }
        string primeOrNot;
        if (number == 1 || number == 2 || number == 3 || number == 5 || number == 7)
        {
            primeOrNot = "IS";
        }
        else if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0)
        {
            primeOrNot = "is NOT";
        }
        else
        {
            primeOrNot = "IS";
        }
        Console.WriteLine("\nThe number {0} {1} prime.\n", number, primeOrNot);
    }
}