//Задача 10
//Write a program that applies bonus scores to given scores in the range [1..9].
//The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10;
//if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000.
//If it is zero or if the value is not a digit, the program must report an error.
//Use a switch statement and at the end print the calculated new value in the console.

using System;

class InputIntDoubleOrStringWithSwitch
{
    static void Main()
    {
        int score;
        bool errorDetect;
        Console.Write("Input score (1-9): ");
        errorDetect = int.TryParse(Console.ReadLine(), out score);

        // V Проверка, която позволява да не се излиза от програмата при въвеждане на невалидни данни.
        //while (errorDetect == false || (score != 1 && score != 2 && score != 3 && score != 4 && score != 5
        //                                           && score != 6 && score != 7 && score != 8 && score != 9))
        //{
        //    Console.Write("Incorect input! Try again (1-9): ");
        //    errorDetect = int.TryParse(Console.ReadLine(), out score);
        //}
        
        switch (score)
        {
            case 1:
            case 2:
            case 3:
                score *= 10;
                Console.WriteLine("The finale score is: {0}", score);
                break;
            case 4:
            case 5:
            case 6:
                score *= 100;
                Console.WriteLine("The finale score is: {0}", score);
                break;
            case 7:
            case 8:
            case 9:
                score *= 1000;
                Console.WriteLine("The finale score is: {0}", score);
                break;
            default:
                Console.WriteLine("ERROR!");
                break;
        }
    }
}