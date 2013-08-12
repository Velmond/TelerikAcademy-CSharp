using System;

class Age
{
    static void Main()
    {
        Console.Write("How old are you? ");
        string input = Console.ReadLine();
        byte currAge;
        bool errorDetect = byte.TryParse(input, out currAge);
        while (errorDetect == false)
        {
            Console.Write("\nYou have not entered a valid number. Please try again: ");
            input = Console.ReadLine();
            errorDetect = byte.TryParse(input, out currAge);
        }
        if (errorDetect == true && currAge > 120)
        {
            Console.WriteLine("\nThis program wasn't ment to be used be mummies... \nJust be happy you've lasted this far.\n");
        }
        else
        {
            int yearNow = DateTime.Today.Year;
            int yearBirth = DateTime.Today.AddYears(-currAge).Year;
            int yearFut = DateTime.Today.AddYears(10).Year;
            int futAge = yearFut - yearBirth;
            Console.WriteLine("\nIt is the year: \t{0} \nYou were born in: \t{1} (or {2} if you haven't had your birthday yet)"+
                              "\nIn 10 years you'll be: \t{3} years old \nDuh!\n", yearNow, yearBirth, (yearBirth-1), futAge);
        }
    }
}