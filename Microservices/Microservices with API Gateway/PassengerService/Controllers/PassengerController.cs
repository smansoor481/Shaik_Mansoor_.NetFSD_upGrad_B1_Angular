using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PassengerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        public static List<Passenger> passengers = new List<Passenger>()
        {
            new Passenger { Id = 1, Name = "Mansoor", Age = 24},
            new Passenger { Id = 2, Name = "Rahul", Age = 28},
            new Passenger { Id = 3, Name = "Sneha", Age = 22}
        };


        [HttpGet]
        public IActionResult GetPassengers()
        {
            return Ok(passengers);
        }

        [HttpGet("{id}")]
        public IActionResult GetPassengerById(int id)
        {
            var passenger = passengers.FirstOrDefault(p => p.Id == id);

            if (passenger == null)
            {
                return NotFound("Passenger not found");
            }

            return Ok(passenger);
        }

        [HttpPost]
        public IActionResult AddPassenger([FromBody] Passenger passenger)
        {
            if (passenger == null)
            {
                return BadRequest("Invalid passenger data");
            }

            passenger.Id = passengers.Max(p => p.Id) + 1;
            passengers.Add(passenger);

            return CreatedAtAction(nameof(GetPassengerById), new { id = passenger.Id }, passenger);
        }

    }
}
