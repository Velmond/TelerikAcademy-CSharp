//04.01. Write a method that counts how many times given number appears in given array.
//04.02. Write a test program to check if the method is working correctly.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class TestingMaxCouter
{
    [TestMethod]
    public void AllPositiveNumbers()
    {
        int[] array = { 1, 5, 2, 5, 3, 3, 7, 4, 6, 8, 5, 8, 4, 3, 3, 0, 8, 6, 8, 6, 9, 0, 7, 8, 6, 9, 5, 4, 7 };
        int maxCount = CountRepetitionsOfANumber.GetNumberOfRepetitions(array);
        Assert.AreEqual(maxCount, 5);
    }
    [TestMethod]
    public void SomeNegativeNumbers()
    {
        int[] array = { 1, -5, 2, 5, -3, 3, -7, 4, -6, -8, 5, 8, -4, 3, 3, 0, 8, -6, 8, 6, -9, 0, 7, 8, 6, 9, -5, 4, 7 };
        int maxCount = CountRepetitionsOfANumber.GetNumberOfRepetitions(array);
        Assert.AreEqual(maxCount, 4);
    }
    [TestMethod]
    public void AllNegativeNumbers()
    {
        int[] array = { -1, -5, -2, -5, -3, -3, -7, -4, -6, -8, -5, -8, -4, -3, -3, 
                         0, -8, -6, -8, -6, -9,  0, -7, -8, -6, -9, -5, -4, -7 };
        int maxCount = CountRepetitionsOfANumber.GetNumberOfRepetitions(array);
        Assert.AreEqual(maxCount, 5);
    }
}