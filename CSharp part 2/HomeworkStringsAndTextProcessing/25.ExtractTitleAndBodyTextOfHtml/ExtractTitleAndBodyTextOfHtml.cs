//25. Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
//    Example:
//      <html>
//      <head><title>News</title></head>
//      <body><p><a href="http://academy.telerik.com">Telerik
//          Academy</a>aims to provide free real-world practical
//          training for young people who want to turn into
//          skillful .NET software engineers.</p></body>
//      </html>
//    Result:
//      Title:      News
//      Body text:  Telerik Academy aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.

namespace ExtractTitleAndBodyTextOfHtml
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class ExtractTitleAndBodyTextOfHtml
    {
        static void Main()
        {
            string htmlText = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";

            MatchCollection matches = Regex.Matches(htmlText, @"(?<=>).*?(?=<)");
            //(?<=>) - Positive Lookbehind - Looks for the > literal, behind text matching the .*?
            //.*? - 0 to infinite times any character (except newline), lazy (?)
            //... if it's not lazy it will start from the first ">" and will get everyting between it and the last "<"
            //(?=<) - Positive Lookahead - Looks for the < literal, after text matching the .*?

            foreach (Match match in matches)
            {
                if (!string.IsNullOrWhiteSpace(match.ToString()))
                {
                    Console.WriteLine(match.ToString());
                }
            }
        }
    }
}
