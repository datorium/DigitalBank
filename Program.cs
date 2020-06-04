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
            accounts[0].MakeDeposit(800, "First salary");
            accounts[0].PrintStatus();
            accounts[0].PrintStatement();

            accounts.Add(new BankAccount("Anna", 1200));
            accounts[1].MakeDeposit(1600, "Salary");
            accounts[1].MakeWithdrawal(140, "Clothes");
            accounts[1].MakeWithdrawal(60, "Spotify subscription");
            accounts[1].PrintStatus();
            accounts[1].PrintStatement();

            List<Human> clients = new List<Human>();            
            clients.Add(new Human("Jenifer", "Clever", "blue", 172));
            clients[0].SetHeight(-10);
            clients.Add(new Human("Anna", "Rich", "green", 158));
            clients.Add(new Human("Bob", "Dylan", "brown", 177));

            clients[2].AddNumbersFromMemory();
            clients[2].AddNumbers(20, 15);
        }
    }
}
