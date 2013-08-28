//19. Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//    Display them in the standard date format for Canada.

namespace ExtractDates
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;

    class ExtractDates
    {
        static void Main()
        {
            string text = @"Some text some text 12.05.2013. More text more text 10.12.1306, also 10.04.2000. And don't forget 03.03.1878";

            MatchCollection entriesDetected = Regex.Matches(text, @"\b\d{2}.\d{2}.\d{4}\b");
            //Because it has the {2} it won't match any dates like 1.4.2012 because they only have one digit for both the
            //... day and the month. But as I see it that is what is required in the task description.

            DateTime date = new DateTime();

            for (int i = 0; i < entriesDetected.Count; i++)
            {
                if (DateTime.TryParseExact(entriesDetected[i].Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    //Console.WriteLine("{0}", date.ToString(CultureInfo.GetCultureInfo("fr-CA").DateTimeFormat.ShortDatePattern));
                    Console.WriteLine("{0}", date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
            }
        }
    }
}
