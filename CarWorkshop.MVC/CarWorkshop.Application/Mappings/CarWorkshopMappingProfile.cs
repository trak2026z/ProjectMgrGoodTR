using AutoMapper;
using CarWorkshop.Application.DTOs;
using CarWorkshop.Domain.Entities;

namespace CarWorkshop.Application.Mappings
{
    public class CarWorkshopMappingProfile : Profile
    {
        public CarWorkshopMappingProfile()
        {
            CreateMap<CarWorkshopDto, Domain.Entities.CarWorkshop>()
                .ForMember(dest => dest.ContactDetails, opt => opt.MapFrom(src => new CarWorkshopContactDetails
                {
                    PhoneNumber = src.PhoneNumber,
                    Street = src.Street,
                    City = src.City,
                    PostalCode = src.PostalCode
                }));

            CreateMap<CarWorkshop.Domain.Entities.CarWorkshop, CarWorkshopDto>()
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.ContactDetails.PhoneNumber))
                .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.ContactDetails.Street))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.ContactDetails.City))
                .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.ContactDetails.PostalCode));
        }
    }
}
