//-----------------------------------------------------------------------
// <copyright file="Methods.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Methods
{
    using System;

    /// <summary>
    /// A collection of "high quality" methods that I see no need to put in separate classes since this homework is about
    /// high quality methods and not high quality classes. Besides if I had to separate these methods in classes most of
    /// them would have to stay alone in a class because they have nothing in common with the rest...
    /// </summary>
    public class Methods
    {
        /// <summary>
        /// Calculates the area of a triangle by the length of its three sides
        /// </summary>
        /// <param name="firstSide">First side of the triangle</param>
        /// <param name="secondSide">Second side of the triangle</param>
        /// <param name="thirdSide">Third side of the triangle</param>
        /// <returns>The area of the triangle</returns>
        public static double CalcTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("Length of triangle's side cannot be less or equal to zero.");
            }

            if (firstSide + secondSide <= thirdSide || secondSide + thirdSide <= firstSide || firstSide + thirdSide <= secondSide)
            {
                throw new ArgumentException("The provided lengths cannot form a triangle.");
            }

            double s = (firstSide + secondSide + thirdSide) / 2;
            double area = Math.Sqrt(s * (s - firstSide) * (s - secondSide) * (s - thirdSide));

            return area;
        }

        /// <summary>
        /// Gets the name in English of a given digit (0-9)
        /// </summary>
        /// <param name="digit">Digit of which the name is needed</param>
        /// <returns>The name of the digit in English</returns>
        public static string GetDigitName(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Inputted digit must be between 0 and 9.");
            }
        }

        /// <summary>
        /// Finds the maximum element in a collection of integers
        /// </summary>
        /// <param name="elements">The collection of integers of which the maximum one is sought</param>
        /// <returns>The maximum element in the collection of integers</returns>
        public static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("elements", "Argument cannot be null.");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("Inputted array must have at least one element.");
            }

            int max = int.MinValue;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Prints on the console a number in a specific format (as percentage, as a floating point number, etc.)
        /// </summary>
        /// <param name="numberToFormat">The number that is to be printed on the console in some format</param>
        /// <param name="format">The format character ('f' for floating point, '%' for percentage, etc)</param>
        public static void PrintFormattedNumber(object numberToFormat, char format)
        {
            double number;
            bool isNumber = double.TryParse(numberToFormat.ToString(), out number);

            if (!isNumber)
            {
                throw new ArgumentException("Inputted value can't be parsed to a numerical one.");
            }

            switch (format)
            {
                case 'f':
                    Console.WriteLine("{0:f2}", number);
                    break;
                case '%':
                    Console.WriteLine("{0:p0}", number);
                    break;
                case 'r':
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException(string.Format("Unknown format indicator - {0}.", format), "format");
            }
        }

        /// <summary>
        /// Calculates the distance between two points
        /// </summary>
        /// <param name="firstPoint">First point</param>
        /// <param name="secondPoint">Second point</param>
        /// <returns>The distance between the two points</returns>
        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double distance = Math.Sqrt(((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X)) +
                ((firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y)));
            return distance;
        }

        /// <summary>
        /// Calculates the distance between two points by their coordinates
        /// </summary>
        /// <param name="x1">X coordinate of the first point</param>
        /// <param name="y1">Y coordinate of the first point</param>
        /// <param name="x2">X coordinate of the second point</param>
        /// <param name="y2">Y coordinate of the second point</param>
        /// <returns>The distance between the two points</returns>
        [Obsolete("Input points instead of coords.", true)]
        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        /// <summary>
        /// Checks if given two points are positioned horizontally
        /// </summary>
        /// <param name="firstPoint">First point</param>
        /// <param name="secondPoint">Second point</param>
        /// <returns>True if the points are positioned horizontally</returns>
        public static bool IsHorizontal(Point firstPoint, Point secondPoint)
        {
            bool isHorizontal = firstPoint.Y == secondPoint.Y;
            return isHorizontal;
        }

        /// <summary>
        /// Checks if given two points are positioned vertically
        /// </summary>
        /// <param name="firstPoint">First point</param>
        /// <param name="secondPoint">Second point</param>
        /// <returns>True if the points are positioned vertically</returns>
        public static bool IsVertical(Point firstPoint, Point secondPoint)
        {
            bool isVertical = firstPoint.X == secondPoint.X;
            return isVertical;
        }
    }
}
