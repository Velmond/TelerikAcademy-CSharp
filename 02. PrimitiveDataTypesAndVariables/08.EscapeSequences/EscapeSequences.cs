//Задача №8
//Declare two string variables and assign them with following value:
//"The "use" of quotations causes difficulties."
//Do the above in two different ways: with and without using quoted strings.

using System;

class EscapeSequences
{
    static void Main()
    {
        Console.WriteLine("The \"use\" of quotations causes difficulties.");
        Console.WriteLine(@"The ""use"" of quotations causes difficulties.");
    }
}