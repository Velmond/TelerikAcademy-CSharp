//Задача №13
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

//За проверка може да се използва следния пример:
//Number:         251723520
//In bits:        0000 1111 0000 0000 1111 1111 0000 0000 - не са разделени при изписване на конзолата
//New number:     134283064
//In bits:        0000 1000 0000 0000 1111 1111 0011 1000 - не са разделени при изписване на конзолата

//За това как работи програмата може да се погледнат разясненията по задача 14. Направил съм ги да работят по аналогичен начин.

using System;

class Exchange3BitsWithAnother3Bits
{
    static void Main()
    {
        Console.Write("In what number would you like to swap the bits? ");
        uint startNumber;
        bool errorDetect = uint.TryParse(Console.ReadLine(), out startNumber);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out startNumber);
        }
        uint number = startNumber;
        uint newNumber = 0;
        byte positionI;
        uint bitTempValue;
        for (positionI = 3; positionI <= 5; positionI++)
        {
            uint mask = (uint)1 << positionI;
            uint numberAndMask = number & mask;
            uint bitIValue = numberAndMask >> positionI;
            mask = (uint)1 << (positionI + 21);
            numberAndMask = number & mask;
            uint bitI2Value = numberAndMask >> (positionI + 21);
            bitTempValue = bitI2Value;
            if (bitIValue == 0)
            {
                mask = (uint)~(1 << (positionI + 21));
                newNumber = number & mask;
            }
            else
            {
                mask = (uint)1 << (positionI + 21);
                newNumber = number | mask;
            }
            number = newNumber;
            if (bitTempValue == 0)
            {
                mask = (uint)~(1 << positionI);
                newNumber = number & mask;
            }
            else
            {
                mask = (uint)1 << positionI;
                newNumber = number | mask;
            }
            number = newNumber;
        }
        Console.WriteLine("\nNumber: \t{0}\nIn bits:\t{1}", startNumber, Convert.ToString(startNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("New number:\t{0}\nIn bits:\t{1}\n", number, Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}