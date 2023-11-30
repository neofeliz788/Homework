using System;
namespace Bank
{
    internal class BankAccount2
    {
        internal int AccountNumber { get; }
        internal string OwnerName { get; }
        internal decimal Balance { get; private set; }


        internal BankAccount2(int accountNumber, string ownerName, decimal balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
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


    }
}
