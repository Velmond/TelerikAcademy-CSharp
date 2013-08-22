//02. Write a program that concatenates two text files into another text file.

namespace ConcatenateTwoFiles
{
    using System;
    using System.IO;

    class ConcatenateTwoFiles
    {
        static void Main()
        {
            using (StreamReader firstInputFile = new StreamReader(@"..\..\Input1.txt"))
            using (StreamReader secondInputFile = new StreamReader(@"..\..\Input2.txt"))
            using (StreamWriter outputFile = new StreamWriter(@"..\..\Output.txt"))
                outputFile.WriteLine(firstInputFile.ReadToEnd() + "\r\n" + secondInputFile.ReadToEnd());
                //The two files are read start to finish and are stuck togheter with a new line inbetween and outputs it all in
                //...the new file

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Done!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}