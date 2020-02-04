using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11ATM
{
    class ATM
    {
        //fields

        private List<Account> accounts;
        private string currentUser;


        //properties

        public List<Account> Accounts { get; set; }

        //constructors

        public ATM(List<Account> _accounts)

        {
            accounts = _accounts;
        }

        //Register new acount
        public static void Register()
        {
            var newAccount = new Account();
                newAccount.Name = Input.GetUserInput("Please enter your user name: ");
                newAccount.Password = Input.GetUserInput("Please enter a new password: ");
                newAccount.Balance = 0;
            accounts.Add(newAccount);
        }


        //Check Balance
        public static double CheckBalance(Account AccountLoggedIn)

        {
            return AccountLoggedIn.Balance;
        }
        //Deposit
        public static double Deposit(Account AccountLoggedIn)
        {
            double deposit = Input.GetUserNumber("How much would you like to deposit?");
            return AccountLoggedIn.Balance + deposit;
        }
        //Withdraw
        public static double Withdraw(Account AccountLoggedIn)
        {
            double withdrawAmount = Input.GetUserNumber("How much would you like to withdraw?");
            if(withdrawAmount < AccountLoggedIn.Balance)
            {
                return AccountLoggedIn.Balance - withdrawAmount;
            }
            else
            {
                Console.WriteLine("Sorry, you do not have enough to withdraw.");
                return 0;
            }
        }
        //Logout
        public void LogOut()
        {
            currentUser = null;
        }
    }
}
