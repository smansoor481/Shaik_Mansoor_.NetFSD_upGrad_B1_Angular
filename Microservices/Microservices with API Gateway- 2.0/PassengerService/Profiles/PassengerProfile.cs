using AutoMapper;
using PassengerService.DTOs;
using PassengerService.Entity;
namespace EComm.ProductService.Profiles
{
    public class PassengerProfile: Profile
    {
        public PassengerProfile() {
            //Define mapping configurations here
            CreateMap<Passenger, ReadPassengerDto>();
            CreateMap<CreatePassengerDto, Passenger>();
            CreateMap<Passenger, ReadPassengerDto>();
           
        }
    }
}
