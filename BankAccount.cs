using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBank
{
    class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        public BankAccount(string ownerName, decimal initialBalance)
        {
            this.Number = "123456789";
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
