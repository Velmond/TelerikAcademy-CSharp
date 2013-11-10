//02. Implement a set of extension methods for IEnumerable<T> that implement the following group 
//    functions: sum, product, min, max, average.

namespace IEnumerableTExtensions
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableTExtensions
    {
        public static T Sum<T>(this IEnumerable<T> iEnum)
            where T : IComparable<T>
        {
            if (!iEnum.CollectionIsEmpty()) // If collection is not empty go through the the required operations
            {
                dynamic result = 0;

                foreach (var item in iEnum) // Go through the elements and sum them one by one
                {
                    result += item;
                }

                return result;
            }
            else                            // If collection is empty throw an exception
            {
                throw new ArgumentException(string.Format("{0} is empty", iEnum.GetType()));
            }
        }

        public static T Product<T>(this IEnumerable<T> iEnum)
            where T : IComparable<T>
        {
            if (!iEnum.CollectionIsEmpty()) // If collection is not empty go through the the required operations
            {
                dynamic result = 1;

                foreach (var item in iEnum) // Go through the elements and multiply them one by one
                {
                    result *= item;
                }

                return result;
            }
            else                            // If collection is empty throw an exception
            {
                throw new ArgumentException(string.Format("{0} is empty", iEnum.GetType()));
            }
        }

        public static T Min<T>(this IEnumerable<T> iEnum)
            where T : IComparable<T>
        {
            if (!iEnum.CollectionIsEmpty())         // If collection is not empty go through the the required operations
            {
                dynamic min = int.MaxValue;

                foreach (var item in iEnum)         // Go through the elements one by one to see if some is smaller than min
                {
                    if (item.CompareTo(min) == -1)  // Since T must be IComparable<T> all items in iEnum must have 'CompareTo' method
                    {
                        min = item;
                    }
                }

                return min;
            }
            else                                    // If collection is empty throw an exception
            {
                throw new ArgumentException(string.Format("{0} is empty", iEnum.GetType()));
            }
        }

        public static T Max<T>(this IEnumerable<T> iEnum)
            where T : IComparable<T>
        {
            if (!iEnum.CollectionIsEmpty())         // If collection is not empty go through the the required operations
            {
                dynamic max = int.MinValue;

                foreach (var item in iEnum)         // Go through the elements one by one to see if some is grater than max
                {
                    if (item.CompareTo(max) == 1)   // Since T must be IComparable<T> all items in iEnum must have 'CompareTo' method
                    {
                        max = item;
                    }
                }

                return max;
            }
            else                                    // If collection is empty throw an exception
            {
                throw new ArgumentException(string.Format("{0} is empty", iEnum.GetType()));
            }
        }

        public static T Average<T>(this IEnumerable<T> iEnum)
            where T : IComparable<T>
        {
            if (!iEnum.CollectionIsEmpty()) // If collection is not empty go through the the required operations
            {
                dynamic sum = 0;
                int elementsCount = 0;

                foreach (var item in iEnum) // Go through the elements sum them one by one and also to determine their count
                {
                    sum += item;
                    elementsCount++;
                }

                return (sum / elementsCount);
            }
            else                            // If collection is empty throw an exception
            {
                throw new ArgumentException(string.Format("{0} is empty", iEnum.GetType()));
            }
        }

        // Check if collection is empty before doing something with it to avoid getting
        // ... wrong results (0 for sum, 1 for multiplication etc.)
        private static bool CollectionIsEmpty<T>(this IEnumerable<T> iEnum) where T : IComparable<T>
        {
            //if (!typeof(T).IsPrimitive ||
            //    typeof(T) != typeof(decimal) ||
            //    typeof(T) == typeof(char) ||
            //    typeof(T) == typeof(DateTime) ||
            //    typeof(T) == typeof(bool))
            //{
            //    throw new ArgumentException(string.Format("Unacceptable type {0}", typeof(T)));
            //}

            int elementsCount = 0;

            foreach (var item in iEnum) // I couldn't think of another way to do it other than foreach even though I only
            {                           // ... need the first element to say if the collection is empty or not
                elementsCount++;

                if (elementsCount > 0)  // To avoid needless going through all elements, once I get to elementsCount = 1 I
                {                       // ... break out of the cicle.
                    break;
                }
            }

            if (elementsCount > 0)
            {
                return false;   // If collection is full
            }
            else
            {
                return true;    // If collection is empty
            }
        }
    }
}