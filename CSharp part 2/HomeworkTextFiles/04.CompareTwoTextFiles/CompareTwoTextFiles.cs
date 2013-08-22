//04. Write a program that compares two text files line by line and prints the number of lines that are the same 
//    and the number of lines that are different. Assume the files have equal number of lines.

namespace CompareTwoTextFiles
{
    using System;
    using System.IO;

    class CompareTwoTextFiles
    {
        static void Main()
        {
            int sameCount = 0;              //Keeps the nunmber of identical lines
            int totalCount = 0;             //Keeps the total number of lines in the files
            string line = string.Empty;

            using (StreamReader firstInputFile = new StreamReader(@"..\..\Input1.txt"))
            using (StreamReader secondInputFile = new StreamReader(@"..\..\Input2.txt"))
                while ((line = secondInputFile.ReadLine()) != null)
                {
                    if (line == firstInputFile.ReadLine())  //If lines are identical sameCount is increased by 1
                        sameCount++;

                    totalCount++;       //totalCount is increased in all cases
                }

            Console.Write("The number of lines that are the same is: ");        //Prints the number of the same lines
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(sameCount);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("The number of lines that are the different is: ");   //Prints the number of the different lines
            Console.ForegroundColor = ConsoleColor.Yellow;                      //...(diff = totalCount - sameCount)
            Console.WriteLine(totalCount - sameCount);
            Console.ForegroundColor = ConsoleColor.Gray;

            //Result should be [11 - the same; 9 - different] with the files provided in the solution's directory
        }
    }
}