using System;

namespace Homework_26._10._23
{
    class Account
    {
        private int accountId;
        private uint balance;


        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        public uint Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Info(int accountId, uint balance)
        {
            Balance = balance;
            AccountId = accountId;
        }
        public void Display()
        {
            Console.WriteLine($"Баланс аккаунта номер {accountId} - {balance}");
        }

        public void Deposit(uint amount)
        {
            balance += amount;
        }

        public void Withdraw(uint amount)
        {
            if (balance < amount)
            {
                throw new ArgumentException("Ошибка! на балансе недостаточно средств");
            }
            balance -= amount;

        }
        public void Transfer(Account receiver, uint amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("количество отправленных денег не может быть отрицательным");
            }

            if (Balance < amount)
            {
                throw new InvalidOperationException("Ошибка! на балансе недостаточно средств");
            }

            Withdraw(amount);
            receiver.Deposit(amount);
        }
    }
}
