//03. Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;

class WhatDayItIs
{
    static void Main()
    {
        var dayOfWeek = DateTime.Now.DayOfWeek;     //The easiest way is using DateTime.DayOfWeek to get the day of the week

        Console.Write("Today is "); 
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(dayOfWeek);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}