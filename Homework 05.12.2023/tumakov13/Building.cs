namespace Tumakov13
{
    [DeveloperInfo("Динар", "-")]
    internal class Building
    {
        public int BuildingNumber { get; set; }
        public int Height { get; set; }
        public int Floors { get; set; }
        public int Apartments { get; set; }
        public int Entrances { get; set; }

        public double CalculateFloorHeight()

        {
            return (double)Height / Floors;
        }

        public double CalculateApartmentsPerEntrance()
        {
            return (double)Apartments / Entrances;
        }

        public double CalculateApartmentsPerFloor()
        {
            return (double)Apartments / Floors;
        }
    }
}