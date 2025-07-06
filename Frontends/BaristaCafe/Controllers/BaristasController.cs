using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.Controllers
{
    public class BaristasController : Controller
    {
        private readonly IRepository<Baristas> _repository;

        public BaristasController(IRepository<Baristas> repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> BaristasDetails( )
        {
            var baristas = await _repository.GetAllAsync();
            return View(baristas);
        }

        [HttpGet]
        public IActionResult CreateBarista()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBarista(Baristas model)
        {
            if (!ModelState.IsValid)
                return View(model);
            await _repository.CrateAsync(model);
            return RedirectToAction("BaristasDetails");
        }
        [HttpGet]
        public async Task<IActionResult> EditBarista(int id)
        {
            var barista = await _repository.GetByIdAsync(id);
            if (barista == null)
                return NotFound();

            return View(barista);
        }

        [HttpPost]
        public async Task<IActionResult> EditBarista(Baristas model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _repository.UpdateAsync(model);
            return RedirectToAction("BaristasDetails");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var barista = await _repository.GetByIdAsync(id);
            if (barista == null)
                return NotFound();

            await _repository.DeleteAsync(barista);
            return RedirectToAction("BaristasDetails");
        }

    }
}
