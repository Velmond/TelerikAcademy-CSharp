//Задача №6
//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class IsAPointInACircle
{
    static void Main()
    {
        Console.Write("Enter X coordinate - ");
        double x;
        bool errorDetect = double.TryParse(Console.ReadLine(), out x);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number.\nDid you use \".\" or \",\"? Try again - ");
            errorDetect = double.TryParse(Console.ReadLine(), out x);
        }
        Console.Write("Enter Y coordinate - ");
        double y;
        errorDetect = double.TryParse(Console.ReadLine(), out y);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = double.TryParse(Console.ReadLine(), out y);
        }
        double distFromO = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)); //Питагорова теорема - a^2+b^2=c^2
        string position;
        if (distFromO < 5)          //Ако разстоянието е по-малко от радиуса -> точката попада вътре в кръга
        {
            position = "inside";
        }
        else if (distFromO > 5)     //Ако разстоянието е по-голямо от радиуса -> точката попада извън кръга
        {
            position = "outside";
        }
        else                        //Ако разстоянието е равно на радиуса -> точката попада върху границата на кръга
        {
            position = "on the edge";
        }
        Console.WriteLine("\nThe point with coordinates ({0};{1}) is {2} of the circle K(O,5)\n", x, y, position);
    }
}
