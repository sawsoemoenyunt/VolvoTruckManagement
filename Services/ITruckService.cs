using System.Net;
using VolvoTruckManagement.Model;

namespace VolvoTruckManagement.Services
{
    public interface ITruckService
    {
        int GetNextAvailableUniqueTruckNumber();
        List<Truck> GetTrucks();
        Truck? GetTruck(int truckNumber);
        void CreateTruck(Truck truck);
        Truck UpdateTruck(Truck truck);
        bool DeleteTruck(int truckNumber);

    }
}
