namespace ProjectedRectangle
{
    using System;

    public class Rectangle
    {
        private double width, height;

        /// <summary>
        /// Create a rectengle with specific dimensions
        /// </summary>
        /// <param name="width">The width that the rectangle should have</param>
        /// <param name="height">The height that the rectangle should have</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        
        /// <summary>
        /// The width of the rectangle
        /// </summary>
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        /// <summary>
        /// The height of the rectangle
        /// </summary>
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        /// <summary>
        /// Creates a rectangle with sides as long as the projected ones of the original rectangle at some angle
        /// </summary>
        /// <param name="rectangle">Rectangle to be projected</param>
        /// <param name="angleToProjectAt">Angle by which the original's sides are to be projected to get the new one's length</param>
        /// <returns>A new rectangle with sides as long as the projected ones of the original rectangle</returns>
        public static Rectangle ProjectedRectangle(Rectangle rectangle, double angleToProjectAt)
        {
            return new Rectangle(
                Math.Abs(Math.Cos(angleToProjectAt)) * rectangle.Width +
                Math.Abs(Math.Sin(angleToProjectAt)) * rectangle.Height,
                Math.Abs(Math.Sin(angleToProjectAt)) * rectangle.Width +
                Math.Abs(Math.Cos(angleToProjectAt)) * rectangle.Height);
        }
    }
}