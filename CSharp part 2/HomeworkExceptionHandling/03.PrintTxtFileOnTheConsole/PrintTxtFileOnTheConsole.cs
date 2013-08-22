//03. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//    reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//    Be sure to catch all possible exceptions and print user-friendly error messages.

namespace PrintTxtFileOnTheConsole
{
    using System;
    using System.IO;
    using System.Security;
    using System.Text;

    class PrintTxtFileOnTheConsole
    {
        public static void Main()
        {
            Console.Write("Input the path to the file you want printed on the console - ");
            Console.ForegroundColor = ConsoleColor.Yellow;  //I've included two files in the application's directory, one 
            string filePath = Console.ReadLine();           //in English and one in Bulgarian. For the Bulgarian one you should 
            Console.ForegroundColor = ConsoleColor.Gray;    //uncomment the commented row below and comment the one above it

            string consoleOutput = File.ReadAllText(filePath, Encoding.ASCII);
            //string consoleOutput = File.ReadAllText(filePath, Encoding.GetEncoding("windows-1251"));

            try
            {
                Console.WriteLine(consoleOutput);
            }
            catch (ArgumentNullException nullException)         //I don't use custome messages because I find Microsoft's are
            {                                                   //user-friendlly enough
                Console.WriteLine(nullException.Message);
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
            catch (PathTooLongException pathTooLong)
            {
                Console.WriteLine(pathTooLong.Message);
            }
            catch (DirectoryNotFoundException directoryNotFound)
            {
                Console.WriteLine(directoryNotFound.Message);
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine(fileNotFound.Message);
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            catch (UnauthorizedAccessException unauthorizedAccess)
            {
                Console.WriteLine(unauthorizedAccess.Message);
            }
            catch (NotSupportedException notSupported)
            {
                Console.WriteLine(notSupported.Message);
            }
            catch (SecurityException security)
            {
                Console.WriteLine(security.Message);
            }

            //Another option was to catch all the possible exceptions by doing the following:
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //... but I think the idea was to find out what kind of exceptions might occure
        }
    }
}
