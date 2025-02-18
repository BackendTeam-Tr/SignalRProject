using AutoMapper;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ResultBookingDto>().ReverseMap();
            CreateMap<Contact, CreateBookingDto>().ReverseMap();
            CreateMap<Contact, GetBookingDto>().ReverseMap();
            CreateMap<Contact, UpdateBookingDto>().ReverseMap();
        }
    }
}
