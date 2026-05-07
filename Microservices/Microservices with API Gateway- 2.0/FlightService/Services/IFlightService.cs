using FlightService.DTOs;

namespace FlightService.Services
{
    public interface IFlightService
    {
        Task CreateFlight(CreateFlightDto flight);
        Task<ReadFlightDto> GetFlightById(int flightId);
        Task<List<ReadFlightDto>> GetAllFlights();
    }
}
