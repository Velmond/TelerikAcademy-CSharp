namespace IEnumerableTExtensionsTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using IEnumerableTExtensions;

    [TestClass]
    public class IEnumerableTExtensionsTests
    {
        [TestMethod]
        public void SumTest()
        {
            List<int> posIntList = new List<int>();
            List<int> intList = new List<int>();
            List<decimal> posDecimalList = new List<decimal>();
            List<decimal> decimalList = new List<decimal>();
            int sign = -1;

            for (int i = 0; i < 10; i++)
            {
                posIntList.Add(i + 1);
                intList.Add((i + 1) * sign);
                posDecimalList.Add((i + 1) / 10m);
                decimalList.Add(((i + 1) / 10m) * sign);
                sign *= -1;
            }

            Assert.AreEqual(55, posIntList.Sum());
            Assert.AreEqual(5, intList.Sum());
            Assert.AreEqual(5.5m, posDecimalList.Sum());
            Assert.AreEqual(.5m, decimalList.Sum());
        }

        [TestMethod]
        public void ProductTest()
        {
            List<int> posIntList = new List<int>();
            List<int> intList = new List<int>();
            List<decimal> posDecimalList = new List<decimal>();
            List<decimal> decimalList = new List<decimal>();
            int sign = -1;

            for (int i = 0; i < 10; i++)
            {
                posIntList.Add(i + 1);
                intList.Add((i + 1) * sign);
                posDecimalList.Add((i + 1) / 10m);
                decimalList.Add(((i + 1) / 10m) * sign);
                sign *= -1;
            }

            Assert.AreEqual(3628800, posIntList.Product());
            Assert.AreEqual(-3628800, intList.Product());
            Assert.AreEqual(.00036288m, posDecimalList.Product());
            Assert.AreEqual(-.00036288m, decimalList.Product());
        }

        [TestMethod]
        public void MinTest()
        {
            List<int> posIntList = new List<int>();
            List<int> intList = new List<int>();
            List<decimal> posDecimalList = new List<decimal>();
            List<decimal> decimalList = new List<decimal>();
            int sign = -1;

            for (int i = 0; i < 10; i++)
            {
                posIntList.Add(i + 1);
                intList.Add((i + 1) * sign);
                posDecimalList.Add((i + 1) / 10m);
                decimalList.Add(((i + 1) / 10m) * sign);
                sign *= -1;
            }

            Assert.AreEqual(1, posIntList.Min());
            Assert.AreEqual(-9, intList.Min());
            Assert.AreEqual(.1m, posDecimalList.Min());
            Assert.AreEqual(-.9m, decimalList.Min());
        }

        [TestMethod]
        public void MaxTest()
        {
            List<int> posIntList = new List<int>();
            List<int> intList = new List<int>();
            List<decimal> posDecimalList = new List<decimal>();
            List<decimal> decimalList = new List<decimal>();
            int sign = -1;

            for (int i = 0; i < 10; i++)
            {
                posIntList.Add(i + 1);
                intList.Add((i + 1) * sign);
                posDecimalList.Add((i + 1) / 10m);
                decimalList.Add(((i + 1) / 10m) * sign);
                sign *= -1;
            }

            Assert.AreEqual(10, posIntList.Max());
            Assert.AreEqual(10, intList.Max());
            Assert.AreEqual(1.0m, posDecimalList.Max());
            Assert.AreEqual(1.0m, decimalList.Max());
        }

        [TestMethod]
        public void AverageTest()
        {
            List<int> posIntList = new List<int>();
            List<int> intList = new List<int>();
            List<decimal> posDecimalList = new List<decimal>();
            List<decimal> decimalList = new List<decimal>();
            int sign = -1;

            for (int i = 0; i < 10; i++)
            {
                posIntList.Add(i + 1);
                intList.Add((i + 1) * sign);
                posDecimalList.Add((i + 1) / 10m);
                decimalList.Add(((i + 1) / 10m) * sign);
                sign *= -1;
            }

            Assert.AreEqual(5, posIntList.Average());
            Assert.AreEqual(0, intList.Average());
            Assert.AreEqual(.55m, posDecimalList.Average());
            Assert.AreEqual(.05m, decimalList.Average());
        }

        [TestMethod]
        public void EmptyCollectionTest()
        {
            List<int> list = new List<int>();

            try
            {
                list.Sum();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(e.Message, string.Format("{0} is empty", list.GetType()));
            }
        }
    }
}