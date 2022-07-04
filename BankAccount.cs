using System;

namespace HoodATM
{
    public class BankAccount
    {
        public decimal balance { get; set; }
        public decimal deposit(decimal amount) 
        { 
            balance = balance + amount;
            return balance;
        }
        public decimal withdrawal(decimal amount)
        {
            balance = balance - amount;
            return balance;
        }
    }
}