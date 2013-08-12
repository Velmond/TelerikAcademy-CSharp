//04. Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}

using System;

class MaximumEqualSequence
{
    static void Main()
    {
        //Входа е аналогичен на предните задачи (2 и 3), но само за един масив
        int arraySize;
        Console.Write("What size should the array you want checked be? ");
        bool errorDetect = int.TryParse(Console.ReadLine(), out arraySize);
        while (!errorDetect)
        {
            Console.Write("Incorect input! Try again - ");
            errorDetect = int.TryParse(Console.ReadLine(), out arraySize);
        }

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Input element {0} of the array: ", i);
            errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            while (!errorDetect)
            {
                Console.Write("Incorect input! Try again - ");
                errorDetect = int.TryParse(Console.ReadLine(), out array[i]);
            }
        }

        //За да се използва примера от условието трябва да се закоментират редове от предния коментар
        //до този и да се разкоментират следващите два:
        //int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        //int arraySize = array.Length;

        Console.Clear();
        int currCounter = 1;            //Променлива, брояща колко пъти се повтаря конкретна стойност
        int maxCounter = 1;             //Променлива, пазеща дължината на най-дългата последователност от еднакви елементи
        int prevElement = array[0];     //Променлива, служеща за проверка дали даден елемент е същия като предишния
        int mostUsedElement = array[0]; //Променлива, пазеща стойността на елемента, който се повтаря в най-дългата последователност

        for (int i = 1; i < arraySize; i++)     //Обхождат се всички елементи
        {
            if (array[i] == prevElement)
            {
                currCounter++;
            }
            else
            {
                if (maxCounter < currCounter)
                {
                    maxCounter = currCounter;
                    mostUsedElement = prevElement;
                }
                currCounter = 1;
                prevElement = array[i];
            }
        }
        if (maxCounter < currCounter)       //Проверявам дали накрая на масива не се намира най-дългата последователност, тъй като
        {                                   //в горния цикъл за последната стойност само ще се промени стойността на currCounter
            maxCounter = currCounter;       //но не и на останалите променливи
            mostUsedElement = prevElement;
        }

        Console.Write("{");                 //Изписване на редицата, както е дадено в условието
        for (int i = 0; i < maxCounter; i++)
        {
            if (i < maxCounter - 1)
            {
                Console.Write(" {0},", mostUsedElement);
            }
            else
            {
                Console.Write(" {0}", mostUsedElement);
            }
        }
        Console.WriteLine("}");
    }
}