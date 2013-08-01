//Задача №12
//We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators 
//that modifies n to hold the value v at the position p from the binary representation of n.
//Example:  n = 5 (00000101), p=3, v=1 => 13 (00001101)
//          n = 5 (00000101), p=2, v=0 => 1 (00000001)

using System;

class ModifyABitOfANumber
{
    static void Main()
    {
        Console.Write("What number would you like a bit modified to? ");
        int number;
        bool errorDetect = int.TryParse(Console.ReadLine(), out number);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out number);
        }
        Console.Write("Witch bit would you like to modify (0 to 31)? ");
        byte position;
        errorDetect = byte.TryParse(Console.ReadLine(), out position);
        while (errorDetect == false || position >= 32)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = byte.TryParse(Console.ReadLine(), out position);
        }
        Console.Write("What value would you like the bit to take (0 or 1)? ");
        byte value;
        errorDetect = byte.TryParse(Console.ReadLine(), out value);
        while (errorDetect == false || (value != 0 && value != 1))
        {
            Console.Write("You've entered an invalid number. Try again (0 or 1) - ");
            errorDetect = byte.TryParse(Console.ReadLine(), out value);
        }
        int mask;
        int newNumber;
        if (value == 0)
        {
            mask = ~(1 << position);
            newNumber = number & mask;
        }
        else
        {
            mask = 1 << position;
            newNumber = number | mask;
        }
        Console.Clear();
        Console.WriteLine("Number: {0}\t\tNumber in bits: {1}\nPosition: {2}\t\tValue: {3}", number, Convert.ToString(number, 2), position, value);
        Console.WriteLine("New number: {0}\t\tNew number in bits: {1}\n", newNumber, Convert.ToString(newNumber, 2));
    }
}
