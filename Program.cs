using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DigitalBank
{
    class Program
    {
        static void Main(string[] args)
        {

            List<BankAccount> accounts = new List<BankAccount>();
            
            accounts.Add(new BankAccount("Jenifer", 100));

            accounts.Add(new BankAccount("Anna", 1600));
            accounts[1].MakeDeposit(1600, "Salary");
            accounts[1].MakeWithdrawal(140, "Clothes");
            accounts[1].MakeWithdrawal(60, "Spotify subscription");
            Console.WriteLine($"Owner {accounts[1].Owner} has {accounts[1].Balance} euro(s) in account Nr. {accounts[1].Number} created on {accounts[1].DateCreated.ToString("dd/MM/yyyy")}.");
        }
    }
}
