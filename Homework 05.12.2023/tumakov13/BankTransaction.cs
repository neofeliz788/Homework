using System;

public class BankTransaction
{
    private DateTime timestamp { get; }
    private decimal amount { get; }

    public DateTime Timestamp
    {
        get
        {
            return timestamp;
        }
    }
    public decimal Amount
    {
        get
        {
            return amount;
        }
    }

    public BankTransaction(decimal amount)
    {
        timestamp = DateTime.Now;
        this.amount = amount;
    }
}