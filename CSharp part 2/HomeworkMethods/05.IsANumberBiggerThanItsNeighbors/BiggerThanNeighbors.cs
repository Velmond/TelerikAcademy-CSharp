//05. Write a method that checks if the element at given position in given array of integers
//is bigger than its two neighbors (when such exist).

using System;

public class BiggerThanNeighbors
{
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

    public static bool IsBigger(int[] array, int element)
    {
        bool numberIsBigger = false;
        if (element > 0 && element < array.Length - 1 && //Тази част от условията се налага тъй като метода се използва и за зад. 6
                array[element] > array[element + 1] && 
                array[element] > array[element - 1])
            numberIsBigger = true;

        return numberIsBigger;
    }

    static void Output(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)  //Проверката се прави за всички елементи без тези с индекс равен на последния и
        {                                           //на 0, тъй като те имат само по 1 съседен елемент, а до колкото разбрах условието
            string result = "";                     //трябва да се проверят тези с 2 съседни елемента
            if (IsBigger(array, i))     //Използва се горния метод, за да се определи дали дадения елементи е или не е по-голям от
                result = "IS";          //съседните си
            else
                result = "is NOT";

            Console.Write("Element {0}:", (i + 1));             //Резултата се изписва директно на конзолата
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" {0} {1} ", array[i], result);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" bigger than its neighbors.");
        }
    }

    static void Main()
    {
        uint arraySize = Input();
        int[] array = Input(arraySize);

        Console.Clear();

        //За проверка може да се закоментира по-горната част на метода Main и да се разкоментира долния ред
        //int[] array = { 1, 5, 2, 5, 3, 3, 7, 4, 6, 8, 5, 8, 4, 3, 3, 0, 8, 6, 8, 6, 9, 0, 7, 8, 6, 9, 5, 4, 7 };

        Output(array);
    }
}