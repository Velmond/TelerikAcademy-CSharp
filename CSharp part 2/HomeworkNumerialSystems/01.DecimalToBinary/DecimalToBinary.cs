//01. Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static string ToBinary(int number)  //The solution works for signed integers
    {
        string reverseBinaryNumber = "";    //The binary number is stiched bit by bit from the last to the first and needs to be
                                            //reverced ones its value is found
        int numberToConvert = number;       //I use another value to do the conversion with so that I can keep my number as it is 
                                            //in case it is negative witch will determine the value of the first bit
        if (number < 0)
            numberToConvert = -(int.MinValue - number);     //The value of the number if it is negative is turned to what it would
                                                            //be if it was positive (without the first bit)
        do
        {
            reverseBinaryNumber += (numberToConvert % 2);
            numberToConvert /= 2;
        } while (numberToConvert != 0);

        if (number >= 0)            //The binary value is stiched with the needed number of zeros to make it 31 bits long (as an int)
            reverseBinaryNumber = reverseBinaryNumber.PadRight(31, '0') + "0";  //...and in the end, depending of its sign it gets
        else                                                                    //...a 0 for "+" or a 1 for "-"
            reverseBinaryNumber = reverseBinaryNumber.PadRight(31, '0') + "1";

        string binaryNumber = "";
        for (int i = reverseBinaryNumber.Length - 1; i >= 0; i--)   //The real binary number we get by reversing the value we 
            binaryNumber += reverseBinaryNumber[i];                 //got so far

        return binaryNumber;
    }

    static void Main()
    {
        while (true)
        {
            int decimalNumber;
            Console.Write("Please input an integer in decimal to convert it to binary\n(or type \"exit\" to stop the program) - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine().ToLower();        //The input is kept as string
            Console.ForegroundColor = ConsoleColor.Gray;

            if (input == "exit")        //Checks if the input is "exit" so that the program breaks out of the infinite while-loop
                break;

            bool inputError = int.TryParse(input, out decimalNumber);   //If the input is not "exit" the program continues with
                                                                        //trying to parse the input as int in decimalNumber
            while (!inputError)     //If it can't parse the input, the input repeats untill it can
            {
                Console.Write("Incorect input! Please try again - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                input = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (input == "exit")
                    break;

                inputError = int.TryParse(input, out decimalNumber);
            }

            string binaryNumber = ToBinary(decimalNumber);  //The binary value is kept as a string

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} (10) = {1} (2)", decimalNumber, binaryNumber);   //Printing the result
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}