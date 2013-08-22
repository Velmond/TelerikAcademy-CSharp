//13. Write a program that reads a list of words from a file words.txt and finds how many times each of the 
//    words is contained in another file test.txt. The result should be written in the file result.txt and 
//    the words should be sorted by the number of their occurrences in descending order. Handle all possible 
//    exceptions in your methods.

namespace FindSomeWordsCountInAFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Security;

    class FindSomeWordsCountInAFile
    {
        static void Main()
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            //Keeps a list of the words and the corresponding number of occurrences

            try
            {
                using (StreamReader wordsInput = new StreamReader(@"..\..\Words.txt"))
                {
                    string word = string.Empty;
                    while ((word = wordsInput.ReadLine()) != null)
                        wordsCount.Add(word, 0);
                        //Adds the words from the file Words.txt to the dictionary with a count of 0 to each one of them
                }

                using (StreamReader input = new StreamReader(@"..\..\Text.txt"))
                {
                    string line = string.Empty;
                    List<string> wordsList = new List<string>(wordsCount.Keys); //Keeps the values of all the needed words

                    while ((line = input.ReadLine()) != null)
                        foreach (string word in wordsList)  //For each of the words in the list, for each line that is read
                        {                                   //...we check and return the number of occurrences in the dictionary
                            string pattern = String.Format(@"\b{0}\b", word);
                            MatchCollection wordCount = Regex.Matches(line, pattern, RegexOptions.IgnoreCase);
                            wordsCount[word] += wordCount.Count;
                        }
                }
            }
            catch (RegexMatchTimeoutException rmte)
            {
                Console.WriteLine(rmte.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine(dnfe.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (OutOfMemoryException oome)
            {
                Console.WriteLine(oome.Message);
            }

            try
            {
                using (StreamWriter result = new StreamWriter(@"..\..\Result.txt"))
                {                               // \/ Sorts the dictionary by the values
                    foreach (var wordCount in wordsCount.OrderByDescending(key => key.Value))
                        result.WriteLine(wordCount.Value.ToString().PadLeft(2) + " - " + wordCount.Key);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Done!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (ObjectDisposedException ode)
            {
                Console.WriteLine(ode.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine(dnfe.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (SecurityException se)
            {
                Console.WriteLine(se.Message);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
        }
    }
}