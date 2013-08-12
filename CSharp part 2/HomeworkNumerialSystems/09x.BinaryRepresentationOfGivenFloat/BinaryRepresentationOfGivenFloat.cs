//09. *Write a program that shows the internal binary representation of given 
//32-bit signed floating-point number in IEEE 754 format (the C# type float). 
//Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

//To check the results with an online converter: http://www.binaryconvert.com/convert_float.html?decimal=045049050051046052053054

using System;

class BinaryRepresentationOfGivenFloat
{
    static bool GetSignBit(float inputNumber)   //Returns true if the number is negative (the bit should be 1)
    {                                           //and false if it's positive (the bit should be 0)
        if (inputNumber < 0)
            return true;
        else
            return false;
    }

    static string IntegerToBinary(int integer)  //Simple transformation of the integer part of the decimal number to binary
    {
        string binaryIntegerNumber = "";

        while (integer != 0)
        {
            binaryIntegerNumber = integer % 2 + binaryIntegerNumber;
            integer /= 2;
        }

        return binaryIntegerNumber;
    }

    static string FractionToBinary(float fraction)  //Transformation of the fraction part of the decimal number to binary
    {
        string binaryFractionNumber = "";
        fraction *= 2;

        while (fraction != 0)
        {
            binaryFractionNumber += (int)fraction;
            fraction -= (int)fraction;
            fraction *= 2;
        }

        return binaryFractionNumber;
    }

    static string GetExponent(string integer, string fraction)  //Returns a string representing the 8 bits of the exponent
    {
        int exponent;

        if (integer.Length != 0)            //If the number is lesser than -1 or greater than 1
            exponent = integer.Length - 1;
        else                                //If the number is in the interval (-1; 1)
            exponent = -fraction.IndexOf('1') - 1;

        string binaryExponent = IntegerToBinary(127 + exponent).PadLeft(8, '0');    //If the exponent is less than 8 bits, the rest
                                                                                    //of the string is filled with 0s
        return binaryExponent;
    }

    static string GetMantissa(string integer, string fraction)  //Returns a string representing the 23 bits of the mantissa
    {
        string mantissa;

        if (integer.Length != 0)            //If the number is lesser than -1 or greater than 1
            mantissa = integer.Substring(1) + fraction;     //Always starts with a 1
        else                                //If the number is in the interval (-1; 1)
            mantissa = fraction.Substring(fraction.IndexOf('1') + 1); //When there id no integer part we get the first 1 in the fraction

        return mantissa.PadRight(23, '0');  //If the exponent is less than 23 bits, the rest of the string is filled with 0s
    }

    static void Main()
    {
        while (true)
        {
            float inputNumber;
            Console.Write("Input the floating point value you want to convert to binary - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.Gray;

            if (input == "exit")    //If the input is "exit" the program breaks out of the infinite while-loop
                return;

            bool inputError = Single.TryParse(input, out inputNumber);
            while (!inputError)
            {
                Console.Write("Incorrect input. Try again - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                input = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (input == "exit")
                    return;

                inputError = float.TryParse(input, out inputNumber);
            }

            //The float type is represented with 32 bits = 1 for sign + 8 for the exponent + 23 for the mantissa

            char sign;
            if (GetSignBit(inputNumber))    //Gets the bit determined by the sign
            {
                sign = '1';
                inputNumber *= -1;          //If the number is negative we turn it positive for ease of work
            }
            else
                sign = '0';

            string integer = IntegerToBinary((int)inputNumber);                 //Transforms the integer part of the number to binary.
            string fraction = FractionToBinary(inputNumber - (int)inputNumber); //Transforms the fraction part of the number to binary.

            string binaryNumber = sign + GetExponent(integer, fraction) + GetMantissa(integer, fraction);
            //Transforms and stiches together all the parts of the number to get one string

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(binaryNumber);                    //Printing the result
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}