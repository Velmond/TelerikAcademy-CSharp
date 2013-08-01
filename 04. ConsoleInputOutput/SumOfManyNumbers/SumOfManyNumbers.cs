//Задача №7
//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumOfManyNumbers
{
    static void Main()
    {
        int numberOfNumbers;
        bool errorDetect;
        double sumOfNumbers = 0;
        Console.Write("Input the number of numbers to be sumed: ");
        errorDetect = int.TryParse(Console.ReadLine(), out numberOfNumbers);
        while (errorDetect == false)
        {
            Console.Write("Invalid input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out numberOfNumbers);
        }

        for (int i = 1; i <= numberOfNumbers; i++)
        {
            double number;
            Console.Write("Input {0} number: ", i);
            errorDetect = double.TryParse(Console.ReadLine(), out number);
            while (errorDetect == false)
            {
                Console.Write("Invalid input! Try again: ", i);
                errorDetect = double.TryParse(Console.ReadLine(), out number);
            }

            sumOfNumbers += number;

            if (i == 1 || i == numberOfNumbers)     //За всички стойности без първата и последната се правят междинни суми,
            {                                       //...който се позиционират на реда, на който се въвежда дадената стойност
                continue;                           //При последната стойност не се прави междинна сума на същия ред, а директно
            }                                       //...се изпизва общата сума от всички въведени числа
            else
            {
                Console.SetCursorPosition(+35, Console.CursorTop - 1);  //Позициониране на курсора на 35 позиции наляво
                Console.WriteLine("| SUM= {0}", sumOfNumbers);          //...и един ред нагоре и принтиране на това място на
            }                                                           //...междинната сума.
        }

        Console.WriteLine("\nSUM of all the numbers: {0}\n", sumOfNumbers);

    }
}