﻿
namespace BankAccountSystem
{
    internal class Program
    {
        static void Main()
        {
            // Accounts
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Display(accounts);
            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            var savAccounts = new List<SavingsAccount>();
            savAccounts.Add(new SavingsAccount());
            savAccounts.Add(new SavingsAccount("Superman"));
            savAccounts.Add(new SavingsAccount("Batman", 2000));
            savAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5.0));

            AccountUtil.Display(savAccounts.Cast<Account>().ToList());
            AccountUtil.Deposit(savAccounts.Cast<Account>().ToList(), 1000);
            AccountUtil.Withdraw(savAccounts.Cast<Account>().ToList(), 2000);

            // Checking
            var checAccounts = new List<CheckingAccount>();
            checAccounts.Add(new CheckingAccount());
            checAccounts.Add(new CheckingAccount("Larry2"));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil.Display(checAccounts.Cast<Account>().ToList());
            AccountUtil.Deposit(checAccounts.Cast<Account>().ToList(), 1000);
            AccountUtil.Withdraw(checAccounts.Cast<Account>().ToList(), 2000);
            AccountUtil.Withdraw(checAccounts.Cast<Account>().ToList(), 2000);

            // Trust
            var trustAccounts = new List<TrustAccount>();
            trustAccounts.Add(new TrustAccount());
            trustAccounts.Add(new TrustAccount("Superman2"));
            trustAccounts.Add(new TrustAccount("Batman2", 2000));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            AccountUtil.Display(trustAccounts.Cast<Account>().ToList());
            AccountUtil.Deposit(trustAccounts.Cast<Account>().ToList(), 1000);
            AccountUtil.Deposit(trustAccounts.Cast<Account>().ToList(), 6000);
            AccountUtil.Withdraw(trustAccounts.Cast<Account>().ToList(), 2000);
            AccountUtil.Withdraw(trustAccounts.Cast<Account>().ToList(), 3000);
            AccountUtil.Withdraw(trustAccounts.Cast<Account>().ToList(), 500);

            Console.WriteLine();
        }
    }
}
