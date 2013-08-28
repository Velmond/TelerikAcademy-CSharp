//23. Write a program that reads a string from the console and replaces all series of 
//    consecutive identical letters with a single one. 
//      Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".

namespace RemoveRepeatingLetters
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class RemoveRepeatingLetters
    {
        static void Main()
        {
            string input = string.Empty;
            Console.Write("Input a string: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //input = Console.ReadLine(); /*
            input = @"aaaaabbbbbcdddeeeedssaa";   // */
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Clear();

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];   //Keeps the current character

                if ((i > 0 && currChar != input[i - 1]) || (i == 0))//For every character after the first one only if it's
                {                                                   //...different than the previous one it gets appended to
                    output.Append(currChar);                        //...the stringbuilder.
                }
            }

            Console.Write("Input: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("After removing the characters repeating in a sequence we get: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(output);
            Console.ForegroundColor = ConsoleColor.Gray;

            //With regular expressions:
            string outputWithRegex = Regex.Replace(input, @"(\w)\1+", "$1");
            //See how it works at http://regex101.com/
            Console.Write("Solution with regular expressions: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(outputWithRegex);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
