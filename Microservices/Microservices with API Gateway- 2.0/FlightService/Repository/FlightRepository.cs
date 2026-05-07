using FlightService.Entity;
using Microsoft.EntityFrameworkCore;
using PassengerService.Database;

namespace FlightService.Repository
{
    public class FlightRepository : IFlightRepository
    {
        private readonly FlightDbContext flightDb;

        public FlightRepository(FlightDbContext flightDb)
        {
            this.flightDb = flightDb;
        }

        public async Task CreateFlightAsync(Flight flight)
        {
            flightDb.Flight.Add(flight);
            await flightDb.SaveChangesAsync();
        }

        public async Task<List<Flight>> GetAllFlightAsync()
        {
            return await flightDb.Flight.ToListAsync();
        }

        public async Task<Flight> GetFlightByIdAsync(int flightId)
        {
            return await flightDb.Flight.FindAsync(flightId);
        }

    }
}
