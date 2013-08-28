//24. Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace ArrangeWordsAlphabetically
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class ArrangeWordsAlphabetically
    {
        static void Main()
        {
            string inputString = string.Empty;
            Console.Write("Input a list of words separated by a spaces: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //inputString = Console.ReadLine(); /*
            inputString = @"THE IMPORTANCE OF FREEDOM OF SPEECH Freedom is one of the most precious possessions that we can have. For centuries, men have fought and died for freedom and this is still continuing today. As we all know, there are many in the world who have sacrificed comfort in life and freedom as a result of expressing what is in their hearts. Freedom of speech refers to the right of the individual to express his views about matters of interest to him/her whilst freedom of the press would refer to the freedom of written word in printed form and that BOTH refer to the freedom of THOUGHT and are the outward expressions of our THOUGHTS...";   // */
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Clear();

            List<string> words = new List<string>();

            MatchCollection allWords = Regex.Matches(inputString, @"\w+");  //Split the words into a MatchCollection

            foreach (var word in allWords)
            {
                string wordLowerCase = word.ToString().ToLower();   //Set each word to lower case

                if (!words.Contains(wordLowerCase))
                {
                    words.Add(wordLowerCase);    //Add all the words that have not been added already to tha list
                }
            }

            words.Sort();                       //Sort the list

            foreach (var word in words)         //Print the result
            {
                Console.WriteLine(word);
            }
        }
    }
}
