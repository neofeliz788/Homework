using System;

namespace Tumakov13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 13.1:");
            BankAccount bankAccount = new BankAccount(1, 100000, BankAccount.AccType.Сберегательный, "quandale dingle");
            Console.WriteLine(bankAccount.accountNumber);
            Console.WriteLine(bankAccount.accountType);
            // Console.WriteLine(bankAccount.OwnerName); недоступен из за его уровня защиты

            Console.WriteLine("Упражнение 13.2:");

            bankAccount.AddTransaction(new BankTransaction(1000));
            bankAccount.AddTransaction(new BankTransaction(100000));

            Console.WriteLine("Транзакции:");

            Console.WriteLine(bankAccount.GetTransactionCount());

            Console.WriteLine("дз 13.1:");
            Building building = new Building();

            building.BuildingNumber = 1;
            building.Height = 50;
            building.Floors = 10;
            building.Apartments = 100;
            building.Entrances = 2;

            Console.WriteLine($"Номер дома: {building.BuildingNumber}");
            Console.WriteLine($"высота дома: {building.Height}");

            double floorHeight = building.CalculateFloorHeight();
            Console.WriteLine($"Высота этажа: {floorHeight}");

            double apartmentsPerEntrance = building.CalculateApartmentsPerEntrance();
            Console.WriteLine($"Квартир в подъезде: {apartmentsPerEntrance}");

            double apartmentsPerFloor = building.CalculateApartmentsPerFloor();
            Console.WriteLine($"Квартир на этаже: {apartmentsPerFloor}");
            Console.WriteLine();


            Console.WriteLine("дз 13.2:");
            BuildingCollection buildingCollection = new BuildingCollection();

            buildingCollection[0] = new Building { BuildingNumber = 1, Height = 40, Floors = 8, Apartments = 100, Entrances = 2 };
            buildingCollection[1] = new Building { BuildingNumber = 2, Height = 100, Floors = 18, Apartments = 150, Entrances = 5 };

            Building building1 = buildingCollection[0];
            Building building2 = buildingCollection[1];

            Console.WriteLine($"Дом номер {building1.BuildingNumber}, высота: {building1.Height}");
            Console.WriteLine($"Дом номер {building2.BuildingNumber}, высота: {building2.Height}");
            Console.WriteLine();


            Console.WriteLine("Упражнение 14.1:");
            BankAccount account3 = new BankAccount(2, 300000, BankAccount.AccType.Сберегательный, "Динар");
            account3.Deposit(1060);
            account3.DumpToScreen();
            Console.WriteLine();

            Console.WriteLine("Упражнение 14.2:");
            Console.WriteLine("дз 14.1:");
            Type type = typeof(Building);
            DeveloperInfoAttribute attribute = (DeveloperInfoAttribute)Attribute.GetCustomAttribute(type, typeof(DeveloperInfoAttribute));

            if (attribute != null)
            {
                Console.WriteLine($"Разработчик: {attribute.DeveloperName}");
                Console.WriteLine($"Организация: {attribute.OrganizationName}");
            }
            else
            {
                Console.WriteLine("Информация о разработчике не найдена");
            }
        }
    }
}
