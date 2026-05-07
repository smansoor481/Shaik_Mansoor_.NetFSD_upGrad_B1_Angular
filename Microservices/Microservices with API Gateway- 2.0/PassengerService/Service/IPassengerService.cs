using PassengerService.DTOs;

namespace PassengerService.Service
{
    public interface IPassengerService
    {
        Task CreatePassenger(CreatePassengerDto passenger);
        Task UpdatePassenger(int id, CreatePassengerDto passenger);
        Task DeletePassenger(int id);
        Task<ReadPassengerDto> GetPassengerById(int passengerId);
        Task<List<ReadPassengerDto>> GetAllPassenger();
    }
}
