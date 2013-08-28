//10. Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
//    Sample input:
//      Hi!
//    Expected output:
//      \u0048\u0069\u0021

namespace ReplaceCharsWithUnicodeCode
{
    using System;
    using System.Text;

    class ReplaceCharsWithUnicodeCode
    {
        static void Main()
        {
            Console.WriteLine("Input the string that should be converted to a sequence of Unicode literals:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            StringBuilder output = ProcessInput(input);

            Console.Clear();
            Console.Write("Pre-processing:\t\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Post-processing:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(output);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static StringBuilder ProcessInput(string word)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                output.AppendFormat(@"\u{0:X4}", (int)word[i]);
                //Appends to the stringbuilder the hexadecimal integer corresponding to each letter in the word
            }
            
            return output;
        }
    }
}
