//06.01. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//       Use the built-in extension methods and lambda expressions.
//06.02. Rewrite the same with LINQ.

namespace DivisibleBy7And3Lambda
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DivisibleBy7And3Lambda
    {
        static void Main()
        {
            int[] array = new int[1000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;               // Fill the array with values from 0 to 999
            }

            var result = array.Where(entry => (entry % 3 == 0) && (entry % 7 == 0));    // The lambda expression that's required
            // Or it can be 'array.Where(entry => entry % 21 == 0);' but I like it more as it is

            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var item in result)   // Write the result on the console
            {
                Console.WriteLine(item);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}