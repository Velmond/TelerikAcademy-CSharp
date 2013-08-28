//13. Write a program that reverses the words in given sentence.
//    Example: 
//      "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!"
//                                                                    /\ I think this comma should be between "not" and "C++" 
//                                                                    /\ so that is how my program works

namespace ReverseWordsInSentence
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ReverseWordsInSentence
    {
        static char finalChar = char.MinValue;

        static void Main()
        {
            string input = string.Empty;
            Console.Write("Input the sentence to reverse its words: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //If you want to use a hard-coded example just comment the line below and uncomment the one you want to test: 
            input = Console.ReadLine();
            //input = @"C# is not C++, not PHP and not Delphi!";
            //input = @"Microsoft announced its next generation PHP compiler today.";
            //input = @"For centuries, men have fought and died for freedom and this is still continuing today.";
            Console.ForegroundColor = ConsoleColor.Gray;

            Stack<string> words = ExtractWords(input);
            StringBuilder output = ArrangeWordsBackwards(words, finalChar);

            Console.Clear();
            Console.WriteLine("Input:\t\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Reversed:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(output);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static Stack<string> ExtractWords(string input)
        {
            Stack<string> words = new Stack<string>();
            int inputIndex = 0;
            words.Push(input[inputIndex].ToString());   //Puts the first character of the first word in the stack
            inputIndex++;

            while (inputIndex < input.Length)
            {
                char currChar = input[inputIndex];

                if (inputIndex == (input.Length - 1) && (currChar == '.' || currChar == '!' || currChar == '?'))
                {
                    finalChar = currChar;   //Gets the final char (the . or the ! or the ?)
                }
                else
                {
                    if (currChar == ',' || currChar == '.' || currChar == '!' || 
                        currChar == '?' || currChar == ':' || currChar == ';')
                    {
                        words.Push(currChar.ToString());    //Push the comma in the stack as a separate word
                    }
                    else if (currChar == ' ')
                    {
                        inputIndex++;
                        words.Push(string.Empty);   //Start a new string and push it in the stack
                        continue;
                    }
                    else
                    {
                        words.Push(words.Pop() + currChar); //Attach the current character to the last word in the stack
                    }
                }

                inputIndex++;
            }

            return words;
        }

        private static StringBuilder ArrangeWordsBackwards(Stack<string> words, char finalChar)
        {
            StringBuilder output = new StringBuilder();
            int wordsCount = words.Count;

            output.Append(words.Pop());

            for (int i = 1; i < wordsCount; i++)
            {
                if (i < wordsCount - 1)
                {
                    if (words.Peek() == "," || words.Peek() == "." || words.Peek() == "!" || 
                        words.Peek() == "?" || words.Peek() == ":" || words.Peek() == ";")
                    {
                        output.Append(words.Pop());
                    }
                    else    //If it's a word put it after a space in the stringbuilder
                    {
                        output.Append(" " + words.Pop());
                    }
                }
                else
                {
                    output.Append(" " + words.Pop() + finalChar);   //If it's the last word stick the last character to it
                }
            }

            return output;
        }
    }
}
