using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBank
{
    class Account
    {
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance { get; }
        public DateTime Created { get; }

        private List<Transaction> transactions = new List<Transaction>();

        public Account(string owner, decimal balance)
        {
            this.Number = "13456789";
            this.Owner = owner;
            this.Balance = balance;
            this.Created = DateTime.Now;
        }

    }
}
