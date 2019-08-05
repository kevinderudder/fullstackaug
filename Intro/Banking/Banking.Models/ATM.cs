using System;

namespace Banking.Models
{
    public class ATM
    {
        public decimal Balance { get; private set; }

        public ATM()
        {
            this.Balance = 0;
        }

        public void AddMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public void WithdrawMoney(decimal amount) {
            if (amount > this.Balance) {
                throw new Exception("unsufficient money on balance");
            }
            this.Balance -= amount;
        }

        public override string ToString()
        {
            //return "your current balance is €" + this.Balance;
            return $"your current balance is €{this.Balance}";
        }
    }
}
