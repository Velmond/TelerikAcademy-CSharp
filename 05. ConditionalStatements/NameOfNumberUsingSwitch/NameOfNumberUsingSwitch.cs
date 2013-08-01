//Задача 5
//Write program that asks for a digit and depending on the input shows the name of that digit (in English) 
//using a switch statement.

using System;

class NameOfNumberUsingSwitch
{
    static void Main()
    {
        byte digit;
        bool errorDetect;
        Console.Write("Input a digit (0-9): ");
        errorDetect = byte.TryParse(Console.ReadLine(), out digit);
        while (errorDetect == false || (digit != 0 && digit != 1 && digit != 2 && digit != 3 && digit != 4 && digit != 5 &&
                                                                    digit != 6 && digit != 7 && digit != 8 && digit != 9))
        {
            Console.Write("Incorect input! Try again: ");
            errorDetect = byte.TryParse(Console.ReadLine(), out digit);
        }
        Console.Clear();
        Console.WriteLine("INPUT:\t{0}", digit);
        Console.Write("RESULT:\t");
        switch (digit)
        {
            case 0: Console.WriteLine("ZERO"); break;
            case 1: Console.WriteLine("ONE"); break;
            case 2: Console.WriteLine("TWO"); break;
            case 3: Console.WriteLine("THREE"); break;
            case 4: Console.WriteLine("FOUR"); break;
            case 5: Console.WriteLine("FIVE"); break;
            case 6: Console.WriteLine("SIX"); break;
            case 7: Console.WriteLine("SEVEN"); break;
            case 8: Console.WriteLine("EIGTH"); break;
            case 9: Console.WriteLine("NINE"); break;
        }
    }
}