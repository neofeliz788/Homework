using System;
namespace Buildings
{
    public class Building2
    {
        public int BuildingNumber { get; private set; }
        public string BuildingName { get; private set; }

        public Building2(int number, string name)
        {
            BuildingNumber = number;
            BuildingName = name;
        }

        public void DisplayBuildingInfo()
        {
            Console.WriteLine($"Номер здания: {BuildingNumber}, Здание: {BuildingName}");
        }


    }
}