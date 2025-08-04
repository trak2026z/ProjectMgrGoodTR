using CarWorkshop.Application.DTOs;

namespace CarWorkshop.Application.Services
{
    public interface ICarWorkshopService
    {
        Task CreateAsync(CarWorkshopDto dto);
        Task<IEnumerable<CarWorkshopDto>> GetAllAsync();
    }
}