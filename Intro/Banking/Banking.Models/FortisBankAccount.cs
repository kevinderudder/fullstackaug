using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    public sealed class FortisBankAccount : BankAccount
    {
        public override void AddToBalance(decimal amount)
        {
            this.Deposit += amount;
        }

        public override void AddToSavings(decimal amount)
        {
            this.Savings += amount;
        }

        public override void WithdrawFromBalance(decimal amount)
        {
            if (amount > this.Deposit)
            {
                throw new Exception("unsufficient resources");
            }
            this.Deposit -= amount;
        }

        public override void WithdrawFromSavings(decimal amount)
        {
            if (amount > this.Savings)
            {
                throw new Exception("unsufficient resources");
            }
            this.Deposit -= amount;
        }
    }
}
