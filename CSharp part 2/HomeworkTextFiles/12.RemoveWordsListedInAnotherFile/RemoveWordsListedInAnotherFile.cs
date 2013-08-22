//12. Write a program that removes from a text file all words listed in given another text file. 
//    Handle all possible exceptions in your methods.

namespace RemoveWordsListedInAnotherFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security;
    using System.Text;
    using System.Text.RegularExpressions;

    class RemoveWordsListedInAnotherFile
    {
        static void Main()
        {
            try
            {
                using (StreamReader text = new StreamReader(@"..\..\Text.txt"))
                using (StreamWriter output = new StreamWriter(@"..\..\Temp.txt"))
                {
                    string line = string.Empty;
                    List<string> outputLines = new List<string>();

                    string pattern = @"\b(" + String.Join("|", File.ReadAllLines("../../Words.txt")) + @")\b";
                    //The following pattern is built - \b(firstWord|secondWord|thirdWord|...|lastWord)\b

                    while ((line = text.ReadLine()) != null)
                    {
                        line = Regex.Replace(line, pattern, string.Empty);
                        //line = Regex.Replace(line, pattern, "-X-");
                        //If you need to see where the removed words are decomment the line above and instead of empty 
                        //...strings the words will be replaced with "-X-"
                        line = Regex.Replace(line, @"\s\s+", " ");
                        outputLines.Add(line);
                    }

                    foreach (string lines in outputLines)
                    {
                        output.WriteLine(lines);
                        //Console.WriteLine(lines);
                        //If you want the result on the console too decomment the line above
                    }
                }

                File.Copy(@"..\..\Temp.txt", @"..\..\Text.txt", true);  //The temporary file is copied over the input one
                File.Delete(@"..\..\Temp.txt");                 //...overwriting it's original content and the temp.txt is deleted

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Done!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (RegexMatchTimeoutException rmte)
            {
                Console.WriteLine(rmte.Message);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (PathTooLongException ptle)
            {
                Console.WriteLine(ptle.Message);
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
            catch (SecurityException se)
            {
                Console.WriteLine(se.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
        }
    }
}