/* Problem 10: A marketing company wants to keep record of its employees. Each record would have the following characteristics:
First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console. */

using System;

class Employee
{
    static void Main()
    {
        // Declaring variables
        Console.Write("First Name: ");
        string name = Console.ReadLine();
        Console.Write("Surname: ");
        string surname = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse (Console.ReadLine());
        Console.Write("Gender: ");
        string gender = Console.ReadLine();
        Console.Write("ID number: ");
        long ID = long.Parse(Console.ReadLine());
        Console.Write("Unique Number: ");
        int uniqueNumber = int.Parse(Console.ReadLine());
        
        Console.Clear();    // Clears the text in order to make the output more clear


        Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nID Number: {4}\nUnique Number: {5}",
            name,surname,age,gender,ID,uniqueNumber);

    }
}

