using FlightAPI.Model;
using FlightAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlighRepository flighRepository;
        public FlightController(IFlighRepository flighRepository)
        {
            this.flighRepository = flighRepository;
        }

        //endpoints
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var flights =flighRepository.GetAllFlights();
            return StatusCode(200, flights);
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var flight = flighRepository.GetFlightId(id);
            if(flight == null)
            {
                return BadRequest("Invalid ID");
            }
            return Ok(flight);
        }

        [HttpPost, Route("Add")]
        public IActionResult Add([FromBody] Flight flight)
        {
            flighRepository.AddFlight(flight);
            return RedirectToAction("GetAll");
        }

        [HttpDelete, Route("Delete/{id}")]
        public IActionResult Delete([FromBody]int id)
        {
            flighRepository.DeleteFlight(id);
            return RedirectToAction("Record Deleted");
        }


        [HttpPut, Route("Edit")]
        public IActionResult Edit([FromBody] Flight flight)
        {
            flighRepository.EditFlight(flight);
            return RedirectToAction("GetAll");
        }
    }
}
