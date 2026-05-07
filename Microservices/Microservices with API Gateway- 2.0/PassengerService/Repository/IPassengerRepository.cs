using PassengerService.Entity;

namespace PassengerService.Repository
{
    public interface IPassengerRepository
    {
        Task CreatePassengerAsync(Passenger passenger);
        Task UpdatePassengerAsync(int id, Passenger passenger);
        Task DeletePassengerAsync(int id);
        Task<Passenger> GetPassengerByIdAsync(int passengerId);
        Task<List<Passenger>> GetAllPassengersAsync();
    }
}
