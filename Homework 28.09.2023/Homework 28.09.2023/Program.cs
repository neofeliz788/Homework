using System;

namespace Homework_28._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1: ");
            Console.WriteLine("Введите число от 1 до 365:");
            int number = Convert.ToInt32(Console.ReadLine());
            int year = DateTime.Now.Year;
            DateTime Date = new DateTime(year, 1, 1).AddDays(number - 1);
            string final_date = Date.ToString("dd MMMM yyyy");
            Console.WriteLine(final_date);

            Console.WriteLine("Упражнение 4.2: ");
            Console.WriteLine("Введите число от 1 до 365:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number2 > 0 && number2 < 366)
            {
                int year2 = DateTime.Now.Year;
                DateTime Date2 = new DateTime(year2, 1, 1).AddDays(number2 - 1);
                string final_date2 = Date2.ToString("dd MMMM yyyy");
                Console.WriteLine(final_date2);
            }
            else
            {
                Console.WriteLine("Неправильно введенная дата");
                System.Environment.Exit(0);
            }
            Console.WriteLine("Домашняя работа 4.1: ");
            Console.Write("Введите год: ");
            int current_year = Convert.ToInt32(Console.ReadLine());
            if (current_year % 4 == 0 && (current_year % 100 != 0 || current_year % 400 == 0)) { Console.WriteLine("Это високосный год"); }
            else
            {
                Console.WriteLine("Это невисокосный год");
            }

        }
    }
}