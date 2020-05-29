using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBank
{
    class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
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

        private List<Transaction> transactions = new List<Transaction>();

        public BankAccount(string ownerName, decimal initialBalance)
        {
            this.DateCreated = DateTime.Now;
            this.Number = "123456789";
            this.Owner = ownerName;
            //this.Balance = initialBalance;
        }

        public void AddMoney(decimal amount, DateTime date, string notes)
        {

        }

        public void TakeMoney(decimal amount, DateTime date, string notes)
        {

        }

    }
}
