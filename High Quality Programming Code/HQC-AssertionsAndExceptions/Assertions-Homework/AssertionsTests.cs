//-----------------------------------------------------------------------
// <copyright file="AssertionsTests.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

// 01. Add assertions in the code from the project "Assertions-Homework" to ensure all possible preconditions
//     and postconditions are checked.

// According to StyleCop only documentation headers need to be added but I'm kinda
// ...pressed on time so I haven't added them. Everything else should be fine.

namespace AssertionsHomework
{
    using System;

    public class AssertionsTests
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SelectionSort.Sort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SelectionSort.Sort(new int[0]); // Test sorting empty array
            //// "Trying to sort an empty array!" warning
            SelectionSort.Sort(new int[1]); // Test sorting single element array
            //// "Trying to sort an array with just one element!" warning

            Console.WriteLine(BinarySearch.Search(arr, -1000));
            Console.WriteLine(BinarySearch.Search(arr, 0));
            Console.WriteLine(BinarySearch.Search(arr, 17));
            Console.WriteLine(BinarySearch.Search(arr, 10));
            Console.WriteLine(BinarySearch.Search(arr, 1000));

            Console.WriteLine(BinarySearch.Search(new int[0], 1));
            //// "Trying to search in an empty array!" warning
            //// "Looking for an element in an empty array!" warning
            //// "endIndex cannot be a negative number!" warning because it is: arr.Length - 1 = 0 - 1 = -1
            //// "startIndex cannot be greater than endIndex!" warning because it is: endIndex = -1 and startIndex = 0
        }
    }
}
