using AutoMapper;
using FlightService.DTOs;
using FlightService.Entity;
namespace EComm.ProductService.Profiles
{
    public class FlightProfile: Profile
    {
        public FlightProfile() {
            //Define mapping configurations here
            CreateMap<Flight, ReadFlightDto>();
            CreateMap<CreateFlightDto, Flight>();
            CreateMap<Flight, ReadFlightDto>();
           
        }
    }
}
