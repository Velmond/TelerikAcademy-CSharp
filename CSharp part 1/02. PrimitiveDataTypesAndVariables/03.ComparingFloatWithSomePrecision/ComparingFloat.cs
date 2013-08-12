//Задача №3
//Write a program that safely compares floating-point numbers with precision of 0.000001.
//Examples:(5.3 ; 6.01) => false;  (5.00000001 ; 5.00000003) => true

using System;

class ComparingFloat
{
    static void Main()
    {
        float firstValue = 5.3f;
        float secondValue = 6.01f;
        float presitionCheck = 0.000001f;
        bool result = (Math.Abs(firstValue - secondValue) <= presitionCheck);
        Console.WriteLine("({0} ; {1}) => {2}", firstValue, secondValue, result);
        double firstValueD = 5.00000001;    //Въвеждам ги като double, въпреки че условието иска да са float тъй като при подобни стойности с float тип в конзолата
        double secondValueD = 5.00000003;   //не се изписва "(5.00000001 ; 5.00000003)", а "(5 ; 5)", поради по-ниската точност. Иначе задачата работи и с float.
        bool resultD = (Math.Abs(firstValueD - secondValueD) <= presitionCheck);
        Console.WriteLine("({0} ; {1}) => {2}", firstValueD, secondValueD, resultD);
    }
}