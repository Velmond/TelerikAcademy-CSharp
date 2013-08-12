//08. Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;

class SumTwoBigIntegersWithAMethod
{
    static string Input()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        string inputValue = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        bool inputError = true;
        for (int i = 0; i < inputValue.Length; i++)
        {
            if (inputValue[i] < '0' || inputValue[i] > '9')
                inputError = false;
        }
        while (!inputError)
        {
            inputError = true;
            Console.Write("Incorect input! Try again - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            inputValue = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < inputValue.Length; i++)
                if (inputValue[i] < '0' || inputValue[i] > '9')
                    inputError = false;
        }

        return inputValue;
    }

    static string Reverse(string inputValue)    //Обръщам стойностите така, че да започва от единици, преминавайки през десетици, стотици,
    {                                           //и т.н., както се изисква в условието
        char[] array = new char[inputValue.Length];
        for (int i = (inputValue.Length - 1), j = 0; (i >= 0) && (j < inputValue.Length); i--, j++)
            array[i] = inputValue[j];

        return new string(array);               //Резултата връщам отново като string
    }

    static string BigIntegerSum(string firstInteger, string secondInteger)
    {
        string reversedSum = "";    //Сумата също приемам като string, като в началото и тя ще е обърната, тъй като събираните числа са
        if (firstInteger.Length < secondInteger.Length)     //Искам първото число да е това с по-голяма дължина
        {
            string temp = firstInteger;
            firstInteger = secondInteger;
            secondInteger = temp;
        }
        bool toCarry = false;   //Тъй като числата само ще се събират няма да има повече от 1 "на ум", за това приама
                                //променлива тип bool за това дали ще има или няма да има пренос "на ум"
        int toAdd = 0;

        for (int i = 0; i < firstInteger.Length; i++)
        {
            if (i < secondInteger.Length)
            {
                if (toCarry)
                    toAdd = firstInteger[i] + secondInteger[i] + 1 - (2 * 48);  //Вадя 48, за да се смята с реалните числа, а не със
                else                                                            //стойностите им от ASCII таблиците
                    toAdd = firstInteger[i] + secondInteger[i] - (2 * 48);

                reversedSum += toAdd % 10;  //Реално добавям към обърнатата сума остатъка от toAdd при делене на 10

                if (toAdd > 9)              //Ако toAdd има стойност над 9, то ще има за пренос 1 "на ум"
                    toCarry = true;
                else
                    toCarry = false;
            }
            else                            //Там където по-малкото число няма стойности, по-голямото може да се събира с 1 "на ум"
            {
                if (toCarry)
                    toAdd = firstInteger[i] + 1 - 48;
                else
                    toAdd = firstInteger[i] - 48;

                reversedSum += toAdd % 10;

                if (toAdd > 9)
                    toCarry = true;
                else
                    toCarry = false;
            }
        }
        if (toCarry)
            reversedSum += 1;

        return Reverse(reversedSum);    //Използвам горния метод, да обърна сумата, така че числата да са в правилната си последователност
    }

    static void Main()
    {
        Console.Write("Input the first integer - ");
        string firstInteger = Input();                  //Въведените стойности на числата оставям като стрингове, тъй като няма тип
                                                        //данни, който да побере такива числа (приемам, че BigInteger не съществува)
        Console.Write("Input the second integer - ");
        string secondInteger = Input();

        Console.WriteLine("{0} + {1} = ", firstInteger, secondInteger);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(BigIntegerSum(Reverse(firstInteger), Reverse(secondInteger)));
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}