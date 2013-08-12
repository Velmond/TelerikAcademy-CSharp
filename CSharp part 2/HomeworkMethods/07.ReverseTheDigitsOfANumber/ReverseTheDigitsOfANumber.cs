//07. Write a method that reverses the digits of given decimal number. Example: 256 -> 652

using System;

class ReverseTheDigitsOfANumber
{
    static uint ReverseNumber(uint numberToReverse, uint numberOfDigits)
    {
        string reversed = "";
        for (int i = 0; i < numberOfDigits; i++)
        {
            reversed += numberToReverse % 10;       //Остатъка от делене на 10 добавям към стойността на стринга и 
            numberToReverse /= 10;                  //деля числото на 10
        }

        return uint.Parse(reversed);                //Връща се парснатата стойност на стринга
    }

    static void Main()
    {
        uint numberToReverse;
        Console.Write("Input a number to reverse it's digits - ");
        bool errorDetect = uint.TryParse(Console.ReadLine(), out numberToReverse);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out numberToReverse);
        }

        Console.WriteLine(ReverseNumber(numberToReverse, (uint)numberToReverse.ToString().Length));
    }
}