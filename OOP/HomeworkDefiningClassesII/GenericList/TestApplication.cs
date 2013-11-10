namespace GenericList
{
    using System;
    using System.Collections.Generic;

    public class TestApplication
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>();

            list.Add(0);
            list.Add(1);
            //Console.WriteLine(list[2]);

            list.Insert(1, 4);
            list[0] = 2;
            list[2] = 3;
            //list[3] = 3;

            Console.Write("Accessing by index (list[1]): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(list[1]);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("ToString(): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(list.ToString());
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Min<int>(): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(list.Min<int>());
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Max<int>(): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(list.Max<int>());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}