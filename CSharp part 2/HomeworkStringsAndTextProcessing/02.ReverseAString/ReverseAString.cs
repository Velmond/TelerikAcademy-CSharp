//02. Write a program that reads a string, reverses it and prints the result at the console.
//    Example: "sample" -> "elpmas".

namespace ReverseAString
{
    using System;

    class ReverseAString
    {
        static void Main()
        {
            Console.Write("Input the string you need reversed: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            string output = Reverse(input);

            Console.Clear();
            Console.Write("Input:".PadRight(10));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Reversed:".PadRight(10));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(output);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static string Reverse(string input)
        {
            char[] inputArray = input.ToCharArray();        //Turns the sting to a char array and
            Array.Reverse(inputArray);                      //...reverses it

            return new string(inputArray);                  //Then turns the array to a string
        }
    }
}
