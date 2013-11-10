//01. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//    Implement the ToString() to enable printing a 3D point.
//02. Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//    Add a static property to return the point O.

namespace PointStructure3D
{
    using System;
    using System.Text;

    public struct Point3D
    {
        // Task 2 - private static read-only field and a static property for point O (0, 0, 0)
        private static readonly Point3D zero = new Point3D(0, 0, 0);

        public static Point3D Zero
        {
            get { return zero; }
        }

        // Task 1 ('till the end)
        // Properties to keep the coords of a point
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public int ZCoord { get; set; }

        // Constructor for a Point3D
        public Point3D(int x, int y, int z) : this()
        {
            this.XCoord = x;
            this.YCoord = y;
            this.ZCoord = z;
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append("[ ");
            toString.Append(this.XCoord);
            toString.Append(", ");
            toString.Append(this.YCoord);
            toString.Append(", ");
            toString.Append(this.ZCoord);
            toString.Append(" ]");

            return toString.ToString();
        }
    }
}
