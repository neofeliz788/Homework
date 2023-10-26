using System;
using System.Collections.Generic;


namespace Homework_26._10._23
{
    class Employee
    {
        public string Name { get; }
        public string Position { get; }
        private List<Employee> subordinates;

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
            subordinates = new List<Employee>();
        }

        public void AddSubordinate(Employee subordinate)
        {
            subordinates.Add(subordinate);
        }

        public void DisplayHierarchy(int level = 0)
        {
            string indentation = new string(' ', level * 4);
            Console.WriteLine($"{indentation}{Name} - {Position}");

            foreach (var subordinate in subordinates)
            {
                subordinate.DisplayHierarchy(level + 1);
            }
        }
    }
}
