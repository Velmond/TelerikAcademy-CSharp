//-----------------------------------------------------------------------
// <copyright file="FiguresExample.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Figures   // This is task 01
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for testing the figures
    /// </summary>
    public class FiguresExample
    {
        /// <summary>
        /// Main method for the program
        /// </summary>
        public static void Main()
        {
            List<Figure> figures = new List<Figure>();
            
            Figure circle = new Circle(5);
            figures.Add(circle);
            Figure rect = new Rectangle(2, 3);
            figures.Add(rect);
            Figure baseCircle = new Circle(1);
            figures.Add(baseCircle);
            Figure square = new Rectangle(2);
            figures.Add(square);

            foreach (var figure in figures)
            {
                Console.WriteLine(
                    "I am a {0}. My perimeter is {1:f2}. My surface is {2:f2}.",
                    figure.GetType().Name,
                    figure.CalcPerimeter(),
                    figure.CalcSurface());
            }
        }
    }
}
