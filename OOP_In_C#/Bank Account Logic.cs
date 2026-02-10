using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_In_C_
{
    internal class Bank_Account_Logic
    {
        private BankAccount bankacc;
        public Bank_Account_Logic(BankAccount bAccount)
        {
            bankacc = bAccount;
            Console.WriteLine($"Account Name: {bankacc.name}");
            Console.WriteLine($"Account Number: {bankacc.accountNumber}");
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                bankacc.Balance += amount;
                Console.WriteLine($"You Have Succefully Deposited {bankacc.Balance} Rupees");
            }
            else
            {
                Console.WriteLine($"Sorry you can't Deposit {amount}");
            }
        }

        public void Withdraw(int amount)
        {
            if (amount > 0 & bankacc.Balance > amount)
            {
                bankacc.Balance -= amount;
                Console.WriteLine($"You have Withdraw {amount}");
            }
            else
            {
                Console.WriteLine($"Sorry! Your Balance is {bankacc.Balance}");
                Console.WriteLine($"You Cannot Withdraw {amount}");

            }
        }

        public void getBalance()
        {
            if (bankacc.Balance < 0)
            {
                bankacc.Balance = 0;
                Console.WriteLine($"You Have Insufficient Balance {bankacc.Balance}");
            }
            else
            {
                Console.WriteLine($"Your Balance is: {bankacc.Balance}");
            }
        }



    }
}
