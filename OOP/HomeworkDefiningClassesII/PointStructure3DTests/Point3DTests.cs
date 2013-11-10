namespace PointStructure3DTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PointStructure3D;

    [TestClass]
    public class Point3DTests
    {
        // To run all the unit tests press [Ctrl+R, A] or go to [TEST -> Run -> All Tests]
        // If the results don't show up go to [TEST -> Windows -> Test Explorer]

        [TestMethod]
        public void TestPointZero()
        {
            Point3D point = new Point3D(0, 0, 0);

            Assert.AreEqual(point, Point3D.Zero);
        }

        [TestMethod]
        public void DistanceTest()
        {
            Point3D firstPoint = new Point3D(3, 4, 2);
            Point3D secondPoint = new Point3D(5, 2, 1);

            Assert.AreEqual(3, Distance3D.Distance(firstPoint, secondPoint));
        }

        [TestMethod]
        public void DistanceFromZeroTest()
        {
            Point3D point = new Point3D(1, 2, 2);

            Assert.AreEqual(3, Distance3D.Distance(point));
        }

        [TestMethod]
        public void ZeroDistanceTest()
        {
            Point3D firstPoint = new Point3D(2, 2, 2);
            Point3D secondPoint = new Point3D(2, 2, 2);

            Assert.AreEqual(0, Distance3D.Distance(firstPoint, secondPoint));
        }

        [TestMethod]
        public void PathStorageTest()
        {
            Path testPath = new Path();
            testPath.Add(new Point3D(1, 2, 3));
            testPath.Add(new Point3D(4, 5, 6));
            testPath.Add(new Point3D(7, 8, 9));

            Assert.AreEqual(3, testPath.PathPoints.Count);
        }
    }
}