using System;

public class Building
{
    public int BuildingNumber { get; private set; }
    public string BuildingName { get; private set; }

    public Building(int number, string name)
    {
        BuildingNumber = number;
        BuildingName = name;
    }

    public void DisplayBuildingInfo()
    {
        Console.WriteLine($"Номер здания: {BuildingNumber}, Здание: {BuildingName}");
    }


}