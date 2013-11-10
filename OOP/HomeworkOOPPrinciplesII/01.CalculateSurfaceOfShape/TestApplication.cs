//01. Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//    Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of
//    the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable
//    constructor so that at initialization height must be kept equal to width and implement the CalculateSurface()
//    method. Write a program that tests the behavior of the CalculateSurface() method for different shapes (Circle,
//    Rectangle, Triangle) stored in an array.

namespace CalculateSurfaceOfShape
{
    using System;

    class TestApplication
    {
        // See the unit tests in 01.02.CalculateSurfaceTest for more tests
        
        static void Main()
        {
            Shape[] figures = {
                                  new Triangle(3, 4),       // Area ->  6.00
                                  new Triangle(2, 1.5),     // Area ->  1.50
                                  new Rectangle(3, 4),      // Area -> 12.00
                                  new Rectangle(2, 1.5),    // Area ->  3.00
                                  new Circle(3),            // Area -> 28.27
                                  new Circle(1.5),          // Area ->  7.07
                              };

            foreach (var figure in figures)
            {
                Console.WriteLine("{0:f2}", figure.CalculateSurface());
            }
        }
    }
}