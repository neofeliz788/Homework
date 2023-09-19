using System;

namespace Lab_work2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1:");
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, {0}", name);

            Console.WriteLine("Упражнение 2.2: ");
            Console.Write("Введите делимое число: ");
            double first_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число делитель: ");
            double second_number = Convert.ToInt32(Console.ReadLine());
            double result = first_number/second_number;
            if (second_number == 0)
            {
                Console.WriteLine("Ошибка, нельзя делить на ноль");
            }
            Console.WriteLine("Ответ: {0}", result);

            Console.WriteLine("Домашняя работа 2.1: ");
            Console.Write("Введите букву: ");
            char letter = Console.ReadKey().KeyChar;
            char next_letter = (char)(((int)letter) + 1);
            if (letter == 'z' || letter == 'я')
            {
                Console.WriteLine("\nОшибка,последняя буква алфавита");
            }
            else
            {
                Console.WriteLine("\nследующая буква - {0}", next_letter);
            }


            Console.WriteLine("Домашнее задание 2.2 - Квадратное уравнение ax^2 + bx + c = 0: ");
            Console.Write("Введите коэффициент a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double discriminant = b*b - 4*a*c;
            double first_answer = (-1*b - Math.Sqrt(discriminant))/(2*a);
            double second_answer = (-1*b + Math.Sqrt(discriminant))/(2*a);
            if (discriminant < 0)
            {
                Console.WriteLine("Ошибка, дискриминант меньше нуля");
                System.Environment.Exit(0);
            }
            if (discriminant == 0)
            {
                Console.WriteLine("Единственный корень уравнения: {0}", first_answer);
            }
            else

            {
                Console.WriteLine("Два корня уравнения: {0} , {1}", first_answer, second_answer);
            }


        }
    }
}
