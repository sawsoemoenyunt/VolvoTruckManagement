using VolvoTruckManagement.Model;

namespace VolvoTruckManagement.Services
{
    /// <summary>
    /// Provides in-memory storage and management of trucks.
    /// Handles creation, retrieval, updating, deletion, and unique truck number assignment.
    /// </summary>
    public class TruckService : ITruckService
    {
        // In-memory collection to store all truck records
        private readonly List<Truck> _trucks = new();

        /// <summary>
        /// Finds the next available truck number between 1 and 99.
        /// Reuses numbers from deleted trucks.
        /// </summary>
        /// <returns>An integer representing the next available truck number.</returns>
        /// <exception cref="InvalidOperationException">Thrown if all 99 numbers are already used.</exception>
        public int GetNextAvailableUniqueTruckNumber()
        {
            // Collect all currently used truck numbers
            var usedNumbers = _trucks.Select(t => t.TruckNumber).ToList();

            // Find the first number between 1 and 99 that is not already used
            int nextNumber = Enumerable.Range(1, 99)
                .FirstOrDefault(n => !usedNumbers.Contains(n));

            // Safety check in case all 99 truck numbers are taken
            if (nextNumber == 0)
                throw new InvalidOperationException("Maximum truck limit (99) reached.");

            return nextNumber;
        }

        /// <summary>
        /// Adds a new truck to the in-memory list.
        /// </summary>
        /// <param name="truck">The truck object to be added.</param>
        public void CreateTruck(Truck truck)
        {
            // Create a new instance to avoid external reference modification
            Truck _truck = new Truck
            {
                TruckNumber = truck.TruckNumber,
                Brand = truck.Brand,
                VIN = truck.VIN,
                BuildDate = truck.BuildDate,
                Comment = truck.Comment
            };

            _trucks.Add(_truck);
        }

        /// <summary>
        /// Deletes a truck from the list by its unique truck number.
        /// </summary>
        /// <param name="truckNumber">The truck number to delete.</param>
        /// <returns>True if a truck was deleted; otherwise, false.</returns>
        public bool DeleteTruck(int truckNumber)
        {
            int removedCount = _trucks.RemoveAll(t => t.TruckNumber == truckNumber);
            return removedCount > 0;
        }

        /// <summary>
        /// Retrieves a single truck by its number.
        /// </summary>
        /// <param name="truckNumber">Truck number to search for.</param>
        /// <returns>The matching Truck object or null if not found.</returns>
        public Truck? GetTruck(int truckNumber)
        {
            return _trucks.FirstOrDefault(t => t.TruckNumber == truckNumber);
        }

        /// <summary>
        /// Retrieves all trucks currently stored in memory.
        /// </summary>
        /// <returns>A list of all Truck objects.</returns>
        public List<Truck> GetTrucks()
        {
            return _trucks;
        }

        /// <summary>
        /// Updates an existing truck’s information.
        /// </summary>
        /// <param name="truck">The updated truck object.</param>
        /// <returns>The updated Truck object.</returns>
        /// <exception cref="KeyNotFoundException">Thrown when a truck with the specified number is not found.</exception>
        public Truck UpdateTruck(Truck truck)
        {
            // Find existing truck by number
            var existingTruck = GetTruck(truck.TruckNumber);

            if (existingTruck == null)
                throw new KeyNotFoundException($"Truck with number {truck.TruckNumber} not found.");

            // Update relevant properties
            existingTruck.Brand = truck.Brand;
            existingTruck.VIN = truck.VIN;
            existingTruck.BuildDate = truck.BuildDate;
            existingTruck.Comment = truck.Comment;

            return existingTruck;
        }
    }
}
