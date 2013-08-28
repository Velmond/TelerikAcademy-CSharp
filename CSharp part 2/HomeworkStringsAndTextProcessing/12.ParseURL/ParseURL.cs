//12. Write a program that parses an URL address given in the format:
//      [protocol]://[server]/[resource]
//    and extracts from it the [protocol], [server] and [resource] elements. 
//    For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//      [protocol] = "http"
//      [server] = "www.devbg.org"
//      [resource] = "/forum/index.php"

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            string inputURL = string.Empty;
            Console.Write("Input a URL: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //To use your own input and key uncomment the line below:
            //inputURL = Console.ReadLine();/*
            inputURL = @"http://www.devbg.org/forum/index.php"; // */
            Console.ForegroundColor = ConsoleColor.Gray;

            GroupCollection elements = Regex.Match(inputURL, @"(.+?)://(.+?)(/.*)").Groups;
            //Creates an indexed collection of all the matches from the pattern
            //elements[0] = http://www.devbg.org/forum/index.php
            //Each of the groups in the brackets is assigned the next index of the GroupCollection

            Console.Clear();
            Console.Write("[protocol] =\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(elements[1]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("[server] =\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(elements[2]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("[resource] =\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(elements[3]);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
