using AutoMapper;
using BookingService.DTOs;
using BookingService.Repository;

namespace BookingService.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository repository;
        private readonly IMapper mapper;

        public BookingService(IBookingRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task CreateBooking(CreateBookingDto bookingDto)
        {
            var bookings = mapper.Map<Booking>(bookingDto);
            await repository.CreateBookingAsync(bookings);
        }

        public async Task<List<ReadBookingDto>> GetAllBooking()
        {
            var bookings = await repository.GetAllBookingAsync();
            var bookingdto = mapper.Map<List<ReadBookingDto>>(bookings);
            return bookingdto;
        }

        public async Task<ReadBookingDto> GetBookingById(int bookingId)
        {
           var booking = await repository.GetBookingByIdAsync(bookingId);
            return mapper.Map<ReadBookingDto>(booking);
        }
    }
}
