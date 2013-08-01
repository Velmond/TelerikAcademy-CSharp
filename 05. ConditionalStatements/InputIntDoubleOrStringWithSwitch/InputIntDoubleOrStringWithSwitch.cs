//Задача 8
//Write a program that, depending on the user's choice inputs int, double or string variable.
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
//The program must show the value of that variable as a console output. Use switch statement.

using System;

class InputIntDoubleOrStringWithSwitch
{
    static void Main()
    {
        byte choice;
        bool errorDetect;
        do
        {
            Console.Clear();
            Console.Write("Chose one of the folowing types:\n\t(1) int\n\t(2) double\n\t(3) string\nWhat will it be? - ");
            errorDetect = byte.TryParse(Console.ReadLine(), out choice);

        } while (!errorDetect || (choice != 1 && choice != 2 && choice != 3));
        Console.Write("Enter data of the chosen type: ");
        string input = Console.ReadLine();
        string result = "";
        switch (choice)
        {
            case 1:
                {
                    int intInput;
                    errorDetect = int.TryParse(input, out intInput);
                    while (!errorDetect)
                    {
                        Console.Write("Invalid input! Try again: \t");
                        errorDetect = int.TryParse(Console.ReadLine(), out intInput);
                    }
                    result = Convert.ToString(intInput += 1);
                    break;
                }
            case 2:
                {
                    double doubleInput;
                    errorDetect = double.TryParse(input, out doubleInput);
                    while (!errorDetect)
                    {
                        Console.Write("Invalid input! Try again: \t");
                        errorDetect = double.TryParse(Console.ReadLine(), out doubleInput);
                    }
                    result = Convert.ToString(doubleInput += 1);
                    break;
                }
            case 3:
                {
                    result = input + "*";
                    break;
                }
            default: Console.WriteLine("Invalid input"); break;
        }
        Console.Clear();
        Console.WriteLine("Type:\t{0}\nResult:\t{1}\n", result.GetType(), result);
    }
}