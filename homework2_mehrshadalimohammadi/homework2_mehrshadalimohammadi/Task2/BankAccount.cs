using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_mehrshadalimohammadi.Task2
{
    public class BankAccount
    {
        private int balance;

        public void Deposit(double amount)
        {
            balance += (int)amount;
        }

        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= (int)amount;
            }
            else
            {
                Console.WriteLine("موجودی کافی نیست");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"موجودی فعلی: {balance}");
        }
    }

}
