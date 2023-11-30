using System;
using System.Collections.Generic;
namespace Buildings
{
    public class Creator2
    {
        private static Dictionary<int, Building2> buildingTable = new Dictionary<int, Building2>();

        private Creator2() { } // Закрытый конструктор

        public static Building2 CreateBuilding(int number, string name)
        {
            Building2 building = new Building2(number, name);
            buildingTable.Add(number, building);
            return building;
        }

        public static Building2 CreateBuilding(int number)
        {

            return CreateBuilding(number, $"здание номер {number}");
        }

        public static Building2 GetBuilding(int number)
        {
            return buildingTable.ContainsKey(number) ? buildingTable[number] : null;
        }

        public static void RemoveBuilding(int number)
        {
            if (buildingTable.ContainsKey(number))
            {
                buildingTable.Remove(number);
                Console.WriteLine($"Здание номер {number} не найдено.");
            }
            else
            {
                Console.WriteLine($"Здание номер {number} не найдено");
            }
        }
    }
}