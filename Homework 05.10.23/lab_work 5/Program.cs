using System;

namespace lab_work_5
{
    internal class Program
    {
        public static int BiggerNumber(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }

        public static void Change(ref double a, ref double b)
        {
            (a, b) = (b, a);
        }
        public static void Change(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
        public static void Change(ref string a, ref string b)
        {
            (a, b) = (b, a);
        }

        public static bool Factorial(int n, out int result)
        {
            result = 1;
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    checked
                    {
                        result *= i;
                    }
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Произошло переполнение");
                return false;
            }
            Console.WriteLine(result);
            return true;
            
        }
        public static int Factorial(int n)
        {

            if (n == 1) return 1;
            try
            {
                checked
                {
                    return n * Factorial(n - 1);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Произошло переполнение");
            }
           
            return 0;
        }
        public static int NOD(int number_1, int number_2)
        {
            while (number_1 != 0 && number_2 != 0)
            {
                int a = number_1 > number_2 ? number_1 = number_1 % number_2 : number_2 = number_2 % number_1;
            }
            return number_1 + number_2;
        }
        public static int NOD(int a, int b, int c)
        {
            int Nod = Math.Min(a, Math.Min(b, c));
            for (; Nod>1; Nod--)
            {
                if (a % Nod == 0 && b % Nod == 0 && c % Nod == 0)
                    break;
            }
            return Nod;
        }


        public static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Упражнение 5.1");
                Console.Write("Введите первое целое число: ");
                if(int.TryParse(Console.ReadLine(),out int number1))
                {
                    Console.Write("Введите второе целое число: ");
                    if(int.TryParse(Console.ReadLine(), out int number2))
                    {
                        Console.WriteLine($"Наибольшее из двух чисел: {BiggerNumber(number1, number2)}");
                    }
                    else
                    {
                        throw new FormatException("Вы не ввели число типа int");
                    }
                }
                else
                {
                    throw new FormatException("Вы не ввели число типа int");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Слишком большое число");
            }

            Console.WriteLine("Упражнение 5.2");
            string value1 = "Hello";
            string value2 = "Bye";
            Change(ref value1, ref value2);
            Console.WriteLine($"Теперь первое значение равно {value1} , а второе: {value2}");
            double value3 = 34.7;
            double value4 = 45.5;
            Change(ref value3, ref value4);
            Console.WriteLine($"Теперь первое значение равно {value3} , а второе: {value4}");
            int value5 = 34;
            int value6 = 45;
            Change(ref value5, ref value6);
            Console.WriteLine($"Теперь первое значение равно {value5} , а второе {value6}");
            try
            {
                Console.WriteLine("Упражнение 5.3");
                int result;
                Console.Write("Введите число, факториал которого хотите найти: ");
                if (int.TryParse(Console.ReadLine(), out int factorialNumber))
                {
                    Console.WriteLine(Factorial(factorialNumber,out result));
                }
                else
                {
                    throw new FormatException("Вы не ввели число типа int");
                }
            }
            
             catch(FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Console.WriteLine("Упражнение 5.4");
                Console.Write("Введите число, факториал которого хотите найти: ");
                if (int.TryParse(Console.ReadLine(), out int factorialNumber2))
                {
                    Console.WriteLine($"факториал данного числа: {Factorial(factorialNumber2)}");
                }
                else
                {
                    throw new FormatException("Вы не ввели число типа int");
                }
            }
            catch(FormatException ee)
            {
                Console.WriteLine(ee.ToString());
            }
           

            int a = 15;
            int b = 21;
            int c = 28;
            Console.Write($"Домашнее задание 5.1: НОД чисел {a} и {b} - {NOD(a, b)}\n");
            Console.Write($"Домашнее задание 5.1: НОД чисел {a} и {b} и {c} - {NOD(a, b, c)}\n");


            int n = 5;
            Console.Write($"Домашнее задание 5.2: член №{n} в ряде Фибоначчи -  {Fibonachi(n)}\n");


        }
    }
}

