using System.Net;
using VolvoTruckManagement.Model;

namespace VolvoTruckManagement.Services
{
    /// <summary>
    /// Defines the contract for managing trucks, including creation, retrieval, updates, and deletions.
    /// </summary>
    public interface ITruckService
    {
        /// <summary>
        /// Gets the next available truck number between 1 and 99.
        /// Reuses any deleted truck numbers if available.
        /// </summary>
        /// <returns>An integer representing the next unused truck number.</returns>
        int GetNextAvailableUniqueTruckNumber();

        /// <summary>
        /// Retrieves the full list of trucks currently stored.
        /// </summary>
        /// <returns>A list of <see cref="Truck"/> objects.</returns>
        List<Truck> GetTrucks();

        /// <summary>
        /// Retrieves a specific truck by its assigned number.
        /// </summary>
        /// <param name="truckNumber">Unique truck number.</param>
        /// <returns>The matching <see cref="Truck"/> or null if not found.</returns>
        Truck? GetTruck(int truckNumber);

        /// <summary>
        /// Adds a new truck to the collection.
        /// </summary>
        /// <param name="truck">Truck object to be created.</param>
        void CreateTruck(Truck truck);

        /// <summary>
        /// Updates an existing truck's details (e.g., brand, VIN, comment, build year).
        /// </summary>
        /// <param name="truck">Truck object containing updated values.</param>
        /// <returns>The updated <see cref="Truck"/> object.</returns>
        Truck UpdateTruck(Truck truck);

        /// <summary>
        /// Deletes a truck from the collection using its unique truck number.
        /// </summary>
        /// <param name="truckNumber">Truck number to remove.</param>
        /// <returns>True if the truck was successfully deleted, otherwise false.</returns>
        bool DeleteTruck(int truckNumber);
    }
}
