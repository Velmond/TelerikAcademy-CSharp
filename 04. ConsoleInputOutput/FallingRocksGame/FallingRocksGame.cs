//Задача №11
//Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen 
//and can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down
//and you need to avoid a crash.
//Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
//Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading;

class FallingRocks
{
    int rockX = 0;
    int rockY = 0;
    int playerPosition;
    int dwarfSize = 3;

    static void RemoveScrollbars()
    { 
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }
    static void PrintAtPosition(int x, int y, char symbol)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }

    static void DrawPlayer()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        PrintAtPosition(((Console.WindowWidth / 2)-1), Console.WindowHeight-1, '(');
        PrintAtPosition((Console.WindowWidth / 2), Console.WindowHeight-1, '0');
        PrintAtPosition(((Console.WindowWidth / 2)+1), Console.WindowHeight-1, ')');
    }
    static void Main()
    {
        RemoveScrollbars();

        while (true)
        {
            //Move player
            //Move rocks
            //Move player
            //Redraw all
            // - clear all
            // - draw rocks
            DrawPlayer();
            // - print results?
            //

            Thread.Sleep(150);
        }
    }
}