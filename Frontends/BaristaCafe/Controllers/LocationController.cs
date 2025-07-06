using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.Controllers
{
    public class LocationController : Controller
    {
        private readonly IRepository<Location> _repository;

        public LocationController(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> LocationDetails()
        {
            var locations = await _repository.GetAllAsync();
            return View(locations);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateLocation(int id)
        {
            var location = await _repository.GetByIdAsync(id);
            if (location == null)
                return NotFound();

            return View(location);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateLocation(Location model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _repository.UpdateAsync(model);
            return RedirectToAction("LocationDetails");
        }

     
    }
}
