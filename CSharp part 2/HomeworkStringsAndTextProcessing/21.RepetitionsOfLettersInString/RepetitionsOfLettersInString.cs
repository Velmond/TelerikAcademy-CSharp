//21. Write a program that reads a string from the console and prints all different letters in the string 
//    along with information how many times each letter is found. 

namespace RepetitionsOfLettersInString
{
    using System;
    using System.Collections.Generic;

    class RepetitionsOfLettersInString
    {
        static void Main()
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            //Keep the characters and the number of their apperances in this dictionary
            
            string inputString = string.Empty;

            Console.WriteLine("Input a string to get the number of times each character is used in it.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //inputString = Console.ReadLine();   /*
            inputString = "THE IMPORTANCE OF FREEDOM OF SPEECH\nFreedom is one of the most precious possessions that we can have. For centuries, men have fought and died for freedom and this is still continuing today. As we all know, there are many in the world who have sacrificed comfort in life and freedom as a result of expressing what is in their hearts.\nFreedom of speech refers to the right of the individual to express his views about matters of interest to him/her whilst freedom of the press would refer to the freedom of written word in printed form and that BOTH refer to the freedom of THOUGHT and are the outward expressions of our THOUGHTS...";   // */
            Console.ForegroundColor = ConsoleColor.Gray;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (charCount.ContainsKey(inputString[i]))  //If the dictionary contains the character we're on
                {
                    charCount[inputString[i]]++;            //...we add one to its value (it is case sensitive)
                }
                else
                {
                    charCount.Add(inputString[i], 1);       //Else we add the character to the dictionary with a value of 1
                }
            }

            Console.Clear();
            foreach (var character in charCount)            //Printing the result on the console
            {
                if (character.Key != '\n' && character.Key != ' ')
                {
                    Console.WriteLine("{0} -> {1}", character.Key, character.Value);
                }
                else if (character.Key == '\n')
                {
                    Console.WriteLine("New line -> {1}", character.Key, character.Value);
                }
                else if (character.Key == ' ')
                {
                    Console.WriteLine("Space -> {1}", character.Key, character.Value);
                }
            }
        }
    }
}
