//11. Write a program that deletes from a text file all words that start with the prefix "test". 
//    Words contain only the symbols 0...9, a...z, A…Z, _.

namespace DeleteWordsWithPrefixTest
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    class DeleteWordsWithPrefixTest
    {
        static void Main()
        {
            using (StreamReader input = new StreamReader(@"..\..\Text.txt"))
            using (StreamWriter output = new StreamWriter(@"..\..\Temp.txt"))
            {
                //SOLUTION WITH REGULAR EXPRESSIONS:
                string line = string.Empty;
                StringBuilder outputText = new StringBuilder();

                while ((line = input.ReadLine()) != null)
                {
                    line = Regex.Replace(line, @"\btest\w*\b", String.Empty);
                    //"\btest\w*\b" means [END OF WORD]+"test"+[0 OR MORE LETTERS]+[END OF WORD] in regular expression and this
                    //line replaces for example "I am having a test in physics" with "I am having a  in physics"
                    line = Regex.Replace(line, @"\s\s+", " ");
                    //"\s\s+" means [SPACE] + [1 OR MORE SPACES] in regular expression and this line replaces wherever this is
                    //...found with a single space. E.g. "I am having a  in physics" becomes "I am having a in physics"
                    outputText.Append(line);
                }

                output.WriteLine(outputText.ToString());

                //SOLUTION WITHOUT REGULAR EXPRESSIONS:
                //If you want you can run it with the debugger because it would take too much time explaining this solution.

                //StringBuilder outputText = new StringBuilder();
                //string temp = string.Empty;
                //char currentSymbol = char.MinValue;
                //while ((int)(currentSymbol = (char)input.Read()) != char.MaxValue)
                //{
                //    while (currentSymbol != ' ' && currentSymbol != '\n' && currentSymbol != char.MaxValue)
                //    {
                //        temp += currentSymbol;
                //        currentSymbol = (char)input.Read();
                //        if (temp.ToLower() == "test")
                //        {
                //            while (currentSymbol != ' ' && currentSymbol != '\n' && currentSymbol != char.MaxValue)
                //            {
                //                currentSymbol = (char)input.Read();
                //                continue;
                //            }
                //            temp = string.Empty;
                //        }
                //    }
                //    if (temp != string.Empty && currentSymbol != char.MaxValue)
                //    {
                //        outputText.Append(temp + currentSymbol);
                //        temp = string.Empty;
                //    }
                //    else if (temp != string.Empty && currentSymbol == char.MaxValue)
                //    {
                //        outputText.Append(temp);
                //        temp = string.Empty;
                //    }
                //}
                //output.WriteLine(outputText.ToString());
            }

            File.Copy(@"..\..\Temp.txt", @"..\..\Text.txt", true);  //The temporary file is copied over the input one
            File.Delete(@"..\..\Temp.txt");                     //...overwriting it's original content and the temp.txt is deleted

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Done!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}