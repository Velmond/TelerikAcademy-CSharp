//Задача 2
//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
//Use a sequence of if statements.

using System;

class SignOfProductWithoutMultiplying
{
    static void Main()
    {
        int firstNumber, secondNumber, thirdNumber;
        bool errorDetect;
        char sign = '+';
        Console.Write("Input first integer: ");
        errorDetect = int.TryParse(Console.ReadLine(), out firstNumber);
        while (errorDetect == false)
        {
            Console.Write("Incorect input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out firstNumber);
        }
        Console.Write("Input second integer: ");
        errorDetect = int.TryParse(Console.ReadLine(), out secondNumber);
        while (errorDetect == false)
        {
            Console.Write("Incorect input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out secondNumber);
        }
        Console.Write("Input third integer: ");
        errorDetect = int.TryParse(Console.ReadLine(), out thirdNumber);
        while (errorDetect == false)
        {
            Console.Write("Incorect input! Try again: ");
            errorDetect = int.TryParse(Console.ReadLine(), out thirdNumber);
        }

        Console.Clear();    //Изчиства конзолата от предните въпроси
        
        if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
        {
            sign = '+';     //Ако всички числа са положителни, произведението им е положително
        }
        else if ((firstNumber < 0 && secondNumber > 0 && thirdNumber > 0) ||
                 (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0) ||
                 (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0))
        {
            sign = '-';     //Ако едно от числата е отрицателно, произведението им е отрицателно
        }
        else if ((firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) ||
                 (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0) ||
                 (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0))
        {
            sign = '+';     //Ако две от числата са отрицателни, произведението им е положително
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            sign = '-';     //Ако всички числа са отрицателни, произведението им е отрицателно
        }
        else if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {                   //Ако някое от числата е 0, произведението им е 0
            Console.WriteLine("The product of {0}, {1} and {2} is 0.", firstNumber, secondNumber, thirdNumber);
            return;         //Програмата прекъсва изпълнението тук, ако някое от числата е 0
        }
        
        Console.WriteLine("First integer:\t\t{0}\nSecond integer:\t\t{1}\nThird integer:\t\t{2}\nSign of their product:\t{3}\n", firstNumber, secondNumber, thirdNumber, sign);

        //Console.WriteLine("Product: {0}", firstNumber * secondNumber * thirdNumber); // <-- За проверка
    }
}