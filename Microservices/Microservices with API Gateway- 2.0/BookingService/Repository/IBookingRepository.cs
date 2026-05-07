namespace BookingService.Repository
{
    public interface IBookingRepository
    {
        Task CreateBookingAsync(Booking booking);
        Task<Booking> GetBookingByIdAsync(int bookingId);
        Task<List<Booking>> GetAllBookingAsync();
    }
}
