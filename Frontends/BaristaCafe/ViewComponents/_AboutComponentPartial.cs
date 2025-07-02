using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly IRepository<AboutCafe> _repository;

        public _AboutComponentPartial(IRepository<AboutCafe> repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _repository.GetAllAsync();
            if (model == null || !model.Any())
            {
                return Content("Veri bulunamadı.");
            }
            return View(model);
        }
    }
}
