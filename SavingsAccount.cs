using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    internal class SavingsAccount : Account
    {
        public double IntRate { get; set; }
        public SavingsAccount(string Name = "Unnamed Saving Account", double Balance = 0.0, double IntRate = 0.0)
            : base(Name, Balance)
        {
            this.IntRate = IntRate;
        }
        public override bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                Balance = amount + (amount*IntRate);
                return true;
            }
        }

    }
}
