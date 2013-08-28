//05. You are given a text. Write a program that changes the text in all regions surrounded by 
//    the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
//    Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//    The expected result:
//    We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace SwitchCasesAccordingToTags
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class SwitchCasesAccordingToTags
    {
        static void Main()
        {
            string inputText = string.Empty;

            //For your own input uncomment the lines below:
            //Console.Write("Input the text you need processed (with correct tags): ");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //inputText = Console.ReadLine();
            //Console.ForegroundColor = ConsoleColor.Gray; /*

            inputText = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else."; // */

            string outputText = Regex.Replace(inputText, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper());
            //Replaces the text between the tags with its value turned to upper case

            Console.WriteLine(outputText);
        }
    }
}
