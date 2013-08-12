//03. Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHex
{
    static string ToHex(uint decimalNumber) //The solution works for unsigned integers
    {
        string reverseHexNumber = "";   //The hexadecimal number is stiched character by character from the last to the first
                                        //and needs to be reverced ones its value is found
        do
        {
            switch (decimalNumber % 16)
            {
                case 10: reverseHexNumber += 'A'; break;
                case 11: reverseHexNumber += 'B'; break;
                case 12: reverseHexNumber += 'C'; break;
                case 13: reverseHexNumber += 'D'; break;
                case 14: reverseHexNumber += 'E'; break;
                case 15: reverseHexNumber += 'F'; break;
                default: reverseHexNumber += (decimalNumber % 16); break;
            }
            decimalNumber /= 16;
        } while (decimalNumber != 0);

        string hexNumber = "";
        for (int i = reverseHexNumber.Length - 1; i >= 0; i--)  //The real hexadecimal number we get by reversing the value we 
            hexNumber += reverseHexNumber[i];                   //got so far

        return hexNumber;
    }

    static void Main()
    {
        while (true)
        {
            uint decimalNumber;
            Console.Write("Please input an integer in decimal to convert it to hexadecimal\n(or type \"exit\" to stop the program) - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine().ToLower();        //The input is kept as string
            Console.ForegroundColor = ConsoleColor.Gray;

            if (input == "exit")        //Checks if the input is "exit" so that the program breaks out of the infinite while-loop
                break;

            bool inputError = uint.TryParse(input, out decimalNumber);  //If the input is not "exit" the program continues with
                                                                        //trying to parse the input as uint in decimalNumber
            while (!inputError)     //If it can't parse the input, the input repeats untill it can
            {
                Console.Write("Incorect input! Please try again - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                input = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (input == "exit")
                    break;

                inputError = uint.TryParse(input, out decimalNumber);
            }

            string hexNumber = ToHex(decimalNumber);  //The binary value is kept as a string

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} (10) = {1} (16)", decimalNumber, hexNumber);   //Printing the result
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}