//Задача №3
//Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("What is the rectangle's WIDTH? ");
        double width;
        bool errorDetect = double.TryParse(Console.ReadLine(), out width);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number.\nDid you use \".\" or \",\"? Try again - ");
            errorDetect = double.TryParse(Console.ReadLine(), out width);
        }
        Console.Write("What is the rectangle's HEIGHT? ");
        double height;
        errorDetect = double.TryParse(Console.ReadLine(), out height);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number.\nDid you use \".\" or \",\"? Try again - ");
            errorDetect = double.TryParse(Console.ReadLine(), out height);
        }
        double area = width * height;
        Console.Clear();
        Console.WriteLine("B = {0:f2}\nH= {1:f2}\nA = H * B = {0:f2} * {1:f2} = {2:f2}\n", width, height, area);
    }
}
