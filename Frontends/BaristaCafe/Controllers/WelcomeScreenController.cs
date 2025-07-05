using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.Controllers
{
    public class WelcomeScreenController : Controller
    {
        private readonly IRepository<WelcomeScreen> _repository;

        public WelcomeScreenController(IRepository<WelcomeScreen> repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> WelcomeScreenDetails()
        {
            var welcomeScreen = await _repository.GetAllAsync();
            return View(welcomeScreen.FirstOrDefault());
        }

        [HttpPost]
        public async Task<IActionResult> UpdateWS(WelcomeScreen model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _repository.UpdateAsync(model);

            // Güncelledikten sonra yine aynı sayfaya dön
            return RedirectToAction(nameof(WelcomeScreenDetails));
        }
    }
}
