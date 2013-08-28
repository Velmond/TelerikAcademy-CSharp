//07. Write a program that encodes and decodes a string using given encryption key (cipher). 
//    The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) 
//    operation over the first letter of the string with the first of the key, the second – with the second, etc. 
//    When the last key character is reached, the next is the first.

namespace EncodeAndDecodeAString
{
    using System;
    using System.Text;

    class EncodeAndDecodeAString
    {
        static void Main()
        {
            string inputText, key;
            //To use your own input and key uncomment the lines below:
            //Console.Write("Input the text you want excoded: ");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //inputText = Console.ReadLine();
            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.Write("Input the key fot excoding: ");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //key = Console.ReadLine();
            //Console.ForegroundColor = ConsoleColor.Gray;  /*
            inputText = @"Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.";
            key = "Encoding key";   // */

            Console.Clear();
            string encoded = Encode(inputText, key);
            Console.Write("Encoded: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(encoded);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            string decoded = Decode(encoded, key);
            Console.Write("Decoded: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(decoded);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }

        static string Encode(string input, string key)
        {
            StringBuilder encoded = new StringBuilder();

            for (int i = 0; i < input.Length; i++)                  //It's fairly straightforward 
            {
                int keyIndex = i % key.Length;                      //We find the index in the key 
                encoded.Append((char)(input[i] ^ key[keyIndex]));   //We XOR the letter at a certain index [i] with the letter 
            }                                                       //...form the key at the corresponding index [keyIndex]

            return encoded.ToString();
        }

        static string Decode(string input, string key)
        {
            return Encode(input, key).ToString();                   //Uses the same method but with the encoded message as input
        }
    }
}
