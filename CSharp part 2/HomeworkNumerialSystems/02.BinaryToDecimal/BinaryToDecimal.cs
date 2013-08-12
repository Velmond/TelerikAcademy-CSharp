//02. Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static int ToDecimal(string binaryNumber)
    {
        int decimalNumber = 0;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)  //The loop goes throu the string from the last to the first digit,
            decimalNumber += (int)((binaryNumber[i] - 48) * Math.Pow(2, ((binaryNumber.Length - 1) - i)));  //...multiplying them by
                                                            //...2 to the power of the digit's index in the string 
        return decimalNumber;
    }

    static void Main()
    {
        while (true)
        {
            Console.Write("Please input an integer in binary to convert it to decimal\n(or type \"exit\" to stop the program) - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine().ToLower();        //The input is kept as string
            Console.ForegroundColor = ConsoleColor.Gray;

            if (input == "exit")        //Checks if the input is "exit" so that the program breaks out of
                break;                  //the infinite while-loop

            bool inputError = true;     //By default I consider that the user will input a valid value consisting of 1s and 0s
            for (int i = 0; i < input.Length; i++)
                if (input[i] != '0' && input[i] != '1' || input.Length > 32)    //If not or the input is longet than 32 characters
                {                                                               //(the number of bits for an int) than the input is
                    inputError = false;                                         //considered invalid
                    break;
                }

            while (!inputError)     //The input is redone until it is valid
            {
                Console.Write("Incorect input! Please try again - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                input = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (input == "exit")
                    return;

                inputError = true;

                for (int i = 0; i < input.Length; i++)
                    if (input[i] != '0' && input[i] != '1' || input.Length > 32)
                    {
                        inputError = false;
                        break;
                    }
            }

            int decimalNumber = ToDecimal(input);  //The decimal value is kept as a int

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} (2) = {1} (10)", input.PadLeft(32, '0'), decimalNumber);   //Printing the result
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}