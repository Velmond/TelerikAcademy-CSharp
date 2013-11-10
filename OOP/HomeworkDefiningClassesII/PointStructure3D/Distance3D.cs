//03. Write a static class with a static method to calculate the distance between two points in the 3D space.

namespace PointStructure3D
{
    using System;

    public static class Distance3D
    {
        // Method requiring two points as input to find the distance between them
        public static double Distance(Point3D firstPoint, Point3D secondPoint)
        {
            double xDistance = (firstPoint.XCoord - secondPoint.XCoord);
            double yDistance = (firstPoint.YCoord - secondPoint.YCoord);
            double zDistance = (firstPoint.ZCoord - secondPoint.ZCoord);

            double distance = Math.Sqrt(xDistance * xDistance + yDistance * yDistance + zDistance * zDistance);

            return distance;
        }

        // Method requiring one point as input to find the distance between it and point O (0, 0, 0)
        public static double Distance(Point3D point)
        {
            double distance = Math.Sqrt(point.XCoord * point.XCoord + point.YCoord * point.YCoord + point.ZCoord * point.ZCoord);

            return distance;
        }
    }
}
