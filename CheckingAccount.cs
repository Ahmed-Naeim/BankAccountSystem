using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    internal class CheckingAccount : Account
    {
        public double Fee { get;}

        public CheckingAccount(string Name = "Unnamed Checking Account", double Balance = 0.0, double Fee = 1.50) : base(Name, Balance)
        {
            this.Fee = Fee;
        }

        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
        }
    }
}
