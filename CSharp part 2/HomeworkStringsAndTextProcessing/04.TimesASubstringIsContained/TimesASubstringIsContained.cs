//04.Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//   Example: The target substring is "in". The text is as follows:
//            We are living in an yellow submarine. We don't have anything else.
//            Inside the submarine is very tight. So we are drinking all the day.
//            We will move out of it in 5 days.
//   The result is: 9.

using System;
using System.Text.RegularExpressions;

namespace TimesASubstringIsContained
{
    class TimesASubstringIsContained
    {
        static void Main()
        {
            string inputText, substring;

            //For your own input uncomment the lines below:
            //Console.Write("Input the text in which a substring's occurrences will be counted: ");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //inputText = Console.ReadLine();
            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.Write("What substring should the program look for: ");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //substring = Console.ReadLine();
            //Console.ForegroundColor = ConsoleColor.Gray;    /*

            inputText = @"We are living in an yellow submarine. We don't have anything else.
                        Inside the submarine is very tight. So we are drinking all the day.
                        We will move out of it in 5 days.";
            substring = "in";   // */

            int substringCount = Regex.Matches(inputText, substring, RegexOptions.IgnoreCase).Count;

            Console.Write(@"The amount of times the substring ""{0}"" is found in the text is: ", substring);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(substringCount);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}