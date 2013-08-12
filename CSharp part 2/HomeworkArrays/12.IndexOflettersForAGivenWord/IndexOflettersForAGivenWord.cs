//12. Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOflettersForAGivenWord
{
    static void Main()
    {
        Console.Write("Just give the word! - ");
        string word = Console.ReadLine();
        string wordToLower = word.ToLower();    //Въвеждам променлива, на която присвоявам string-а, преобразуван в малки букви
        char[] alphabetArray = new char[26];    //Създавам масив с азбуката
        alphabetArray[0] = 'a';
        for (int i = 1; i < alphabetArray.Length; i++)
        {
            alphabetArray[i] = (char)(alphabetArray[i-1] + 1);
        }

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabetArray.Length; j++)
            {
                if (wordToLower[i] == alphabetArray[j])
                {
                    Console.WriteLine("{0} = {1}", word[i], j);
                }
            }
        }
    }
}