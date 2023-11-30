using System;

class BankAccount3
{
    public int AccountNumber { get; set; }
    public string OwnerName { get; set; }
    public decimal Balance { get; set; }

    internal BankAccount3(int accountNumber, string ownerName, decimal balance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = balance;
    }
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        BankAccount3 other = (BankAccount3)obj;
        return AccountNumber == other.AccountNumber &&
               OwnerName == other.OwnerName &&
               Balance == other.Balance;
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
    public override int GetHashCode()
    {
        return HashCode.Combine(AccountNumber, OwnerName, Balance);
    }

    public static bool operator ==(BankAccount3 account1, BankAccount3 account2)
    {
        if (ReferenceEquals(account1, account2))
        {
            return true;
        }

        if (account1 is null || account2 is null)
        {
            return false;
        }

        return account1.Equals(account2);
    }

    public static bool operator !=(BankAccount3 account1, BankAccount3 account2)
    {
        return !(account1 == account2);
    }

    public override string ToString()
    {
        return $"Account Number: {AccountNumber}, Account Holder: {OwnerName}, Balance: {Balance:C}";
    }
}