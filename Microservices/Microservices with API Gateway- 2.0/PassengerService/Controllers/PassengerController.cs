using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PassengerService.DTOs;
using PassengerService.Entity;
using PassengerService.Service;

namespace PassengerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private readonly IPassengerService passengerService;

        public PassengerController(IPassengerService passengerService)
        {
            this.passengerService = passengerService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePassenger([FromBody] CreatePassengerDto passengerDto)
        {
            await passengerService.CreatePassenger(passengerDto);
            return Ok();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePassenger(int id, [FromBody] CreatePassengerDto passengerDto)
        {
            await passengerService.UpdatePassenger(id, passengerDto);
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePassenger(int id)
        {
            await passengerService.DeletePassenger(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPassengerById(int id)
        {
            var passenger = await passengerService.GetPassengerById(id);
            return Ok(passenger);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllPassengers()
        {
            var passenger = await passengerService.GetAllPassenger();
            return Ok(passenger);
        }

    }
}
