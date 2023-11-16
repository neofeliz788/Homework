using System;

namespace Homework_16._11._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICipher aCipher = new ACipher();
            ICipher bCipher = new BCipher();

            string originalText = "моеее тп отменено игра проебана давно";


            string encodedA = aCipher.Encode(originalText);
            string decodedA = aCipher.Decode(encodedA);

            Console.WriteLine("ACipher:");
            Console.WriteLine("Изначально: " + originalText);
            Console.WriteLine("Шифровка: " + encodedA);
            Console.WriteLine("Расшифровка: " + decodedA);

            Console.WriteLine();


            string encodedB = bCipher.Encode(originalText);
            string decodedB = bCipher.Decode(encodedB);

            Console.WriteLine("BCipher:");
            Console.WriteLine("Изначально: " + originalText);
            Console.WriteLine("Шифровка: " + encodedB);
            Console.WriteLine("Расшифровка: " + decodedB);

            Console.WriteLine();

            Circle circle = new Circle("Yellow", true, 4);
            circle.Display();
            Console.WriteLine($"Area: {circle.CalculateArea()}");
            Console.WriteLine();
            circle.ChangeColor("Red");
            circle.Display();

            Rectangle rectangle = new Rectangle("Red", true, 5, 6);
            rectangle.Display();
            rectangle.MoveVertical(30);
            Console.WriteLine($"Area: {rectangle.CalculateArea()}");

        }
    }
}
