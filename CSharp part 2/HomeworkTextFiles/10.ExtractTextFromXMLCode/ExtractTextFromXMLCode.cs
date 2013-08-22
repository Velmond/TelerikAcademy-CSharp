//10. Write a program that extracts from given XML file all the text without the tags. 
//    Example:  <?xml version="1.0"><student><name>Pesho</name>
//              <age>21</age><interests count="3"><interest>
//              Games</instrest><interest>C#</instrest><interest>
//              Java</instrest></interests></student>

namespace ExtractTextFromXMLCode
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class ExtractTextFromXMLCode
    {
        static void Main()
        {
            using (StreamReader input = new StreamReader(@"..\..\Input.txt"))   //You can also try @"..\..\Input2.txt"
            {
                char currentSymbol = char.MinValue;
                bool inTag = true;
                string temp = string.Empty;
                List<string> list = new List<string>();     //Keeps the strings that are not in the tags

                while ((int)(currentSymbol = (char)input.Read()) != char.MaxValue)  //Reads the file character by character untill the last one
                {
                    if (currentSymbol == '<')   //If the char is an opening tag than from here untill we get to a closing one 
                        inTag = true;           //...we are in a tag
                    else if (currentSymbol == '>')  //If we get to a closing tag we need to check if it is not followed by another
                    {                               //...opening tag. If not we are out of any tags
                        currentSymbol = (char)input.Read();
                        if (currentSymbol == '<')
                            inTag = true;
                        else if (currentSymbol == char.MaxValue || currentSymbol == '\n')
                            continue;
                        else
                            inTag = false;
                    }

                    if (!inTag)                 //If we are out of tags the characters are added to the string "temp"
                        temp += currentSymbol;
                    else if (inTag && (temp.Trim() != string.Empty))//If we get to a tag and the string "temp" is not empty
                    {                                               //...we add the the content of it to the list and assign
                        list.Add(temp.Trim());                      //...string.Empty to "temp"
                        temp = string.Empty;
                    }
                }

                foreach (string line in list)
                    Console.WriteLine(line);
            }
        }
    }
}