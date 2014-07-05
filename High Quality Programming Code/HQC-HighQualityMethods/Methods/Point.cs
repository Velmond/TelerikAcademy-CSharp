//-----------------------------------------------------------------------
// <copyright file="Point.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Methods
{
    using System;

    /// <summary>
    /// Creates a point in two-dimensional space by its two coordinates
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Coordinate X of the point
        /// </summary>
        private double x;

        /// <summary>
        /// Coordinate Y of the point
        /// </summary>
        private double y;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class
        /// </summary>
        /// <param name="x">Coordinate X of the point</param>
        /// <param name="y">Coordinate Y of the point</param>
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or sets the value of the point's coordinate X
        /// </summary>
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        /// <summary>
        /// Gets or sets the value of the point's coordinate Y
        /// </summary>
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
    }
}
