//01. Implement an extension method Substring(int index, int length) for the class StringBuilder that returns
//    new StringBuilder and has the same functionality as Substring in the class String.

namespace StringBuilderSubstringExtension
{
    using System;
    using System.Text;

    public static class SubstringExtension
    {
        public static string Substring(this StringBuilder sb, int startIndex, int length)
        {
            if ((startIndex >= 0 && startIndex < sb.Length) && startIndex + length <= sb.Length)    // If input values are correct
            {
                StringBuilder result = new StringBuilder();     // I use a new StringBuilder. Another option would be
                //                                              // ... turning sb to string and getting the substring using
                for (int i = 0; i < length; i++)                // ... the existent Substring() method for the string class
                {
                    result.Append(sb[startIndex + i]);
                }

                return result.ToString();
            }
            else if (startIndex < 0 || startIndex > sb.Length - 1)  // If input values are incorrect
            {
                throw new IndexOutOfRangeException(string.Format("Starting index must be between 0 and {0}", sb.Length - 1));
            }
            else
            {
                throw new ArgumentException(string.Format("StringBuilder has less than {0} symbols.", startIndex + length));
            }
        }

        public static string Substring(this StringBuilder sb, int startIndex)
        {
            if (startIndex >= 0 && startIndex < sb.Length)  // If startIndex value is correct
            {
                StringBuilder result = new StringBuilder();

                for (int i = startIndex; i < sb.Length; i++)
                {
                    result.Append(sb[i]);
                }

                return result.ToString();
            }
            else    // If startIndex value is incorrect
            {
                throw new IndexOutOfRangeException(string.Format("Starting index must be between 0 and {0}", sb.Length - 1));
            }
        }
    }
}