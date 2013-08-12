//03. Write a method that returns the last digit of given integer as an English word.
//Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

using System;

class LastDigitAsWord
{
    static string GetLastDigit(int number)
    {
        int lastDigit = number % 10;                //Деля остатъчно на 10 и така намирам последнана цифра в даденото число
        string lastDigitAsString = null;
        switch (lastDigit)                          //Чрез swith, в зависимост от lastDigit задавам стойността на стринга lastDigitAsString
        {
            case 0: lastDigitAsString = "zero"; break;
            case 1: lastDigitAsString = "one"; break;
            case 2: lastDigitAsString = "two"; break;
            case 3: lastDigitAsString = "three"; break;
            case 4: lastDigitAsString = "four"; break;
            case 5: lastDigitAsString = "five"; break;
            case 6: lastDigitAsString = "six"; break;
            case 7: lastDigitAsString = "seven"; break;
            case 8: lastDigitAsString = "eight"; break;
            case 9: lastDigitAsString = "nine"; break;
        }

        return lastDigitAsString;
    }

    static void Main()
    {
        int inputNumber;
        Console.Write("Input a number to get its last digit - ");
        bool errorDetect = int.TryParse(Console.ReadLine(), out inputNumber);
        while (!errorDetect)
        {
            Console.Write("Incorrect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out inputNumber);
        }

        Console.Write("The last digit of {0} is ", inputNumber);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(GetLastDigit(inputNumber));
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}