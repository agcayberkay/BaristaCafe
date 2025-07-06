using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.Controllers
{
    public class SocailMediaController : Controller
    {
        private readonly IRepository<SocailMedia> _repository;

        public SocailMediaController(IRepository<SocailMedia> repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> SocailMediaDetails()
        {
            var list = await _repository.GetAllAsync();
            return View(list);
        }

        // Düzenleme (GET)
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _repository.GetByIdAsync(id);
            if (item == null) return NotFound();

            return View(item);
        }

        // Düzenleme (POST)
        [HttpPost]
        public async Task<IActionResult> Edit(SocailMedia model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _repository.UpdateAsync(model);
            return RedirectToAction("SocailMediaDetails");
        }

        // Silme
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _repository.GetByIdAsync(id);
            if (item == null) return NotFound();

            await _repository.DeleteAsync(item);
            return RedirectToAction("SocailMediaDetails");
        }
    }
}
