//Задача №9
//Write an expression that checks for given point (x, y) if it is within the circle 
//K((1,1),3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class IsAPointInACircleAndOutARectangle
{
    static void Main()
    {
        byte centerX = 1;
        byte centerY = 1;
        byte radius = 3;
        byte rectangleCornerX = 1;
        sbyte rectangleCornerY = -1;
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
        double insideCircle = Math.Sqrt(Math.Pow((x - centerX), 2) + Math.Pow((y - centerY), 2));
        string position;
        if (insideCircle <= radius && ((x < rectangleCornerX) || (x >= rectangleCornerX && y > rectangleCornerY)))
        {
            position = "IS";
        }
        else
        {
            position = "is NOT";
        }
        Console.WriteLine("\nCircle: \tK(({0},{1}),{2})\nRectangle R: \tTop left corner ({3},{4})\n"+
                          "\t\tWidth: 6\n\t\tHeight: 2\n"+
                          "\nThe point ({5};{6}) {7} in the circle K and out of the rectangle R\n",
                          centerX,centerY,radius,rectangleCornerX,rectangleCornerY, x, y, position);
    }
}
