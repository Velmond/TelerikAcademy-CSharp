// 04. *Write a program to compare the performance of insertion sort, selection sort, quicksort
//     for int, double and string values.
//     Check also the following cases: random values, sorted values, values sorted in reversed order.

namespace PerfOfInsertionSelectionAndQuicksort
{
    using System;
    using System.Diagnostics;

    public class SortingTests
    {
        public static void Main()
        {
            TestIntSorting(100);
            Console.WriteLine();
            TestDoubleSorting(100);
            Console.WriteLine();
            TestStringSorting(36);
        }

        private static void TestIntSorting(int length)
        {
            int[] random = ArrayGenerator.GenerateIntArray(length, "random");
            int[] sorted = ArrayGenerator.GenerateIntArray(length, "sorted");
            int[] reversed = ArrayGenerator.GenerateIntArray(length, "reversed");

            int[] toInsertionSortRandom = new int[length];
            int[] toSelectionSortRandom = new int[length];
            int[] toQuickSortRandom = new int[length];
            int[] toInsertionSortSorted = new int[length];
            int[] toSelectionSortSorted = new int[length];
            int[] toQuickSortSorted = new int[length];
            int[] toInsertionSortReversed = new int[length];
            int[] toSelectionSortReversed = new int[length];
            int[] toQuickSortReversed = new int[length];

            for (int i = 0; i < length; i++)
            {
                toInsertionSortRandom[i] = random[i];
                toSelectionSortRandom[i] = random[i];
                toQuickSortRandom[i] = random[i];
                toInsertionSortSorted[i] = sorted[i];
                toSelectionSortSorted[i] = sorted[i];
                toQuickSortSorted[i] = sorted[i];
                toInsertionSortReversed[i] = reversed[i];
                toSelectionSortReversed[i] = reversed[i];
                toQuickSortReversed[i] = reversed[i];
            }

            Console.WriteLine("SORTING INT ARRAYS:");

            Console.WriteLine("Randomly generated array with {0} element between -1000000 and 1000000.", length);
            PrintTestResults(toInsertionSortRandom, toSelectionSortRandom, toQuickSortRandom);

            Console.WriteLine("Sorted in reversed order array with {0} element between 1000000 and -1000000.", length);
            PrintTestResults(toInsertionSortReversed, toSelectionSortReversed, toQuickSortReversed);

            Console.WriteLine("Sorted array with {0} element between -1000000 and 1000000.", length);
            PrintTestResults(toInsertionSortSorted, toSelectionSortSorted, toQuickSortSorted);
        }

        private static void TestDoubleSorting(int length)
        {
            double[] random = ArrayGenerator.GenerateDoubleArray(length, "random");
            double[] sorted = ArrayGenerator.GenerateDoubleArray(length, "sorted");
            double[] reversed = ArrayGenerator.GenerateDoubleArray(length, "reversed");

            double[] toInsertionSortRandom = new double[length];
            double[] toSelectionSortRandom = new double[length];
            double[] toQuickSortRandom = new double[length];
            double[] toInsertionSortSorted = new double[length];
            double[] toSelectionSortSorted = new double[length];
            double[] toQuickSortSorted = new double[length];
            double[] toInsertionSortReversed = new double[length];
            double[] toSelectionSortReversed = new double[length];
            double[] toQuickSortReversed = new double[length];

            for (int i = 0; i < length; i++)
            {
                toInsertionSortRandom[i] = random[i];
                toSelectionSortRandom[i] = random[i];
                toQuickSortRandom[i] = random[i];
                toInsertionSortSorted[i] = sorted[i];
                toSelectionSortSorted[i] = sorted[i];
                toQuickSortSorted[i] = sorted[i];
                toInsertionSortReversed[i] = reversed[i];
                toSelectionSortReversed[i] = reversed[i];
                toQuickSortReversed[i] = reversed[i];
            }

            Console.WriteLine("SORTING DOUBLE ARRAYS:");

            Console.WriteLine("Randomly generated array with {0} element between -1000000 and 1000000.", length);
            PrintTestResults(toInsertionSortRandom, toSelectionSortRandom, toQuickSortRandom);

            Console.WriteLine("Sorted in reversed order array with {0} element between 1000000 and -1000000.", length);
            PrintTestResults(toInsertionSortReversed, toSelectionSortReversed, toQuickSortReversed);

            Console.WriteLine("Sorted array with {0} element between -1000000 and 1000000.", length);
            PrintTestResults(toInsertionSortSorted, toSelectionSortSorted, toQuickSortSorted);
        }

        private static void TestStringSorting(int length)
        {
            string[] random = ArrayGenerator.GenerateStringArray(length, "random");
            string[] sorted = ArrayGenerator.GenerateStringArray(length, "sorted");
            string[] reversed = ArrayGenerator.GenerateStringArray(length, "reversed");

            string[] toInsertionSortRandom = new string[length];
            string[] toSelectionSortRandom = new string[length];
            string[] toQuickSortRandom = new string[length];
            string[] toInsertionSortSorted = new string[length];
            string[] toSelectionSortSorted = new string[length];
            string[] toQuickSortSorted = new string[length];
            string[] toInsertionSortReversed = new string[length];
            string[] toSelectionSortReversed = new string[length];
            string[] toQuickSortReversed = new string[length];

            for (int i = 0; i < length; i++)
            {
                toInsertionSortRandom[i] = random[i];
                toSelectionSortRandom[i] = random[i];
                toQuickSortRandom[i] = random[i];
                toInsertionSortSorted[i] = sorted[i];
                toSelectionSortSorted[i] = sorted[i];
                toQuickSortSorted[i] = sorted[i];
                toInsertionSortReversed[i] = reversed[i];
                toSelectionSortReversed[i] = reversed[i];
                toQuickSortReversed[i] = reversed[i];
            }

            Console.WriteLine("SORTING STRING ARRAYS:");

            Console.WriteLine("Randomly generated array with {0} element between -1000000 and 1000000.", length);
            PrintTestResults(toInsertionSortRandom, toSelectionSortRandom, toQuickSortRandom);

            Console.WriteLine("Sorted in reversed order array with {0} element between 1000000 and -1000000.", length);
            PrintTestResults(toInsertionSortReversed, toSelectionSortReversed, toQuickSortReversed);

            Console.WriteLine("Sorted array with {0} element between -1000000 and 1000000.", length);
            PrintTestResults(toInsertionSortSorted, toSelectionSortSorted, toQuickSortSorted);
        }

        private static void PrintTestResults<T>(T[] toInsertionSort, T[] toSelectionSort, T[] toQuickSort)
            where T : IComparable<T>
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Sort.InsertionSort(toInsertionSort);
            sw.Stop();
            Console.WriteLine("Insertion sort:\t{0} ms", sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            sw.Start();
            Sort.SelectionSort(toSelectionSort);
            sw.Stop();
            Console.WriteLine("Selection sort:\t{0} ms", sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            sw.Start();
            Sort.QuickSort(toQuickSort, 0, toQuickSort.Length - 1);
            sw.Stop();
            Console.WriteLine("Quick sort:\t{0} ms", sw.Elapsed.TotalMilliseconds);
        }
    }
}
