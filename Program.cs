using System;
using System.Diagnostics;

namespace DigitalBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account;
            
            account = new BankAccount("Jenifer", 100);
            Console.WriteLine($"Owner {account.Owner} has {account.Balance} euro(s) in account Nr. {account.Number} created on {account.DateCreated.ToString("dd/MM/yyyy")}.");

            account.MakeDeposit(400, "Salary");
            Console.WriteLine($"Owner {account.Owner} has {account.Balance} euro(s) in account Nr. {account.Number} created on {account.DateCreated.ToString("dd/MM/yyyy")}.");

            account.MakeWithdrawal(50, "Online game");
            Console.WriteLine($"Owner {account.Owner} has {account.Balance} euro(s) in account Nr. {account.Number} created on {account.DateCreated.ToString("dd/MM/yyyy")}.");

            account.MakeWithdrawal(150, "Online course");
            Console.WriteLine($"Owner {account.Owner} has {account.Balance} euro(s) in account Nr. {account.Number} created on {account.DateCreated.ToString("dd/MM/yyyy")}.");

        }
    }
}
