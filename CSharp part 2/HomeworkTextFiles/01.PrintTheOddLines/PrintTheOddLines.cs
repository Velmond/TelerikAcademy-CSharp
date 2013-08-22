//01. Write a program that reads a text file and prints on the console its odd lines.

namespace PrintTheOddLines
{
    using System;
    using System.IO;

    class PrintTheOddLines
    {
        static void Main()
        {
            using (StreamReader inputText = new StreamReader(@"..\..\Input.txt"))
            {
                string line = string.Empty;         //Keeps the contents of all the lines one by one
                int lineCount = 1;                  //Keeps the number of the line that we got to

                while ((line = inputText.ReadLine()) != null)   //Reeds the file line by line untill it gets to the end
                {
                    if (lineCount % 2 == 1)         //If the line number is odd it gets printed on the console
                        Console.WriteLine(line);

                    lineCount++;                    //In all cases the line number is increased right before reading the next one
                }
            }
        }
    }
}