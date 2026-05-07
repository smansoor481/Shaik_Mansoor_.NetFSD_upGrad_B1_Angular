using AutoMapper;
using PassengerService.DTOs;
using PassengerService.Entity;
using PassengerService.Repository;

namespace PassengerService.Service
{
    public class PassengerService : IPassengerService
    {
        private readonly IPassengerRepository repository;
        private readonly IMapper mapper;

        public PassengerService(IPassengerRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task CreatePassenger(CreatePassengerDto passenger)
        {
            var passengers = mapper.Map<Passenger>(passenger);

            await repository.CreatePassengerAsync(passengers);
        }

        public async Task DeletePassenger(int id)
        {
            await repository.DeletePassengerAsync(id);
        }

        public async Task<List<ReadPassengerDto>> GetAllPassenger()
        {
            var passengers = await repository.GetAllPassengersAsync();
            var passengerDtos = mapper.Map<List<ReadPassengerDto>>(passengers);
            return passengerDtos;
        }

        public async Task<ReadPassengerDto> GetPassengerById(int passengerId)
        {
            var passenger = await repository.GetPassengerByIdAsync(passengerId);
            return mapper.Map<ReadPassengerDto>(passenger);
        }

        public async Task UpdatePassenger(int id, CreatePassengerDto passenger)
        {
            var passengers = mapper.Map<Passenger>(passenger);
            passengers.Id = id;
            await repository.UpdatePassengerAsync(id, passengers);  


        }
    }
}
