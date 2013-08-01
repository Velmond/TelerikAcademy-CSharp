//Задача №2
//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        double radius;
        string radiusStr = "Radius";
        string perimeterStr = "Perimeter";
        string areaStr = "Area";
        Console.Write("Please input circle radius: ");
        bool errorDetect = double.TryParse(Console.ReadLine(), out radius);
        while (errorDetect==false)
        {
            Console.Write("Please input circle radius: ");
            errorDetect = double.TryParse(Console.ReadLine(), out radius);
        }
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("\n{0,-10}| {1,8:f2}\n{2,-10}| {3,8:f2}\n{4,-10}| {5,8:f2}\n", radiusStr, radius, perimeterStr, perimeter, areaStr, area);
    }
}