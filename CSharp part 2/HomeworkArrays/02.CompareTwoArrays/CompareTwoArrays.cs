//02. Write a program that reads two arrays from the console and compares them element by element.
                                //! ! ! ! !
                                //Приемам, че ще се сравняват масиви с еднакакъв брой елементи, защото в противен случай,
                                //след последния елемент на по-малкия масив, трябва да се сравняват числа от по-големия
                                //с несъществуващи стойности (не съм сигурен дали дори биха се класифицирали като null)
using System;

class CompareTwoArrays
{
    static void Main()
    {
        //Въвеждане на размера на масивите, които ще се сравняват
        int arraySize;          
        Console.Write("What size should the arrays be? ");
        bool errorDetect = int.TryParse(Console.ReadLine(), out arraySize);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out arraySize);
        }
        //Деклариране на два масива с желания размер
        int[] firstArray = new int[arraySize];
        int[] secondArray = new int[arraySize];
        //Попълване на стойностите в първия масив
        Console.WriteLine("Input the {0} elements of the first array:", arraySize);
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Element {0}: ", i);
            errorDetect = int.TryParse(Console.ReadLine(), out firstArray[i]);
            while (!errorDetect)
            {
                Console.Write("Incorect input! Try again - ");
                errorDetect = int.TryParse(Console.ReadLine(), out firstArray[i]);
            }
        }
        //Попълване на стойностите във втория масив
        Console.WriteLine("Input the {0} elements of the second array:", arraySize);
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Element {0}: ", i);
            errorDetect = int.TryParse(Console.ReadLine(), out secondArray[i]);
            while (!errorDetect)
            {
                Console.Write("Incorect input! Try again - ");
                errorDetect = int.TryParse(Console.ReadLine(), out secondArray[i]);
            }
        }

        //За проверка:
        //int[] firstArray = { 1, 2, -3, 2, -5, 2, 1, 0 };
        //int[] secondArray = { 3, 2, 4, -1, 5, 0, 9, 1 };
        //int arraySize = firstArray.Length;

        Console.Clear();

        Console.WriteLine("First array:".PadLeft(24) + "Second array:".PadLeft(16));
        for (int i = 0; i < arraySize; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("Element {0} -\t{1}\t =\t{2}", i, firstArray[i], secondArray[i]);
            }
            else if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("Element {0} -\t{1}\t >\t{2}", i, firstArray[i], secondArray[i]);
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("Element {0} -\t{1}\t <\t{2}", i, firstArray[i], secondArray[i]);
            }
        }
    }
}