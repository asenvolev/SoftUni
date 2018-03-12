using System;
using System.Linq;
using P01_BillsPaymentSystem.Data;
using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new BillsPaymentSystemContext();
            using (dbContext)
            {
                int userId = 1;
                decimal amount = 3000.00m;
                PayBills(userId, amount, dbContext);
                //PrintUserById(dbContext);

                //dbContext.Database.EnsureDeleted();
                //dbContext.Database.Migrate();

                //Seed(dbContext); закоментиран е целият метод ако искаш да провериш дали работи трябва да махнеш
                // private на сетърите в bankAccount i CreditCard моделите, това е заради 3та задача там пише следното:
                // make sure they are the only way you can change the Balance, MoneyOwed and Limit properties
            }
        }

        public static void PayBills(int userId, decimal amount, BillsPaymentSystemContext dbContext)
        {
            using (dbContext)
            {
                var userInfo = dbContext.Users.
                    Where(u => u.UserId == userId)
                    .Select(x => new
                    {
                        Name = $"{x.FirstName} {x.LastName}",
                        bankAccounts = x.PaymentMethods
                            .Where(pm => pm.Type == Data.Models.Type.BankAccount)
                            .Select(pm => pm.BankAccount).ToList(),
                        creditCards = x.PaymentMethods
                            .Where(pm => pm.Type == Data.Models.Type.CreditCard)
                            .Select(pm => pm.CreditCard).ToList()
                    }).FirstOrDefault();

                decimal currSum = 0;
                if (userInfo.bankAccounts.Any())
                {

                    foreach (var acc in userInfo.bankAccounts)
                    {
                        if (acc.Balance < amount)
                        {
                            currSum += acc.Withdraw(acc.Balance);
                        }
                        else
                        {
                            currSum += acc.Withdraw(amount);
                            break;
                        }
                    }
                }

                if (userInfo.creditCards.Any() && currSum < amount)
                {
                    foreach (var acc in userInfo.creditCards)
                    {
                        if (acc.MoneyOwed < amount)
                        {
                            currSum += acc.Withdraw(acc.MoneyOwed);
                        }
                        else
                        {
                            currSum += acc.Withdraw(amount);
                            break;
                        }
                    }
                }
                
                if(currSum < amount)
                {
                    Console.WriteLine("Insufficient funds!");
                }
                else
                {
                    Console.WriteLine("Payment Done!");
                }

                dbContext.SaveChanges();
            }
        }

        public static void PrintUserById(BillsPaymentSystemContext dbContext)
        {
            var userId = int.Parse(Console.ReadLine());

            using (dbContext)
            {
                var userInfo = dbContext.Users.
                    Where(u => u.UserId == userId)
                    .Select(x => new
                    {
                        Name = $"{x.FirstName} {x.LastName}",
                        bankAccounts = x.PaymentMethods
                            .Where(pm => pm.Type == Data.Models.Type.BankAccount)
                            .Select(pm => pm.BankAccount).ToList(),
                        creditCards = x.PaymentMethods
                            .Where(pm => pm.Type == Data.Models.Type.CreditCard)
                            .Select(pm => pm.CreditCard).ToList()
                    }).FirstOrDefault();

                Console.WriteLine($"User: {userInfo.Name}");
                if (userInfo.bankAccounts.Any())
                {
                    Console.WriteLine("Bank Accounts:");
                    foreach (var acc in userInfo.bankAccounts)
                    {
                        Console.WriteLine($"-- ID: {acc.BankAccountId}\r\n--- Balance: {acc.Balance:f2}\r\n--- Bank: {acc.BankName}\r\n--- SWIFT: {acc.SWIFTCode}");
                    }
                }

                if (userInfo.creditCards.Any())
                {
                    Console.WriteLine("Credit Cards:");
                    foreach (var acc in userInfo.creditCards)
                    {
                        Console.WriteLine($"-- ID: {acc.CreditCardId}\r\n--- Limit: {acc.Limit:f2}\r\n--- Money Owed: {acc.MoneyOwed}\r\n--- Limit Left: {acc.LimitLeft}\r\n--- Expiration Date: {acc.ExpirationDate.ToString("yyyy/MM")}");
                    }
                }
            }
        }

        //public static void Seed(BillsPaymentSystemContext dbContext)
        //{
        //    using (dbContext)
        //    {
        //        var User = new User()
        //        {
        //            FirstName = "Goshu",
        //            LastName = "Trakiev",
        //            Email = "goshy.trakata@abv.bg",
        //            Password = "pedalazagazta"
        //        };
        //
        //        var creditCards = new CreditCard[]
        //        {
        //            new CreditCard()
        //            {
        //                Limit = 2000m,
        //                MoneyOwed = 500m,
        //                ExpirationDate = DateTime.ParseExact("20-05-2020", "dd-MM-yyyy", null)
        //            },
        //            new CreditCard()
        //            {
        //                Limit = 200m,
        //                MoneyOwed = 150m,
        //                ExpirationDate = DateTime.ParseExact("22-12-2018", "dd-MM-yyyy", null)
        //            }
        //        };
        //
        //        var bankAccount = new BankAccount()
        //        {
        //            Balance = 10000m,
        //            BankName = "Durjavna Spestovna Kasa",
        //            SWIFTCode = "DSK"
        //        };
        //
        //        var paymentMethods = new PaymentMethod[]
        //        {
        //            new PaymentMethod()
        //            {
        //                Type = Data.Models.Type.BankAccount,
        //                User = User,
        //                BankAccount = bankAccount
        //            },
        //            new PaymentMethod()
        //            {
        //                Type = Data.Models.Type.CreditCard,
        //                User = User,
        //                CreditCard = creditCards[1]
        //            },
        //
        //        };
        //
        //        dbContext.Add(User);
        //        dbContext.AddRange(creditCards);
        //        dbContext.Add(bankAccount);
        //        dbContext.AddRange(paymentMethods);
        //        dbContext.SaveChanges();
        //    }
        //}
    }
}
