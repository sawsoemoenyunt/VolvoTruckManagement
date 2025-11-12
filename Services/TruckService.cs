using VolvoTruckManagement.Model;

namespace VolvoTruckManagement.Services
{
    public class TruckService : ITruckService
    {
        private readonly List<Truck> _trucks = new();

        public int GetNextAvailableUniqueTruckNumber() {
            // Get all used numbers (1–99)
            var usedNumbers = _trucks.Select(t => t.TruckNumber).ToList();

            // Find the first available number from 1 to 99
            int nextNumber = Enumerable.Range(1, 99)
                .FirstOrDefault(n => !usedNumbers.Contains(n));

            // Safety check (in case all 99 are used)
            if (nextNumber == 0)
                throw new InvalidOperationException("Maximum truck limit (99) reached.");
            
            return nextNumber;
        }

        public void CreateTruck(Truck truck)
        {
            Truck _truck = new Truck();
            _truck.TruckNumber = truck.TruckNumber;
            _truck.Brand = truck.Brand;
            _truck.VIN = truck.VIN;
            _truck.BuildDate = truck.BuildDate;
            _truck.Comment = truck.Comment;
            _trucks.Add(_truck);
        }

        public bool DeleteTruck(int truckNumber)
        {
            int removedCount = _trucks.RemoveAll(t => t.TruckNumber == truckNumber);
            return removedCount > 0;
        }

        public Truck? GetTruck(int truckNumber)
        {
            return _trucks.FirstOrDefault(t => t.TruckNumber == truckNumber);
        }


        public List<Truck> GetTrucks()
        {
            return _trucks;
        }

        public Truck UpdateTruck(Truck truck)
        {
            var existingTruck = GetTruck(truck.TruckNumber);

            if (existingTruck == null)
                throw new KeyNotFoundException($"Truck with number {truck.TruckNumber} not found.");

            existingTruck.Brand = truck.Brand;
            existingTruck.VIN = truck.VIN;
            existingTruck.BuildDate = truck.BuildDate;
            existingTruck.Comment = truck.Comment;

            return existingTruck;
        }

    }
}
