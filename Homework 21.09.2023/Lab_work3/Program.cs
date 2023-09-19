using System;

namespace Lab_work3
{
    internal class Program
    {
        enum Account
        {
            savings_account = 10000,
            current_account = 4000

        }
        enum University
        {
            KGU,
            KAI,
            KHTI
        }
        struct Bank_account
        {
            public int account_number;
            public string account_type;
            public int account_balance;

            public void Print()
            {
                Console.WriteLine($"Номер счёта - {account_number} , тип счёта - {account_type} , баланс на счету - {account_balance} руб.\n");
            }
        }

        struct Worker
        {
            public string worker_name;
            public University worker_university;

            public void Print()
            {
                Console.WriteLine($"Имя работника - {worker_name}, место работы - {worker_university}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            Account money = Account.savings_account;
            Console.WriteLine("тип счёта - {0} , баланс на счету - {1} руб.\n", money, (int)money);

            Console.WriteLine("Упражнение 3.2: ");
            Bank_account my_account = new Bank_account();
            my_account.account_number = 14392;
            my_account.account_type = "Сберегательный";
            my_account.account_balance = 75900;
            my_account.Print();


            Console.WriteLine("Домашнее задание 3.1: ");
            Worker worker = new Worker();
            worker.worker_name = "Михаил";
            worker.worker_university = 0;
            worker.Print();

        }
    }
}

