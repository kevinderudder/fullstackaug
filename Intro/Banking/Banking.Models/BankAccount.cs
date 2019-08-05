using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    public abstract class BankAccount
    {
        public decimal Savings { get; set; }
        public decimal Deposit { get; set; }

        public BankAccount()
        {
            this.Savings = 0;
            this.Deposit = 0;
        }

        public abstract void AddToBalance(decimal amount);
        public abstract void WithdrawFromBalance(decimal amount);
        public abstract void AddToSavings(decimal amount);
        public abstract void WithdrawFromSavings(decimal amount);
    }
}
