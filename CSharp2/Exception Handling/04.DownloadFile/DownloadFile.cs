// Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
// Find in Google how to download files in C#.
// Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.IO;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        const string fileAddress = "http://academy.telerik.com/images/default-album/programming-champion-telerik-academy.png";
        string targetPath = Path.GetFileName(fileAddress);

        using (var webClient = new WebClient())
        {
            try
            {
                webClient.DownloadFile(fileAddress, targetPath);
                Console.WriteLine("Download completed! The file is located in folder Debug.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Some of the addresses are not specified.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Some of the addresses has invalid format.");
            }
            catch (WebException ex)
            {
                Console.Error.WriteLine("Unable to connect to the internet " +
                                        "The reason is {0}.", ex.InnerException.ToString().ToLower());
            }
            catch (NotSupportedException ex)
            {
                Console.Error.WriteLine("ome trubles appeared while tring to download the resource. " +
                                        "The reason is {0}.", ex.InnerException.ToString().ToLower());
            }
        }
    }
}
