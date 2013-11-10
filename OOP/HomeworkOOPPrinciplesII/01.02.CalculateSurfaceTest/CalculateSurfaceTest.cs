namespace CalculateSurfaceTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CalculateSurfaceOfShape;

    [TestClass]
    public class CalculateSurfaceTest
    {
        [TestMethod]
        public void ValidInputRectangleTest()
        {
            Rectangle rect = new Rectangle(3.5, 4.5);

            Assert.AreEqual("15.75", string.Format("{0:f2}", rect.CalculateSurface()));
        }

        [TestMethod]
        public void InvalidInputRectangleTest()
        {
            try
            {
                Rectangle rect = new Rectangle(-3.5, 4.5);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Size must be a positive number.", e.Message);
            }
        }

        [TestMethod]
        public void ValidInputTriangleTest()
        {
            Triangle tri = new Triangle(3.5, 4.5);

            Assert.AreEqual("7.875", string.Format("{0:f3}", tri.CalculateSurface()));
        }

        [TestMethod]
        public void InvalidInputTriangleTest()
        {
            try
            {
                Triangle tri = new Triangle(3.5, -4.5);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Size must be a positive number.", e.Message);
            }
        }

        [TestMethod]
        public void ValidInputCircleTest()
        {
            Circle circ = new Circle(3.5);

            Assert.AreEqual("38.4845", string.Format("{0:f4}", circ.CalculateSurface()));
        }

        [TestMethod]
        public void InvalidInputCircleTest()
        {
            try
            {
                Circle circ = new Circle(-3.5);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Size must be a positive number.", e.Message);
            }
        }
    }
}