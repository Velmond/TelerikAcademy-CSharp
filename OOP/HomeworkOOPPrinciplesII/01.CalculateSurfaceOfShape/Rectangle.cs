namespace CalculateSurfaceOfShape
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height);
        }
    }
}