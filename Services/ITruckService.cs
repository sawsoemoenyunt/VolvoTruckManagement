using System.Net;
using VolvoTruckManagement.Model;

namespace VolvoTruckManagement.Services
{
    public interface ITruckService
    {
        Task<ServiceResponse<List<Truck>>> GetTrucksAsync();
        Task<ServiceResponse<Truck>> GetTruckAsync(int truckNumber);
        Task<ServiceResponse<Truck>> CreateTruck(Truck truck);
        Task<ServiceResponse<Truck>> UpdateTruck(Truck product);
        Task<ServiceResponse<bool>> DeleteTruck(int truckNumber);
    }
}
