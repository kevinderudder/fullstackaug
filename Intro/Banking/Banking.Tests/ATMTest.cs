using Banking.Models;
using System;
using Xunit;

namespace Banking.Tests
{
    public class ATMTest
    {
        [Fact]
        public void ShouldAddMoneyToBalance()
        {
            // AAA (arrange, act, assert)
            // SEE (setup, execute, expect)

            // Arrange
            ATM atm = new ATM();
            
            // Act
            //atm.Balance = 200;
            atm.AddMoney(200);

            // Assert
            Assert.Equal(200, atm.Balance);


        }

        [Fact]
        public void ShouldWithdrawMoneyFromBalance() {
            ATM atm = new ATM();
            atm.AddMoney(200);

            atm.WithdrawMoney(100);

            Assert.Equal(100, atm.Balance);
        }

        [Fact]
        public void ShouldThrowExceptionWhenAttemptIsMoreThanBalance() {
            ATM atm = new ATM();
            atm.AddMoney(200);
            try {
                atm.WithdrawMoney(400);
            }
            catch (Exception ex) {

            }
            

            Assert.Equal(200, atm.Balance);
            Assert.Throws<Exception>(() => atm.WithdrawMoney(400)) ;
        }
    }
}
