// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
// reads its contents and prints it on the console.
// Find in MSDN how to use System.IO.File.ReadAllText(…).
// Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Security;

class ReadFileContents
{
    static void Main()
    {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
        Console.WriteLine("SELECT A FILE TO READ");
        Console.Write("PATH: ");
        Console.Write(filePath);
        filePath += Console.ReadLine();

        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("FILE CONTENT: ");
            Console.WriteLine(content);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("File path is not selected!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("File not found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory from given path not found!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Selected path is too long!");
        }
        catch (IOException)
        {
            Console.WriteLine("Unable to read file!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have permitions to read this file!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Unable to operate with the specified fil!");
        }
        catch (SecurityException)
        {
            Console.WriteLine("Unable to read this file for security reasons!");
        }
    }
}

