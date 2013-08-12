//04. Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexToDecimal
{
    static uint ToDecimal(string hexNumber)  //The solution works for unsigned integers
    {
        uint decimalNumber = 0;

        for (int i = hexNumber.Length - 1; i >= 0; i--)     //The loop goes throu the string from the last to the first digit,
        {                                                   //multiplying them by 15 to the power of the digit's index in the string 
            if (hexNumber[i] >= '0' && hexNumber[i] <= '9')     //When the digits correspond to the characters between 0 and 9
                decimalNumber += (uint)((hexNumber[i] - 48) * Math.Pow(16, ((hexNumber.Length - 1) - i)));
            else                                                //When the digits correspond to the characters between A and F
                decimalNumber += (uint)((hexNumber[i] - 55) * Math.Pow(16, ((hexNumber.Length - 1) - i)));
        }

        return decimalNumber;
    }

    static void Main()
    {
        while (true)
        {
            Console.Write("Please input an integer in hexadecimal to convert it to decimal\n(or type \"exit\" to stop the program) - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine().ToUpper();        //The input is kept as string
            Console.ForegroundColor = ConsoleColor.Gray;

            if (input == "EXIT")        //Checks if the input is "exit" so that the program breaks out of
                break;                  //the infinite while-loop

            bool inputError = true;     //By default I consider that the user will input a valid hexadecimal number
            for (int i = 0; i < input.Length; i++)
                if ((input[i] < '0' || input[i] > '9') && (input[i] < 'A' || input[i] > 'F') || input.Length > 8)   //If not or if
                {                                                               //the input is longet than 8 characters than the
                    inputError = false;                                         //input is considered invalid
                    break;
                }

            while (!inputError)     //The input is redone until it is valid
            {
                Console.Write("Incorect input! Please try again - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                input = Console.ReadLine().ToUpper();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (input == "EXIT")
                    return;

                inputError = true;

                for (int i = 0; i < input.Length; i++)
                    if ((input[i] < '0' || input[i] > '9') && (input[i] < 'A' || input[i] > 'F') || input.Length > 8)
                    {
                        inputError = false;
                        break;
                    }
            }

            uint decimalNumber = ToDecimal(input);  //The decimal value is kept as an unsigned int

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} (16) = {1} (10)", input, decimalNumber);   //Printing the result
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}