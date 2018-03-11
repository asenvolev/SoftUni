using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Startup
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.Deposit(15);
            acc.Withdraw(5);
            Console.WriteLine(acc.ToString());
        }
    }

