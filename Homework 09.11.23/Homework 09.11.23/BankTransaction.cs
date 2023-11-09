using System;

public class BankTransaction
{
    public DateTime Timestamp { get; }
    public decimal Amount { get; }

    public BankTransaction(decimal amount)
    {
        Timestamp = DateTime.Now;
        Amount = amount;
    }
}