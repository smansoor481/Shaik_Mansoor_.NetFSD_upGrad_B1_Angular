using BookingService.DTOs;

namespace BookingService.Services
{
    public interface IBookingService
    {
        Task CreateBooking(CreateBookingDto bookingDto);
        Task<ReadBookingDto> GetBookingById(int bookingId);
        Task<List<ReadBookingDto>> GetAllBooking();
    }
}
