//Задача №1
//Declare five variables choosing for each of them the most appropriate 
//of the types byte, sbyte, short, ushort, int, uint, long, ulong 
//to represent the following values: 52130, -115, 4825932, 97, -10000.

using System;

class AppropriateType
{
    static void Main()
    {
        ushort number52130 = 52130;
        sbyte numberN115 = -115;
        uint number4825932 = 4825932;
        byte number97 = 97;
        short numberN10000 = -10000;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", number52130, numberN115, number4825932, number97, numberN10000);
    }
}