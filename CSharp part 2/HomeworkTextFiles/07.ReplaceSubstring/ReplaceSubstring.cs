//07. Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//    Ensure it will work with large files (e.g. 100 MB).

namespace ReplaceSubstring
{
    using System;
    using System.IO;

    class ReplaceSubstring
    {
        static void Main()
        {

            using (StreamReader input = new StreamReader(@"..\..\Input.txt"))
            using (StreamWriter output = new StreamWriter(@"..\..\Output.txt"))
            {
                string line = string.Empty;
                
                while ((line = input.ReadLine()) != null)               //Reads the lines one by one untill we get to the last one
                    output.WriteLine(line.Replace("start", "finish"));  //Directly outputs the line with replaced substrings
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Done!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}