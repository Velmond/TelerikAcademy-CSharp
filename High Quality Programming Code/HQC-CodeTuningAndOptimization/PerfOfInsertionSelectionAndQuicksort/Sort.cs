namespace PerfOfInsertionSelectionAndQuicksort
{
    using System;

    public static class Sort
    {
        public static void InsertionSort<T>(T[] arr)
            where T : IComparable<T>
        {
            int length = arr.Length;

            for (int i = 1; i < length; i++)
            {
                int previousIndex = i - 1;
                T element = arr[i];

                while (element.CompareTo(arr[previousIndex]) < 0)
                {
                    arr[previousIndex + 1] = arr[previousIndex];
                    previousIndex--;

                    if (previousIndex < 0)
                    {
                        break;
                    }
                }

                arr[previousIndex + 1] = element;
            }
        }

        public static void SelectionSort<T>(T[] arr)
            where T : IComparable<T>
        {
            int length = arr.Length;

            for (int index = 0; index < length; index++)
            {
                int minIndex = index;

                for (int i = index + 1; i < length; i++)
                {
                    if (arr[i].CompareTo(arr[minIndex]) < 0)
                    {
                        minIndex = i;
                    }
                }

                SwapValues(ref arr[index], ref arr[minIndex]);
            }
        }

        public static void QuickSort<T>(T[] arr, int leftLimit, int rightLimit)
           where T : IComparable<T>
        {
            int leftIndex = leftLimit;
            int rightIndex = rightLimit;
            int middleIndex = (leftLimit + rightLimit) / 2;
            T middleElement = arr[middleIndex];

            while (leftIndex <= rightIndex)
            {
                while (arr[leftIndex].CompareTo(middleElement) < 0)
                {
                    leftIndex++;
                }

                while (arr[rightIndex].CompareTo(middleElement) > 0)
                {
                    rightIndex--;
                }

                if (leftIndex <= rightIndex)
                {
                    SwapValues(ref arr[leftIndex], ref arr[rightIndex]);
                    leftIndex++;
                    rightIndex--;
                }
            }

            if (leftLimit < rightIndex)
            {
                QuickSort(arr, leftLimit, rightIndex);
            }

            if (leftIndex < rightLimit)
            {
                QuickSort(arr, leftIndex, rightLimit);
            }

            ////function quicksort(array)
            ////    if length(array) > 1
            ////        pivot := select any element of array
            ////        left := first index of array
            ////        right := last index of array
            ////        while left ≤ right
            ////            while array[left] < pivot
            ////                left := left + 1
            ////            while array[right] > pivot
            ////                right := right - 1
            ////            if left ≤ right
            ////                swap array[left] with array[right]
            ////                left := left + 1
            ////                right := right - 1
            ////        quicksort(array from first index to right)
            ////        quicksort(array from left to last index)
        }

        private static void SwapValues<T>(ref T firstValue, ref T secondValue)
            where T : IComparable<T>
        {
            T bufferValue = firstValue;
            firstValue = secondValue;
            secondValue = bufferValue;
        }
    }
}
