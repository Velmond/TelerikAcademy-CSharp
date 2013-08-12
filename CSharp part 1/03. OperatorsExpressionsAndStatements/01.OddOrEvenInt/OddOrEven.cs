//Задача №1
//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("What interger would you like to check for being odd or even? - ");
        int number;
        bool errorDetect = int.TryParse(Console.ReadLine(), out number);
        while (errorDetect == false)
        {
            Console.Write("You have not entered a valid number. Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out number);
        }
        string oddOrEven;
        if (number % 2 == 0)
        {
            oddOrEven = "even";
        }
        else
        {
            oddOrEven = "odd";
        }
        Console.Clear();
        Console.WriteLine("{0} is {1}\n", number, oddOrEven);
    }
}
