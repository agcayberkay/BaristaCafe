using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.Controllers
{
    public class AboutCafeController : Controller
    {
        private readonly IRepository<AboutCafe> _repository;

        public AboutCafeController(IRepository<AboutCafe> repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> AboutCafe()
        {
            var aboutCafe = await _repository.GetAllAsync();
            return View(aboutCafe.FirstOrDefault()); // sadece bir kayıt varsa
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAboutCafe(AboutCafe aboutCafe)
        {
            if (aboutCafe == null)
            {
                // Model gelmiyorsa
                return BadRequest("Model boş geldi");
            }

            Console.WriteLine($"ID: {aboutCafe.AboutCafeId}, Title: {aboutCafe.Title}");

            if (ModelState.IsValid)
            {
                await _repository.UpdateAsync(aboutCafe);
                return RedirectToAction("AboutCafe");
            }
            return View("AboutCafe", aboutCafe);
        }
    }
}
