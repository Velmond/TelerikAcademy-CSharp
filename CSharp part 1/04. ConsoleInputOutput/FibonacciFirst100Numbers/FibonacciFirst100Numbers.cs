//Задача №9
//Write a program to print the first 100 members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class FibonacciFirst100Numbers
{
    static void Main()
    {
        decimal theNumber = 0;
        decimal nextNumber = 1;
        for (int i = 1; i <= 100; i++)
        {
            if (i == 1) //За първия член на редицата (0) не се извършват никакви операции и се преминава директно към
            {           //...изписване на Console.WriteLine-ът след оператора else
                Console.WriteLine("\t\tSequence of Fibonacci\n\t\t (first 100 members)\n");
            }
            else        //За всеки следващ член на редицата     
            {
                decimal prevNumber = theNumber;
                theNumber = nextNumber;
                nextNumber = prevNumber + theNumber;                                       // | Подравнявам числата отдясно
            }                                                                              // V ...и оставям място за 32 цифри
            Console.WriteLine("\t{0}|{1}", i.ToString().PadLeft(3, '0'), theNumber.ToString().PadLeft(32));
        }                                                    // ^ Приемам формат на номерацията на редицата 000, тъй като
        Console.WriteLine();                                 //...след 139-тия член програмата "гръмва", тъй като числото
    }                                                        //...става прекалено голямо за decimal (50095301248058391139327916261)
}