//01.01. Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
//01.02. Write a program to test this method.

using System;

public class HelloName                          //Програмата е направена, както е, за да мога да направя тестовете, защото не намерих
{                                               //как да ги направя, ако използвам void метод, питащ и директно изписващ "Hello, name!"
    public static string AskName(string name)
    {
        string result = "Hello, " + name + "!";
        return result;
    }
    
    public static void Main()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine(AskName(name));
    }
}