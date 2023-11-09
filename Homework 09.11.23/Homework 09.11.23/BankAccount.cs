using System;
using System.Collections.Generic;
using System.IO;

public class BankAccount
{
    public string AccountNumber { get; }
    public string AccountType { get; set; }

    public decimal Balance { get; private set; }
    private readonly Queue<BankTransaction> transactionHistory = new Queue<BankTransaction>();
    private Queue<string> transactions = new Queue<string>();
    public BankAccount()
    {
        AccountNumber = GenerateAccountNumber();
    }

    public BankAccount(decimal initialBalance)
        : this()
    {
        Balance = initialBalance;
    }
    public BankAccount(string accountType)
        : this()
    {
        AccountType = accountType;
        Balance = 0;
    }

    public BankAccount(decimal initialBalance, string accountType)
        : this()
    {
        Balance = initialBalance;
        AccountType = accountType;
    }
    private string GenerateAccountNumber()
    {

        return Guid.NewGuid().ToString();
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("зачисление должно быть положительным");
        }

        Balance += amount;
        var transaction = new BankTransaction(amount);
        transactionHistory.Enqueue(transaction);
    }

    public void Withdraw(decimal amount)
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
        var transaction = new BankTransaction(-amount);
        transactionHistory.Enqueue(transaction);
    }
    public void Dispose()
    {

        string fileName = $"{AccountNumber}_transactions.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            while (transactions.Count > 0)
            {
                string transaction = transactions.Dequeue();
                writer.WriteLine(transaction);
            }
        }


        GC.SuppressFinalize(this);
    }

    public IEnumerable<BankTransaction> GetTransactionHistory()
    {
        return transactionHistory;
    }
}
