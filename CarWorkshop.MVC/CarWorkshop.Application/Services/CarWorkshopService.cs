using AutoMapper;
using CarWorkshop.Application.DTOs;
using CarWorkshop.Domain.Interfaces;

namespace CarWorkshop.Application.Services
{
    public class CarWorkshopService : ICarWorkshopService
    {
        private readonly ICarworkshopRepository _carworkshopRepository;
        private readonly IMapper _mapper;


        public CarWorkshopService(
            ICarworkshopRepository carworkshopRepository,
            IMapper mapper)
        {
            _carworkshopRepository = carworkshopRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(CarWorkshopDto dto)
        {
            var carWorkshop = _mapper.Map<Domain.Entities.CarWorkshop>(dto);
            carWorkshop.EncodeName();
            await _carworkshopRepository.Create(carWorkshop);
        }
    }
}
