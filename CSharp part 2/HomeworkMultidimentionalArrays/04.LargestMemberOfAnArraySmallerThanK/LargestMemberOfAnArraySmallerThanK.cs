//04. Write a program, that reads from the console an array of N integers and an integer K, sorts the array
//and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

//http://msdn.microsoft.com/en-us/library/2cy9f6wb.aspx

using System;

class LargestMemberOfAnArraySmallerThanK
{
    static void Main()
    {
        uint N;
        Console.Write("Please input the size N of the array (N) ");
        bool errorDetect = uint.TryParse(Console.ReadLine(), out N);
        while (!errorDetect || N < 3)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out N);
        }
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Please input element {0} of the array - ", i);
            errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            while (!errorDetect)
            {
                Console.Write("Incorect input! Try again - ");
                errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            }
        }
        int K;
        Console.Write("Smaller than what number are you looking for? (K) ");
        errorDetect = int.TryParse(Console.ReadLine(), out K);
        while (!errorDetect || N < 3)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out K);
        }

        //За проверка:
        //int[] array = { 0, 1, -5, 2, -3, 5, 5, -3, 1, 8, 5, -4, 4, 2, -8, 0, 2, -1, -1, 0, 5, 4, -1, 2 };
        //int K = 7;

        Array.Sort(array);          //Сортиране на масива

        if (array[0] > K)           //В случай, че първия елемент след сортирането е по-голям от К, то в него явно няма 
        {                           //елемент по-малък от него и това се изписва на конзолата
            Console.WriteLine("All the elements of the array are greater than {0}", K);
        }
        else                        //В противен случай чрез Array.BinarySearch се намира индекса на търсения елемент
        {
            int soughtNumber;
            int index = Array.BinarySearch(array, K);
            if (index >= 0)         //Ако в стойностите в масива съществува стойност равна на К, то Array.BinarySearch
            {                       //връща директно стойността на индекса на елемента, който е положително число
                soughtNumber = array[index];
            }
            else    //Ако стойността не съществува в масива, то Array.BinarySearch връща стойността на индекса на елемента 
            {       //по-голям от даденото К, но с разменени стойности на битовете (т.е. връща отрицателно число)
                soughtNumber = array[~index - 1];
            }
            Console.WriteLine(soughtNumber);
        }
    }
}