//-----------------------------------------------------------------------
// <copyright file="BinarySearch.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace AssertionsHomework
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public class BinarySearch
    {
        public static int Search<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Trying to search in a null array!");
            Debug.Assert(arr.Length > 0, "Trying to search in an empty array!");
            Debug.Assert(value != null, "Trying to search for a value that is null!");

            int length = arr.Length;
            for (int index = 0; index < length - 1; index++)
            {
                Debug.Assert(arr[index].CompareTo(arr[index + 1]) <= 0, "Array is not sorted!");
            }

            int indexOfElement = Search(arr, value, 0, arr.Length - 1);

            Debug.Assert(indexOfElement == -1 || arr[indexOfElement].Equals(value), "Found element does not match the sought one!");

            return indexOfElement;
        }

        private static int Search<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Looking for an element in a null array!");
            Debug.Assert(arr.Length > 0, "Looking for an element in an empty array!");
            Debug.Assert(arr.Length != 1, "Looking for an element in array with just one element!");
            Debug.Assert(startIndex >= 0, "startIndex cannot be a negative number!");
            Debug.Assert(endIndex >= 0, "endIndex cannot be a negative number!");
            Debug.Assert(endIndex < arr.Length, "endIndex cannot be greater than the length of the array!");
            Debug.Assert(startIndex <= endIndex, "startIndex cannot be greater than endIndex!");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            Debug.Assert(!arr.Contains(value), "Array contains value but its index wasn't found!");

            // Searched value not found
            return -1;
        }
    }
}
