using System;

namespace Task
{
    class Person
    {
        public delegate void EventHandler(string eName);
        public event EventHandler Reaction;

        string name;
        string hobby;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Hobby
        {
            get
            {
                return hobby;
            }
        }
        public Person(string name, string hobby)
        {
            this.name = name;
            this.hobby = hobby;
        }
        public void React(string eName)
        {
            string[] hobbies = { hobby };
            if (Array.IndexOf(hobbies, eName) != -1)
            {
                Reaction.Invoke(($"\n{name} радуется {eName}"));
            }
        }
    }
}