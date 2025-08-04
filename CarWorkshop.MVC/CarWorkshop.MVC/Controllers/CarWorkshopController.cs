using CarWorkshop.Application.DTOs;
using CarWorkshop.Application.Services;
using CarWorkshop.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers
{
    public class CarWorkshopController : Controller
    {
        private readonly ICarWorkshopService _carWorkshopService;

        public CarWorkshopController(ICarWorkshopService carWorkshopService)
        {
            _carWorkshopService = carWorkshopService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var workshops = await _carWorkshopService.GetAllAsync();
            return View(workshops);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CarWorkshopDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarWorkshopDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _carWorkshopService.CreateAsync(dto);
            return RedirectToAction(nameof(Create));
        }
    }
}
