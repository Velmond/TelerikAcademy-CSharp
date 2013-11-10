namespace StringBuilderSubstringExtensionTests
{
    using System;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StringBuilderSubstringExtension;

    [TestClass]
    public class StringBuilderSubstringExtensionTests
    {
        [TestMethod]
        public void FromSomeIndexToEndOfStringTest()
        {
            StringBuilder sb = new StringBuilder();

            for (char i = 'a'; i <= 'z'; i++)
            {
                sb.Append(i);
            }

            string expected = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < sb.Length; i++)
            {
                Assert.AreEqual(expected.Substring(i), sb.Substring(i));
                Assert.AreEqual(expected.Substring(i, sb.Length - i), sb.Substring(i, sb.Length - i));
            }
        }

        [TestMethod]
        public void SomeNumberOfCharsFromSomeIndexTest()
        {
            StringBuilder sb = new StringBuilder();

            for (char i = 'a'; i <= 'z'; i++)
            {
                sb.Append(i);
            }

            string expected = "abcdefghijklmnopqrstuvwxyz";

            for (int length = 0; length < sb.Length; length++)
            {
                for (int startIndex = 0; startIndex < sb.Length - length; startIndex++)
                {
                    Assert.AreEqual(expected.Substring(startIndex, length), sb.Substring(startIndex, length));
                }
            }
        }

        [TestMethod]
        public void InvalidStartingIndexTest()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("a");

            try
            {
                sb.Substring(-1);
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.AreEqual(string.Format("Starting index must be between 0 and {0}", sb.Length - 1), e.Message);
            }
        }

        [TestMethod]
        public void InvalidLengthTest()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("a");
            int invalidLength = 50;

            try
            {
                sb.Substring(0, invalidLength);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(string.Format("StringBuilder has less than {0} symbols.", invalidLength), e.Message);
            }
        }
    }
}