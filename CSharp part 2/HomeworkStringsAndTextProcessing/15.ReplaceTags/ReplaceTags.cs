//15. Write a program that replaces in a HTML document given as string all the tags 
//    <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
//    Sample HTML fragment:
//      <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//      => <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

namespace ReplaceTags
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceTags
    {
        static void Main()
        {
            string input = string.Empty;
            Console.WriteLine("Input the sample HTML fragment: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //To use your own input and key uncomment the line below:
            //input = Console.ReadLine(); /*
            input = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";// */
            Console.ForegroundColor = ConsoleColor.Gray;

            string output = Regex.Replace(input, @"<a href=""(.+?)"">(.+?)</a>", "[URL=$1]$2[/URL]");
            //$0 corresponds to the whole match for the pattern -> <a href="http://academy.telerik. com">our site</a>
            //$1 corresponds to the match for what's in the first brackets -> http://academy.telerik. com
            //$2 corresponds to the match for what's in the second brackets -> our site
            //$3 corresponds to nothing

            Console.Clear();
            Console.WriteLine("Input code:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Output code:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(output);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
