using CarWorkshop.Domain.Interfaces;

namespace CarWorkshop.Application.Services
{
    public class CarWorkshopService : ICarWorkshopService
    {
        private readonly ICarworkshopRepository _carworkshopRepository;

        public CarWorkshopService(ICarworkshopRepository carworkshopRepository)
        {
            _carworkshopRepository = carworkshopRepository;
        }

        public async Task Create(Domain.Entities.CarWorkshop carWorkshop)
        {
            carWorkshop.EncodeName();

            await _carworkshopRepository.Create(carWorkshop);
        }
    }
}
