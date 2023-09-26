using System;
using System.Collections.Generic;

namespace Tasks
{
    internal class Program
    {

      
          


        
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: ");
            int previous_number = int.MinValue;
            for (int i = 1; i < 11; i++) 
            {
                Console.Write("Введите {0} значение: ", i);
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > previous_number)
                {
                    previous_number = number;
                }
                else
                {
                    Console.WriteLine("первый номер , который нарушил последовательность: {0}",number);
                    break;
                }
                if (i == 10) { Console.WriteLine("Последовательность упорядочена по возрастанию"); }
            }

            Console.WriteLine("Задание 2: ");
            Console.WriteLine("Введите число от 6 до 14");
            try
            {
                int card_value = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ваша карта: ");
                switch (card_value)
                {
                    case 6: Console.WriteLine("шестёрка"); break;
                    case 7: Console.WriteLine("семёрка"); break;
                    case 8: Console.WriteLine("восьмёрка"); break;
                    case 9: Console.WriteLine("девятка"); break;
                    case 10: Console.WriteLine("десятка"); break;
                    case 11: Console.WriteLine("валет"); break;
                    case 12: Console.WriteLine("дама"); break;
                    case 13: Console.WriteLine("король"); break;
                    case 14: Console.WriteLine("туз"); break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Hell nah");
            }
            finally
            {
                Console.WriteLine("Вы узнали все, что хотели знать");
            }
            Console.WriteLine("Задание 3: ");
            Console.Write("Введите строку: ");
            string input = Console.ReadLine().ToLower();
            int identificator = 0;
            var people = new Dictionary<string, string>()
{
    { "jabroni", "Patron Tequila"},
    { "school counselor", "Anything with alcohol"},
    { "programmer", "hipster Craft beer"},
    {"bike gang member","Moonshine" },
    {"politician","Your tax dollars" },
    {"rapper","Cristal" },

};
            foreach (var person in people)
            { if(input == person.Key) {Console.WriteLine($"Человек: {person.Key}, {person.Value}");identificator++; }
            }
            if (identificator == 0) { Console.WriteLine("Beer"); }


            Console.WriteLine("Задание 4: ");
            Console.Write("Введите число от 1 до 7: ");
            int day = Convert.ToInt32(Console.ReadLine());
            if (1 <= day && day <= 7) { Console.WriteLine((Day)day); }
            else { Console.WriteLine("Hell nah im not doing this"); }


            Console.WriteLine("Задание 5: ");
            Array strings = new string[] { "Hello Kitty", "Barbie Doll", "arthas", "alinor", "Barbie Doll", "vvardenfel" };
            int quantity = 0;
            foreach (string str in strings)
            {
                if (str == "Barbie Doll" || str == "Hello Kitty") { quantity++; }
            }
            Console.WriteLine($"Количество нужных строк в массиве: {quantity}");
        }
    enum Day
       {Понедельник = 1,
        Вторник = 2,
        Среда = 3,
       Четверг = 4,
        Пятница = 5,
        Суббота = 6,
        Воскресенье = 7}
    }
}
