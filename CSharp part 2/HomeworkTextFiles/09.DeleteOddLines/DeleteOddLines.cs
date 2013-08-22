//09. Write a program that deletes from given text file all odd lines. The result should be in the same file.

namespace DeleteOddLines
{
    using System;
    using System.IO;

    class DeleteOddLines
    {
        static void Main()
        {
            using (StreamReader input = new StreamReader(@"..\..\InputOutput.txt"))
            using (StreamWriter temp = new StreamWriter(@"..\..\Temp.tmp"))
            {
                string line = string.Empty;     //Keeps the lines one by one
                int lineNumber = 0;             //Keeps the number of the line

                while ((line = input.ReadLine()) != null)
                {
                    lineNumber++;               //Increases the line number

                    if (lineNumber % 2 == 0)    //The line is outputed to the temporary file only if the number is even
                        temp.WriteLine(line);   //... i.e. the odd ones are left out
                }
            }

            File.Copy(@"..\..\Temp.tmp", @"..\..\InputOutput.txt", true);   //The temporary file is copied over the input one
            File.Delete(@"..\..\Temp.tmp");                     //...overwriting it's original content and the temp.txt is deleted

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Done!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}