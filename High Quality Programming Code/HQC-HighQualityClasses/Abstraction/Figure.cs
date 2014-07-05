//-----------------------------------------------------------------------
// <copyright file="Figure.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Figures
{
    /// <summary>
    /// A two-dimensional figure with perimeter and surface
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Calculates the perimeter of the figure
        /// </summary>
        /// <returns>The perimeter of the figure</returns>
        public abstract double CalcPerimeter();

        /// <summary>
        /// Calculates the surface of the figure
        /// </summary>
        /// <returns>The surface of the figure</returns>
        public abstract double CalcSurface();
    }
}
