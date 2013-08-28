//22. Write a program that reads a string from the console and lists all different words in the string 
//    along with information how many times each word is found.

namespace RepetitionsOfWordsInString
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class RepetitionsOfWordsInString
    {
        static void Main()
        {
            //The solution is the same as the previous one but is case insensitive
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string inputString = string.Empty;

            Console.WriteLine("Input a string to get the number of times each word is used in it.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //inputString = Console.ReadLine();   /*
            inputString = @"THE IMPORTANCE OF FREEDOM OF SPEECH Freedom is one of the most precious possessions that we can have. For centuries, men have fought and died for freedom and this is still continuing today. As we all know, there are many in the world who have sacrificed comfort in life and freedom as a result of expressing what is in their hearts. Freedom of speech refers to the right of the individual to express his views about matters of interest to him/her whilst freedom of the press would refer to the freedom of written word in printed form and that BOTH refer to the freedom of THOUGHT and are the outward expressions of our THOUGHTS...";   // */
            Console.ForegroundColor = ConsoleColor.Gray;

            MatchCollection words = Regex.Matches(inputString, @"\w+"); //Split the string in separate words

            for (int i = 0; i < words.Count; i++)
            {
                string word = words[i].Value.ToLower(); //Set the word to lower case so the dictionary doesn't have 3 entries for 
                                                        //... the word "freedom" for example ("FREEDOM", "Freedom" and "freedom")
                if (wordCount.ContainsKey(word))    //If word is in the dictionary, add 1 to its value
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount.Add(word, 1);         //Else add it to the dictionary with a value of 1
                }
            }

            Console.Clear();
            foreach (var word in wordCount)         //Print the result to the console
            {
                Console.WriteLine("{0} -> {1}", word.Key, word.Value);
            }
        }
    }
}
