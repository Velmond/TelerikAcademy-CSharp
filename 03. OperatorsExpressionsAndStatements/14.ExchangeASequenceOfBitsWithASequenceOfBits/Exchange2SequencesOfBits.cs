//Задача №14
//Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class Exchange3BitsWithAnother3Bits
{
    static void Main()
    {
        Console.Write("In what number would you like to swap the bits? ");      //За проверка може да се използва: 
        uint startNumber;                                                       //251723520 = 1111 0000 0000 1111 1111 0000 0000
        bool errorDetect = uint.TryParse(Console.ReadLine(), out startNumber);  //Позиция №:  .... ---q .... .... ---p .... 3210
        while (errorDetect == false)                                            //Ако k=4:          \/             \/
        {                                                                       //        Групите от битове, които ще се разменят
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out startNumber);
        }
        Console.Write("How many bits would you like to exchange (k)? ");        //Пример за горепосоченото число: k=4
        byte numberOfBits;
        errorDetect = byte.TryParse(Console.ReadLine(), out numberOfBits);
        while (errorDetect == false)    //Валидация на входа
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = byte.TryParse(Console.ReadLine(), out numberOfBits);
        }
        Console.Write("Witch is the first of the group of bits closest to 0 (p)? ");    //Пример за горепосоченото число: p=8
        byte closestBit;
        errorDetect = byte.TryParse(Console.ReadLine(), out closestBit);
        while (errorDetect == false)    //Валидация на входа
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = byte.TryParse(Console.ReadLine(), out closestBit);
        }
        Console.Write("Witch is the first of the farthest group of bits closest to 0 (q)? "); //Трябва да е изпълнено q > (p + k) и (q + k) < 32
        byte farthestBit;                                                                     //или програмата ще даде грешка
        errorDetect = byte.TryParse(Console.ReadLine(), out farthestBit);                     //Пример за горепосоченото число: q=20
        while (errorDetect == false || farthestBit <= closestBit + numberOfBits || farthestBit + numberOfBits > 32) //Валидация на входа
        {
            Console.Write("You've entered an invalid number. Try again (q>p+k) - ");
            errorDetect = byte.TryParse(Console.ReadLine(), out farthestBit);
        }
        uint number = startNumber;
        uint newNumber = 0;          //Величината, която ще приеме стойността на числото с разменени групи от битове
        byte distBetweenBits = (byte)(farthestBit - closestBit);
        uint bitTempValue;           //Временна променлива, която ще приема стойността на бит от втората група, на който...
        Console.Clear();             //...предстои да загуби стойността си, приемайки тази на бит от първата група
        for (byte i = closestBit; i < (closestBit + numberOfBits); i++)
        {
            uint mask = (uint)1 << i;                 //Правя маска за да извлека пърбия бит от първата група
            uint numberAndMask = number & mask;
            uint bitIValue = numberAndMask >> i;      //Определям дали стойността на дадения бит е 1 или 0
            mask = (uint)1 << (i + distBetweenBits);  //Повтарям операцията да първия бит от втората група
            numberAndMask = number & mask;
            uint bitI2Value = (uint)numberAndMask >> (i + distBetweenBits);
            bitTempValue = bitI2Value;  //Задавам на временната променлива стойност, равна на тази на бита от втората група
            if (bitIValue == 0)         //Започвам операция по промяна на бита от втората група, така че да добие стойността,...
            {                           //...която съм определил по-горе, че има бита от първата група.
                mask = (uint)~(1 << (i + distBetweenBits));   //Маска, ако бита има стойност 0
                newNumber = number & mask;
            }
            else
            {
                mask = (uint)1 << (i + distBetweenBits);      //Маска, ако бита има стойност 1
                newNumber = number | mask;
            }
            number = newNumber;         //Нова стойност на числото след смяна на първия бит
            if (bitTempValue == 0)      //Започвам операция по промяна на бита от първата група, така че да добие стойността, която...
            {                           //... е определено, че има бита от втората група и съм запазил във временната променлива.
                mask = (uint)~(1 << i); //Маска, ако бита има стойност 0
                newNumber = number & mask;
            }
            else
            {
                mask = (uint)1 << i;    //Маска, ако бита има стойност 1
                newNumber = number | mask;
            }   //Цикъла се повтаря за всички битове между първия и първия+броя на битовете
            number = newNumber;
        }
        Console.WriteLine("Number: \t{0}\nIn bits:\t{1}", startNumber, Convert.ToString(startNumber, 2).PadLeft(32,'0'));
        Console.WriteLine("New number:\t{0}\nIn bits:\t{1}\n", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        //За дадения пример:
        //Number:         251723520
        //In bits:        0000 1111 0000 0000 1111 1111 0000 0000 - не са разделени при изписване на конзолата
        //New number:     267448320
        //In bits:        0000 1111 1111 0000 1111 0000 0000 0000 - не са разделени при изписване на конзолата
    }
}