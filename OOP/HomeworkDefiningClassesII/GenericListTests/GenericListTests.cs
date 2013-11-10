namespace GenericListTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using GenericList;

    [TestClass]
    public class GenericListTests
    {
        // To run all the unit tests press [Ctrl+R, A] or go to [TEST -> Run -> All Tests]
        // If the results don't show up go to [TEST -> Windows -> Test Explorer]
        
        [TestMethod]
        public void EmptyListDefaultCapacityTest()
        {
            GenericList<int> list = new GenericList<int>();

            Assert.AreEqual((uint)0, list.Count);
            Assert.AreEqual((uint)4, list.Capacity);
        }

        [TestMethod]
        public void EmptyListSetCapacityTest()
        {
            GenericList<int> list = new GenericList<int>(17);

            Assert.AreEqual((uint)0, list.Count);
            Assert.AreEqual((uint)17, list.Capacity);
        }

        [TestMethod]
        public void FullListElementsTest()
        {
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 4; i++)
            {
                list.Add(i);
            }

            Assert.AreEqual((uint)4, list.Count);
            Assert.AreEqual((uint)4, list.Capacity);
        }

        [TestMethod]
        public void ResizedListElementsTest()
        {
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            Assert.AreEqual((uint)5, list.Count);
            Assert.AreEqual((uint)8, list.Capacity);
        }

        [TestMethod]
        public void GetAtIndexTest()
        {
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < 100; i++)
            {
                Assert.AreEqual(i, list[i]);
            }
        }

        [TestMethod]
        public void SetAtIndexTest()
        {
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(0);
            }

            for (int i = 0; i < 100; i++)
            {
                list[i] = i;
            }

            for (int i = 0; i < 100; i++)
            {
                Assert.AreEqual(i, list[i]);
            }
        }

        [TestMethod]
        public void RemoveAtTest()
        {
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                list.RemoveAt(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(((i + 1) * 2) - 1, list[i]);
            }

            // 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 ...
            // ^   ^   ^   ^   ^   ^     ^     ^     ^     ^     ^     ^     ^     ^     ^
            // i = 0 < Count = 100  (-> 99)
            // 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 ...
            //   ^   ^   ^   ^   ^     ^     ^     ^     ^     ^     ^     ^     ^     ^
            // i = 1 < Count = 99  (-> 98)
            // 1 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 ...
            //     ^   ^   ^   ^     ^     ^     ^     ^     ^     ^     ^     ^     ^
            // i = 2 < Count = 98  (-> 97)
            // ...
            // 1 3 5 7 9 11 13 15 17 19 21 23 ... 79 81 83 85 87 89 91 93 95 97 98 99
            //                                                                  ^
            // i = 49 < Count = 51  (-> 50)
            // 1 3 5 7 9 11 13 15 ... 83 85 87 89 91 93 95 97 99
            // i = 50 == Count = 50
        }

        [TestMethod]
        public void InsertTest()
        {
            GenericList<int> list = new GenericList<int>();
            list.Add(0);

            for (int i = 0; i < list.Count; i++)
            {
                if (i < 99)
                {
                    list.Insert(0, i + 1);
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(99 - i, list[i]);
            }

            // 0
            // i = 0 < Count = 1
            // 1 0                                  // i + 1 = 1
            // i = 1 < Count = 2
            // 2 1 0                                // i + 1 = 2
            // i = 2 < Count = 3
            // 3 2 1 0                              // i + 1 = 3
            // i = 3 < Count = 4
            // 4 3 2 1 0                            // i + 1 = 4
            // ...
            // i = 99 < Count = 100
            // 100 99 98 97 96 95 ... 5 4 3 2 1 0   // i + 1 = 100
            // Break so that we don't end up in an infinite loop

            // Finale list:
            // Index:   0  1  2  3  4  5  6  7  8  9 10 11 ... 89 90 91 92 93 94 95 96 97 98 99 100
            // Value: 100 99 98 97 96 95 94 93 92 91 90 89 ... 11 10  9  8  7  6  5  4  3  2  1   0
        }

        [TestMethod]
        public void ClearTest()
        {
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            list.Clear();

            Assert.AreEqual((uint)0, list.Count);
            Assert.AreEqual((uint)4, list.Capacity);
        }

        [TestMethod]
        public void FindTest()
        {
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            Assert.AreEqual(0, list.Find(0));
            Assert.AreEqual(64, list.Find(64));
            Assert.AreEqual(99, list.Find(99));
            Assert.AreEqual(-1, list.Find(100));
        }

        [TestMethod]
        public void ToStringTest()
        {
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            string expected = "0 1 2 3 4 5 6 7 8 9";

            Assert.AreEqual(expected, list.ToString());
        }

        [TestMethod]
        public void MinTest()
        {
            GenericList<int> list = new GenericList<int>();

            list.Add(100);
            list.Add(-123);
            list.Add(54);
            list.Add(25);
            list.Add(-15);
            list.Add(35);
            list.Add(-53);
            list.Add(123);

            Assert.AreEqual(-123, list.Min<int>());
        }

        [TestMethod]
        public void MaxTest()
        {
            GenericList<int> list = new GenericList<int>();

            list.Add(100);
            list.Add(-123);
            list.Add(54);
            list.Add(25);
            list.Add(-15);
            list.Add(35);
            list.Add(-53);
            list.Add(123);

            Assert.AreEqual(123, list.Max<int>());
        }
    }
}