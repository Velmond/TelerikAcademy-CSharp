//-----------------------------------------------------------------------
// <copyright file="Parallelepiped.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Utilities
{
    using System;

    /// <summary>
    /// A three-dimensional figure with all right angles
    /// </summary>
    public class Parallelepiped
    {
        /// <summary>
        /// Width of the parallelepiped
        /// </summary>
        private double width;

        /// <summary>
        /// Height of the parallelepiped
        /// </summary>
        private double height;

        /// <summary>
        /// Depth of the parallelepiped
        /// </summary>
        private double depth;

        /// <summary>
        /// Initializes a new instance of the <see cref="Parallelepiped"/> class
        /// </summary>
        /// <param name="width">Width of the parallelepiped</param>
        /// <param name="height">Height of the parallelepiped</param>
        /// <param name="depth">Depth of the parallelepiped</param>
        public Parallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        /// <summary>
        /// Gets or sets the width of the parallelepiped
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
        /// Gets or sets the height of the parallelepiped
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
        /// Gets or sets the depth of the parallelepiped
        /// </summary>
        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than 0.");
                }

                this.depth = value;
            }
        }

        /// <summary>
        /// Calculates the volume of the parallelepiped
        /// </summary>
        /// <returns>The volume of the figure</returns>
        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        /// <summary>
        /// Calculates the length of the diagonal between 2 opposite angles in 3D of the parallelepiped
        /// </summary>
        /// <returns>The length of the diagonal</returns>
        public double CalcDiagonalXYZ()
        {
            double distance = CalcUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        /// <summary>
        /// Calculates the length of the diagonal between 2 opposite angles on one of the walls of the parallelepiped (width/height)
        /// </summary>
        /// <returns>The length of the diagonal</returns>
        public double CalcDiagonalXY()
        {
            double distance = CalcUtils.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        /// <summary>
        /// Calculates the length of the diagonal between 2 opposite angles on one of the walls of the parallelepiped (width/depth)
        /// </summary>
        /// <returns>The length of the diagonal</returns>
        public double CalcDiagonalXZ()
        {
            double distance = CalcUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        /// <summary>
        /// Calculates the length of the diagonal between 2 opposite angles on one of the walls of the parallelepiped (height/depth)
        /// </summary>
        /// <returns>The length of the diagonal</returns>
        public double CalcDiagonalYZ()
        {
            double distance = CalcUtils.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
