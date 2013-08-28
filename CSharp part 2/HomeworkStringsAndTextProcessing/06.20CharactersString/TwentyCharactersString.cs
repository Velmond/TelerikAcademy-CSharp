//06. Write a program that reads from the console a string of maximum 20 characters. 
//    If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//    Print the result string into the console.

namespace TwentyCharactersString
{
    using System;

    class TwentyCharactersString
    {
        static void Main()
        {
            Console.WriteLine("Input a string with up to 20 characters: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine();              //Read the string
            Console.ForegroundColor = ConsoleColor.Gray;

            while (input.Length > 20)                       //If the string is longer than 20 characters input a new string
            {
                Console.WriteLine("Input was to long. It should be up to 20 characters: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                input = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            input = input.PadLeft(20, '*');                 //Fill the string up to 20 characters with '*'

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}", input);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
