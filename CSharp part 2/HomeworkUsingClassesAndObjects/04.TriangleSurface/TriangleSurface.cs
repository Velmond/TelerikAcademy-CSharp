//04. Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

class TriangleSurface
{
    static byte InputChoice()
    {
        byte choice;
        Console.WriteLine("Choose by what you want to find the surface of a triangle.");
        Console.WriteLine("- Side and an altitude to it - choose 1");
        Console.WriteLine("- Three sides - choose 2");
        Console.WriteLine("- Two sides and an angle between them - choose 3");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("What do you choose? ");
        bool inputError = byte.TryParse(Console.ReadLine(), out choice);
        Console.ForegroundColor = ConsoleColor.Gray;

        while (!inputError || (choice != 1 && choice != 2 && choice != 3))
        {
            Console.Write("Incorrect input! Try again (1, 2 or 3): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            inputError = byte.TryParse(Console.ReadLine(), out choice);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        return choice;
    }

    static double InputDouble()
    {
        double input;
        Console.ForegroundColor = ConsoleColor.Yellow;
        bool inputError = double.TryParse(Console.ReadLine(), out input);
        Console.ForegroundColor = ConsoleColor.Gray;

        while (!inputError)
        {
            Console.Write("Incorrect input! Try again: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            inputError = double.TryParse(Console.ReadLine(), out input);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        return input;
    }

    static double FindSurface(double side, double altitude)     //I'm using the same method in all three cases. For the first case
    {                                                           //it takes only two arguments. For the second and third it takes four
        return (0.5 * side * altitude);                         //one of which is the choise made at the start of the program to detirmen
    }                                                           //by which formula the surface should be calculated.

    static double FindSurface(double sideA, double sideB, double angleOrSideC, byte choise)
    {
        double surface = 0;
        if (choise == 2)
        {
            double s = 0.5 * (sideA + sideB + angleOrSideC);
            surface = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - angleOrSideC));
        }
        else
            surface = 0.5 * sideA * sideB * Math.Sin(angleOrSideC * Math.PI / 180);

        return surface;
    }

    static void Main()
    {
        while (true)
        {
            byte choice = InputChoice();    //Choose how you want to calculate the surface of the triangle
            double surface = 0;
            bool triangleIsValid = true;

            switch (choice)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You chose to find the surface by side and an altitude to it");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Input a side of the triangle: ");
                    double sideA = InputDouble();
                    Console.Write("Input the altitude to that side of the triangle: ");
                    double altitude = InputDouble();
                    surface = FindSurface(sideA, altitude);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You chose to find the surface by three sides");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Input the first side of the triangle: ");
                    sideA = InputDouble();
                    Console.Write("Input the second side of the triangle: ");
                    double sideB = InputDouble();
                    Console.Write("Input the third side of the triangle: ");
                    double sideC = InputDouble();
                    if (sideA <= (sideB + sideC) || sideB <= (sideA + sideC) || sideC <= (sideA + sideB))
                    {                                                                               //Makes sure the input is valid
                        triangleIsValid = false;
                        break;
                    }
                    surface = FindSurface(sideA, sideB, sideC, choice);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You chose to find the surface by two sides and an angle between them");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Input one of the sides of the triangle: ");
                    sideA = InputDouble();
                    Console.Write("Input the second of the sides of the triangle: ");
                    sideB = InputDouble();
                    Console.Write("Input the angle between those sides: ");
                    double angle = InputDouble();
                    surface = FindSurface(sideA, sideB, angle, choice);
                    break;
            }

            if (triangleIsValid)        //If the input is valid
            {
                Console.Write("The area of the triangle is: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0:f2}\n", surface);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else                        //If the input is invalid
            {
                Console.Write("The entered dimentions make the triangle ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("impossible.\n", surface);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}