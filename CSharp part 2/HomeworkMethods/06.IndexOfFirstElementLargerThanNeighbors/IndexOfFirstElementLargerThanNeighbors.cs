//06. Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1,
//if there’s no such element. Use the method from the previous exercise.

using System;

class IndexOfFirstElementLargerThanNeighbors
{
    static int FirstBiggerNumbersIndex(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            if (BiggerThanNeighbors.IsBigger(array, i)) //Използвайки метода от предната задача се обхожда целия масив търсейки елемент
                return i;                               //по-голям от съседните си, за да се върне индекса му

        return -1;      //Ако не се намери такъв елемент се връща стойност -1
    }

    static uint Input()
    {
        uint arraySize;       
        Console.Write("Input a number to get its last digit - ");
        bool errorDetect = uint.TryParse(Console.ReadLine(), out arraySize);
        while (!errorDetect)
        {
            Console.Write("Incorrect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out arraySize);
        }
        return arraySize;
    }

    static int[] Input(uint arraySize)
    {
        int[] array = new int[arraySize];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Input element {0} - ", i);
            bool errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            while (!errorDetect)
            {
                Console.Write("Incorrect input! Try again - ");
                errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            }
        }
        return array;
    }

    static void Main()
    {
        uint arraySize = Input();
        int[] array = Input(arraySize);

        //int[] array = { 1, 5, 2, 5, 3, 3, 7, 4, 6, 8, 5, 8, 4, 3, 3, 0, 8, 6, 8, 6, 9, 0, 7, 8, 6, 9, 5, 4, 7 };  //1
        //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };                                                  //-1
        //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 10 };                                                  //10
        //int[] array = { 1, 2, 3, 6, 5, 4, 7, 8, 9, 10, 11, 12 };                                                  //3

        Console.WriteLine(FirstBiggerNumbersIndex(array));
    }
}