using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        public static List<Booking> bookings = new List<Booking>()
        {
             new Booking { BookingId = 101, FlightId = 1, PassengerId = 201 },
            new Booking { BookingId = 102, FlightId = 2, PassengerId = 202 },
            new Booking { BookingId = 103, FlightId = 3, PassengerId = 203 }
        };

        [HttpGet]
        public IActionResult GetBookings()
        {
            return Ok(bookings);
        }

        [HttpPost]
        public IActionResult AddBooking([FromBody] Booking booking)
        {
            if (booking == null)
            {
                return BadRequest("Invalid booking data");
            }

            booking.BookingId = bookings.Count > 0 ? bookings.Max(b => b.BookingId) + 1 : 101;
            bookings.Add(booking);

            return Ok(booking);
        }
    }
}
