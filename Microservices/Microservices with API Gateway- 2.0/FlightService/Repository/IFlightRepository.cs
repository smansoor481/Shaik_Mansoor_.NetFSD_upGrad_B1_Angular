using FlightService.Entity;

namespace FlightService.Repository
{
    public interface IFlightRepository
    {
        Task CreateFlightAsync(Flight flight);
        Task<Flight> GetFlightByIdAsync(int flightId);
        Task<List<Flight>> GetAllFlightAsync();
    }
}
