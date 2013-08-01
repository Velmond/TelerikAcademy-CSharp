//Задача №13
//Create a program that assigns null values to an integer and to double variables.
//Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

class NullIntAndDouble
{
    static void Main()          //Сложил съм "_" пред и зад променливата със стойност null.
    {
        int? aInt = null;
        double? aDouble = null;
        Console.WriteLine("Null int is: _{0}_ \nNull double is: _{1}_", aInt, aDouble);
        int? aInt2 = aInt + 2;
        double? aDouble2 = aDouble + 2;
        Console.WriteLine("\n+2 to each of them: \nNull int + 2 is: _{0}_ \nNull double + 2 is: _{1}_", aInt2, aDouble2);
        int? aInt3 = aInt + null;
        double? aDouble3 = aDouble + null;
        Console.WriteLine("\n+\"null\" to each of them: \nNull int + null is: _{0}_ \nNull double + null is: _{1}_\n", aInt3, aDouble3);
    }
}