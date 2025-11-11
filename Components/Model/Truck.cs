namespace VolvoTruckManagement.Components.Model
{
    public class Truck
    {
        public int TruckNumber { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string VIN { get; set; } = string.Empty;
        public int BuildDate { get; set; } = 0;
        public string Comment { get; set; } = string.Empty;
    }
}
