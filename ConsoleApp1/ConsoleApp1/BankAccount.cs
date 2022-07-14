using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountEnscapulation
{
    public class BankAccount
    {
        private static double balance = 00;
        public static double GetBalance()
        {
            Console.WriteLine($"Your Balance is ${balance}");
            return balance;
        }

        public static void Deposit(double amount)
        {
            balance += amount;
        }

        public static void Withdrawl(double amount)
        { 
            balance -= amount;
        }

    }
}
