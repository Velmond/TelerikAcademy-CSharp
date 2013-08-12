//03. Write a program that compares two char arrays lexicographically (letter by letter).
                                //! ! ! ! !
                                //Приемам, че ще се сравняват масиви с еднакакъв брой елементи, защото в противен случай,
                                //след последния елемент на по-малкия масив, трябва да се сравняват числа от по-големия
                                //с несъществуващи стойности (не съм сигурен дали дори биха се класифицирали като null)
using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        //Входа е аналогичен на предната задача (2)
        int arraySize;
        Console.Write("What size should the arrays be? ");
        bool errorDetect = int.TryParse(Console.ReadLine(), out arraySize);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out arraySize);
        }
        char[] firstArray = new char[arraySize];
        char[] secondArray = new char[arraySize];
        Console.WriteLine("Input the {0} elements of the first array:", arraySize);
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Element {0}: ", i);
            errorDetect = char.TryParse(Console.ReadLine(), out firstArray[i]);
            while (!errorDetect)
            {
                Console.Write("Incorect input! Try again - ");
                errorDetect = char.TryParse(Console.ReadLine(), out firstArray[i]);
            }
        }
        Console.WriteLine("Input the {0} elements of the second array:", arraySize);
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Element {0}: ", i);
            errorDetect = char.TryParse(Console.ReadLine(), out secondArray[i]);
            while (!errorDetect)
            {
                Console.Write("Incorect input! Try again - ");
                errorDetect = char.TryParse(Console.ReadLine(), out secondArray[i]);
            }
        }

        //За проверка:
        //int[] firstArray = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i' };
        //int[] secondArray = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'o' };
        //int arraySize = firstArray.Length;

        Console.Clear();
        Console.Write("First array:\t");            //Изписвам на конзолата масивите, за да е по-ясен резултата от сравняването
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write((char)firstArray[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Second array:\t");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write((char)secondArray[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < arraySize; i++)
        {
            if (firstArray[i] == secondArray[i])        //Проверявам за равенство между елементите, от началото, до където се
            {                                           //различават. Ако не се различават до края, това се изписва на конзолата.
                if (i < (arraySize - 1))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("First array = Second Array\n");
                }
            }
            else if (firstArray[i] > secondArray[i])    //Ако в някой от елементите има разлика, от нея следва кой от двата масива
            {                                           //е "по-голям" в лексикографично отношение (до колкото разбрах условието)
                Console.WriteLine("The first difference is at element {0} - {1} > {2} => First array > Second Array\n",
                                                                        i, (char)firstArray[i], (char)secondArray[i]);
                break;
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("The first difference is at element {0} - {1} < {2} => First array < Second Array\n",
                                                                        i, (char)firstArray[i], (char)secondArray[i]);
                break;
            }
        }
    }
}