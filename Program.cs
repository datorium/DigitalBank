using System;
using System.Diagnostics;

namespace DigitalBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Jenifer", 100);
            Console.WriteLine($"Owner {account.Owner} has {account.Balance} euro(s) in account Nr. {account.Number} created on {account.DateCreated.ToString("dd/MM/yyyy")}.");
        }   
    }
}
