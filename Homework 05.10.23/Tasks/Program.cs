using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Xml.Linq;

namespace Tasks
{
    internal class Program
    {
        enum CursingLevel
        {
            Low,
            Medium,
            High
        }
        struct DED
        {
            public string Name;
            public CursingLevel Cursing;
            public string[] Words;
            public int quantityOfBruises;

            public int ComparePhrases(params string[] cursingWords)
            {
                
                int quantityOfBruises = 0;
                foreach (string word in Words)
                {
                    foreach (string badWord in cursingWords)
                    {
                        if (badWord == word)
                        {
                            quantityOfBruises+=1;
                        }
                    }
                }
               
                return quantityOfBruises;
            }
           
        }
            public static void ArrayInfo(ref double sum, ref double multiplication, out double average, params double[] array)
            {
                average = sum = 0;
                multiplication = 1;
                foreach (double number in array)
                {
                    sum+= number;
                    multiplication*= number;
                }
                average = sum / array.Length;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Задание 1: ");
                Random random = new Random();
                int[] array = new int[20];
                for (int i = 0; i < 20; i++)
                {
                    array[i] = random.Next();
                }
                foreach (int number in array)
                {
                    Console.Write($"{number}\n");
                }
                try
                {
                    int i = 0;
                    Console.WriteLine("\nВведите любое число из этого массива:");
                    if(int.TryParse(Console.ReadLine(), out int firstNumber)) 
                    {
                        Console.WriteLine("Введите другое число из этого массива:");
                        if(int.TryParse(Console.ReadLine(),out int secondNumber))
                        {
                            foreach (int number in array)
                            {
                                if (number == firstNumber)
                                {
                                    i+=1;
                                    foreach (int number2 in array)
                                    {
                                        if (number2 == secondNumber)
                                        {
                                            i+=1;
                                            (array[Array.IndexOf(array, firstNumber)], array[Array.IndexOf(array, secondNumber)]) = (array[Array.IndexOf(array, secondNumber)], array[Array.IndexOf(array, firstNumber)]);
                                        }
                                       

                                    }
                                }


                            }
                        }
                        
                    }                  
                    if (i < 2)
                    {
                        throw new Exception("такого или таких значений нет в массиве");
                    }
                }
                
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    Console.WriteLine("Получившийся массив: ");
                    foreach (int number in array)
                    {
                        Console.Write($"{number}\n");
                    }
                }
                try
                {
                    Console.WriteLine("Задание 2: ");
                    Console.Write("Введите длину массива: ");
                    if(int.TryParse(Console.ReadLine(),out int arrLen))
                    {
                        double[] Array2 = new double[arrLen];
                        if (arrLen == 0)
                        {
                            throw new ArgumentException("Массив пустой");
                        }
                        for (int i = 0; i < arrLen; i++)
                            {
                            Console.Write($"Введите элемент массива номер {i+1}: ");
                            double value = double.Parse(Console.ReadLine());
                            Array2[i] = value;
                        }
                        double multiplication = 1;
                        double average;
                        double sum = 0;
                        ArrayInfo(ref sum, ref multiplication, out average, Array2);

                        Console.WriteLine($"Сумма элементов массива: {sum}");
                        Console.WriteLine($"Произведение массива: {multiplication}");
                        Console.WriteLine($"Среднее арифметическое в массиве с учетом округления: {Math.Round(average)}");
                        Console.WriteLine($"Среднее арифметическое в массиве без учета округления: {average}");
                    }
                    else 
                    {
                    throw new FormatException("Вы ввели не число");
                    }
                    
                }
                catch (FormatException ee)
                {
                    Console.WriteLine(ee.ToString());
                }   
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                try
                {
                    Console.WriteLine("Задание 3: ");
                    Console.Write("Введите целое число от 0 до 9, либо введите 'exit' или 'закрыть', чтобы выйти из консоли: ");
                    string input = Console.ReadLine();
                    if (input == "exit" || input == "закрыть")
                    {
                        Console.WriteLine("вы выходите из консоли");
                        System.Environment.Exit(0);


                    }
                    if (int.TryParse(input, out int value2))
                    {
                        if (value2 < 0 || value2 > 9)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Вы не ввели целое число от 0 до 9");
                            Thread.Sleep(3000);
                            Console.ResetColor();
                            Console.WriteLine("Цвет консоли сменился обратно                                                                                          .");
                        }
                        else
                        {
                            if (value2 == 0)
                            {
                                Console.WriteLine("###\n# #\n# #\n###");
                            }
                            if (value2 == 1)
                            {
                                Console.WriteLine("  #\n ##\n# #\n  #");
                            }
                            if (value2 == 2)
                            {
                                Console.WriteLine("####\n   #\n####\n#\n####");
                            }
                            if (value2 == 3)
                            {
                                Console.WriteLine("###\n  #\n ##\n  #\n###");
                            }
                            if (value2 == 4)
                            {
                                Console.WriteLine("# #\n###\n  #\n  #");
                            }
                            if (value2 == 5)
                            {
                                Console.WriteLine("###\n#\n###\n  #\n###");
                            }
                            if (value2 == 6)
                            {
                                Console.WriteLine("###\n#\n###\n# #\n###");
                            }
                            if (value2 == 7)
                            {
                                Console.WriteLine("###\n  #\n  #\n  #");
                            }
                            if (value2 == 8)
                            {
                                Console.WriteLine("###\n# #\n###\n# #\n###");
                            }
                            if (value2 == 9)
                            {
                                Console.WriteLine("###\n# #\n###\n  #\n  #");
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Вы не ввели подходящее значение");
                    }
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.ToString());
                }
                Console.WriteLine("Задание 4: ");
                string[] cursingWords = { "засранец", "хитрожопый", "шлюха", "хероед", "дристун",  "изговнять", "гнида",  "ссаная псина", "спидораковый", "гандон","чувырло"};

