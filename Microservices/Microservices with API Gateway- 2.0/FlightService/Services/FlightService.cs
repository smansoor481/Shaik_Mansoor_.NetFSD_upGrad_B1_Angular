using AutoMapper;
using FlightService.DTOs;
using FlightService.Entity;
using FlightService.Repository;

namespace FlightService.Services
{
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository repository;
        private readonly IMapper mapper;

        public FlightService(IFlightRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task CreateFlight(CreateFlightDto flight)
        {
            var flights = mapper.Map<Flight>(flight);
            await repository.CreateFlightAsync(flights);
        }

        public async Task<List<ReadFlightDto>> GetAllFlights()
        {
            var flights = await repository.GetAllFlightAsync();
            var flightDtos = mapper.Map<List<ReadFlightDto>>(flights);
            return flightDtos;
        }

        public async Task<ReadFlightDto> GetFlightById(int flightId)
        {
            var flight = await repository.GetFlightByIdAsync(flightId);
            return mapper.Map<ReadFlightDto>(flight);
        }
    }
}
