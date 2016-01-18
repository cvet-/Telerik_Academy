/* Problem 11: A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names. */

using System;

class BankAccount
{
    static void Main()
    {
        // Declaration
        string name, middleName, lastName, bankName, IBAN;
        decimal amount;
        ulong creditCard, debitCard, masterCard;

        // Initialization
        name = "Ivan";
        middleName = "Ivanov";
        lastName = "Ivanov";
        bankName = "FiBank";
        IBAN = "BG20TTBB94003526341239";
        amount = 263.15M;
        creditCard = 012335456215613;
        debitCard = 1236873574863218;
        masterCard = 335785357853556;

        // Output
        Console.WriteLine("First Name: " + name + "\nMiddle Name: "
            + middleName + "\nLast Name: " + lastName  + "\nBank Name: "
            + bankName  + "\nIBAN: " + IBAN + "\nBalance: "
            + amount + "\nCreditCard: " + creditCard
            + "\nDebitCard: " + debitCard
            + "\nMasterCard: " + masterCard + "\n");
    }
}
