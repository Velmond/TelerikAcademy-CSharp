//-----------------------------------------------------------------------
// <copyright file="SelectionSort.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace AssertionsHomework
{
    using System;
    using System.Diagnostics;

    public class SelectionSort
    {
        public static void Sort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Trying to sort a null array!");
            Debug.Assert(arr.Length > 0, "Trying to sort an empty array!");
            Debug.Assert(arr.Length != 1, "Trying to sort array with just one element!");

            int length = arr.Length;
            for (int index = 0; index < length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            for (int index = 0; index < length - 1; index++)
            {
                Debug.Assert(arr[index].CompareTo(arr[index + 1]) <= 0, "Array did not get sorted!");
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Looking for the minimum element in a null array!");
            Debug.Assert(arr.Length > 0, "Looking for the minimum element in an empty array!");
            Debug.Assert(arr.Length != 1, "Looking for the minimum element in array with just one element!");
            Debug.Assert(startIndex >= 0, "startIndex cannot be a negative number!");
            Debug.Assert(endIndex >= 0, "endIndex cannot be a negative number!");
            Debug.Assert(endIndex < arr.Length, "endIndex cannot be greater than the length of the array!");
            Debug.Assert(startIndex < endIndex, "startIndex cannot be greater than endIndex!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            for (int index = startIndex + 1; index <= endIndex; index++)
            {
                Debug.Assert(arr[minElementIndex].CompareTo(arr[index]) <= 0, "Found element is not the smallest!");
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null, "x must be a non null value!");
            Debug.Assert(y != null, "y must be a non null value!");

            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
