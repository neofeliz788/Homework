namespace Homework
{
    using System;

    enum AccountType
    {
        сберегательный,
        текущий
    }

    class Account
    {
        private int accountId;
        private uint balance;
        private AccountType accountType;

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

        public AccountType AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        public void Deposit(uint amount)
        {
            balance += amount;
        }

        public bool Withdraw(uint amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Ошибка! на балансе недостаточно средств");
                return false;
            }
        }

        public void Info(int number, uint initialBalance, AccountType type)
        {
            AccountId = number;
            Balance = initialBalance;
            AccountType = type;
        }

        public void Print()
        {
            Console.WriteLine("Account ID: {0}", AccountId);
            Console.WriteLine("Balance: {0}", Balance);
            Console.WriteLine("Account Type: {0}\n", AccountType);

        }
    }

    class UniqueAccount : Account
    {
        private static int nextAccountNumber = 1;
        public void BankAccount()
        {
            AccountId = GenerateAccountNumber();

        }

        private static int GenerateAccountNumber()
        {
            int accountNumber = nextAccountNumber;
            nextAccountNumber++;
            return accountNumber;
        }
    }

    public class Building
    {
        private static int lastBuildingNumber = 0;

        private int buildingNumber;
        private int height;
        private int floors;
        private int apartments;
        private int entrances;

        public Building(int height, int floors, int apartments, int entrances)
        {
            this.buildingNumber = GenerateBuildingNumber();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }

        private int GenerateBuildingNumber()
        {
            lastBuildingNumber++;
            return lastBuildingNumber;
        }

        public int GetBuildingNumber()
        {
            return buildingNumber;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetFloors()
        {
            return floors;
        }

        public int GetApartments()
        {
            return apartments;
        }

        public int GetEntrances()
        {
            return entrances;
        }

        public int CalculateFloorHeight()
        {
            return height / floors;
        }

        public int CalculateApartmentsPerEntrance()
        {
            return apartments / entrances;
        }

        public int CalculateApartmentsPerFloor()
        {
            return apartments / (floors*entrances);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 7.1: ");
            Account myAccount = new Account();
            myAccount.Info(2281337, 1890000, AccountType.текущий);
            myAccount.Print();
            Console.WriteLine("Упражнение 7.2: ");
            UniqueAccount myUniqueAccount = new UniqueAccount();
            myUniqueAccount.Info(0, 12384, AccountType.сберегательный);
            myUniqueAccount.BankAccount();
            myUniqueAccount.Print();

            UniqueAccount myUniqueAccount2 = new UniqueAccount();
            myUniqueAccount2.Info(0, 123536, AccountType.текущий);
            myUniqueAccount2.BankAccount();
            myUniqueAccount2.Print();

            UniqueAccount myUniqueAccount3 = new UniqueAccount();
            myUniqueAccount3.Info(0, 7812312, AccountType.сберегательный);
            myUniqueAccount3.BankAccount();
            myUniqueAccount3.Print();


            Console.WriteLine("Упражнение 7.3:\nдо зачисления ");
            myAccount.Print();
            myAccount.Deposit(110000);
            Console.WriteLine("после зачисления ");
            myAccount.Print();
            Console.WriteLine("после снятия суммы ");
            myAccount.Withdraw(500000);
            myAccount.Print();
            Console.WriteLine("если сумма снятия больше баланса: ");
            myAccount.Withdraw(5000000);
            myAccount.Print();

            Console.WriteLine("Домашнее задание 7.1: ");
            Building building1 = new Building(100, 10, 400, 8);
            Console.WriteLine("Номер здания: " + building1.GetBuildingNumber());
            Console.WriteLine("Высота здания: " + building1.GetHeight());
            Console.WriteLine("Этажи: " + building1.GetFloors());
            Console.WriteLine("Количество квартир: " + building1.GetApartments());
            Console.WriteLine("Количество подъездов: " + building1.GetEntrances());
            Console.WriteLine("Высота одного этажа: " + building1.CalculateFloorHeight());
            Console.WriteLine("Квартир в подъезде: " + building1.CalculateApartmentsPerEntrance());
            Console.WriteLine("Квартир на этаже: " + building1.CalculateApartmentsPerFloor());

            Building building2 = new Building(315, 15, 900, 15);
            Console.WriteLine("\nНомер здания: " + building2.GetBuildingNumber());
            Console.WriteLine("Высота здания: " + building2.GetHeight());
            Console.WriteLine("Этажи: " + building2.GetFloors());
            Console.WriteLine("Количество квартир: " + building2.GetApartments());
            Console.WriteLine("Количество подъездов: " + building2.GetEntrances());
            Console.WriteLine("Высота одного этажа: " + building2.CalculateFloorHeight());
            Console.WriteLine("Квартир в подъезде: " + building2.CalculateApartmentsPerEntrance());
            Console.WriteLine("Квартир на этаже: " + building2.CalculateApartmentsPerFloor());

        }
    }
}
