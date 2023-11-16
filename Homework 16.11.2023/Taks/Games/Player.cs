using System;

namespace Task
{
    public enum Countries
    {
        Россия,
        Франция,
        Китай,
        Казахстан
    }
    class Player
    {
        string name;
        Countries country;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Countries Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public Player(string name, Countries country)
        {
            this.name = name;
            this.country = country;
        }
        public void Print()
        {
            Console.WriteLine($"\nИнформация о игроке\nИмя: {Name}\nСтрана: {country}");
        }
    }
}
