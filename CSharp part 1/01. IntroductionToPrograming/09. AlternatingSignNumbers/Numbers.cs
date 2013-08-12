using System;

class Numbers
{
    static void Main()
    {
        for (byte i = 2; i <= 11; i++)
        {
            Console.WriteLine(i * Math.Pow(-1,i));
        }
    }
}
