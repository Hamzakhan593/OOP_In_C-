using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_
{
    public class BankAccount
    {
        private int balance;
        public string name;
        public string accountNumber;
        public BankAccount(string Name, string AccountNumber ) 
        {
            balance = 0;
            name = Name;
            accountNumber = AccountNumber;
        }

        

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

    }
}
