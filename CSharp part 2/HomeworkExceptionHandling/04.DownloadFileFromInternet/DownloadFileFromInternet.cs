//04. Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//    and stores it the current directory. Find in Google how to download files in C#. 
//    Be sure to catch all exceptions and to free any used resources in the finally block.

namespace DownloadFileFromInternet
{
    using System;
    using System.Net;

    public class DownloadFileFromInternet
    {
        public static void Main()
        {
            string remoteURI = "http://www.devbg.org/img/"; //The address where the file is located WITHOUT the file name in it
            string fileName = "Logo-BASD.jpg";              //The name of the file that should be downloaded from the above uri

            try
            {
                using (WebClient myWebClient = new WebClient()) //Create a WebClient instance that won't be used beyond the using block
                {
                    myWebClient.DownloadFile(remoteURI + fileName, fileName);
                    //Download and save the file into the current folder -> ...\04.DownloadFileFromInternet\bin\Debug\
                }   //All used resources are freed as the using block ends, so there is no need for a finally block
                Console.WriteLine("File was downloaded.");
            }
            catch (ArgumentNullException argumentNull)
            {
                Console.WriteLine(argumentNull.Message);
            }
            catch (WebException webEx)
            {
                Console.WriteLine(webEx.Message);
            }
            catch (NotSupportedException notSupported)
            {
                Console.WriteLine(notSupported.Message);
            }
        }
    }
}
