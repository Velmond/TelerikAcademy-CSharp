using System;

class Age
{
    static void Main()
    {
        Console.Write("How old are you? ");
        string input = Console.ReadLine();
        byte age;
        bool errorDetect = byte.TryParse(input, out age);
        while (errorDetect == false)
        {
            Console.Write("\nYou have not entered a valid number. Try again: ");
            input = Console.ReadLine();
            errorDetect = byte.TryParse(input, out age);
        }
        if (errorDetect == true && age>120)
        {
            Console.WriteLine("\nJust be happy you've lasted this far...\nYou'd be {0} if you're still alive in 10 years.\n", (age += 10));
        }
        else
        {
            Console.WriteLine("\nIn 10 years you should be: {1} years old.\n",age,(age += 10));
        }
    }
}