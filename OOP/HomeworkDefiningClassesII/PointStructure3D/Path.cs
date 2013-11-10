//04.01. Create a class Path to hold a sequence of points in the 3D space.

namespace PointStructure3D
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        // The sequence of points will be saved in a list of Point3D objects
        private readonly List<Point3D> pathPoints = new List<Point3D>();

        public List<Point3D> PathPoints
        {
            get
            {
                return this.pathPoints;
            }
        }

        // Method for adding a point to the path
        public void Add(Point3D point)
        {
            this.pathPoints.Add(point);
        }

        // Method for clearing the path
        public void Clear(Point3D point)
        {
            this.pathPoints.Clear();
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            for (int i = 0; i < pathPoints.Count; i++)
            {
                toString.Append(pathPoints[i].ToString());

                if (i != pathPoints.Count - 1)
                {
                    toString.Append(Environment.NewLine);
                }
            }

            return toString.ToString();
        }
    }
}
