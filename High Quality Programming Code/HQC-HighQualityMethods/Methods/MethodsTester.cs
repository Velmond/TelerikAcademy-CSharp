//-----------------------------------------------------------------------
// <copyright file="MethodsTester.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Methods
{
    using System;

    /// <summary>
    /// Class for testing the methods
    /// </summary>
    public class MethodsTester
    {
        /// <summary>
        /// Main method for the program
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Triangle area: " + Methods.CalcTriangleArea(3, 4, 5));
            ////Console.WriteLine("Triangle area: " + CalcTriangleArea(3, -4, 5));  // Throws exception
            ////Console.WriteLine("Triangle area: " + CalcTriangleArea(3, 4, 15));  // Throws exception
            Console.WriteLine();

            Console.WriteLine("Digit to string: " + Methods.GetDigitName(5));
            ////Console.WriteLine(DigitToString("Digit to string: " + 'a'));    // Throws exception
            ////Console.WriteLine(DigitToString("Digit to string: " + 52));     // Throws exception
            Console.WriteLine();

            Console.WriteLine("Max element: " + Methods.FindMax(5, -1, 3, 2, 14, 2, 3));
            ////Console.WriteLine("Max element: " + FindMax()); // Throws exception
            Console.WriteLine();

            Console.Write("Formatted number (f): ");
            Methods.PrintFormattedNumber(1.3, 'f');
            Console.Write("Formatted number (%): ");
            Methods.PrintFormattedNumber(0.75, '%');
            Console.Write("Formatted number (r): ");
            Methods.PrintFormattedNumber(2.30, 'r');
            ////Console.Write("Formatted number (f): ");
            ////PrintFormattedNumber(new []{1,2,3,4}, 'f');     // Throws exception
            ////Console.Write("Formatted number (a): ");
            ////PrintFormattedNumber(2.30, 'a');                // Throws exception
            Console.WriteLine();

            Point pointA = new Point(3, -1);
            Point pointB = new Point(3, 2.5);

            bool isHorizontal = Methods.IsHorizontal(pointA, pointB);
            bool isVertical = Methods.IsVertical(pointA, pointB);

            Console.WriteLine("Distance between points: " + Methods.CalcDistance(pointA, pointB));
            ////Console.WriteLine("Distance between points: " + CalcDistance(3, -1, 3, 2.5));   // Deprecated method overload
            Console.WriteLine("Horizontal? " + isHorizontal);
            Console.WriteLine("Vertical? " + isVertical);
            Console.WriteLine();

            Student peter = new Student("Peter", "Ivanov");
            peter.BirthDate = DateTime.Parse("17.03.1992");     // new DateTime(1992, 3, 17);
            peter.OtherInfo = "From Sofia.";

            Student stella = new Student()
            {
                FirstName = "Stella",
                LastName = "Markova",
                BirthDate = DateTime.Parse("03.11.1993"),       // new DateTime(1993, 11, 3),
                OtherInfo = "From Vidin, gamer, high results."
            };

            Console.WriteLine("{0}, Birth date: {1}", peter.FirstName, peter.BirthDate.ToShortDateString());
            Console.WriteLine("{0}, Birth date: {1}", stella.FirstName, stella.BirthDate.ToShortDateString());
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
