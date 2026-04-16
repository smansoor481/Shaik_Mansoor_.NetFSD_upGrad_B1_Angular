using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        public static List<Flight> flights = new List<Flight>
        {
            new Flight { Id = 1, FlightNumber = "AI101", Source = "Hyderabad", Destination = "Delhi" },
            new Flight { Id = 2, FlightNumber = "AI202", Source = "Mumbai", Destination = "Chennai" },
            new Flight { Id = 3, FlightNumber = "AI303", Source = "Bangalore", Destination = "Kolkata" }
        };


        [HttpGet]
        public IActionResult GetFlights()
        {
            return Ok(flights);
        }

        [HttpGet("{id}")]
        public IActionResult GetFlightById(int id)
        {
            var flight = flights.FirstOrDefault(f => f.Id == id);

            if (flight == null)
            {
                return NotFound("Flight not found");
            }

            return Ok(flight);
        }


        [HttpPost]
        public IActionResult AddFlight([FromBody] Flight flight)
        {
            if (flight == null)
                return BadRequest("Invalid data");

            // Auto increment ID
            flight.Id = flights.Max(f => f.Id) + 1;

            flights.Add(flight);

            return CreatedAtAction(nameof(GetFlightById), new { id = flight.Id }, flight);
        }


    }
}
