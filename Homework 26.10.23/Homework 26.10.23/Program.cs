using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Homework_26._10._23
{

    internal class Program
    {
        static string ReversedString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string FormatIFormattable(object obj)
        {
            if (obj is IFormattable formattable)
            {

                return formattable.ToString(null, null);
            }
            else
            {
                return obj.ToString();
            }
        }
        public static string SearchMail(ref string s)
        {
            // Используем регулярное выражение для поиска адреса электронной почты
            Regex emailRegex = new Regex(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");
            Match match = emailRegex.Match(s);

            if (match.Success)
            {
                string email = match.Value;
                s = s.Replace(email, ""); // Удаляем найденный адрес электронной почты из исходной строки
                return email;
            }

            return string.Empty; // Возвращаем пустую строку, если адрес не найден
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 8.1: ");
            Account account1 = new Account();
            Account account2 = new Account();
            account1.Info(1, 400000);
            account2.Info(2, 0);
            Console.WriteLine("До перевода: ");
            account1.Display();
            account2.Display();

            account1.Transfer(account2, 300000);
            Console.WriteLine("\nПосле перевода: ");
            account1.Display();
            account2.Display();

            Console.WriteLine("Упражнение 8.2: ");
            string input = "A-A-ALL MY FELLAS";
            string reversedInput = ReversedString(input);
            Console.WriteLine($"Изначальная строка: {input}");
            Console.WriteLine($"Эта строка наоборот: {reversedInput}");

            Console.WriteLine("Упражнение 8.3: ");
            Console.Write("Введите имя файла: ");
            string inputFileName = Console.ReadLine();

            if (File.Exists(inputFileName))
            {
                string outputFileName = "C:\\Users\\User\\source\\repos\\Homework 26.10.23\\Homework 26.10.23\\Files\\output.txt"; // директория входного файла -  C:\Users\User\source\repos\Homework 26.10.23\Homework 26.10.23\Files\input.txt
                string fileContent = File.ReadAllText(inputFileName);
                string uppercaseContent = fileContent.ToUpper();

                File.WriteAllText(outputFileName, uppercaseContent);

                Console.WriteLine("Содержимое файла скопировано в файл 'output.txt' и преобразовано в заглавные буквы.");
            }
            else
            {
                Console.WriteLine("Файл не найден. Программа завершает работу.");
            }

            Console.WriteLine("Упражнение 8.4: ");
            int value = 788;
            string formattedValue = FormatIFormattable(value);
            Console.WriteLine(formattedValue);


            Console.WriteLine("Домашнее задание 8.1: ");
            string data = "C:\\Users\\User\\source\\repos\\Homework 26.10.23\\Homework 26.10.23\\Files\\data.txt";
            string emails = "C:\\Users\\User\\source\\repos\\Homework 26.10.23\\Homework 26.10.23\\Files\\email.txt";

            // Чтение из исходного файла и запись адресов электронной почты в новый файл
            using (StreamReader reader = new StreamReader(data))
            using (StreamWriter writer = new StreamWriter(emails))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string email = SearchMail(ref line); // Извлечение адреса электронной почты
                    if (!string.IsNullOrEmpty(email))
                    {
                        writer.WriteLine(email);
                    }
                }
            }

            Console.WriteLine("Адреса электронной почты сохранены в файле: \n" + emails);


            Console.WriteLine("Домашнее задание 8.2: ");
            Song song1 = new Song("Сельский туалет", "Сектор газа");
            Song song2 = new Song("Сельский туалет", "Сектор газа");
            Song song3 = new Song("Бомж", "Сектор газа");
            Song song4 = new Song("Туман", "Сектор газа");

            // Устанавливаем связь между песнями
            song1.Next = song2;
            song2.Next = song3;
            song3.Next = song4;

            // Выводим информацию о каждой песне
            Song currentSong = song1;
            while (currentSong != null)
            {
                Console.WriteLine(currentSong.Title());
                currentSong = currentSong.Next;
            }

            // Сравниваем первую и вторую песни
            if (song1.Equals(song2))
            {
                Console.WriteLine("\nпервая и вторая песни идентичны.");
            }
            else
            {
                Console.WriteLine("\nПервая и вторая песни различны.");
            }
            if (song2.Equals(song3))
            {
                Console.WriteLine("\nВторая и третья песни идентичны.");
            }
            else
            {
                Console.WriteLine("\nВторая и третья песни различны.");
            }


        }


    }
}
