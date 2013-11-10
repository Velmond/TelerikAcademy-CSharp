//06.01. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//       Use the built-in extension methods and lambda expressions.
//06.02. Rewrite the same with LINQ.

namespace DivisibleBy7And3LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DivisibleBy7And3LINQ
    {
        static void Main()
        {
            int[] array = new int[1000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;               // Fill the array with values from 0 to 999
            }

            var result = from entry in array
                         where (entry % 3 == 0) && (entry % 7 == 0) // Or 'where entry % 21 == 0' but I like it more as it is
                         select entry;      // The LINQ query that's required by the task's description

            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var item in result)   // Write the result on the console
            {
                Console.WriteLine(item);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}