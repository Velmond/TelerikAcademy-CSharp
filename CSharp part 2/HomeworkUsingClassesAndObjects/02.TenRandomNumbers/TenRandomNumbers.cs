//02. Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class TenRandomNumbers
{
    static void Main()
    {
        Random randomGenerator = new Random();

        for (int i = 0; i < 10; i++)
        {
            int randomNumber = randomGenerator.Next(100, 201);  //using random.Next() we can set from what interval we want the numbers
            Console.WriteLine(randomNumber);                    //The interval is closed at the start and open at the end -> [100, 201)
        }                                                       //meaning it can't get the digit that is ponted as the upper boundary
    }
}