using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.Items;

namespace BankSystem
{
    class BankSystem
    {
        static void Main()
        {
            var customer = new IndividualCustomer("Pesho", "Sofia");
            var bankAccount = new DepositAccount(customer, 30.4);

            bankAccount.Deposit(2000M);
            Console.WriteLine("Current balance: {0}",bankAccount.Balance);
            Console.WriteLine("Interest amount: {0}", bankAccount.GetInterestAmount(23));

            bankAccount.Withdraw(160.50M);
            Console.WriteLine("Current balance: {0}",bankAccount.Balance);
        }
    }
}
