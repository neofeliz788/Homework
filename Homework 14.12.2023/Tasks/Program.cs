using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    { 
        static void PrintTenNumbers()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        static async Task<long> FindFactorial(int value)
        {
            await Task.Delay(8000);

            long factorial = 1;
            for (int i = 1; i <= value; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static long FindSquare(int value)
        {
            return value * value;
        }
        public string Output()
        {
            return "Test-Output";
        }

        public int AddInts(int i1, int i2)
        {
            return i1 + i2;
        }
        static async Task Main(string[] args)
        {
            
            Console.WriteLine("Задание 1:");
            Thread thread1 = new Thread(new ThreadStart(PrintTenNumbers));
            Thread thread2 = new Thread(new ThreadStart(PrintTenNumbers));
            Thread thread3 = new Thread(new ThreadStart(PrintTenNumbers));

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            try
            {
                Console.WriteLine("\nЗадание 2:");
                Console.WriteLine("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    Task<long> factorial = FindFactorial(value);
                    long square = FindSquare(value);
                    long factorialResult = await factorial;

                    Console.WriteLine($"Квадрат числа: {square}");
                    Console.WriteLine($"Факториал числа: {factorialResult}");
                }
                else
                    throw new ArgumentException();
            }
            catch (ArgumentException ee) 
            {
                Console.WriteLine("вы ввели не число"); 
            }

            Console.WriteLine("\nЗадание 3:");
            Type type = typeof(Program);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
     


        }

    }
}