                string[] dedWords1 = { "засранец", "хероед", "шлюха", "дристожуй", "ужас",};
                string[] dedWords2 = { "ужас", "позор" };
                string[] dedWords3 = {  "дебил",  "оболтус", "долбан" , "дристун" };
                string[] dedWords4 = { "глиномес", "изговнять", "гнида", "ссаная псина", "спидораковый", "срать", };
                string[] dedWords5 = { "кретиноид", "курвырь","балбес", "дурак" , "гандон", "чувырло"};

                DED ded1 = new DED();
                ded1.Name = "Евдрист";
                ded1.Cursing = CursingLevel.High;
                ded1.Words = dedWords1;
                ded1.quantityOfBruises = ded1.ComparePhrases(cursingWords);

                DED ded2 = new DED();
                ded2.Name = "Святослав";
                ded2.Cursing = CursingLevel.Low;
                ded2.Words = dedWords2;
                ded2.quantityOfBruises = ded2.ComparePhrases(cursingWords);

                DED ded3 = new DED();
                ded3.Name = "Ярополк";
                ded3.Cursing = CursingLevel.Medium;
                ded3.Words = dedWords3;
                ded3.quantityOfBruises = ded3.ComparePhrases(cursingWords);

                DED ded4 = new DED();
                ded4.Name = "Добрыня";
                ded4.Cursing = CursingLevel.High;
                ded4.Words = dedWords4;
                ded4.quantityOfBruises = ded4.ComparePhrases(cursingWords);

                DED ded5 = new DED();
                ded5.Name = "Святозар";
                ded5.Cursing = CursingLevel.Medium;
                ded5.Words = dedWords5;
                ded5.quantityOfBruises = ded5.ComparePhrases(cursingWords);


                Console.WriteLine($"количество фингалов деда по имени {ded1.Name} :  {ded1.quantityOfBruises} ");
                Console.WriteLine($"количество фингалов деда по имени {ded2.Name} :  {ded2.quantityOfBruises} ");
                Console.WriteLine($"количество фингалов деда по имени {ded3.Name} :  {ded3.quantityOfBruises} ");
                Console.WriteLine($"количество фингалов деда по имени {ded4.Name} :  {ded4.quantityOfBruises} ");
                Console.WriteLine($"количество фингалов деда по имени {ded5.Name} :  {ded5.quantityOfBruises} ");
            }





        
    }
}

  


