namespace CalculateSurfaceOfShape
{
    using System;

    public class Circle : Shape
    {
        public Circle(double radius)
            : base(radius, radius)      // I chose to view both Height and Width as radius of the circle
        {
        }

        public override double CalculateSurface()
        {
            return (Math.PI * this.Height * this.Width);
        }
    }
}