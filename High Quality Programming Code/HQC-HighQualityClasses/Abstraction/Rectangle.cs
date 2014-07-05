//-----------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Figures
{
    using System;

    /// <summary>
    /// A rectangle with a specific sizes
    /// </summary>
    public class Rectangle : Figure
    {
        /// <summary>
        /// Width of the rectangle
        /// </summary>
        private double width;

        /// <summary>
        /// Height of the rectangle
        /// </summary>
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class that is actually a square
        /// </summary>
        /// <param name="sideLength">Length of the squares sides</param>
        public Rectangle(double sideLength)
            : this(sideLength, sideLength)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class
        /// </summary>
        /// <param name="width">Width of the rectangle</param>
        /// <param name="height">Height of the rectangle</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets the width of the rectangle
        /// </summary>
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than 0.");
                }

                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the rectangle
        /// </summary>
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than 0.");
                }

                this.height = value;
            }
        }

        /// <summary>
        /// Calculates the perimeter of the figure
        /// </summary>
        /// <returns>The perimeter of the figure</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        /// <summary>
        /// Calculates the surface of the figure
        /// </summary>
        /// <returns>The surface of the figure</returns>
        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
