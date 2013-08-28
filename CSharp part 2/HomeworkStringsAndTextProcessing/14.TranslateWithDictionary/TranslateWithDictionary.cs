//14. A dictionary is stored as a sequence of text lines containing words and their explanations. 
//    Write a program that enters a word and translates it by using the dictionary. 
//    Sample dictionary:
//      .NET – platform for applications from Microsoft
//      CLR – managed execution environment for .NET
//      namespace – hierarchical organization of classes

namespace TranslateWithDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class TranslateWithDictionary
    {
        static void Main()
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>(); //Create a dictionary

            myDictionary.Add(".NET", "platform for applications from Microsoft");   //Stuff it with the keys and their explanations
            myDictionary.Add("CLR", "managed execution environment for .NET");
            myDictionary.Add("namespace", "hierarchical organization of classes");

            Console.Write("What do you need the meaning of? - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Clear();
            Console.Write("Input:".PadRight(10));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ForegroundColor = ConsoleColor.Gray;
            try
            {
                Console.Write("Meaning:".PadRight(10));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(myDictionary[input]);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (KeyNotFoundException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("We are missing the explanation for your input!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
