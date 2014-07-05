namespace Sizes
{
    using System;

    public class Sizes
    {
        private double width;
        private double height;

        /// <summary>
        /// Create a set of sizes with specific values
        /// </summary>
        /// <param name="width">The width that the set of values should return</param>
        /// <param name="height">The height that the set of values should return</param>
        public Sizes(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        
        /// <summary>
        /// The width from the set of values
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
        /// The height from the set of values
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
        /// Creates a set of sezes as long as the projected ones of the original set at some angle
        /// </summary>
        /// <param name="sizes">Set of sizes that will be projected</param>
        /// <param name="angleToProjectAt">Angle at which the original set's values are to be projected</param>
        /// <returns>A new set of sizes that are as long as the projected ones of the original set</returns>
        public static Sizes ProjectSizes(Sizes sizes, double angleToProjectAt)
        {
            double projectedWidth = Math.Abs(Math.Cos(angleToProjectAt)) * sizes.Width +
                Math.Abs(Math.Sin(angleToProjectAt)) * sizes.Height;
            double projectedHeight = Math.Abs(Math.Sin(angleToProjectAt)) * sizes.Width +
                Math.Abs(Math.Cos(angleToProjectAt)) * sizes.Height;

            Sizes newSizes = new Sizes(projectedWidth, projectedHeight);

            return newSizes;
        }
    }
}
