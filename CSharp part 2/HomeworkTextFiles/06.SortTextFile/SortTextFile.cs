//06. Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
//    Example:  Ivan			George
//              Peter	->		Ivan
//              Maria			Maria
//              George		    Peter

namespace SortTextFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class SortTextFile
    {
        static void Main()
        {
            List<string> list = new List<string>();             //Keeps the strings from the file that should be read

            using (StreamReader inputFile = new StreamReader(@"..\..\Input.txt"))
            {
                string line = string.Empty;

                while ((line = inputFile.ReadLine()) != null)   //Reads the file line by line
                    list.Add(line);                             //The string gets added to the list
            }

            list.Sort();        //Sorts the list

            using (StreamWriter output = new StreamWriter(@"..\..\Output.txt"))
                foreach (string line in list)
                    output.WriteLine(line);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Done!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}