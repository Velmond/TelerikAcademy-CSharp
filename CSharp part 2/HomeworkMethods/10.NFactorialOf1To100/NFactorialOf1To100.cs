//10. Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Numerics;

class NFactorialOf1To100
{
    static byte[] Multiply(byte[] array, int maxToMultiplyBy)   //Умножение представено чрез събиране (3.4 = 3+3+3+3)
    {
        byte[] result = { 0 };
        for (int i = 0; i < maxToMultiplyBy; i++)
            result = Add(result, array);

        return result;
    }

    static byte[] Add(byte[] firstArray, byte[] secondArray)
    {
        if (firstArray.Length > secondArray.Length)
            return Add(secondArray, firstArray);            //Така сме сигурни, че първия масив е по-малкия от двата

        byte[] result = new byte[secondArray.Length];
        int i = 0;
        int toCarry = 0;

        for (; i < firstArray.Length; i++)                  //До дължината на по-малкия масив, до където и в двата масива има
        {                                                   //някаква стойност
            result[i] = (byte)(firstArray[i] + secondArray[i] + toCarry);

            toCarry = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < secondArray.Length && toCarry != 0; i++) //След като по-малкия масив няма вече елементи може все още да има 
        {                                                   //някаква стойност за добавяне ("на ум")
            result[i] = (byte)(secondArray[i] + toCarry);

            toCarry = result[i] / 10;
            result[i] %= 10;
        }
        
        for (; i < secondArray.Length; i++)                 //След като по-малкия масив няма вече елементи и няма стойност 
            result[i] = secondArray[i];                     //за добавяне "на ум"

        if (toCarry != 0)                                   //Ако сме достигнали последния елемент и е останало да се пренесе
        {                                                   //някаква стойност "на ум", тя се зависва в допълнителнен елемент, за
            Array.Resize(ref result, result.Length + 1);    //който се добавя място в масива
            result[i] = 1;
        }
        
        return result;
    }

    static void PrintFactorial(byte[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)           //Изписва стойността, както трябва да е
            Console.Write(arr[i]);
    }
    
    static void Main()
    {
        byte[] factorial = { 1 };
        for (int i = 1; i <= 100; i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0,3}!", i);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" = ");
            PrintFactorial(factorial = Multiply(factorial, i));
            Console.WriteLine();
        }
    }
}