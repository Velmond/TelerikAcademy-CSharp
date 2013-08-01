//Задача №6
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 
//and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        double a;
        double b;
        double c;
        bool errorDetect;
        Console.WriteLine("This is a program for solving quadratic equations.\nA.x^2+B.x+C=0\n");
        Console.Write("Please input coeficient A: ");
        errorDetect = double.TryParse(Console.ReadLine(), out a);
        while (errorDetect == false)
        {
            Console.Write("Please input coeficient A: ");
            errorDetect = double.TryParse(Console.ReadLine(), out a);
        }
        Console.Write("Please input coeficient B: ");
        errorDetect = double.TryParse(Console.ReadLine(), out b);
        while (errorDetect == false)
        {
            Console.Write("Please input coeficient B: ");
            errorDetect = double.TryParse(Console.ReadLine(), out b);
        }
        Console.Write("Please input coeficient C: ");
        errorDetect = double.TryParse(Console.ReadLine(), out c);
        while (errorDetect == false)
        {
            Console.Write("Please input coeficient C: ");
            errorDetect = double.TryParse(Console.ReadLine(), out c);
        }
        double det = (b * b) - (4 * a * c);
        if (det == 0)
        {
            double x = (-b / (2 * a));
            Console.WriteLine("\nThe equation has one real root.\n{0}.x^2 + {1}.x + {2} = 0\nx = {3:0.000}\n", a, b, c, x);
        }
        else if (det < 0)
        {
            Console.WriteLine("\nThe equation has no real root.\n{0}.x^2 + {1}.x + {2} = 0\n", a, b, c);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(det) / (2 * a));
            double x2 = (-b - Math.Sqrt(det) / (2 * a));
            Console.WriteLine("\nThe equation has two real root.\n{0}.x^2 + {1}.x + {2} = 0\nx1 = {3:0.000}\nx2 = {4:0.000}\n", a, b, c, x1, x2);
        }
    }
}