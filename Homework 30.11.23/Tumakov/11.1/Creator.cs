using System;
using System.Collections.Generic;

public class Creator
{
    private static Dictionary<int, Building> buildingTable = new Dictionary<int, Building>();

    private Creator() { } // Закрытый конструктор

    public static Building CreateBuilding(int number, string name)
    {
        Building building = new Building(number, name);
        buildingTable.Add(number, building);
        return building;
    }

    public static Building CreateBuilding(int number)
    {

        return CreateBuilding(number, $"здание номер {number}");
    }

    public static Building GetBuilding(int number)
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