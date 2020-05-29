using System;
using System.Runtime.InteropServices;

namespace DigitalBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Jenifer", 200);
            Console.WriteLine($"Client {account.Owner} has {account.Balance} euros in account number {account.Number} created on {account.Created.ToString("dd/MM/yyyy")}.");
        }
    }
}
