using System;

namespace Task
{
    public abstract class Tale
    {
        // Свойства
        public string Title { get; }
        public string Author { get; }
        public int YearPublished { get; }
        public string MainCharacter { get; }

        // Конструктор
        public Tale(string title, string author, int yearPublished, string mainCharacter)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
            MainCharacter = mainCharacter;
        }

        // Методы
        public abstract void Name();
        public abstract void Link();
        public abstract void Plot();
        public abstract void MoralLesson();
        public abstract void ShortInfo();
        public abstract void ExtendedInfo();
        
        public abstract void Description();
    }
}
