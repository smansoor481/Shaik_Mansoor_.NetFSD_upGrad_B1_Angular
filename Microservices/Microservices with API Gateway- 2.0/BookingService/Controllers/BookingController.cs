using BookingService.DTOs;
using BookingService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService bookingService;

        public BookingController(IBookingService bookingService)
        {
            this.bookingService = bookingService;
        }


        [HttpPost]
        public async Task<IActionResult> CreateBooking([FromBody] CreateBookingDto bookingDto)
        {
            await bookingService.CreateBooking(bookingDto);
            return Ok();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetFlightById(int id)
        {
            var booking = await bookingService.GetBookingById(id);
            return Ok(booking);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFlights()
        {
            var bookings =await bookingService.GetAllBooking();
            return Ok(bookings);
        }
    }
}
