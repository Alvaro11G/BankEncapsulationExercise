using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double balance = 0;
        public void deposit(double amount)
        {
            balance = amount;
        }

        public double GetBalance()
        {
            return balance;
        }

        public int amount { get; set; }
    }
}
