using System;
using System.Data.SqlTypes;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;

namespace Task
{
    internal class Program
    {   enum Alcohol
        {
            a='a', b='b', c='c', d='d'
        }
        
        struct Student
        {
            public string surname;
            public string name;
            public int identificator;
            public string birth_date;
            public Alcohol alco_category;
            public double alcohol_drinked;
            public void Print()
            {
                Console.WriteLine($"Имя - {name} , фамилия - {surname} , идентификатор - {identificator}, дата рождения - {birth_date}, категория алкоголизма {alco_category}, обьем выпитого алкоголя - {alcohol_drinked} литров");
            }
        }
        struct Person
        {
            public string name;
            public string city;
            public int age;
            public ulong pin;
            public void Print()
            {
                Console.WriteLine($"Имя - {name} , город проживания - {city} , возраст - {age}, пин-код -{pin} .\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания от 1 до 8: ");
            int task_number = Convert.ToInt32(Console.ReadLine());

            if (task_number == 1)
            {
                Console.WriteLine("Задание 1: ");
                Console.WriteLine("Минимальное значение типа byte : {0} , максимальное : {1}", Byte.MinValue, Byte.MaxValue);
                Console.WriteLine("Минимальное значение типа sbyte : {0} , максимальное : {1}", SByte.MinValue, SByte.MaxValue);
                Console.WriteLine("Минимальное значение типа short : {0} , максимальное : {1}", short.MinValue, short.MaxValue);
                Console.WriteLine("Минимальное значение типа ushort : {0} , максимальное : {1}", ushort.MinValue, ushort.MaxValue);
                Console.WriteLine("Минимальное значение типа int : {0} , максимальное : {1}", int.MinValue, int.MaxValue);
                Console.WriteLine("Минимальное значение типа uint : {0} , максимальное : {1}", uint.MinValue, uint.MaxValue);
                Console.WriteLine("Минимальное значение типа long : {0} , максимальное : {1}", long.MinValue, long.MaxValue);
                Console.WriteLine("Минимальное значение типа ulong : {0} , максимальное : {1}", ulong.MinValue, ulong.MaxValue);
                Console.WriteLine("Минимальное значение типа float : {0} , максимальное : {1}", float.MinValue, float.MaxValue);
                Console.WriteLine("Минимальное значение типа double : {0} , максимальное : {1}", double.MinValue, double.MaxValue);
                Console.WriteLine("Минимальное значение типа decimal : {0} , максимальное : {1}", decimal.MinValue, decimal.MaxValue);
            }

            if (task_number == 2)
            {
                Console.WriteLine("Задание 2: ");
                Console.WriteLine("Введите ваше имя: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите ваш город проживания: ");
                string city = Console.ReadLine();
                Console.WriteLine("Введите ваш возраст: ");
                byte age = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Введите ваш пин-код: ");
                ulong pin = Convert.ToUInt64(Console.ReadLine());
                Person person = new Person();
                person.name = name;
                person.city = city;
                person.age = age;
                person.pin = pin;
                person.Print();
            }
            if (task_number == 3)
            {
                Console.WriteLine("Задание 3(смена регистра): ");
                Console.WriteLine("Введите строку");
                string str = Console.ReadLine();
                string new_str = "";
                foreach (char c in str)
                {
                    new_str += Char.IsUpper(c) ? Char.ToLower(c) : Char.ToUpper(c);
                }
                Console.WriteLine("С учетом изменения регистра новая строка теперь выглядит так - {0}", new_str);
            }
            if (task_number == 4)
            {
                Console.WriteLine("Задание 4(подстрока): ");
                Console.WriteLine("Введите строку: ");
                string String = Console.ReadLine();
                Console.WriteLine("Введите подстроку");
                string Sub_String = Console.ReadLine();
                int amount = new Regex(Sub_String).Matches(String).Count;
                Console.WriteLine("Количество вхождений подстроки {0} в строке {1}: {2}", Sub_String, String, amount);
            }
            if (task_number == 5)
            {
                Console.WriteLine("Задание 5: ");
                Console.WriteLine("Введите начальную цену виски: ");
                double whiskey_price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите скидку на виски в процентах: ");
                double sale_percent = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите стоимость отпуска: ");
                double holiday_price = Convert.ToDouble(Console.ReadLine());
                double profit = whiskey_price * sale_percent / 100;
                double number_of_bottles = holiday_price / profit;
                Console.WriteLine("Количество бутылок виски по акции, которые скомпенсируют цену отпуска - {0} бутылок", Math.Round(number_of_bottles)-1);
            }

            if (task_number == 6)
            {
                Console.WriteLine("Задание 6(диалог): ");
                Console.WriteLine("1 - Привет");
                Console.WriteLine("2 - (промолчать)\nВыберите вариант диалога: ");
                int variant1 = Convert.ToInt32(Console.ReadLine());
                if (variant1 == 1)
                {
                    Console.WriteLine("Как тебя зовут?: ");
                    string your_name = Console.ReadLine();
                    Console.WriteLine("Привет, {0}", your_name);
                }
                else
                {
                    Console.WriteLine("Неправильный ответ");
                    System.Environment.Exit(0);
                }
                Console.WriteLine("1 - спросить о погоде");
                Console.WriteLine("2 - спросить, знает ли дверь что-то о тайной комнате\nВыберите вариант диалога");
                int variant2 = Convert.ToInt32(Console.ReadLine());
                if (variant2 == 2)
                {
                    Console.WriteLine("Да");
                }
                else
                {
                    Console.WriteLine("Неправильный ответ");
                    System.Environment.Exit(0);
                }
                Console.WriteLine("1 - попросить рассказать о тайной комнате");
                Console.WriteLine("2 - промолчать\nВыберите вариант диалога");
                int variant3 = Convert.ToInt32(Console.ReadLine());
                if (variant3 == 1)
                {
                    Console.WriteLine("Нет");
                }
                else
                {
                    Console.WriteLine("Неправильный ответ");
                    System.Environment.Exit(0);
                }
                Thread.Sleep(5000);
                Console.WriteLine("Но могу показать");
              
                Random random = new Random();
                int rand_number = random.Next();
                if (rand_number % 4 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    
                }
                if (rand_number % 4 == 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    
                }
                if (rand_number % 4 == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    
                }
                if (rand_number % 4 == 3)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    
                }
                Thread.Sleep(3000);
                Console.Clear();
            }
            if (task_number == 7)
            {
                Console.WriteLine("1 вариант - цифры распределены рандомно");
                Console.WriteLine("2 вариант - цифры распределены пользователем");
                int num = Convert.ToInt32(Console.ReadLine());
                int sum1 = 0;
                int sum2 = 0;
                if (num == 1)
                {
                    
                    Random rand_num = new Random();
                    for (int i = 0;i < 11;i+=2) 
                    {
                        int number1 = rand_num.Next();
                        int digit1 = number1 % 10;
                        sum1+= digit1;
                        
                    }
                    for (int i = 1; i < 12; i+=2)
                    {
                        int number2 = rand_num.Next();
                        int digit2 = number2 % 10;
                        sum2+= digit2*3;
                       
                    }
                    
                }
                if (num == 2)
                {
                    
                    Console.WriteLine("Введите 12 цифр(по одной в ряду)");
                    for (int i = 1; i < 13; i++) { 
                    int num_2  = Convert.ToInt32(Console.ReadLine());
                    if (i%2 != 0) { 
                            sum1 += num_2;
                        }
                    else
                        {
                            sum2 += num_2*3;
                        }
                    }
                    
                }
                int final_sum = sum1 + sum2;
                int number_13 = 10 - (final_sum % 10);
                Console.WriteLine("Контрольная цифра EAN13 - {0}", number_13);
            }
            if (task_number == 8)
            {
                Student student1 = new Student();
                student1.name = "Михаил";
                student1.surname = "Круг";
                student1.identificator = 01;
                student1.birth_date = "07.04.1962";
                student1.alcohol_drinked = 5;
                student1.alco_category = (Alcohol)'b';

                Student student2 = new Student();
                student2.name = "Михаил";
                student2.surname = "Горшенёв";
                student2.identificator = 02;
                student2.birth_date = "07.08.1973";
                student2.alcohol_drinked = 10;
                student2.alco_category = (Alcohol)'a';

                Student student3 = new Student();
                student3.name = "Юрий";
                student3.surname = "Хой";
                student3.identificator = 03;
                student3.birth_date = "27.07.1964";
                student3.alcohol_drinked = 15;
                student3.alco_category = (Alcohol)'a';

                Student student4 = new Student();
                student4.name = "Юрий";
                student4.surname = "Шатунов";
                student4.identificator = 04;
                student4.birth_date = "06.09.1973";
                student4.alcohol_drinked = 3;
                student4.alco_category = (Alcohol)'d';

                Student student5 = new Student();
                student5.name = "Виктор";
                student5.surname = "Цой";
                student5.identificator = 05;
                student5.birth_date = "21.06.1962";
                student5.alcohol_drinked = 6;
                student5.alco_category = (Alcohol)'b';
                double alco_sum = student1.alcohol_drinked + student2.alcohol_drinked + student3.alcohol_drinked + student4.alcohol_drinked + student5.alcohol_drinked;
                double stu1_per = student1.alcohol_drinked / alco_sum * 100;
                double stu2_per = student2.alcohol_drinked / alco_sum * 100;
                double stu3_per = student3.alcohol_drinked / alco_sum * 100;
                double stu4_per = student4.alcohol_drinked / alco_sum * 100;
                double stu5_per = student5.alcohol_drinked / alco_sum * 100;
                student1.Print();
                Console.WriteLine("Процент выпитого алкоголя студентом 1 - {0}%\n", Math.Round(stu1_per));
                student2.Print();
                Console.WriteLine("Процент выпитого алкоголя студентом 2 - {0}%\n", Math.Round(stu2_per));
                student3.Print();
                Console.WriteLine("Процент выпитого алкоголя студентом 3 - {0}%\n", Math.Round(stu3_per));
                student4.Print();
                Console.WriteLine("Процент выпитого алкоголя студентом 4 - {0}%\n", Math.Round(stu4_per));
                student5.Print();
                Console.WriteLine("Процент выпитого алкоголя студентом 5 - {0}%\n", Math.Round(stu5_per));



            }
        }
    }
}
