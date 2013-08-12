//Задача №4
//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 => true.

using System;

class CheckIfThirdDigitIs7
{
    static void Main()
    {
        Console.Write("What number would you like checked? ");
        int number;
        bool errorDetect = int.TryParse(Console.ReadLine(), out number);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out number);
        }
        int thirdDigit = (number / 100) % 10; //Даденото число се дели целочислено на 100, премахвайки всички числа след 3тата позиция
        string answer;                        //... след това се определя остатъка при делене на 10.
        if (thirdDigit == 7)
        {
            answer = "YES";
        }
        else
        {
            answer = "NO";
        }
        Console.Clear();
        Console.WriteLine("Number: {0}\nIs the third digit 7? - {1}\n", number, answer);
    }
}
