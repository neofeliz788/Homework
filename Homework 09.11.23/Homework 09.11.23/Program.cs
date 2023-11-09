using Homework_9._11._23;
using System;

namespace Homework_09._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 9.1: ");
            BankAccount account = new BankAccount(1000000);
            BankAccount account2 = new BankAccount("сберегательный");
            BankAccount account3 = new BankAccount(10000, " текущий");
            Console.WriteLine("Упражнение 9.2: ");
            Console.WriteLine("Баланс аккаунта: " + account.Balance);

            account.Deposit(500000);
            account.Withdraw(200000);
            account.Deposit(100000);
            account.Withdraw(700000);

            Console.WriteLine("История транзакций:");
            foreach (var transaction in account.GetTransactionHistory())
            {
                Console.WriteLine($"{transaction.Timestamp}: {transaction.Amount}");
            }
            Console.WriteLine("Баланс аккаунта: " + account.Balance);
            Console.WriteLine("Упражнение 9.3: ");
            account3.Deposit(10000);
            account3.Deposit(40000);
            account3.Withdraw(10000);

            account3.Dispose();

            Console.WriteLine("Домашнее задание 9.1: ");
            Song song = new Song();
            Song song2 = new Song("30 лет", "Сектор газа");
            Song song3 = new Song("сектор газа", "Сектор газа", song2);

            Console.WriteLine($"{song2.Title()}\n{song3.Title()}");







        }
    }
}
