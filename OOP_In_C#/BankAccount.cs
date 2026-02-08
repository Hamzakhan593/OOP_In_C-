using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_
{
    public class BankAccount
    {
        private int balance = 0;

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"You Have Succefully Depoosited {balance} Rupees");
            }
            else
            {
                Console.WriteLine($"Sorry you can't Deposit {amount}");
            }
        }

        public void Withdraw(int amount)
        {
            if (amount > 0 & balance > amount )
            {
                balance -= amount;
                Console.WriteLine($"You have Withdraw {amount}");
            }
            else
            {
                Console.WriteLine($"Sorry! Your Balance is {balance}");
                Console.WriteLine($"You Cannot Withdraw {amount}");

            }
        }

        public void getBalance()
        {
            if( balance < 0)
            {
                balance = 0;
                Console.WriteLine($"You Have Insufficient Balance {balance}");
            }
            else
            {
                Console.WriteLine($"Your Balance is: {balance}");
            }
        }


    }
}
