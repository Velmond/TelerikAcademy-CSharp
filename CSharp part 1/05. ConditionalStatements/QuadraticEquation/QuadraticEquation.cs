//Задача 6
//Write a program that enters the coefficients a, b and c of a quadratic equation
//a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class QuadraticEquation
{
    static void Main()
    {
        double a, b, c;
        bool errorDetect;
        Console.WriteLine("This is a program for solving quadratic equations.\nA.x^2+B.x+C=0\n");
        Console.Write("Please input coeficient A: ");
        errorDetect = double.TryParse(Console.ReadLine(), out a);
        while (errorDetect == false)
        {
            Console.Write("Invalid input! Try again: ");
            errorDetect = double.TryParse(Console.ReadLine(), out a);
        }
        Console.Write("Please input coeficient B: ");
        errorDetect = double.TryParse(Console.ReadLine(), out b);
        while (errorDetect == false)
        {
            Console.Write("Invalid input! Try again: ");
            errorDetect = double.TryParse(Console.ReadLine(), out b);
        }
        Console.Write("Please input coeficient C: ");
        errorDetect = double.TryParse(Console.ReadLine(), out c);
        while (errorDetect == false)
        {
            Console.Write("Invalid input! Try again: ");
            errorDetect = double.TryParse(Console.ReadLine(), out c);
        }
        double det = (b * b) - (4 * a * c);
        double x1, x2;
        if (det == 0)
        {
            x1 = (-b / (2 * a));
            Console.WriteLine("\nThe equation has one real root.\n{0}.x^2 + {1}.x + {2} = 0\nx = {3:0.000}\n", a, b, c, x1);
        }
        else if (det < 0)
        {
            Console.WriteLine("\nThe equation has no real root.\n{0}.x^2 + {1}.x + {2} = 0\n", a, b, c);
        }
        else
        {
            x1 = (-b + Math.Sqrt(det) / (2 * a));
            x2 = (-b - Math.Sqrt(det) / (2 * a));
            Console.WriteLine("\nThe equation has two real root.\n{0}.x^2 + {1}.x + {2} = 0\nx1 = {3:0.000}\nx2 = {4:0.000}\n", a, b, c, x1, x2);
        }
    }
}