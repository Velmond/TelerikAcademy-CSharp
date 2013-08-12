using System;

class Age
{
    static void Main()
    {
        Console.Write("Your age is: ");
        string input = Console.ReadLine();
        byte currAge;
        bool errorDetect = byte.TryParse(input, out currAge);
        while (errorDetect == false)
        {
            Console.Write("\nYou have not entered a valid number. Try again: ");
            input = Console.ReadLine();
            errorDetect = byte.TryParse(input, out currAge);
        }
        if (errorDetect == true && currAge>120)
        {
            Console.WriteLine("\nJust be happy you've lasted this far...\n");
        }
        else
        {
            DateTime yearNow = DateTime.Today;
            DateTime yearBirth = yearNow.AddYears(-currAge);
            DateTime yearFut = yearNow.AddYears(10);
            TimeSpan span = yearFut - yearBirth;
            int futAgeDays = span.Days;
            int futAge = futAgeDays / 365;
            Console.WriteLine("\nIn 10 years you should be: {0} years old.\n", futAge);
        }
    }
}
