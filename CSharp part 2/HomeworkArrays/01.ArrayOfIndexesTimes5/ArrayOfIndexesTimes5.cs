//01. Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class ArrayOfIndexesTimes5
{
    static void Main()
    {
        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
        }
                                                        //Първи вариант за изписването на елементите на масива:
        Console.WriteLine("Printing the array with a \"foreach\" loop: ");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine("\n");
                                                        //Втори вариант за изписването на елементите на масива:
        Console.WriteLine("Printing the array with a \"for\" loop: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("\n");
    }
}