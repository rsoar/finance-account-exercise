using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFinance.Entities
{
    public class Account
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public float Balance { get; set; } = 0;

        public Account(string owner, string number)
        {
            Owner = owner;
            Number = number;
        }

        public void Withdraw(float value)
        {
            this.Balance -= value;
        }

        public void Deposit(float value)
        {
            this.Balance += value;
        }
    }
}
