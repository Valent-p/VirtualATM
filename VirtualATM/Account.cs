using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualATM
{

    internal class Account
    {
        private bool isUnlocked = false;
        private string pin;
        private string number;
        private double balance;
        
        public Account(string number, string pin, double initial_balance) 
        {
            this.number = number;
            this.pin = pin;
            this.balance = initial_balance;
            this.isUnlocked = false;
        }

        public double Balance {  get { return balance; } }
        public bool IsUnlocked { get { return isUnlocked; } }

        public string Number { get { return number; } }

        public bool Withdraw(double amount)
        {
            // Auth & Validate
            if (!isUnlocked && amount < 0) { return false; }


            double new_balance = balance - amount;
            if(new_balance < 0) { return false; }

            // Commit
            balance = new_balance;


            return true;
        }

        public bool Unlock(string pin)
        {
            if (this.pin == pin) {
                this.isUnlocked = true;
            }

            return this.isUnlocked;
        }
    }
}
