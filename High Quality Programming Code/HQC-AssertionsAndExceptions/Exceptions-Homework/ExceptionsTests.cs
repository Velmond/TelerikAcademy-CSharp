//-----------------------------------------------------------------------
// <copyright file="ExceptionsTests.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

// 02. Add exception handling (where missing) and refactor all incorrect error handling in the code from the
//     "Exceptions-Homework" project to follow the best practices for using exceptions.

// According to StyleCop only documentation headers need to be added but I'm kinda
// ...pressed on time so I haven't added them. Everything else should be fine.

namespace ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExceptionsTests
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("arr", "Trying to use an array that is null.");
            }

            if (count <= 0 || count > arr.Length - startIndex)
            {
                throw new ArgumentOutOfRangeException("count", "Count must be between 1 and the length of the array beyond the start index.");
            }

            if (startIndex < 0 || startIndex > arr.Length - count)
            {
                throw new ArgumentOutOfRangeException("startIndex", "Start index must be between 0 and the array's length minus the count [0-(Length - count)].");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (str == null)
            {
                throw new ArgumentNullException("str", "Trying to use a string that is null.");
            }

            if (count <= 0 || count > str.Length)
            {
                throw new ArgumentOutOfRangeException("count", "Count must be between 1 and the length of the string.");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool IsPrime(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Can't use CheckPrime(int number) method for negative numbers", "number");
            }

            int maxDivisor = (int)Math.Sqrt(number);
            for (int divisor = 2; divisor <= maxDivisor; divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main()
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            try
            {
                var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
                Console.WriteLine(string.Join(" ", emptyarr));
            }
            catch (ArgumentOutOfRangeException outOfRangeEx)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("EXCEPTION!\nException message: {0}", outOfRangeEx.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));

            try
            {
                Console.WriteLine(ExtractEnding("Hi", 100));
            }
            catch (ArgumentOutOfRangeException outOfRangeEx)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("EXCEPTION!\nException message: {0}", outOfRangeEx.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            int[] numbers = new int[] { 23, 33, -3 };

            foreach (var number in numbers)
            {
                try
                {
                    bool isPrime = IsPrime(number);
                    if (isPrime)
                    {
                        Console.WriteLine("{0} is prime.", number);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not prime.", number);
                    }
                }
                catch (ArgumentException aEx)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("EXCEPTION!\nException message: {0}", aEx.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
