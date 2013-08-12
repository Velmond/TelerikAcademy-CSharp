//Задача №12
//Find online more information about ASCII (American Standard Code for Information Interchange)
//and write a program that prints the entire ASCII table of characters on the console.
//http://www.asciitable.com/

using System;
using System.Text;

class ASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.ASCII;    //Решението правя чрез цикъл, в който залагам условия, за изписването на
        for (int i = 0; i <= 127; i++)              //някои функции, които няма как да се визуализират на конзолата като
        {                                           //"\n"-нов ред, "\t"-хоризонтална табулация,"\a"-звуков сигнал и т.н.
            char c = (char)i;                       //Подобно решение, от което ми дойде идеята, може да се види на следния
            string symbol="";
            if (c == '\n')                          //линк -> http://www.dotnetperls.com/ascii-table
            {
                symbol = "\\n";
                //Console.WriteLine("The charecter in posision {0} is: {1}", i, "\\n");       //нов ред
            }
            else if (c == '\b')
            {
                symbol = "\\b";
                //Console.WriteLine("The charecter in posision {0} is: {1}", i, "\\b");       //backspace
            }
            else if (c == '\t')
            {
                symbol = "\\t";
                //Console.WriteLine("The charecter in posision {0} is: {1}", i, "\\t");       //хоризонтална табулация
            }
            else if (c == '\r')
            {
                symbol = "\\r";
                //Console.WriteLine("The charecter in posision {0} is: {1}", i, "\\r");       //return
            }
            else if (c == '\v')
            {
                symbol = "\\v";
                // Console.WriteLine("The charecter in posision {0} is: {1}", i, "\\v");       //вертикална табулация
            }
            else if (c == '\f')
            {
                symbol = "\\f";
                //Console.WriteLine("The charecter in posision {0} is: {1}", i, "\\f");       //нова страница
            }
            else if (c == '\a')
            {
                symbol = "\\a";
                //Console.WriteLine("The charecter in posision {0} is: {1}", i, "\\a");       //звуков сигнал
            }
            else if (c == ' ')
            {
                symbol = "space";
                //Console.WriteLine("The charecter in posision {0} is: {1}", i, "space");
            }
            else if (char.IsControl(c))
            {
                symbol = "control";
                //Console.WriteLine("The charecter in posision {0} is: {1}", i, "control");
            }
            Console.WriteLine("The charecter in posision {0} is: {1}", i, symbol);
            //else
            {
            //    Console.WriteLine("The charecter in posision {0} is: {1}", i, c);
                //всички стандартни символи
            }
        }
    }
}