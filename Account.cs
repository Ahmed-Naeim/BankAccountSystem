using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    internal class Account
    {
        public string Name { get; }
        public double Balance{ get; set; }

        public Account(string Name = "Unnamed Account", double Balance = 0.0)
        {
            this.Name = Name;
            this.Balance = Balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                Balance += amount;
                return true;
            }
        }
        public virtual bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public double GetBalance()
        {
            return Balance;
        }
        public static Account operator+(Account left, Account right)
        {
            Account myAccount = new Account(left.Name, left.Balance + right.Balance);
            return myAccount;
        }



    }
}
