using System;
using System.Collections.Generic;

namespace Bank
{
    public class BankAccountFactory3
    {
        private Dictionary<int, BankAccount2> accounts = new Dictionary<int, BankAccount2>();
        private int accountNumberCounter = 1;

        internal int CreateAccount(string ownerName, decimal initialBalance)
        {
            BankAccount2 newAccount = new BankAccount2(accountNumberCounter, ownerName, initialBalance);
            accounts.Add(accountNumberCounter, newAccount);
            accountNumberCounter++;
            return newAccount.AccountNumber;
        }

        internal int CreateAccount(string ownerName)
        {
            return CreateAccount(ownerName, 0);
        }

        internal void CloseAccount(int accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts.Remove(accountNumber);
                Console.WriteLine($"Аккаунт номер {accountNumber} не найден.");
            }
            else
            {
                Console.WriteLine($"Аккаунт номер {accountNumber} не найден.");
            }
        }
    }
}