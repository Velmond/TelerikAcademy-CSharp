namespace PerfOfInsertionSelectionAndQuicksort
{
    using System;
    using System.Text;

    public class ArrayGenerator
    {
        internal static int[] GenerateIntArray(int elementsCount, string type)
        {
            int[] array = new int[elementsCount];

            if (type == "sorted")
            {
                FillSortedIntArray(array);
            }
            else if (type == "reversed")
            {
                FillReversedIntArray(array);
            }
            else
            {
                FillIntArray(array);
            }

            return array;
        }

        internal static double[] GenerateDoubleArray(int elementsCount, string type)
        {
            double[] array = new double[elementsCount];

            if (type == "sorted")
            {
                FillSortedDoubleArray(array);
            }
            else if (type == "reversed")
            {
                FillReversedDoubleArray(array);
            }
            else
            {
                FillDoubleArray(array);
            }

            return array;
        }

        internal static string[] GenerateStringArray(int elementsCount, string type)
        {
            string[] array = new string[elementsCount];

            if (type == "sorted")
            {
                FillSortedStringArray(array);
            }
            else if (type == "reversed")
            {
                FillReversedStringArray(array);
            }
            else
            {
                FillStringArray(array);
            }

            return array;
        }

        private static void FillSortedIntArray(int[] array)
        {
            Random random = new Random();
            int length = array.Length;
            int fromLimit = -1000000;
            int step = Math.Abs(2 * fromLimit / array.Length);
            int toLimit = fromLimit + step;

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(fromLimit, toLimit);
                fromLimit = -1000000 + ((i + 1) * step);
                toLimit = -1000000 + ((i + 2) * step);
            }
        }

        private static void FillReversedIntArray(int[] array)
        {
            Random random = new Random();
            int length = array.Length;
            int toLimit = 1000000;
            int step = 2 * toLimit / array.Length;
            int fromLimit = toLimit - step;

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(fromLimit, toLimit);
                fromLimit = 1000000 - ((i + 2) * step);
                toLimit = 1000000 - ((i + 1) * step);
            }
        }

        private static void FillIntArray(int[] array)
        {
            Random random = new Random();
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(-1000000, 1000000);
            }
        }

        private static void FillSortedDoubleArray(double[] array)
        {
            Random random = new Random();
            int length = array.Length;
            int fromLimit = -1000000;
            int step = Math.Abs(2 * fromLimit / array.Length);
            int toLimit = fromLimit + step;
            for (int i = 0; i < length; i++)
            {
                int value = random.Next(fromLimit, toLimit);
                array[i] = value * 1.1111d;
                fromLimit = -1000000 + ((i + 1) * step);
                toLimit = -1000000 + ((i + 2) * step);
            }
        }

        private static void FillReversedDoubleArray(double[] array)
        {
            Random random = new Random();
            int length = array.Length;
            int toLimit = 1000000;
            int step = 2 * toLimit / array.Length;
            int fromLimit = toLimit - step;
            for (int i = 0; i < length; i++)
            {
                int value = random.Next(fromLimit, toLimit);
                array[i] = value * 1.1111d;
                fromLimit = 1000000 - ((i + 2) * step);
                toLimit = 1000000 - ((i + 1) * step);
            }
        }

        private static void FillDoubleArray(double[] array)
        {
            Random random = new Random();
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(-1000000, 1000000) * 1.1111d;
            }
        }

        private static void FillSortedStringArray(string[] array)
        {
            string legalChars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                int numberOfcharsInElement = random.Next(1, 15);
                StringBuilder element = new StringBuilder();
                element.Append(legalChars[i]);
                for (int j = 0; j < numberOfcharsInElement; j++)
                {
                    int charIndex = random.Next(0, 61);
                    element.Append(legalChars[charIndex]);
                }

                array[i] = element.ToString();
            }
        }

        private static void FillReversedStringArray(string[] array)
        {
            string legalChars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                int numberOfcharsInElement = random.Next(1, 15);
                StringBuilder element = new StringBuilder();
                element.Append(legalChars[35 - i]);
                for (int j = 0; j < numberOfcharsInElement; j++)
                {
                    int charIndex = random.Next(0, 61);
                    element.Append(legalChars[charIndex]);
                }

                array[i] = element.ToString();
            }
        }

        private static void FillStringArray(string[] array)
        {
            string legalChars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                int numberOfcharsInElement = random.Next(1, 15);
                StringBuilder element = new StringBuilder();
                for (int j = 0; j < numberOfcharsInElement; j++)
                {
                    int charIndex = random.Next(0, 61);
                    element.Append(legalChars[charIndex]);
                }

                array[i] = element.ToString();
            }
        }
    }
}
