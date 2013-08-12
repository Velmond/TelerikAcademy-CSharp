//05. You are given an array of strings. Write a method that sorts the array by the length of its elements
//(the number of characters composing them).

//http://msdn.microsoft.com/en-us/library/85y6y2d3.aspx

using System;

class SortAStringArrayByLengthOfElements
{
    static void Main()
    {
        uint N;
        Console.Write("How many elements shold the array consist of? ");
        bool errorDetect = uint.TryParse(Console.ReadLine(), out N);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out N);
        }
        string[] stringArray = new string[N];
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write("Input element {0} of the array ", i);
            stringArray[i] = Console.ReadLine();
        }

        //За проверка:
        //string[] stringArray = { "aaaaa", "aa", "aaaaaad", "aaaaa", "aaaaaa", "aaaaaaaa", "aaaaaa", "aaaaaaaaa", "aaaaaaaaaa",
        //                         "aaa","aaaaaa", "aa", "aaaa", "aaaaa", "aaaaaaa", "a", "aaaaaaa", "aaa", "aaaa", "aaaaaaa" };

        Console.Clear();
        uint[] stringLength = new uint[stringArray.Length]; //Въвеждам втори масив, в който се записват дължините на отделните
        for (int i = 0; i < stringArray.Length; i++)        //стрингове
        {
            stringLength[i] = (uint)stringArray[i].Length;
        }

        Array.Sort(stringLength, stringArray);              //Сортира стринговете чрез масива съдържащ дължините им

        for (int i = 0; i < stringArray.Length; i++)        //Отпечатване на резултата
        {
            Console.WriteLine("{0,4}: ({1,2} characters) {2}", (i + 1), stringLength[i], stringArray[i]);
        }
        Console.WriteLine();
    }
}