using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    internal class TrustAccount : SavingsAccount
    {
        public int WithDrawLimit { get; set; }
        public TrustAccount(string Name = "Unnamed Trust Account", double Balance = 0.0, double IntRate = 0.0) :base(Name, Balance, IntRate)
        {
            this.WithDrawLimit = 0;
        }

        public override bool Deposit(double amount)
        {

            if (amount > 5000)
            {
                Balance = amount + (amount * IntRate) + 50;
                return true;
            }
            else if (amount >= 0 && amount < 5000)
            {
                Balance = amount + (amount * IntRate);
                return true;
            }
            else {
                return false;
            }
        }
        public override bool Withdraw(double amount)
        {
            if (WithDrawLimit >= 3)
            {
                Console.WriteLine($"Withdrawal limit reached. Only 3 withdrawals allowed per year.");
                return false;
            }

            double maxWithdrawalAmount = Balance * 0.20;
            if (amount > maxWithdrawalAmount)
            {
                Console.WriteLine($"Withdrawal exceeds 20% of the account balance. Max allowed is {maxWithdrawalAmount}");
                return false;
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                WithDrawLimit++;
                Console.WriteLine($"Withdrawal of {amount} was successful. Current balance: {Balance}");
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
                return false;
            }
        }

        public void ResetWithdrawals()
        {
            WithDrawLimit = 0;
            Console.WriteLine("Withdrawal count has been reset for the new year.");
        }

    }
}
