/* Problem 2: A company has name, address, phone number, fax number, web site and manager. 
The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console. */

using System;

class PrintInformation
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter phone number: ");
        int phoneNum = int.Parse(Console.ReadLine());
        Console.Write("Enter fax number: ");
        int faxNum = int.Parse(Console.ReadLine());
        Console.Write("Enter web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Enter manager's first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter manager's last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter manager's age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Enter manager's phone number: ");
        int phoneManager = int.Parse(Console.ReadLine());

        Console.Clear(); // Clears what's written so far, makes the output easier to read

        Console.WriteLine(companyName);
        Console.WriteLine("Address:" + companyAddress);
        Console.WriteLine("Tel:" + phoneNum);
        Console.WriteLine("Fax:" + faxNum);
        Console.WriteLine("Web side: http://" + webSite);
        Console.WriteLine("Manager: {0}{1} (Age: {2}, Tel: {3})", firstName, lastName, age, phoneManager);
    }
}

