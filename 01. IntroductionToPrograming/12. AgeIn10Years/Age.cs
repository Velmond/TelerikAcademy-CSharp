using System;

class Age
{
    static void Main()
    {
        Console.Write("Your age is: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("\nIn 10 years you'll be: {0} years old.\n", (age += 10));
    }
}