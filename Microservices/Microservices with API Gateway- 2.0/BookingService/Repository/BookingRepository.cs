using BookingService.Database;
using Microsoft.EntityFrameworkCore;

namespace BookingService.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly BookingDbContext bookingDbContext;

        public BookingRepository(BookingDbContext bookingDbContext)
        {
            this.bookingDbContext = bookingDbContext;
        }

        public async Task CreateBookingAsync(Booking booking)
        {
            bookingDbContext.Bookings.Add(booking);
           await bookingDbContext.SaveChangesAsync();
        }

        public async Task<List<Booking>> GetAllBookingAsync()
        {
            return await bookingDbContext.Bookings.ToListAsync();
        }

        public async Task<Booking> GetBookingByIdAsync(int bookingId)
        {
            return await bookingDbContext.Bookings.FindAsync(bookingId);
        }
    }
}
