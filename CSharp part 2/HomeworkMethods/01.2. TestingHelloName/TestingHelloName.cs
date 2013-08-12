//01.01. Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
//01.02. Write a program to test this method.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class TestingHelloName
{
    [TestMethod]
    public void TestPeter()
    {
        string name = "Peter";
        string result = HelloName.AskName(name);
        Assert.AreEqual(result, "Hello, Peter!");
    }
    [TestMethod]
    public void TestMaria()
    {
        string name = "Maria";
        string result = HelloName.AskName(name);
        Assert.AreEqual(result, "Hello, Maria!");
    }
    [TestMethod]
    public void TestBatman()
    {
        string name = "Batman";
        string result = HelloName.AskName(name);
        Assert.AreEqual(result, "Hello, Batman!");
    }
}
