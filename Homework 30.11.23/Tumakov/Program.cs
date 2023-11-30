using Bank;
using Buildings;
using System;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 11.1: ");
            BankAccountFactory accountFactory = new BankAccountFactory();
            int account1 = accountFactory.CreateAccount("John Jonson", 100000);
            int account2 = accountFactory.CreateAccount("John Jonson");
            Console.WriteLine($"Номер аккаунта 1: {account1}");
            Console.WriteLine($"Номер аккаунта 2: {account2}");
            accountFactory.CloseAccount(account1);
            accountFactory.CloseAccount(account2);


            Console.WriteLine("\nУпражнение 11.2: ");
            BankAccountFactory3 accountFactory2 = new BankAccountFactory3();
            int account3 = accountFactory2.CreateAccount("Qundale Dingle", 666);
            Console.WriteLine($"Номер аккаунта 3: {account3}");
            accountFactory.CloseAccount(account3);


            Console.WriteLine("\nдомашнее задание 11.1: ");
            Building building1 = Creator.CreateBuilding(1, "больница");
            Building building2 = Creator.CreateBuilding(2);
            building1.DisplayBuildingInfo();
            building2.DisplayBuildingInfo();
            Building retrievedBuilding = Creator.GetBuilding(1);
            retrievedBuilding?.DisplayBuildingInfo();
            Creator.RemoveBuilding(2);
            Creator.RemoveBuilding(3);


            Console.WriteLine("\nдомашнее задание 11.2: ");
            Building2 building3 = Creator2.CreateBuilding(1, "Школа");
            Building2 building4 = Creator2.CreateBuilding(2);
            building3.DisplayBuildingInfo();
            building4.DisplayBuildingInfo();
            Building2 retrievedBuilding2 = Creator2.GetBuilding(1);
            retrievedBuilding2.DisplayBuildingInfo();
            Creator2.RemoveBuilding(2);
            Creator2.RemoveBuilding(3);


            Console.WriteLine("\nУпражнение 12.1: ");
            BankAccount3 account4 = new BankAccount3(1, "Quandale Dingle", 666);
            BankAccount3 account5 = new BankAccount3(2, "Kumalala", 666);
            Console.WriteLine("Using Equals method: " + account4.Equals(account5));

            Console.WriteLine("Using == operator: " + (account4 == account5));
            Console.WriteLine("Using != operator: " + (account4 != account5));
            Console.WriteLine("Account 1:\n" + account4);
            Console.WriteLine("Account 2:\n" + account5);


            Console.WriteLine("Упражнение 12.2: ");
            RationalNumber a = new RationalNumber(1, 2);
            RationalNumber b = new RationalNumber(3, 4);

            bool isEqual = a == b;
            bool isNotEqual = a != b;
            bool isLessThan = a < b;
            bool isGreaterThan = a > b;
            bool isLessThanOrEqual = a <= b;
            bool isGreaterThanOrEqual = a >= b;

            Console.WriteLine($"a == b: {isEqual}");
            Console.WriteLine($"a != b: {isNotEqual}");
            Console.WriteLine($"a < b: {isLessThan}");
            Console.WriteLine($"a > b: {isGreaterThan}");
            Console.WriteLine($"a <= b: {isLessThanOrEqual}");
            Console.WriteLine($"a >= b: {isGreaterThanOrEqual}");

            RationalNumber sum = a + b;
            RationalNumber difference = a - b;
            RationalNumber product = a * b;
            RationalNumber quotient = a / b;
            RationalNumber remainder = a % b;

            Console.WriteLine($"a + b: {sum}");
            Console.WriteLine($"a - b: {difference}");
            Console.WriteLine($"a * b: {product}");
            Console.WriteLine($"a / b: {quotient}");
            Console.WriteLine($"a % b: {remainder}");


            RationalNumber c = new RationalNumber(2, 3);
            RationalNumber incremented = c++;
            RationalNumber decremented = c--;

            Console.WriteLine($"c++: {incremented}");
            Console.WriteLine($"c--: {decremented}");


            float floatValue = (float)a;
            int intValue = (int)b;

            Console.WriteLine($"(float)a: {floatValue}");
            Console.WriteLine($"(int)b: {intValue}");
            Console.WriteLine();


            Console.WriteLine("Домашнее задание 12.1: ");
            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, -1);

            Console.WriteLine($"c1 = {c1}");
            Console.WriteLine($"c2 = {c2}");

            ComplexNumber sum1 = c1 + c2;
            ComplexNumber difference1 = c1 - c2;
            ComplexNumber product1 = c1 * c2;

            Console.WriteLine($"c1 + c2 = {sum1}");
            Console.WriteLine($"c1 - c2 = {difference1}");
            Console.WriteLine($"c1 * c2 = {product1}");

            Console.WriteLine($"c1 == c2: {c1 == c2}");
            Console.WriteLine($"c1 != c2: {c1 != c2}");
            Console.WriteLine();


            Console.WriteLine("Домашнее задание 12.2: ");
            BookContainer container = new BookContainer();

            container.AddBook(new Book("'Преступление и наказание'", "Ф.М.Достоевский", "Стелловский"));
            container.AddBook(new Book("'Игрок'", "Ф.М.Достоевский", "-"));
            container.AddBook(new Book("'Кровавый меридиан'", "Кормак Маккарти", "Random House"));

            Console.WriteLine("Книги до сортировки:");
            container.PrintBooks();
            Console.WriteLine();

            Comparison<Book> sortByTitle = (book1, book2) => book1.Title.CompareTo(book2.Title);

            container.SortBooks(sortByTitle);
            Console.WriteLine("Книги после сортировки по названию:");
            container.PrintBooks();
            Console.WriteLine();

            Comparison<Book> sortByAuthor = (book1, book2) => book1.Author.CompareTo(book2.Author);

            container.SortBooks(sortByAuthor);
            Console.WriteLine("Книги отсортированные по автору:");
            container.PrintBooks();
            Console.WriteLine();


            Comparison<Book> sortByPublisher = (book1, book2) => book1.Publisher.CompareTo(book2.Publisher);

            container.SortBooks(sortByPublisher);
            Console.WriteLine("Сортировка по издателю:");
            container.PrintBooks();

        }
    }
}
