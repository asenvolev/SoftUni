using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Startup
{
    static void Main(string[] args)
    {
        var accounts = new Dictionary<int, BankAccount>();
        var input = Console.ReadLine();
        while (input!="End")
        {
            var commands = input.Split();
            switch (commands[0])
            {
                default:
                    break;
                case "Create":
                    Create(commands, accounts);
                    break;
                case "Deposit":
                    Deposit(commands, accounts);
                    break;
                case "Withdraw":
                    Withdraw(commands, accounts);
                    break;
                case "Print":
                    Print(commands, accounts);
                    break;
            }
            input = Console.ReadLine();
        }
    }

    private static void Print(string[] commands, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(commands[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id].ToString());
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Withdraw(string[] commands, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(commands[1]);
        var amount = double.Parse(commands[2]);
        if (accounts.ContainsKey(id))
        {
            if (amount > accounts[id].Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[id].Withdraw(amount);
            }
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Deposit(string[] commands, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(commands[1]);
        var amount = double.Parse(commands[2]);
        if (accounts.ContainsKey(id))
        {
            accounts[id].Deposit(amount);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Create(string[] commands, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(commands[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var acc = new BankAccount();
            acc.ID = id;
            accounts.Add(id, acc);
        }
    }
}
   
