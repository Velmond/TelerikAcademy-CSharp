//20. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace ExtractPalindromes
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractPalindromes
    {

        static void Main()
        {
            string text = @"Some text ABBA. More text lamal, also exe. And don't forget racecar.";

            MatchCollection words = Regex.Matches(text, @"\b\w+\b");    //Splits the string to words

            for (int i = 0; i < words.Count; i++)
            {
                if (WordIsPalindrome(words[i].Value) && words[i].Value.Length > 1)
                {       //Checks if a word is palinddrome and if it's more than 1 character (to avoid the "t" from "don't")
                    Console.WriteLine(words[i]);    //...and prints it on the console
                }
            }

            //I saw this one in another solution of this task and couldn't quite figure it out but I thought it was cool :)
            //words = Regex.Matches(text, @"\b(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))\b");
            //for (int i = 0; i < words.Count; i++)
            //{
            //    Console.WriteLine(words[i].Value);
            //}
        }

        static bool WordIsPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[(word.Length - 1) - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
