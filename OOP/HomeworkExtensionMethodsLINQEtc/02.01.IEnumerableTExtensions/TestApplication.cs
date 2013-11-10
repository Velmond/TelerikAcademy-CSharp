namespace IEnumerableTExtensions
{
    using System;
    using System.Collections.Generic;

    class TestApplication
    {
        static void Main()
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("{0}", list.Sum());
            Console.WriteLine("{0}", list.Product());
            Console.WriteLine("{0}", list.Min());
            Console.WriteLine("{0}", list.Max());
            Console.WriteLine("{0}", list.Average());
        }
    }
}