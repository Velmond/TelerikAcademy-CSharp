//08. Modify the solution of the previous problem to replace only whole words (not substrings).

namespace ReplaceWords
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class ReplaceWords
    {
        static void Main()
        {

            using (StreamReader input = new StreamReader(@"..\..\Input.txt"))
            using (StreamWriter output = new StreamWriter(@"..\..\Output.txt"))
            {
                string line = string.Empty;
                
                while ((line = input.ReadLine()) != null)       //Reads the lines one by one untill we get to the last one
                    output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    //Directly outputs the line with replaced words ("\b" indicates the end of a word in regular expressions)
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Done!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}