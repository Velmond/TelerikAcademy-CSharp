//Задача 11
//Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation.
//Examples:
//0 => "Zero"
//273 => "Two hundred seventy three"
//400 => "Four hundred"
//501 => "Five hundred and one"
//711 => "Seven hundred and eleven"

//http://en.wikipedia.org/wiki/English_numerals

using System;

class ConvertNumberToItsName
{
    static void Main()
    {
        int input;
        // | Цикъл, с който си проверявах дали може да ми изпише абсолютно всички стойности в интервала.
        // | Тъй като конзолата изглежда "помни" само последните ~300 реда, променям размера на буфера на конзолата, като за
        // | височината задавам - 1001 (1000 стойности + реда "Press any key to continue . . .").
        // | Ако искате да използвате тази проверката, се разкоментира следващия ред, както и закоментираната фигурна скоба
        // V ... на ред 206 (на края на кода).
        //Console.SetBufferSize(Console.WindowWidth, 1001); for (input = 0; input <= 999; input++) {/*
        Console.Write("Input a number (0-999): ");
        bool errorDetect = int.TryParse(Console.ReadLine(), out input);
        while (errorDetect == false || input > 999)
        {
            Console.Write("Incorrect input! Try again (0-999): ");
            errorDetect = int.TryParse(Console.ReadLine(), out input);
        }                                   //Ако се разкоментира цикъла за проверка по-горе, следващия ред ще затвори
        //*/                                //...коментара, в който ще остане въпроса за въвеждане на числото през конзолата.
        string onesStr = "";                //Въвеждам си 3 стрингови променливи, в които по-късно ще въвеждам
        string tensStr = "";                //... стойностите на единиците, десетиците и стотиците на даденото число.                        
        string numberName = "";
        int ones = (input % 10);            //Операциите и променливите, чрез които определям стойностите 
        int tens = ((input / 10) % 10);     //... на единиците, десетиците и стотиците
        int hundreds = (input / 100);
        if (hundreds == 0 && tens == 0)     //Ако числото е под 10
        {
            switch (ones)
            {
                case 0: numberName = "ZERO"; break;
                case 1: numberName = "ONE"; break;
                case 2: numberName = "TWO"; break;
                case 3: numberName = "THREE"; break;
                case 4: numberName = "FOUR"; break;
                case 5: numberName = "FIVE"; break;
                case 6: numberName = "SIX"; break;
                case 7: numberName = "SEVEN"; break;
                case 8: numberName = "EIGTH"; break;
                case 9: numberName = "NINE"; break;
                default: break;
            }
        }
        else if (hundreds == 0 && tens != 0)        //Ако числото е между 10 и 100
        {
            if (tens == 1)                          //Ако числото е между 10 и 19
            {
                switch (ones)
                {
                    case 0: numberName = "TEN"; break;
                    case 1: numberName = "ELEVEN"; break;
                    case 2: numberName = "TWELVE"; break;
                    case 3: numberName = "THIRTEEN"; break;
                    case 4: numberName = "FOURTEEN"; break;
                    case 5: numberName = "FIFTEEN"; break;
                    case 6: numberName = "SIXTEEN"; break;
                    case 7: numberName = "SEVENTEEN"; break;
                    case 8: numberName = "EIGTHTEEN"; break;
                    case 9: numberName = "NINETEEN"; break;
                    default: break;
                }
            }
            else if (tens != 1)                     //Ако числото е между 20 и 99
            {
                switch (ones)                       //За единиците
                {
                    case 0: onesStr = "\b "; break; //Ако числото е кръгло \b връща една позиция назад и разстоянието
                    case 1: onesStr = "ONE"; break; //... се поставя върху тирето на десетиците (виж следващия switch)
                    case 2: onesStr = "TWO"; break;
                    case 3: onesStr = "THREE"; break;
                    case 4: onesStr = "FOUR"; break;
                    case 5: onesStr = "FIVE"; break;
                    case 6: onesStr = "SIX"; break;
                    case 7: onesStr = "SEVEN"; break;
                    case 8: onesStr = "EIGTH"; break;
                    case 9: onesStr = "NINE"; break;
                    default: break;
                }
                switch (tens)                       //За десетици
                {
                    case 2: numberName = "TWENTY-" + onesStr; break;
                    case 3: numberName = "THIRTY-" + onesStr; break;
                    case 4: numberName = "FORTY-" + onesStr; break;
                    case 5: numberName = "FIFTY-" + onesStr; break;
                    case 6: numberName = "SIXTY-" + onesStr; break;
                    case 7: numberName = "SEVENTY-" + onesStr; break;
                    case 8: numberName = "EIGTHTY-" + onesStr; break;
                    case 9: numberName = "NINETY-" + onesStr; break;
                    default: break;
                }
            }
        }
        else if (hundreds != 0 && tens == 0)        //Ако числото е в интерварите 100-109, 200-209, 300-309, 400-409
        {                                           //... 500-509, 600-609, 700-709, 800-809, 900-909
            switch (ones)                           //За единиците
            {
                case 0: onesStr = ""; break;
                case 1: onesStr = "ONE"; break;
                case 2: onesStr = "TWO"; break;
                case 3: onesStr = "THREE"; break;
                case 4: onesStr = "FOUR"; break;
                case 5: onesStr = "FIVE"; break;
                case 6: onesStr = "SIX"; break;
                case 7: onesStr = "SEVEN"; break;
                case 8: onesStr = "EIGTH"; break;
                case 9: onesStr = "NINE"; break;
                default: break;
            }
            switch (hundreds)                       //За стотиците
            {
                case 1: numberName = "ONE HUNDRED " + onesStr; break;
                case 2: numberName = "TWO HUNDRED " + onesStr; break;
                case 3: numberName = "THREE HUNDRED " + onesStr; break;
                case 4: numberName = "FOUR HUNDRED " + onesStr; break;
                case 5: numberName = "FIVE HUNDRED " + onesStr; break;
                case 6: numberName = "SIX HUNDRED " + onesStr; break;
                case 7: numberName = "SEVEN HUNDRED " + onesStr; break;
                case 8: numberName = "EIGHT HUNDRED " + onesStr; break;
                case 9: numberName = "NINE HUNDRED " + onesStr; break;
                default: break;
            }
        }
        else                                        //За всички останали случаи - 110-199, 210-299, 310-399, 410-499, 
        {                                           //...510-599, 610-699, 710-799, 810-899, 910-999 
            if (tens == 1)                          //За интервалите _10-_19
            {
                switch (ones)
                {
                    case 0: tensStr = "TEN"; break;
                    case 1: tensStr = "ELEVEN"; break;
                    case 2: tensStr = "TWELVE"; break;
                    case 3: tensStr = "THIRTEEN"; break;
                    case 4: tensStr = "FOURTEEN"; break;
                    case 5: tensStr = "FIFTEEN"; break;
                    case 6: tensStr = "SIXTEEN"; break;
                    case 7: tensStr = "SEVENTEEN"; break;
                    case 8: tensStr = "EIGTHTEEN"; break;
                    case 9: tensStr = "NINETEEN"; break;
                    default: break;
                }
            }
            else if (tens != 1)                     //За интервалите _20-_99
            {
                switch (ones)                       //За единиците
                {
                    case 0: onesStr = "\b "; break; //Отново, ако числото е кръгло \b връща една позиция назад и разстоянието
                    case 1: onesStr = "ONE"; break; //... се поставя върху тирето на десетиците (виж следващия switch)
                    case 2: onesStr = "TWO"; break;
                    case 3: onesStr = "THREE"; break;
                    case 4: onesStr = "FOUR"; break;
                    case 5: onesStr = "FIVE"; break;
                    case 6: onesStr = "SIX"; break;
                    case 7: onesStr = "SEVEN"; break;
                    case 8: onesStr = "EIGTH"; break;
                    case 9: onesStr = "NINE"; break;
                    default: break;
                }
                switch (tens)                       //За десетиците
                {
                    case 2: tensStr = "TWENTY-" + onesStr; break;
                    case 3: tensStr = "THIRTY-" + onesStr; break;
                    case 4: tensStr = "FORTY-" + onesStr; break;
                    case 5: tensStr = "FIFTY-" + onesStr; break;
                    case 6: tensStr = "SIXTY-" + onesStr; break;
                    case 7: tensStr = "SEVENTY-" + onesStr; break;
                    case 8: tensStr = "EIGTHTY-" + onesStr; break;
                    case 9: tensStr = "NINETY-" + onesStr; break;
                    default: break;
                }
            }
            switch (hundreds)                       //За стотиците
            {
                case 1: numberName = "ONE HUNDRED " + tensStr; break;
                case 2: numberName = "TWO HUNDRED " + tensStr; break;
                case 3: numberName = "THREE HUNDRED " + tensStr; break;
                case 4: numberName = "FOUR HUNDRED " + tensStr; break;
                case 5: numberName = "FIVE HUNDRED " + tensStr; break;
                case 6: numberName = "SIX HUNDRED " + tensStr; break;
                case 7: numberName = "SEVEN HUNDRED " + tensStr; break;
                case 8: numberName = "EIGHT HUNDRED " + tensStr; break;
                case 9: numberName = "NINE HUNDRED " + tensStr; break;
                default: break;
            }
        }
        Console.Clear();
        //numberName = numberName.ToLowerInvariant();                           //Ако искам да ми изписва имената с малка буква
        Console.WriteLine("{0}: {1}", input.ToString().PadLeft(5), numberName); //Изписва се резултата на конзолата
    }
}
//}