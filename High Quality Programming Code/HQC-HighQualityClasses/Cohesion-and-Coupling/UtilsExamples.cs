//-----------------------------------------------------------------------
// <copyright file="UtilsExamples.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Utilities     // This is task 02
{
    using System;

    /// <summary>
    /// Class for testing the utilities
    /// </summary>
    public class UtilsExamples
    {
        /// <summary>
        /// Main method for the program
        /// </summary>
        public static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));
            Console.WriteLine();
            
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));
            Console.WriteLine();
            
            Console.WriteLine("Distance in the 2D space = {0:f2}", CalcUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", CalcUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));
            Console.WriteLine();

            Parallelepiped parallelepiped = new Parallelepiped(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", parallelepiped.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", parallelepiped.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", parallelepiped.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", parallelepiped.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", parallelepiped.CalcDiagonalYZ());
        }
    }
}
