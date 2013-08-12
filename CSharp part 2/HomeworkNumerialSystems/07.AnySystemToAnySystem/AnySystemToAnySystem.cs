//07. Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

//To check the results with an online converter: http://www.kaagaard.dk/service/convert.htm
//I can't think of a way to represent the input numbers once all the digits and letters are gone so I put a limit on s and
//...it can't be more than 36 (10 digits + 26 letters)

using System;

class AnySystemToAnySystem
{
    static uint ToDecimal(string inputNumber, byte baseOfInput)
    {
        uint decimalNumber = 0;

        for (int i = inputNumber.Length - 1; i >= 0; i--)  //The loop goes throu the string from the last to the first digit, multiplying 
            if (inputNumber[i] >= '0' && inputNumber[i] <= '9') //...them by the base to the power of the digit's index in the string 
                decimalNumber += (uint)((inputNumber[i] - 48) * Math.Pow(baseOfInput, ((inputNumber.Length - 1) - i)));
            else
                decimalNumber += (uint)((inputNumber[i] - 55) * Math.Pow(baseOfInput, ((inputNumber.Length - 1) - i)));

        return decimalNumber;
    }

    static string ToBaseD(uint decimalNumber, byte baseOfOutput)
    {
        string reverseNumber = "";  //The number is stiched character by character from the last to the first and needs to be 
        do                          //reverced ones its value is found
        {
            switch (decimalNumber % baseOfOutput)
            {
                case 10: reverseNumber += 'A'; break;
                case 11: reverseNumber += 'B'; break;
                case 12: reverseNumber += 'C'; break;
                case 13: reverseNumber += 'D'; break;
                case 14: reverseNumber += 'E'; break;
                case 15: reverseNumber += 'F'; break;
                default: reverseNumber += (decimalNumber % baseOfOutput); break;
            }
            decimalNumber /= baseOfOutput;
        } while (decimalNumber != 0);

        string outputNumber = "";
        for (int i = reverseNumber.Length - 1; i >= 0; i--)     //The real number we get by reversing the value we got so far
            outputNumber += reverseNumber[i];

        return outputNumber;
    }

    static void Main()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Type \"exit\" at any point to stop the program.");
            Console.ForegroundColor = ConsoleColor.Gray;

            byte baseOfInput;
            Console.Write("Please input the base in which the input will be (s = 2 to 36) - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.Gray;

            if (input == "EXIT")        //Checks if the input is "exit" so that the program breaks out of
                return;                 //the infinite while-loop

            bool inputError = byte.TryParse(input, out baseOfInput);
            while (!inputError || (baseOfInput < 2 || baseOfInput > 36))     //The input is redone until it is valid
            {
                Console.Write("Incorect input! Please try again (s = 2 to 36) - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                input = Console.ReadLine().ToUpper();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (input == "EXIT")
                    return;

                inputError = byte.TryParse(input, out baseOfInput);
            }

            byte baseOfOutput;
            Console.Write("Please input the base in which the output should be (d = 2 to 16) - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.Gray;

            if (input == "EXIT")
                return;

            inputError = byte.TryParse(input, out baseOfOutput);
            while (!inputError || (baseOfOutput < 2 || baseOfOutput > 16))     //The input is redone until it is valid
            {
                Console.Write("Incorect input! Please try again (d = 2 to 16) - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                input = Console.ReadLine().ToUpper();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (input == "EXIT")
                    return;

                inputError = byte.TryParse(input, out baseOfInput);
            }

            Console.Write("Please input a positive integer in base {0} to be converted to base {1} - ", baseOfInput, baseOfOutput);
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine().ToUpper();        //The input is kept as string
            Console.ForegroundColor = ConsoleColor.Gray;

            if (input == "EXIT")
                return;          

            inputError = true;          //By default I consider that the user will input a valid value
            for (int i = 0; i < input.Length; i++)    //If not the input is considered invalid
            {
                if (baseOfInput <= 10 && (input[i] < '0' || input[i] > (char)(48 + baseOfInput)))
                {
                    inputError = false;
                    break;
                }
                else if (baseOfInput > 10 && (input[i] < '0' || input[i] > '9') && (input[i] < 'A' ||
                         input[i] > (char)(54 + baseOfInput)))
                {
                    inputError = false;
                    break;
                }
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
                {
                    if (baseOfInput <= 10 && (input[i] < '0' || input[i] > (char)(48 + baseOfInput)))
                    {
                        inputError = false;
                        break;
                    }
                    else if (baseOfInput > 10 && (input[i] < '0' || input[i] > '9') && (input[i] < 'A' ||
                             input[i] > (char)(54 + baseOfInput)))
                    {
                        inputError = false;
                        break;
                    }
                }
            }

            string output;
            if (baseOfInput != 10 && baseOfOutput == 10)
                output = ToDecimal(input, baseOfInput).ToString();
            else if (baseOfInput != 10 && baseOfOutput == 10)
                output = ToBaseD(uint.Parse(input), baseOfOutput);
            else
                output = ToBaseD(ToDecimal(input, baseOfInput), baseOfOutput);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} ({1}) = {2} ({3})", input, baseOfInput, output, baseOfOutput);   //Printing the result
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}