using System;

class Homework
{
    public static void Main(string[] args)
    {
        Console.Write("Выберите номер задачи, решение которой хотите увидеть(от 1 до 9): ");
        int task_number = Convert.ToInt32(Console.ReadLine());
        if (task_number == 1)
        {
            Console.WriteLine("Задание 1: ");
            Console.WriteLine("Мир Труд Май");
            Console.Write("Мир\n");
            Console.Write("  Труд\n");
            Console.Write("      Май\n\n");
        }
        if (task_number == 2)
        {
            Console.WriteLine("Задание 2 - перестановка значений чисел: ");
            Console.WriteLine("Введите два числа");
            Console.Write("Первое число: ");
            string first_num = Console.ReadLine();
            first_num = first_num.Replace(".", ",");
            double first_number = Convert.ToDouble(first_num);
            Console.Write("Второе число: ");
            string second_num = Console.ReadLine();
            second_num = second_num.Replace(".", ",");
            double second_number = Convert.ToDouble(second_num);
            (first_number, second_number) = (second_number, first_number);
            Console.WriteLine("Теперь первое число равно {0}, а второе: {1}\n", first_number, second_number);

        }
        if (task_number == 3)
        {
            Console.WriteLine("Задание 3 - определение длины и площади: ");
            Console.Write("Введите радиус окружности: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double length = radius * 2 * Math.PI;
            double square = radius * radius * Math.PI;
            Console.WriteLine("Длина окружности равна {0}, площадь круга равна {1}\n", length, square);
        }

        if (task_number == 4)
        {
            Console.WriteLine("Задание 4 - определение косинуса угла: ");
            Console.Write("Введите угол в градусах: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            double radian = angle * Math.PI / 180;
            if (angle != 90)
            {
                Console.WriteLine("Косинус данного угла равен {0}", Math.Cos(radian));

            }
            else
            {
                Console.WriteLine("Косинус данного угла равен {0}", Math.Round(Math.Cos(radian)));
            }
        }
        if (task_number == 5)
        {
            Console.WriteLine("Задание 5 - Квадратное уравнение ax^2 + bx + c: ");
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
            }
            if (discriminant == 0)
            {
                Console.WriteLine("Единственный корень уравнения: {0}", first_answer);
            }
            if (discriminant > 0)
            {
                Console.WriteLine("Два корня уравнения: {0} , {1}", first_answer, second_answer);
            }

        }
        if (task_number == 6)
        {
            Console.WriteLine("Задание 6 - обмен значения трех переменных: ");
            Console.Write("Введите первое значение : ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе значение: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье значение: ");
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("нажмите 1, чтобы выбрать схему а(число становится равным следующему), или 2, чтобы выбрать схему b(число становится равным предыдущему): ");
            double indicator = Convert.ToInt32(Console.ReadLine());
            if (indicator == 1)
            {
                (a1, b1, c1) = (b1, c1, a1);
            }
            if (indicator == 2)
            {
                (a1, b1, c1) = (c1, a1, b1);
            }
            Console.WriteLine("Теперь первое число равно {0}, второе число равно {1} ,третье равно {2}", a1, b1, c1);

        }
        if (task_number == 7)
        {
            Console.WriteLine("Задание 7 - вывод четырёх случайных чисел: ");
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int random_number = random.Next();
                Console.WriteLine(random_number);
            }

        }
        if (task_number == 8)
        {
            Console.WriteLine("Задание 8: ");
            Console.Write("Введите трёхзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int last_digit = number % 10;
            number = number / 10;
            number = number + (last_digit*100);
            Console.WriteLine("Полученное число равно {0}", number);

        }
        if (task_number == 9)
        {
            Console.WriteLine("Задание 9 - стоимость покупки конфет, печенья и яблок: ");
            Console.Write("Введите стоимость 1 кг конфет и количество килограмм , которые вы хотите купить, через пробел: ");
            string[] candies = Console.ReadLine().Split(' ');
            int candy_price = int.Parse(candies[0]);
            int candy_quantity = int.Parse(candies[1]);
            Console.Write("Введите стоимость 1 кг печенья и количество килограмм , которые вы хотите купить, через пробел: ");
            string[] cookies = Console.ReadLine().Split(' ');
            int cookie_price = int.Parse(cookies[0]);
            int cookie_quantity = int.Parse(cookies[1]);
            Console.Write("Введите стоимость 1 кг яблок и количество килограмм , которые вы хотите купить, через пробел: ");
            string[] apples = Console.ReadLine().Split(' ');
            int apple_price = int.Parse(apples[0]);
            int apple_quantity = int.Parse(apples[1]);
            int whole_purchase = candy_price*candy_quantity + cookie_price*cookie_quantity + apple_price*apple_quantity;
            Console.WriteLine("Вся ваша покупка обойдется вам в {0} рублей", whole_purchase);
        }
        if (task_number > 9 || task_number < 1)
        {
            Console.WriteLine("Такого номера задачи нет в списке");
        }
    }
}
