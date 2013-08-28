//18. Write a program for extracting all email addresses from given text. All substrings that match the format 
//    <identifier>@<host>…<domain> should be recognized as emails.

namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractEmails
    {
        static void Main()
        {
            string text = @"Some text some text pesho.peshov@gmail.com. More text more text gosho_goshov@abv.bg,
                            also tosho-toshev@yahoo.com.  And don't forget sasho123@hotmail.co.uk.
                            This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.
                            gledamisekickass2nakinoisitursiakompania@kinoman.info";

            MatchCollection emails = Regex.Matches(text, @"\b[\w.-]{6,20}@[\w.-]{3,20}[.][\w.]{2,6}\b");
            //"[\w.]{2,6}" matches domains like .co.uk
            //{6,20} sets the minimum and maximum of characters that should be in a group
            //Check this site for more http://regex101.com/

            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
