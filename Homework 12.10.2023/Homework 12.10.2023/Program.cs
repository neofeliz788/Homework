using System.Collections.Generic;
using System;
using System.IO;

namespace Homework_12._10._2023
{
    internal class Program
    {
        static int[,] MatrixMultiply(int[,] Matrix1, int[,] Matrix2)
        {
            int[,] FinalMatrix = new int[2, 2];

            for (int i = 0; i < Matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix2.GetLength(0); j++)
                {
                    FinalMatrix[i, j] = Matrix1[i, 0] * Matrix2[0, j] + Matrix1[i, 1] * Matrix2[1, j];
                }
            }

            return FinalMatrix;
        }


        static LinkedList<int> MatrixMultiply(LinkedList<int> Matrix1, LinkedList<int> Matrix2)
        {
            LinkedList<int> FinalMatrix = new LinkedList<int>();

            FinalMatrix.AddLast(Matrix1.First.Value * Matrix2.First.Value + Matrix1.First.Next.Value * Matrix2.Last.Previous.Value);
            FinalMatrix.AddLast(Matrix1.First.Value * Matrix2.First.Next.Value + Matrix1.First.Next.Value * Matrix2.Last.Value);
            FinalMatrix.AddLast(Matrix1.Last.Previous.Value * Matrix2.First.Value + Matrix1.Last.Value * Matrix2.Last.Previous.Value);
            FinalMatrix.AddLast(Matrix1.Last.Previous.Value * Matrix2.First.Next.Value + Matrix1.Last.Value * Matrix2.Last.Value);

            return FinalMatrix;
        }


        static void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(String.Format("{0, 5}", matrix[i, j]));
                }

                Console.WriteLine();
            }
        }


        static void ShowMatrix(LinkedList<int> matrix)
        {
            int count = 0;

            foreach (int number in matrix)
            {
                Console.Write(String.Format("{0, 5}", number));
                count++;

                if (count % 2 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6.1: ");
            string text = File.ReadAllText("C://homework.txt");
            char[] letters = new char[text.Length];

            for (int i = 0; i < text.Length - 1; i++)
            {
                letters[i] = text[i];
            }

            int vowels = 0;
            int consonants = 0;
            string allConsonantsRU = "бвгджзйклмнпрстфхцчшщ";
            string allVowelsRU = "аеёиоуэыюя";
            string allConsonantsUS = "bcdfghjklmnpqrstvwxz";
            string allVowelsUS = "aeiouy";
            foreach (char letter in letters)
            {
                char newLetter = Char.ToLower(letter);
                if (allConsonantsRU.ToLower().Contains(Convert.ToString(newLetter)) || allConsonantsUS.ToLower().Contains(Convert.ToString(newLetter)))
                {
                    consonants++;
                }
                else if (allVowelsRU.ToLower().Contains(Convert.ToString(newLetter)) || allVowelsUS.ToLower().Contains(Convert.ToString(newLetter)))
                {
                    vowels++;
                }
            }
            Console.WriteLine($"Количество гласных букв  - {vowels}\nКоличество согласных букв - {consonants}");

            try
            {
                Console.WriteLine("Задание 6.2: ");
                Console.WriteLine(" матрица вида\n{ 1 2 }\n{ 3 4 }");
                int[,] Matrix1 = new int[2, 2];
                int[,] Matrix2 = new int[2, 2];
                int[,] FinalMatrix;
                int k = 1;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine($"Введите элемент номер {k} обеих матриц: ");

                        Matrix1[i, j] = int.Parse(Console.ReadLine());
                        Matrix2[i, j] = int.Parse(Console.ReadLine());
                        k++;
                    }

                }

                FinalMatrix = MatrixMultiply(Matrix1, Matrix2);
                ShowMatrix(Matrix1);
                Console.WriteLine("");
                ShowMatrix(Matrix2);
                Console.WriteLine("");
                ShowMatrix(FinalMatrix);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                Console.WriteLine("Задание 6.2, но с коллекциями: ");
                LinkedList<int> Matrix11 = new LinkedList<int>();
                LinkedList<int> Matrix22 = new LinkedList<int>();
                LinkedList<int> FinalMatrix1 = new LinkedList<int>();

                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine($"Введите элемент номер {i} обеих матриц: ");                 
                    int n = int.Parse(Console.ReadLine());
                    int k = int.Parse(Console.ReadLine());
                    Matrix11.AddLast(n);
                    Matrix22.AddLast(k);
                        
                }

                FinalMatrix1 = MatrixMultiply(Matrix11, Matrix22);

                ShowMatrix(Matrix11);
                Console.WriteLine("");
                ShowMatrix(Matrix22);
                Console.WriteLine("");
                ShowMatrix(FinalMatrix1);
            }
            catch(Exception ee) 
            {
                Console.WriteLine(ee.ToString());
            }
        }
    }
}
