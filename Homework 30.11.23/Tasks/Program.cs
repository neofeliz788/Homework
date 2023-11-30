using System;
using System.Collections.Generic;
using System.IO;

namespace Task
{
    class Program
    {
        public static void DisplayMessage(string message) => Console.WriteLine(message);
        static void Main(string[] args)
        {
            Console.WriteLine("Программа реализует мероприятие");

            List<Student> students = Student.ReadAll("students.txt");
            List<List<Student>> studentsDivided = Student.DivideStudents(students);

            StudentEvent studentEvent = new StudentEvent("Поход в музей", new DateTime(2023, 7, 20), 4);
            studentEvent.ToFile("event.txt");
            studentEvent.SelectionParticipants(studentsDivided, "event.txt");

            foreach (var s in students)
            {
                string fullinfo = $"{s.Surname}#{s.Name}#{s.Group} # {s.EventVisited}\n";
                File.AppendAllText("students.txt", fullinfo);
            }

            Console.WriteLine("\nПрограмма для слежения за интересующим вас событием");

            string[] events = { "Выход нового сериала", "Концерт", "Выход новой музыки", "Открытие нового сопртивного зала", "Продажа новой книги", "Приезд известного шеф-повара" };

            Person Ivan = new Person("Иван", "Концерт");
            Person Maria = new Person("Мария", "Прогулка на велосипеде");
            Person Sergey = new Person("Сергей", "Продажа новой книги");

            Ivan.Reaction += DisplayMessage;
            Maria.Reaction += DisplayMessage;
            Sergey.Reaction += DisplayMessage;

            Ivan.React("Концерт");
            Maria.React("Выход новой музыки");
            Sergey.React("Продажа новой книги");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}