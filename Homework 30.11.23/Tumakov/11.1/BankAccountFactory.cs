using System;
using System.Collections.Generic;


public class BankAccountFactory
{
    private Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
    private int accountNumberCounter = 1;

    internal int CreateAccount(string ownerName, decimal initialBalance)
    {
        BankAccount newAccount = new BankAccount(accountNumberCounter, ownerName, initialBalance);
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
