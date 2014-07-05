//-----------------------------------------------------------------------
// <copyright file="Circle.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Figures
{
    using System;

    /// <summary>
    /// A circle with a specific radius
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Radius of the circle
        /// </summary>
        private double radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class
        /// </summary>
        /// <param name="radius">Radius of the circle</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets the radius of the circle
        /// </summary>
        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than 0.");
                }

                this.radius = value;
            }
        }

        /// <summary>
        /// Calculates the perimeter of the figure
        /// </summary>
        /// <returns>The perimeter of the figure</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>
        /// Calculates the surface of the figure
        /// </summary>
        /// <returns>The surface of the figure</returns>
        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
