//Задача 11
//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
//The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class PrintAllCardsInADeckUsingSwitch
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.White;
        string cardColor = "";
        string cardName = "";
        byte counter = 0;
        for (int name = 1; name <= 13; name++)
        {
            switch (name)
            {
                case 1: cardName = "2"; break;
                case 2: cardName = "3"; break;
                case 3: cardName = "4"; break;
                case 4: cardName = "5"; break;
                case 5: cardName = "6"; break;
                case 6: cardName = "7"; break;
                case 7: cardName = "8"; break;
                case 8: cardName = "9"; break;
                case 9: cardName = "10"; break;
                case 10: cardName = "Jack"; break;
                case 11: cardName = "Queen"; break;
                case 12: cardName = "King"; break;
                case 13: cardName = "Ace"; break;
            }
            for (int color = 1; color <= 4; color++)
            {
                switch (color)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Black;
                        cardColor = "Clubs";
                        counter++;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        cardColor = "Diamonds";
                        counter++;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        cardColor = "Hearts";
                        counter++;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Black;
                        cardColor = "Spades";
                        counter++;
                        break;
                }
                Console.WriteLine("{0}: {1} of {2}", Convert.ToString(counter).PadLeft(2, ' '), cardName, cardColor);
            }
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}