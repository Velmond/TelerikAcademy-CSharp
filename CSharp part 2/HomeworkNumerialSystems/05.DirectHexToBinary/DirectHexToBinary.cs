//05. Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class DirectHexToBinary
{
    static string ToBinary(string hexNumber)  //The solution works for unsigned numbers only
    {
        string binaryNumber = "";  //The values corresponding to each of the digits of the hex number are added to this string
        for (int i = 0; i < hexNumber.Length; i++)  //Goes through each of the digits of the hexadecimal number
            switch (hexNumber[i])
            {
                case '0': binaryNumber += "0000"; break;
                case '1': binaryNumber += "0001"; break;
                case '2': binaryNumber += "0010"; break;
                case '3': binaryNumber += "0011"; break;
                case '4': binaryNumber += "0100"; break;
                case '5': binaryNumber += "0101"; break;
                case '6': binaryNumber += "0110"; break;
                case '7': binaryNumber += "0111"; break;
                case '8': binaryNumber += "1000"; break;
                case '9': binaryNumber += "1001"; break;
                case 'A': binaryNumber += "1010"; break;
                case 'B': binaryNumber += "1011"; break;
                case 'C': binaryNumber += "1100"; break;
                case 'D': binaryNumber += "1101"; break;
                case 'E': binaryNumber += "1110"; break;
                case 'F': binaryNumber += "1111"; break;
            }

        return binaryNumber;
    }

    static void Main()
    {
        while (true)
        {
            Console.Write("Please input an integer in hexadecimal to convert it to binary\n(or type \"exit\" to stop the program) - ");
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

            string binaryNumber = ToBinary(input);  //The binary value is kept as a string

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} (16) = {1} (2)", input, binaryNumber.PadLeft(32, '0'));   //Printing the result
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}