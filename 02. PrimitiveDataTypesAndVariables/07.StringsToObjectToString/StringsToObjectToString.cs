//Задача №7
//Declare two string variables and assign them with “Hello” and “World”.
//Declare an object variable and assign it with the concatenation of the
//first two variables (mind adding an interval). Declare a third string
//variable and initialize it with the value of the object variable
//(you should perform type casting).

using System;

class StringsToObjectToString
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object helloWorld = hello + " " + world;
        string strHelloWorld = (string)helloWorld;
        Console.WriteLine("String: {0} \nString: {1} \nObject: {2} \nString: {3}\n", hello, world, helloWorld, strHelloWorld);
    }
}