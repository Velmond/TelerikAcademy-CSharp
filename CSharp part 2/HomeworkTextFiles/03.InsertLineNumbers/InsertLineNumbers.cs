//03. Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//    The result should be written to another text file.

namespace InsertLineNumbers
{
    using System;
    using System.IO;

    class InsertLineNumbers
    {
        static void Main()
        {
            using (StreamReader inputText = new StreamReader(@"..\..\Input.txt"))
            using (StreamWriter outputText = new StreamWriter(@"..\..\Output.txt"))
            {
                string line = string.Empty;         //Keeps the contents of all the lines one by one
                int lineNumber = 1;                 //Keeps the number of the line that we got to

                while ((line = inputText.ReadLine()) != null)           //Reads the lines one by one
                {
                    outputText.WriteLine("{0}. {1}", lineNumber, line); //Outputs in the new file the line with the line number in front of it
                    lineNumber++;                                       //Increases the line number before reading the next one
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Done!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}