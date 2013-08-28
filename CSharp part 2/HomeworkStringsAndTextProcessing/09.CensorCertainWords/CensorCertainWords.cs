//09. We are given a string containing a list of forbidden words and a text containing some of these words. 
//    Write a program that replaces the forbidden words with asterisks. 
//    Example:
//      Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//    Words: "PHP, CLR, Microsoft"
//    The expected result:
//      ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

namespace CensorCertainWords
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class CensorCertainWords
    {
        static void Main()
        {
            string inputText = string.Empty;
            List<string> forbiddenWords = new List<string>();   //The forbidden words are added to this list

            //For the example in the task description uncomment the lines below (mark them -> Ctrl+K+U):
            //inputText = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            //forbiddenWords = new List<string> { "PHP", "CLR", "Microsoft" };/*

            inputText = "THE IMPORTANCE OF FREEDOM OF SPEECH\nFreedom is one of the most precious possessions that we can have. For centuries, men have fought and died for freedom and this is still continuing today. As we all know, there are many in the world who have sacrificed comfort in life and freedom as a result of expressing what is in their hearts.\nFreedom of speech refers to the right of the individual to express his views about matters of interest to him/her whilst freedom of the press would refer to the freedom of written word in printed form and that BOTH refer to the freedom of THOUGHT and are the outward expressions of our THOUGHTS...";
            forbiddenWords = new List<string> { "freedom", "speech", "express", "right", "rights", "thought", "thoughts" }; // */ // <- You shouldn't touch this if you can't figure out why it's there

            string outputText = inputText;

            for (int i = 0; i < forbiddenWords.Count; i++)
            {
                outputText = CensorWord(outputText, forbiddenWords[i]); //We do this process for each word in the list
            }

            Console.WriteLine("Original text: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(inputText);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Post-processed text: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(outputText);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static string CensorWord(string outputText, string forbiddenWord)
        {
            string pattern = @"\b" + forbiddenWord + @"\b";     //make a pattern for a certain word
            outputText = Regex.Replace(outputText, pattern, new string('*', forbiddenWord.Length), RegexOptions.IgnoreCase);
            //Replace all occurances of the word with a string of "*"s with the lenght of the word itself

            return outputText;
        }
    }
}
