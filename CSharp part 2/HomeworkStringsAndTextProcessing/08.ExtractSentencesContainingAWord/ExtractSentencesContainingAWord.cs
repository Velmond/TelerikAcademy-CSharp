//08. Write a program that extracts from a given text all sentences containing given word.
//    Example: The word is "in". The text is:
//      We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//    The expected result is:
//      We are living in a yellow submarine.
//      We will move out of it in 5 days.
//    Consider that the sentences are separated by "." and the words – by non-letter symbols.

namespace ExtractSentencesContainingAWord
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractSentencesContainingAWord
    {
        static void Main()
        {
            string inputText = string.Empty;

            //To use your own input and key uncomment the lines below:
            //Console.WriteLine("Input the text you want the sentences extracted: ");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //inputText = Console.ReadLine();
            //Console.ForegroundColor = ConsoleColor.Gray; /*
            inputText = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."; // */

            string[] sentences = inputText.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            //Separates the sentences in a string array by "."s as is pointed in the task's edscriptions

            Console.Clear();
            for (int i = 0; i < sentences.Length; i++)
            {
                if (Regex.IsMatch(sentences[i], @"\bin\b", RegexOptions.IgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;  //If the sentence has the word "in" in it, it gets printed on 
                    Console.WriteLine(sentences[i].Trim() + ".");   //...the console with a "." as it has been removed when the 
                    Console.ForegroundColor = ConsoleColor.Gray;    //...sentences were separated
                }
            }
        }
    }
}