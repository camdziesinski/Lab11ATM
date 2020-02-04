using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11ATM
{
    class Account
    {
        //Fields
        private string name, password;
        private double balance;

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        //Constructers
        public Account()
        {

        }
        public Account(string _name, string _password, double _balance)

        {
            name = _name;
            password = _password;
            balance = _balance;
        }
    }
}
