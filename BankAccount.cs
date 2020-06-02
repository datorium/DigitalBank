using System;
using System.Collections.Generic;
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
    }
}
