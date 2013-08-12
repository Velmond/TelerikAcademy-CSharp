//06. Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class DirectBinaryToHex
{
    static string ToHex(string binaryNumber)  //The solution works for unsigned numbers only
    {
        string hexNumber = "";  //The values corresponding to each of the groups of 4 bits are added to this string

        for (int i = 0; i < binaryNumber.Length; i += 4)
        {
            string hexDigitInBinary = "";   //This will contain the 4 bits corresponding to 1 hexadecimal digit
            for (int j = i; j < (i + 4); j++)
                hexDigitInBinary += binaryNumber[j];

            switch (hexDigitInBinary)
            {
                case "0000": hexNumber += '0'; break;
                case "0001": hexNumber += '1'; break;
                case "0010": hexNumber += '2'; break;
                case "0011": hexNumber += '3'; break;
                case "0100": hexNumber += '4'; break;
                case "0101": hexNumber += '5'; break;
                case "0110": hexNumber += '6'; break;
                case "0111": hexNumber += '7'; break;
                case "1000": hexNumber += '8'; break;
                case "1001": hexNumber += '9'; break;
                case "1010": hexNumber += 'A'; break;
                case "1011": hexNumber += 'B'; break;
                case "1100": hexNumber += 'C'; break;
                case "1101": hexNumber += 'D'; break;
                case "1110": hexNumber += 'E'; break;
                case "1111": hexNumber += 'F'; break;
            }
        }
        //The process so far gives me an answer that always contains 8 digits (for example 0000004F) so we need to get rid of the
        //unwanted zeros in the beginning
        for (int i = 0; i < binaryNumber.Length / 4; i++)
        {
            if (hexNumber[0] == '0')    //If the first character in the string is "0", in is removed, making the second element - first
                hexNumber = hexNumber.Remove(0, 1); //... the third - second etc and the string is left one character shorter
            else        //If at some point there is a value that is not "0" we break out of the cicle, so that we don't accidentally
                break;  //get rid of any 0 that is of importance (for example A0D3)
        }

        if (hexNumber == "")    //If the string is left empty that means the input was 0 which is tha same in hexadecimal
            hexNumber = "0";

        return hexNumber;
    }

    static void Main()
    {
        while (true)
        {
            Console.Write("Please input an integer in binary to convert it to hexadecimal\n(or type \"exit\" to stop the program) - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine().ToUpper();        //The input is kept as string
            Console.ForegroundColor = ConsoleColor.Gray;

            if (input == "EXIT")        //Checks if the input is "exit" so that the program breaks out of
                break;                  //the infinite while-loop

            bool inputError = true;     //By default I consider that the user will input a valid number
            for (int i = 0; i < input.Length; i++)
                if ((input[i] != '0' && input[i] != '1') || input.Length > 32)  //If not or if the input is longet than 32 characters
                {                                                               //than the input is considered invalid
                    inputError = false;
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
                    if ((input[i] != '0' && input[i] != '1') || input.Length > 32)
                    {
                        inputError = false;
                        break;
                    }
            }

            string hexNumber = ToHex(input.PadLeft(32, '0'));  //The binary value is kept as a string

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} (2) = {1} (16)", input.PadLeft((hexNumber.Length * 4), '0'), hexNumber);   //Printing the result
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}