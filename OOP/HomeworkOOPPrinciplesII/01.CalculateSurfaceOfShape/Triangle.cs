namespace CalculateSurfaceOfShape
{
    public class Triangle : Shape
    {
        public Triangle(double height, double width)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height / 2);
        }
    }
}