namespace CalculateSurfaceOfShape
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size must be a positive number.");
                }
                else
                {
                    width = value;
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size must be a positive number.");
                }
                else
                {
                    height = value;
                }
            }
        }

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();
    }
}