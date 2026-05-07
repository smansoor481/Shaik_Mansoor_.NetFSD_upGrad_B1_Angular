using Microsoft.EntityFrameworkCore;
using PassengerService.Database;
using PassengerService.Entity;

namespace PassengerService.Repository
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly PassengerDbContext _context;

        public PassengerRepository(PassengerDbContext context)
        {
            _context = context;
        }

        public async Task CreatePassengerAsync(Passenger passenger)
        {
            _context.Passenger.Add(passenger);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePassengerAsync(int id)
        {
            var passenger = await _context.Passenger.FindAsync(id);
            if (passenger != null)
            {
                _context.Passenger.Remove(passenger);
                _context.SaveChanges();
            }
        }

        public async Task<List<Passenger>> GetAllPassengersAsync()
        {
            return await _context.Passenger.ToListAsync();
        }

        public async Task<Passenger> GetPassengerByIdAsync(int passengerId)
        {
            return await _context.Passenger.FindAsync(passengerId);
        }

        public async Task UpdatePassengerAsync(int id, Passenger passenger)
        {
            var existingPassenger = await _context.Passenger.FindAsync(id);
            if (existingPassenger != null)
            {
                existingPassenger.Name = passenger.Name;
                existingPassenger.Age = passenger.Age;
                await _context.SaveChangesAsync();
            }
        }
    }
}
