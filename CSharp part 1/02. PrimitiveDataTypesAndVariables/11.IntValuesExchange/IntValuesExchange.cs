//Задача №11
//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class IntValuesExchange
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;
        Console.WriteLine("Before value exchange: a={0}; b={1}", firstNumber, secondNumber);
        int exchangeNumber = secondNumber;  //Въвеждам трета променлива, чрез която извършвам размяната на стойностите.
        secondNumber = firstNumber;
        firstNumber = exchangeNumber;
        Console.WriteLine("After value exchange: a={0}; b={1}", firstNumber, secondNumber);
    }
}