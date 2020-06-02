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
        public decimal Balance { get; }
        public DateTime DateCreated { get; }

        private static int accountNumber = 123456789;

        private List<Transaction> transactions = new List<Transaction>();

        public BankAccount(string ownerName, decimal initialBalance)
        {
            this.DateCreated = DateTime.Now;
            this.Number = "LV" + accountNumber.ToString();
            accountNumber++;
            this.Owner = ownerName;
            this.Balance = initialBalance;
        }

        public void AddMoney(decimal amount, DateTime date, string notes)
        {

        }

        public void TakeMoney(decimal amount, DateTime date, string notes)
        {

        }

    }
}
