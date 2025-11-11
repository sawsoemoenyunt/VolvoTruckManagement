using VolvoTruckManagement.Model;

namespace VolvoTruckManagement.Services
{
    public class TruckService : ITruckService
    {
        public Task<ServiceResponse<Truck>> CreateTruck(Truck truck)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<bool>> DeleteTruck(int truckNumber)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Truck>> GetTruckAsync(int truckNumber)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<Truck>>> GetTrucksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Truck>> UpdateTruck(Truck product)
        {
            throw new NotImplementedException();
        }
    }
}
