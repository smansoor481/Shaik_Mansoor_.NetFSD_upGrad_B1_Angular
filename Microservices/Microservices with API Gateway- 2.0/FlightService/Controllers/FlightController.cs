using FlightService.DTOs;
using FlightService.Entity;
using FlightService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
       private readonly IFlightService flightService;

        public FlightController(IFlightService flightService)
        {
            this.flightService = flightService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFlight([FromBody] CreateFlightDto flightDto)
        {
            await flightService.CreateFlight(flightDto);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFlightById(int id)
        {
            var flight = await flightService.GetFlightById(id);
            return Ok(flight);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllFlights()
        {
            var flights = await flightService.GetAllFlights();
            return Ok(flights);
        }


    }
}
