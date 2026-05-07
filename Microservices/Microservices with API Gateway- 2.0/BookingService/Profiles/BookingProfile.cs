using AutoMapper;
using BookingService;
using BookingService.DTOs;

namespace EComm.ProductService.Profiles
{
    public class BookingProfile: Profile
    {
        public BookingProfile() {
            //Define mapping configurations here
            CreateMap<Booking, ReadBookingDto>();
            CreateMap<CreateBookingDto, Booking>();
            CreateMap<Booking, ReadBookingDto>();
           
        }
    }
}
