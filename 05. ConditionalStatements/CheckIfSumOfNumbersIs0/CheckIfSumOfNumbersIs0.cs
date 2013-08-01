//Задача 9
//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
//Example: 3, -2, 1, 1, 8 => 1+1-2=0.

using System;

class InputIntDoubleOrStringWithSwitch
{
    static void Main()
    {
        Console.Write("Input first integer: ");     //Не правя валидация на кода, тъй като задачата и без това към момента
        int a = int.Parse(Console.ReadLine());      //... е прекалено дълга (ако не съм качил преработен вариант, след като
        Console.Write("Input second integer: ");    //... изгледам лекциите за масиви)
        int b = int.Parse(Console.ReadLine());
        Console.Write("Input third integer: ");     //Като пример за тестване може да се използва 2, 4, -4, 2, -2
        int c = int.Parse(Console.ReadLine());      //... дава 6 комбинации чиято сума е 0 (3 от 2 стойности, 1 от 3 и 2 от 4)
        Console.Write("Input forth integer: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Input fifth integer: ");
        int e = int.Parse(Console.ReadLine());
        Console.Clear();

        //Надявам се да сменя кода на тази задача преди да изтече срока, но в случай, че не съм и е останало това решение
        //...искам да поясня няколко мои решения. С цел окомпактоване на кода около 3 пъти съм премахнал фигурните скоби на
        //...if-овете и съм качил единия ред, който трябва да се изпълни, ако усливоето в скобите се покрива, на същия ред. 
        //Въпреки че и двете са лоши практики, в този случая ми изглежда по-добре от 150 реда код, в които на практика се 
        //...повтарят едни и същи сметки.
        
        Console.WriteLine("1ST integer:\t{0}\n2ND integer:\t{1}\n3RD integer:\t{2}\n4TH integer:\t{3}\n5TH integer:\t{4}\n", a, b, c, d, e);
        Console.WriteLine("Combinations in witch the sum is 0:");
        //За групата от 5 стойности
        if ((a + b + c + d + e) == 0) Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", a, b, c, d, e, (a + b + c + d + e));
        //За всички групи от 4 стойности
        if ((a + b + c + d) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, c, d, a + b + c + d);
        if ((a + b + c + e) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, c, e, a + b + c + e);
        if ((a + b + d + e) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, d, e, a + b + d + e);
        if ((a + c + d + e) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, c, d, e, a + c + d + e);
        if ((b + c + d + e) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = {4}", b, c, d, e, b + c + d + e);
        //За всички групи от 3 стойности
        if ((a + b + c) == 0) Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
        if ((a + b + d) == 0) Console.WriteLine("{0} + {1} + {2} = {3}", a, b, d, a + b + d);
        if ((a + b + e) == 0) Console.WriteLine("{0} + {1} + {2} = {3}", a, b, e, a + b + e);
        if ((a + c + d) == 0) Console.WriteLine("{0} + {1} + {2} = {3}", a, c, d, a + c + d);
        if ((a + c + e) == 0) Console.WriteLine("{0} + {1} + {2} = {3}", a, c, e, a + c + e);
        if ((a + d + e) == 0) Console.WriteLine("{0} + {1} + {2} = {3}", a, d, e, a + d + e);
        if ((b + c + d) == 0) Console.WriteLine("{0} + {1} + {2} = {3}", b, c, d, b + c + d);
        if ((b + c + e) == 0) Console.WriteLine("{0} + {1} + {2} = {3}", b, c, e, b + c + e);
        if ((b + d + e) == 0) Console.WriteLine("{0} + {1} + {2} = {3}", b, e, e, b + e + e);
        if ((c + d + e) == 0) Console.WriteLine("{0} + {1} + {2} = {3}", c, d, e, c + d + e);
        //За всички групи от 2 стойности
        if ((a + b) == 0) Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        if ((a + c) == 0) Console.WriteLine("{0} + {1} = {2}", a, c, a + c);
        if ((a + d) == 0) Console.WriteLine("{0} + {1} = {2}", a, d, a + d);
        if ((a + e) == 0) Console.WriteLine("{0} + {1} = {2}", a, e, a + e);
        if ((b + c) == 0) Console.WriteLine("{0} + {1} = {2}", b, c, b + c);
        if ((b + d) == 0) Console.WriteLine("{0} + {1} = {2}", b, d, b + d);
        if ((b + e) == 0) Console.WriteLine("{0} + {1} = {2}", b, e, b + e);
        if ((c + d) == 0) Console.WriteLine("{0} + {1} = {2}", c, d, c + d);
        if ((c + e) == 0) Console.WriteLine("{0} + {1} = {2}", c, e, c + e);
        if ((d + e) == 0) Console.WriteLine("{0} + {1} = {2}", d, e, d + e);
        Console.WriteLine();
    }
}