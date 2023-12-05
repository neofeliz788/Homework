using System;
using System.Collections.Generic;
using System.Diagnostics;

internal class BankAccount
{
    private int AccountNumber { get; }
    private string OwnerName { get; }
    public string ownerName => OwnerName;
    private AccType AccountType { get; }
    private readonly Queue<BankTransaction> transactionHistory = new Queue<BankTransaction>();
    private List<BankTransaction> transactions = new List<BankTransaction>();
    private decimal Balance { get; set; }
    public int accountNumber => AccountNumber;
    public AccType accountType => AccountType;

    public BankAccount(int accountNumber, decimal balance, AccType accounttype, string ownerName)
    {
        AccountNumber = accountNumber;

        Balance = balance;
        AccountType = accounttype;
        OwnerName = ownerName;
    }
    public List<BankTransaction> Transactions
    {
        get
        {
            return transactions;
        }
    }


    internal void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("зачисление должно быть положительным");
        }

        Balance += amount;

    }

    internal void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Баланс меньше нуля");
        }

        if (amount > Balance)
        {
            throw new InvalidOperationException("Недостаточно средств на балансе");
        }

        Balance -= amount;

    }
    public void AddTransaction(BankTransaction transaction)
    {
        transactions.Add(transaction);
    }
    public enum AccType
    {
        Сберегательный,
        Текущий
    }
    public IEnumerable<BankTransaction> GetTransactionHistory()
    {
        return transactionHistory;
    }

    public int GetTransactionCount()
    {
        return transactions.Count;
    }
    public BankTransaction this[int index]
    {
        get
        {
            if (index >= 0 && index < transactions.Count)
                return transactions[index];
            else
                throw new IndexOutOfRangeException();
        }
    }
    [Conditional("DEBUG_ACCOUNT")]
    public void DumpToScreen()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Balance: {Balance}");
    }
}

