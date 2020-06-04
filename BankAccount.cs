using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace DigitalBank
{
    class BankAccount
    {
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach(Transaction t in transactions)
                {
                    balance += t.Amount;
                }
                return balance;
            }
        }
        public DateTime DateCreated { get; }

        private static int accountNumber = 123456789;

        private List<Transaction> transactions = new List<Transaction>();

        public BankAccount(string ownerName, decimal initialBalance)
        {
            this.DateCreated = DateTime.Now;
            this.Number = "LV" + accountNumber.ToString();
            accountNumber++;
            this.Owner = ownerName;
            this.MakeDeposit(initialBalance, "Initial balance");
            Console.WriteLine($"Account for {this.Owner} is created on {this.DateCreated.ToString("dd/MM/yyyy hh:mm:ss")}");
        }

        public void MakeDeposit(decimal amount, string notes)
        {
            Transaction deposit = new Transaction(amount, DateTime.Now, notes);
            transactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, string notes)
        {
            Transaction withdrawal = new Transaction(-amount, DateTime.Now, notes);
            transactions.Add(withdrawal);
        }

        public void PrintStatus()
        {
            Console.WriteLine($"Owner {this.Owner} has {this.Balance} euro(s) in account Nr. {this.Number} created on {this.DateCreated.ToString("dd/MM/yyyy")}.");
        }

        public void PrintStatement()
        {
            StringBuilder report = new StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNotes");

            foreach(Transaction t in transactions)
            {
                balance += t.Amount;
                report.AppendLine($"{t.Date.ToShortDateString()}\t{t.Amount}\t{balance}\t{t.Notes}");
            }
            Console.WriteLine(report.ToString());
        }
    }
}
